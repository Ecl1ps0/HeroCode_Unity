using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField] HealthBar _healthBar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            PlayerGetDamage(10);
            Debug.Log(GameManager.gameManager._playerHealth.Health);
        }

        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            PlayerHeal(20);
            Debug.Log(GameManager.gameManager._playerHealth.Health);
        }
    }

    private void PlayerGetDamage(int damage)
    {
        GameManager.gameManager._playerHealth.DamageUnit(damage);
        _healthBar.SetHealth(GameManager.gameManager._playerHealth.Health);
    }

    private void PlayerHeal(int heal)
    {
        GameManager.gameManager._playerHealth.HealUnit(heal);
        _healthBar.SetHealth(GameManager.gameManager._playerHealth.Health);
    }
}
