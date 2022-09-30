using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Button))]
public class NextLevel : MonoBehaviour
{
    int nextSceneIndex;
    Button button;


    void Start()
    {
        nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        button = GetComponent<Button>();
        button.onClick.AddListener(NextLevelOpen);
    }







    public void NextLevelOpen()
    {
        if (nextSceneIndex == 5)
        {
            SceneManager.LoadScene(0);
        }
        else
        {
            Pause.isPaused = false;
            SceneManager.LoadScene(nextSceneIndex);
        }
    }


}
