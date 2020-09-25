using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log(other.collider.name);

        if (!other.collider.CompareTag("Obstacle")) return;
        var playerHandler = GetComponent<PlayerHandler>();
        playerHandler.PlayerHealth.Damage(1);
        Debug.Log("1 Damage taken " + playerHandler.PlayerHealth.Health + " HP left" );
    }
}