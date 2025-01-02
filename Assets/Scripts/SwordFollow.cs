using UnityEngine;

public class SwordFollow : MonoBehaviour
{
    public Transform player;

    private void LateUpdate()
    {
        transform.position = new Vector3(
            Mathf.Round(player.position.x * 100) / 100,
            Mathf.Round(player.position.y * 100) / 100,
            transform.position.z
        );
    }
}