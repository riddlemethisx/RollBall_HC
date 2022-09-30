using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Button))]
public class Restart : MonoBehaviour
{

    Button button;

    private void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(Restarting);
    }

    void Restarting()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
