using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassRoomDropDown : MonoBehaviour
{
    public GameObject tables_U;
    public GameObject tables_Row;
    public GameObject tables_U_and_Row;
  
    public void Choose_Row()
    {
        tables_Row.SetActive(true);
        tables_U.SetActive(false);
        tables_U_and_Row.SetActive(false);
    }

    public void Choose_U()
    {
        tables_Row.SetActive(false);
        tables_U.SetActive(true);
        tables_U_and_Row.SetActive(false);
    }

    public void Choose_U_and_Row()
    {
        tables_Row.SetActive(false);
        tables_U.SetActive(false);
        tables_U_and_Row.SetActive(true);
    }
}
