using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class ColabDropDown : MonoBehaviour
{
    public GameObject ExitWindow;
    public GameObject OptionPanel;
    public TMP_Dropdown ColabDD;  

    public void DropDownChoice(int index)
    {
        switch (index)
        {
            case 0: break;
            case 1: OptionenScene.GoToOptionsScene(); break;
            case 2: SceneManager.LoadScene(3); break; // hier noch current player daten speichern >> um beim zurück drücken genau dort wieder aufzutauchen
            case 3: ExitWindow.SetActive(true); break;
            case 4: OptionPanel.SetActive(true); ColabDD.value = 0;  break;
        }
    }
}