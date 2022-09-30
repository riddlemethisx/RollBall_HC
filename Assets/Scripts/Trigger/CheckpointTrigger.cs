using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckpointTrigger : MonoBehaviour
{





    public GameObject levelCompletePanel;
    public GameObject gameplayPanel;




    void OnTriggerEnter(Collider temasedilen)
    {
            if (temasedilen.gameObject.tag == "Player")
            {
                Time.timeScale = 0;
                gameplayPanel.SetActive(false);
                levelCompletePanel.SetActive(true);
            }
    }





}
