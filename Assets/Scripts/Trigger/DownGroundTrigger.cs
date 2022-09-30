using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownGroundTrigger : MonoBehaviour
{


    public Transform spawnPos;


    void OnTriggerEnter(Collider temasedilen)
    {
            if (temasedilen.gameObject.tag == "Player")
            {
                temasedilen.gameObject.GetComponent<Rigidbody>().isKinematic = true;
                temasedilen.gameObject.transform.position = spawnPos.position;
                temasedilen.gameObject.GetComponent<Rigidbody>().isKinematic = false;
            }
    }



}
