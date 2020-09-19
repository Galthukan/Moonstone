using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameHandler : MonoBehaviour
{
    // [SerializeField] private UnityEvent onHealthZero = null;
    public static HealthSystem healthSystem;

    void Awake() {
        healthSystem = new HealthSystem();
        healthSystem.setHealth(100);
        Debug.Log("Health: " + healthSystem.getHealth());
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // private void HandlePlayerHealthZeroEvent()
    // {
    //     onHealthZero.Invoke();
    // }

    public void PlayerDamage(int damage) {
        healthSystem.Damage(damage);
        Debug.Log("Health: " + healthSystem.getHealth());
    }

    public int PlayerHealth() {
        return healthSystem.getHealth();
    }
}
