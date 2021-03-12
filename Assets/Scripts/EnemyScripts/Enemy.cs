using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Health, IObjectDestroyer
{
    [SerializeField] private float _damage;
    public float Damage
    {
        get { return _damage; }
        private set { }
    }
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
        Destroy(gameObject);
    }
}
