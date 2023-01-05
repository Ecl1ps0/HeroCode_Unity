using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitsHealth 
{
    // Fields
    int _currentHealth;
    int _currentMaxHeath;

    // Properties

    public int Health
    {
        get
        {
            return _currentHealth;
        }

        set
        {
            _currentHealth = value;
        }
    }

    public int MaxHealth
    {
        get
        {
            return _currentMaxHeath;
        }

        set
        {
            _currentMaxHeath = value;
        }
    }

    // Constuctor

    public UnitsHealth(int health, int maxHealth)
    {
        _currentHealth = health;
        _currentMaxHeath = maxHealth;
    }

    // Methods
    public void DamageUnit(int damageAmount)
    {
        if(_currentHealth > 0)
        {
            _currentHealth -= damageAmount;
        }
    }

    public void HealUnit(int healAmount)
    {
        if(_currentHealth < _currentMaxHeath)
        {
            _currentHealth += healAmount;
        }

        if(_currentHealth > _currentMaxHeath)
        {
            _currentHealth = _currentMaxHeath;
        }
    }
}
