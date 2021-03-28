using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class CannonBall : MonoBehaviour, IObjectDestroyer
{
    [SerializeField] private float _damage;
    public float Damage
    {
        get { return _damage; }
    }

    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] private float _lifeTime;

    public void SetImpulse(Vector2 direction, float force)
    {
        _rigidbody2D.AddForce(direction * force, ForceMode2D.Impulse);
        StartCoroutine(StartLiving());
    }
    
    public void SelfDestroy(GameObject gameObject)
    {
        gameObject.SetActive(false);
        transform.position = transform.parent.position;
    }

    private IEnumerator StartLiving()
    {
        yield return new WaitForSeconds(_lifeTime);
        SelfDestroy(gameObject);
        yield break;
    }
}
