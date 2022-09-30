using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFunction : MonoBehaviour
{

    public Transform cam;
    public Transform camPivot;  //takip edilmesi istenen obje
    public float camSpeed = 4f;
    public Vector2 clampVertical = new Vector2(-70f, 70f);

    Vector3 camOffset;
    float HorizontalRot;    //rot=rotation
    float VerticalRot;



    public Joystick variableJoystick;



    void Start()
    {
        HorizontalRot = cam.eulerAngles.x;
        VerticalRot = cam.eulerAngles.y;

        camOffset = cam.InverseTransformDirection(cam.position - camPivot.position);  //aradaki mesafeyi ayarladık



    }




    void Update()
    {
        float mouseX = 0f;
        float mouseY = 0f;

        mouseX += variableJoystick.Horizontal;  //yatay
        mouseY += variableJoystick.Vertical;    //dikey

        HorizontalRot += mouseX * camSpeed;
        VerticalRot -= mouseY * camSpeed;

        VerticalRot = Mathf.Clamp(VerticalRot, clampVertical.x, clampVertical.y);

        Quaternion camRot = Quaternion.Euler(VerticalRot, HorizontalRot, 0f);
        cam.rotation = camRot;

        Vector3 camPos = camPivot.position + camRot * camOffset;
        cam.position = camPos;





    }
}
