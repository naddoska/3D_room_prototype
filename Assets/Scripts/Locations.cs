using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Locations : MonoBehaviour
{
    static public int x_pos_UP_DOWN = -3;
    static public int x_pos_LEFT = 59;
    static public int x_pos_RIGHT = -49;

    static public int z_pos_UP = -13;
    static public int z_pos_DOWN = 65;
    static public int z_pos_LEFT_RIGHT = 27;

    static public float y_pos_ground = 1.13f;
    static public float y_pos_first_floor = 6.16f;
    static public float y_pos_second_floor = 11.1f;
    static public float y_pos_roof = 16.1f;

    public static Vector3 player_start_pos = new Vector3(x_pos_UP_DOWN, y_pos_ground, z_pos_UP);


    // this function is called within the teleportation script.
    // the teleportation script saves an teleportation_pos enum based on which floor the player chooses 
    // in Teleportation_pos() we use that saved enum and according to it give out the location in which the 
    // the player will be appear in the building
    public static void Teleportation_pos(ColabSpace.teleportation_pos chosen_floor)
    {
        if (chosen_floor == ColabSpace.teleportation_pos.EG_up)
        {
            player_start_pos = new Vector3(x_pos_UP_DOWN, y_pos_ground, z_pos_UP);
            SceneManager.LoadScene(1);       
        }

        else if (chosen_floor == ColabSpace.teleportation_pos.EG_left)
        {
            player_start_pos = new Vector3(x_pos_LEFT, y_pos_ground, z_pos_LEFT_RIGHT);
            SceneManager.LoadScene(1);
        }

        else if (chosen_floor == ColabSpace.teleportation_pos.EG_right)
        {
            player_start_pos = new Vector3(x_pos_RIGHT, y_pos_ground, z_pos_LEFT_RIGHT);
            SceneManager.LoadScene(1);
        }

        else if (chosen_floor == ColabSpace.teleportation_pos.firstfloor_left)
        {
            player_start_pos = new Vector3(x_pos_LEFT, y_pos_first_floor, z_pos_LEFT_RIGHT);
            SceneManager.LoadScene(1);
        }

        else if (chosen_floor == ColabSpace.teleportation_pos.firstfloor_right)
        {
            player_start_pos = new Vector3(x_pos_RIGHT, y_pos_first_floor, z_pos_LEFT_RIGHT);
            SceneManager.LoadScene(1);
        }

        else if (chosen_floor == ColabSpace.teleportation_pos.firstfloor_down)
        {
            player_start_pos = new Vector3(x_pos_UP_DOWN, y_pos_first_floor, z_pos_DOWN);
            SceneManager.LoadScene(1);
        }

        else if (chosen_floor == ColabSpace.teleportation_pos.secondfloor_up)
        {
            player_start_pos = new Vector3(x_pos_UP_DOWN, y_pos_second_floor, z_pos_UP);
            SceneManager.LoadScene(1);
        }

        else if (chosen_floor == ColabSpace.teleportation_pos.secondfloor_left)
        {
            player_start_pos = new Vector3(x_pos_LEFT, y_pos_second_floor, z_pos_LEFT_RIGHT);
            SceneManager.LoadScene(1);
        }

        else if (chosen_floor == ColabSpace.teleportation_pos.secondfloor_right)
        {
            player_start_pos = new Vector3(x_pos_RIGHT, y_pos_second_floor, z_pos_LEFT_RIGHT);
            SceneManager.LoadScene(1);
        }

        else if (chosen_floor == ColabSpace.teleportation_pos.secondfloor_down)
        {
            player_start_pos = new Vector3(x_pos_UP_DOWN, y_pos_second_floor, z_pos_DOWN);
            SceneManager.LoadScene(1);
        }

        else if (chosen_floor == ColabSpace.teleportation_pos.roof_up)
        {
            player_start_pos = new Vector3(x_pos_UP_DOWN, y_pos_roof, z_pos_UP);
            SceneManager.LoadScene(1);
        }

        else if (chosen_floor == ColabSpace.teleportation_pos.roof_left)
        {
            player_start_pos = new Vector3(x_pos_LEFT, y_pos_roof, z_pos_LEFT_RIGHT);
            SceneManager.LoadScene(1);
        }

        else if (chosen_floor == ColabSpace.teleportation_pos.roof_right)
        {
            player_start_pos = new Vector3(x_pos_RIGHT, y_pos_roof, z_pos_LEFT_RIGHT);
            SceneManager.LoadScene(1);
        }

        else if (chosen_floor == ColabSpace.teleportation_pos.roof_down)
        {
            player_start_pos = new Vector3(x_pos_UP_DOWN, y_pos_roof, z_pos_DOWN);
            SceneManager.LoadScene(1);
        }

        else
        {
           player_start_pos = new Vector3(x_pos_LEFT, y_pos_ground, z_pos_LEFT_RIGHT);      
        }

    }

}

