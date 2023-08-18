using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderScript : MonoBehaviour
{
    public void MouseSensitivity(float value)
    {
        Singleton.instance.rotationSpeed = value * 50 ;    
    }

}
