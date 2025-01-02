using System.Collections;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public GameObject attackArea; // Assign an empty GameObject with a Collider2D
    public float attackDuration = 0.2f; // Duration of the attack hitbox

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // Replace with your preferred input
        {
            StartCoroutine(PerformAttack());
        }
    }

    private IEnumerator PerformAttack()
    {
        attackArea.SetActive(true);
        yield return new WaitForSeconds(attackDuration);
        attackArea.SetActive(false);
    }
}