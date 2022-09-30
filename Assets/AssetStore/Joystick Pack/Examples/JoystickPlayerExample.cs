using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickPlayerExample : MonoBehaviour
{
    public float speed;
    public Joystick variableJoystick;
    public Rigidbody rb;

    public GameObject kamera;

    public void FixedUpdate()
    {
        Vector3 direction = kamera.transform.forward * variableJoystick.Vertical + kamera.transform.right * variableJoystick.Horizontal;    //kamera.transform yerine vector3 yazılırsa
        //joystick ileri sürüldüğünde obje ileri gider. ama bu haldeyken kamera hangi tarafa bakıyorsa joystick sürüldüğünde top o tarafa gider


        rb.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode.VelocityChange); //direction yönünde objeye güç uygula

    


    }

}