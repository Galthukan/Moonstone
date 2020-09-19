using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public GameHandler gameHandler;
    // public HealthSystem playerOneHP;

    private void Awake() {
        // gameHandler = GetComponent<GameHandler>();
        // Debug.Log("healthMax" + gameHandler.healthSystem.healthMax);
        // gameHandler = GetComponent<GameHandler>();

    }

    private void Start() {
        // Debug.Log("The player health is: " + gameHandler.healthSystem.getHealth());
    }

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log(other.collider.name);
        if (other.collider.tag == "Obstacle")
        {
            // gameHandler.healthSystem.Damage(1);
            GameHandler gameHandler = GetComponent<GameHandler>();
            gameHandler.PlayerDamage(1);
            // playerOneHP.Damage(1);
            Debug.Log("1 Damage taken");
        }
    }
}