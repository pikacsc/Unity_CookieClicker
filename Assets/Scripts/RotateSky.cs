using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSky : MonoBehaviour {

    public float m_RotateSpeed = 1.1f;


    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * m_RotateSpeed);    
    }
}
