using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionenScene : MonoBehaviour
{
    static int lastSceneIndex;

    public static void GoToOptionsScene()
    {
        lastSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(2);
    }

    public void ReturnToLastScene()
    {
        SceneManager.LoadScene(lastSceneIndex);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
