using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public Rigidbody Player;
    private float horizontalInput;
    private float verticalInput;
    private float speed = 10.0f;
    private float rotationSpeed = 10f;
    private float mouseX;
    private float mouseY;
    private float rotationMaxDown = 42.0f;
    private float rotationMaxUp = 45.0f;
    private float xRotation;
    private bool mouseClicked = false;
   


    // Start is called before the first frame update
    void Start()
    {
        Camera.main.transform.SetParent(transform);       // Setting the Camera as parent so that it follows the player 
        Camera.main.transform.localPosition = new Vector3(0, 1, 0);
        Camera.main.transform.localRotation = Quaternion.identity;
    }

    // Update is called once per frame
    void Update()
    {
        int checkScene = SceneManager.GetActiveScene().buildIndex;
        if (checkScene == 1) { MouseNotClicked(); }
    }


    private void CmdMove()  // This function controls all movement the player can do. From moving with WASD and the arrow keys, to looking around with the mouse
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        mouseX = Input.GetAxis("Mouse X") * rotationSpeed; 
        mouseY = Input.GetAxis("Mouse Y") * rotationSpeed;
        //Rotate the camera based on the Y input of the mouse
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -rotationMaxDown, rotationMaxUp);
        Camera.main.transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
        transform.Rotate(Vector3.up * mouseX * 3); 
        Cursor.visible = false;

        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);
    }

    private void MouseNotClicked() // the mouse is not visible when its used to look around
    {
        if (Input.GetMouseButtonUp(1))
        {
            mouseClicked = !mouseClicked;
        }

        if (mouseClicked)
        {
            Cursor.visible = true;
        }
        else { CmdMove(); }
    }
}