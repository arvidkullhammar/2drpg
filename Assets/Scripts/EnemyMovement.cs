using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float moveSpeed = 2f;
    private Vector2 _direction;
    private Rigidbody2D _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        SetRandomDirection();
        InvokeRepeating(nameof(SetRandomDirection), 2f, 2f); // Change direction every 2 seconds
    }

    void FixedUpdate()
    {
        _rb.MovePosition(_rb.position + _direction * (moveSpeed * Time.fixedDeltaTime));
    }

    void SetRandomDirection()
    {
        _direction = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;
    }
}