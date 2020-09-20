using System;
using UnityEngine;

public class PlayerHandler : MonoBehaviour
{
    public PlayerHealth PlayerHealth;

    private void Awake()
    {
        PlayerHealth = new PlayerHealth();
        Debug.Log("Health: " + PlayerHealth.Health);
    }

    private void PlayerDeath()
    {
        // TODO: implement event handling
        // onHealthZero.Invoke();
        throw new NotImplementedException();
    }
}