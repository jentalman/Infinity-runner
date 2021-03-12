using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    [SerializeField] private float _health;
    public float HealthValue
    {
        get { return _health; }
    }
    
    private float _maxHealth;

    public event UnityAction<GameObject> Died;

    private void Start()
    {
        _maxHealth = _health;
    }

    public void TakeDamage(float damage)
    {
        _health -= damage;
        if (_health <= 0)
            Died?.Invoke(gameObject);
    }

    public void TakeHealth(float heal)
    {
        _health += heal;
        if(_health >= _maxHealth)
        {
            _health = _maxHealth;
        }
    }
}
