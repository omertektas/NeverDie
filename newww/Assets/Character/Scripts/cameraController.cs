using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    public Transform target;
    public Vector3 targetDistance;
    float mouseX,mouseY;
    public float mouseSensibility;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    
    void Update()
    {
        //this.transform.position = Vector3.zero;
    }
    private void LateUpdate()
    {
        this.transform.position =  Vector3.Lerp(this.transform.position, target.position + targetDistance, Time.deltaTime);
        mouseX += Input.GetAxis("Mouse X")*mouseSensibility;
        mouseY += Input.GetAxis("Mouse Y")*mouseSensibility;
        this.transform.eulerAngles = new Vector3(-mouseY, mouseX, 0);
        target.transform.eulerAngles = new Vector3(0, mouseX, 0);
        if(mouseY>40) { 
            mouseY = 40;
        }
        if (mouseY < -60)
        {
            mouseY = -60;
        }

        
    }
}
