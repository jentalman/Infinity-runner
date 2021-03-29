using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    private void Awake()
    {
        Time.timeScale = 0;
    }

    public void StartButton()
    {
        Time.timeScale = 1;
    }

    public void RestartButton()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
