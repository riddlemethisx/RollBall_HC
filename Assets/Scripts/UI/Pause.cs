using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


[RequireComponent(typeof(Button))]
public class Pause : MonoBehaviour
{

    public GameObject pausePanel = null;
    Button button;

    public static bool isPaused = false;


    private void Start()
    {
        
        button = GetComponent<Button>();
        button.onClick.AddListener(PauseAndResume);
    }


    public void PauseAndResume()
    {
        isPaused = !isPaused;

        if (isPaused)
        {
            pausePanel.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            pausePanel.SetActive(false);
            Time.timeScale = 1;
        }
    }





}
