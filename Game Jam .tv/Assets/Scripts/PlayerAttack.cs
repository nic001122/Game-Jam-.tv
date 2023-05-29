using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private float timeBtwAttack;
    public float startTimeBtwAttack;

    public Transform attackPos;
    public float attackRange;
    public LayerMask whatisEnemies;
    public int damage = 5;

    public KeyCode attackKey;

    // Animations

    public Animator animator;

    public void Update()
    {
        Attack();
        if (timeBtwAttack <= 0)
        {
            if (Input.GetKey(KeyCode.Mouse0))
            {
                Debug.Log(animator.GetBool("IsHitting"));
                Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPos.position, attackRange, whatisEnemies);
                for (int i = 0; i < enemiesToDamage.Length; i++)
                {
                   enemiesToDamage[i].GetComponent<Enemy>().TakeDamage(damage);
                }
            }
            
            timeBtwAttack = startTimeBtwAttack;
        }
        else
        {
            timeBtwAttack -= Time.deltaTime;
        }
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPos.position, attackRange);
    }

    void Attack()
    {
            if (Input.GetKeyDown(attackKey))
            {
                animator.SetBool("IsHitting", true);
                Debug.Log("IsHitting is now " + animator.GetBool("IsHitting"));
            }

            if (Input.GetKeyUp(attackKey))
            {
                animator.SetBool("IsHitting", false);
                Debug.Log("IsHitting is now " + animator.GetBool("IsHitting"));
            }
    }
}
