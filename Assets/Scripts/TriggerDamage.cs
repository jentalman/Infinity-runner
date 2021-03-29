using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Events;

public class TriggerDamage : MonoBehaviour
{
    [SerializeField] private AudioSource _hitSound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (TryGetComponent<CannonBall>(out CannonBall cannonBall))
        {
            if (collision.TryGetComponent<Enemy>(out Enemy enemy))
            {
                enemy.TakeDamage(cannonBall.Damage);
                cannonBall.SelfDestroy(cannonBall.gameObject);
            }
        }
    }
}
