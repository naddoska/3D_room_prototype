using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ColabDropDown : MonoBehaviour
{
    public void DropDownChoice(int index)
    {
        switch (index)
        {
            case 0: break;
            case 1: OptionenScene.GoToOptionsScene(); break;
            case 2: Application.Quit(); break;
        }
    }
}