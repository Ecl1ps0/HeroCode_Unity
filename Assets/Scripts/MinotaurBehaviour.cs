using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinotaurBehaviour : MonoBehaviour
{
    [SerializeField] HealthBar _minotaurHealthBar;

    private Animator _animator;

    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            MinotaurGetDamage(20);
            Debug.Log(GameManager.gameManager._minotaurHealth.Health);
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            _animator.SetTrigger("Minotaur_Left_Hit");
        }
    }

    public void MinotaurGetDamage(int damage)
    {
        GameManager.gameManager._minotaurHealth.DamageUnit(damage);
        _minotaurHealthBar.SetHealth(GameManager.gameManager._minotaurHealth.Health);
    }
}
