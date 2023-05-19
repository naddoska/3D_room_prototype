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
            case 2: SceneManager.LoadScene(3); break; // hier noch current player daten speichern >> um beim zurück drücken genau dort wieder aufzutauchen
            case 3: Application.Quit(); break;
        }
    }
}