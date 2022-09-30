using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvoidAnim : MonoBehaviour
{

    public float minPos;
    public float maxPos;

    public int animSpeed = 1;


    void Start()
    {

    }

    void Update()
    {
        if (transform.position.z < minPos)
        {
            transform.Rotate(0, -180, 0);

        }

        if (transform.position.z > maxPos)
        {
            transform.Rotate(0, 180, 0);
        }

        transform.Translate(0, 0, -animSpeed * Time.deltaTime);
    }
}
