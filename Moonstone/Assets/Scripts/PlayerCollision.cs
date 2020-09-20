using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log(other.collider.name);

        if (!other.collider.CompareTag("Obstacle")) return;
        var component = GetComponent<PlayerHealth>();
        component.Damage(1);
        Debug.Log("1 Damage taken");
    }
}