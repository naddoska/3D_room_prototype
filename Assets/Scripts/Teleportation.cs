using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportation : MonoBehaviour
{
    // This script lets the player choose the floor of the map on which they want to teleport to in the Teleportation Scene


    public int floor = 0;
    public GameObject EG_pic;
    public GameObject firstOG_pic;
    public GameObject secondOG_pic;
    public GameObject roof_pic;
    public GameObject EG_buttons;
    public GameObject firstOG_buttons;
    public GameObject secondOG_buttons;
    public GameObject roof_buttons;
    public static bool isButtonPressed = false;


    // Choose_floor() and Delete_floor manage the depiction of the floor sprites, buttons and make the unusued ones invisible
    public void Choose_floor(int index)
    {
        switch(index)
        {
            case 0:
                Delete_floor(floor);
                EG_pic.SetActive(true);
                EG_buttons.SetActive(true);
                floor = 0;
                break;
            case 1:
                Delete_floor(floor);
                firstOG_pic.SetActive(true);
                firstOG_buttons.SetActive(true);
                floor = 1; break;
            case 2:
                Delete_floor(floor);
                secondOG_pic.SetActive(true);
                secondOG_buttons.SetActive(true);
                floor = 2;
                break;
            case 3: 
                Delete_floor(floor);
                roof_pic.SetActive(true);
                roof_buttons.SetActive(true);
                floor = 3;
                break;
        }
    }

    public void Delete_floor(int floor)
    {
        switch(floor)
        {
            case 0: 
                EG_pic.SetActive(false); 
                EG_buttons.SetActive(false);
                break; 
            case 1: 
                firstOG_pic.SetActive(false);
                firstOG_buttons.SetActive(false);
                break;
            case 2: 
                secondOG_pic.SetActive(false);
                secondOG_buttons.SetActive(false);
                break;
            case 3: 
                roof_pic.SetActive(false);
                roof_buttons.SetActive(false);
                break;
        }
    }


    // the following functions are created to save which floor the player wants to be teleported to

    public void Button_pressed_EG_UP()
    {
       isButtonPressed = true;
       ColabSpace.teleportation_pos chosen_floor;
       chosen_floor = ColabSpace.teleportation_pos.EG_up;
       Locations.Teleportation_pos(chosen_floor);     
    }

    public void Button_pressed_EG_LEFT()
    {
        isButtonPressed = true;
        ColabSpace.teleportation_pos chosen_floor;
        chosen_floor = ColabSpace.teleportation_pos.EG_left;
        Locations.Teleportation_pos(chosen_floor);
    }

    public void Button_pressed_EG_RIGHT()
    {
        isButtonPressed = true;
        ColabSpace.teleportation_pos chosen_floor;
        chosen_floor = ColabSpace.teleportation_pos.EG_right;
        Locations.Teleportation_pos(chosen_floor);
    }

    public void Button_pressed_1OG_LEFT()
    {
        isButtonPressed = true;
        ColabSpace.teleportation_pos chosen_floor;
        chosen_floor = ColabSpace.teleportation_pos.firstfloor_left;
        Locations.Teleportation_pos(chosen_floor);
    }

    public void Button_pressed_1OG_RIGHT()
    {
        isButtonPressed = true;
        ColabSpace.teleportation_pos chosen_floor;
        chosen_floor = ColabSpace.teleportation_pos.firstfloor_right;
        Locations.Teleportation_pos(chosen_floor);
    }

    public void Button_pressed_1OG_DOWN()
    {
        isButtonPressed = true;
        ColabSpace.teleportation_pos chosen_floor;
        chosen_floor = ColabSpace.teleportation_pos.firstfloor_down;
        Locations.Teleportation_pos(chosen_floor);
    }
    public void Button_pressed_2OG_UP()
    {
        isButtonPressed = true;
        ColabSpace.teleportation_pos chosen_floor;
        chosen_floor = ColabSpace.teleportation_pos.secondfloor_up;
        Locations.Teleportation_pos(chosen_floor);
    }

    public void Button_pressed_2OG_LEFT()
    {
        isButtonPressed = true;
        ColabSpace.teleportation_pos chosen_floor;
        chosen_floor = ColabSpace.teleportation_pos.secondfloor_left;
        Locations.Teleportation_pos(chosen_floor);
    }

    public void Button_pressed_2OG_RIGHT()
    {
        isButtonPressed = true;
        ColabSpace.teleportation_pos chosen_floor;
        chosen_floor = ColabSpace.teleportation_pos.secondfloor_right;
        Locations.Teleportation_pos(chosen_floor);
    }

    public void Button_pressed_2OG_DOWN()
    {
        isButtonPressed = true;
        ColabSpace.teleportation_pos chosen_floor;
        chosen_floor = ColabSpace.teleportation_pos.secondfloor_down;
        Locations.Teleportation_pos(chosen_floor);
    }

    public void Button_pressed_ROOF_UP()
    {
        isButtonPressed = true;
        ColabSpace.teleportation_pos chosen_floor;
        chosen_floor = ColabSpace.teleportation_pos.roof_up;
        Locations.Teleportation_pos(chosen_floor);
    }

    public void Button_pressed_ROOF_LEFT()
    {
        isButtonPressed = true;
        ColabSpace.teleportation_pos chosen_floor;
        chosen_floor = ColabSpace.teleportation_pos.roof_left;
        Locations.Teleportation_pos(chosen_floor);
    }

    public void Button_pressed_ROOF_RIGHT()
    {
        isButtonPressed = true;
        ColabSpace.teleportation_pos chosen_floor;
        chosen_floor = ColabSpace.teleportation_pos.roof_right;
        Locations.Teleportation_pos(chosen_floor);
    }

    public void Button_pressed_ROOF_DOWN()
    {
        isButtonPressed = true;
        ColabSpace.teleportation_pos chosen_floor;
        chosen_floor = ColabSpace.teleportation_pos.roof_down;
        Locations.Teleportation_pos(chosen_floor);
    }
}
