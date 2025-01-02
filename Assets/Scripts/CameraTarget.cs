using UnityEngine;

public class CameraTarget : MonoBehaviour
{
    public Transform player; // Assign the player Transform in the Inspector
    public float pixelsPerUnit = 16f; // Match the PPU setting in your project

    void LateUpdate()
    {
        if (player)
        {
            // Snap the target's position to the pixel grid
            Vector3 targetPosition = player.position;
            targetPosition.x = Mathf.Round(targetPosition.x * pixelsPerUnit) / pixelsPerUnit;
            targetPosition.y = Mathf.Round(targetPosition.y * pixelsPerUnit) / pixelsPerUnit;

            // Update the proxy object's position
            transform.position = targetPosition;
        }
    }
}