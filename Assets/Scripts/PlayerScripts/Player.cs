using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Health, IObjectDestroyer
{
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
        Debug.Log("Bay bay nigers!");
    }
}
