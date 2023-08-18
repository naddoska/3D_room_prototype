
using UnityEngine;

public class Singleton : MonoBehaviour
{
    public static Singleton instance;
    public float rotationSpeed; 

    private void Awake()
    {
        if (instance == null)
        { instance = this; } 
    }
}
