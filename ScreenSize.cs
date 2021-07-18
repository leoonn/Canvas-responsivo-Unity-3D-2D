using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenSize : MonoBehaviour
{
    
    private float orthoSize = 10f;
    [SerializeField]
    private float aspect = 1.75f;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         ScreenAjust();
    }

    void ScreenAjust()
    {
        Camera.main.projectionMatrix = Matrix4x4.Ortho(-orthoSize * aspect, orthoSize * aspect, -orthoSize, orthoSize, Camera.main.nearClipPlane , Camera.main.farClipPlane);
    }
}
