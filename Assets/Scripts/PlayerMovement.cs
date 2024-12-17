using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Speed of the player

    private Rigidbody2D _rb; // Reference to the Rigidbody2D component
    private Vector2 _movement; // Stores player's movement direction

    void Start()
    {
        // Get the Rigidbody2D component attached to the player
        _rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Capture input and assign it to the movement vector
        _movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }

    void FixedUpdate()
    {
        // Move the player with the calculated movement
        Vector2 scaledMovement = _movement * (moveSpeed * Time.fixedDeltaTime);
        _rb.MovePosition(_rb.position + scaledMovement);
    }
}