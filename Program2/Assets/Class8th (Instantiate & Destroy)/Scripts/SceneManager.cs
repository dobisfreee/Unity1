using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    private float degree;

    void Update()
    {
        if (degree <= 360)
        {
            degree = 0;
        }
        else
        {
            degree += Time.deltaTime;
        }
    }
   
    
}
