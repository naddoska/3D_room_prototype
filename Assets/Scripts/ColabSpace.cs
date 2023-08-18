using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColabSpace : MonoBehaviour
{
    public GameObject Player;
    public GameObject instantiatedPlayer;
     
    public enum teleportation_pos{

            EG_up,
            EG_left,
            EG_right,

            firstfloor_up,
            firstfloor_down,
            firstfloor_left,
            firstfloor_right,

            secondfloor_up,
            secondfloor_down,
            secondfloor_left,
            secondfloor_right,

            roof_up,
            roof_down,
            roof_left,
            roof_right,
     }

    
    // Start is called before the first frame update
    void Start()
    {
        if (Teleportation.isButtonPressed == false)
        {
            Vector3 start_pos = new Vector3(Locations.x_pos_UP_DOWN, Locations.y_pos_ground, Locations.z_pos_UP);
            instantiatedPlayer = Instantiate(Player, start_pos , Quaternion.identity);
        }
        
        else
        {
            Vector3 start_pos = Locations.player_start_pos; 
            instantiatedPlayer = Instantiate(Player, start_pos, Quaternion.identity);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
