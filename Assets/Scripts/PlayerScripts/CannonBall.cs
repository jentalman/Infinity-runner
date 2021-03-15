using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBall : MonoBehaviour, IObjectDestroyer
{

    [SerializeField] private float _damage;
    [SerializeField] private float _speed;


    public void SelfDestroy(GameObject gameObject)
    {
        throw new System.NotImplementedException();
    }
}
