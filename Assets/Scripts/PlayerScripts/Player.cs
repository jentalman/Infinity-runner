using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Health, IObjectDestroyer
{
    [SerializeField] private GameObject _endScreen;
    private void OnEnable()
    {
        Died += SelfDestroy;
    }
    private void OnDisable()
    {
        Died -= SelfDestroy;
    }

    public void SelfDestroy(GameObject gameObject)
    {
        Time.timeScale = 0;
        _endScreen.SetActive(true);
    }
}
