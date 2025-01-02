
using UnityEngine;

public class AttackArea : MonoBehaviour
{
    public int damage = 10;

    
    void Start()
    {
        Debug.Log($"Attack area enabled!");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Enemy")
        {
            collision.GetComponent<EnemyHealth>()?.TakeDamage(damage);
        }
    }
}