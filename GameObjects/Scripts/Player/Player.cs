//Alex-Gorney programm

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, IAttackable
{
    private static int _startHealth = 3;

    private int _health = 3;
    private string _name;

    public void SetPlayerHealth()
    {
        _health = _startHealth;
    }

    public void AddHealthToPlayer(int healthAmount)
    {
        _health += healthAmount;
    }

    public void TakeDamage(int healthAmount)
    {
        _health -= healthAmount;
        Debug.Log($"PlayerHealth {_health}");
        if (_health <= 0)
        {
            Debug.Log("Game end");
        }
    }
}
