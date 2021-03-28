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
    public event UnityAction ChangeScore;
    public event UnityAction<float> OnPlayerHealthChangedEvent;

    private void Start()
    {
        _maxHealth = _health;
    }

    public void TakeDamage(float damage)
    {
        _health -= damage;
        OnPlayerHealthChangedEvent?.Invoke(_health / _maxHealth);
        if (_health <= 0)
        {
            Died?.Invoke(gameObject);
            ChangeScore?.Invoke();
        }
    }

    public void TakeHealth(float heal)
    {
        _health += heal;
        if(_health >= _maxHealth)
        {
            _health = _maxHealth;
        }
    }

    public void RestoreFullHealth()
    {
        _health = _maxHealth;
    }
}
