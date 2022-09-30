using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject tabToStart;

    void Start()
    {
        
        tabToStart.SetActive(true);
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
            tabToStart.SetActive(false);
    }
}
