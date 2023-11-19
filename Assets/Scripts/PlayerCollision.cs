using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerScript movement; // Reference to the script or component that handles movement

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            // Handle collision with obstacle

            // Disable movement
            movement.enabled = false;

            // Call the EndGame method on the GameManager
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
