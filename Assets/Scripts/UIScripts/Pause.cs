using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    [SerializeField] private GameObject _pauseScreen;
    private bool _gamePaused = true;
    private void Update()
    {
        ControlPauseCreen();
    }

    private void ControlPauseCreen()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (_gamePaused)
            {
                Time.timeScale = 0;
                _pauseScreen.SetActive(true);
                _gamePaused = false;
            }
            else if (!_gamePaused)
            {
                Time.timeScale = 1;
                _pauseScreen.SetActive(false);
                _gamePaused = true;
            }
        }
    }
}
