using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody Player;
    private float horizontalInput;
    private float verticalInput;
    private float speed = 10.0f;
    private float rotationInputVertical;
    private float rotationInputHorizontal;
    private float rotationSpeed = 1.5f;
    private float mouseStartX;
    private float mouseStartY;
    private float rotationMaxDown = 42.0f;
    private float rotationMaxUp = 45.0f;


    // Start is called before the first frame update
    void Start()
    {
        Camera.main.transform.SetParent(transform);
        Camera.main.transform.localPosition = new Vector3(0, 1, 0);
        Camera.main.transform.localRotation = Quaternion.identity;
    }

    // Update is called once per frame
    void Update()
    {
        CmdMove();
        MouseNotClicked();
    }

    private void CmdMove()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");


        if (Input.GetMouseButtonDown(0))
        {
            mouseStartX = Input.GetAxis("Mouse X");
            mouseStartY = Input.GetAxis("Mouse Y");
        }

        if (Input.GetMouseButton(0))
        {
            rotationInputVertical += (Input.GetAxis("Mouse X") - mouseStartX) * rotationSpeed;
            rotationInputHorizontal += (Input.GetAxis("Mouse Y") - mouseStartY) * rotationSpeed;
            rotationInputHorizontal = Mathf.Clamp(rotationInputHorizontal, -rotationMaxDown, rotationMaxUp);
            transform.localRotation = Quaternion.Euler(0, rotationInputVertical, 0);
            Camera.main.transform.localRotation = Quaternion.Euler(-rotationInputHorizontal, 0, 0);
            Cursor.visible = false;
        }

        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);

    }

    private void MouseNotClicked()
    {
        if (Input.GetMouseButtonUp(0))
        {
            Cursor.visible = true;
        }
    }
}