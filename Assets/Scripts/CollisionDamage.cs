using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDamage : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (TryGetComponent<Enemy>(out Enemy imEnemy))
        {
            AttackCollision(collision, imEnemy);
            CheckCollisonForSelfDestory(collision, imEnemy);
                
        }
    }

    private void CheckCollisonForSelfDestory(Collision2D collision, Enemy enemy)
    {
        if (!collision.gameObject.TryGetComponent<Enemy>(out Enemy friendlyEnemy))
        {
            enemy.SelfDestroy(gameObject);
        }
    }

    private void AttackCollision(Collision2D collision, Enemy enemy)
    {
        if (collision.gameObject.TryGetComponent<Player>(out Player player))
        {
            player.TakeDamage(enemy.Damage);
        }
    }
}
