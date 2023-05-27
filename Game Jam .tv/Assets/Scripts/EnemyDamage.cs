using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public Player playerScript;
    public bool FindPlayer = false;
    public float cooldown = 2f; //seconds
    private float lastAttackedAt = -9999f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (FindPlayer)
        {
            if (Time.time > lastAttackedAt + cooldown)
            {
                GiveDamage();
                FindPlayer = false;
                lastAttackedAt = Time.time;
                FindPlayer = false;
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            FindPlayer = true;
        }
    }
    public void GiveDamage()
    {
        if (FindPlayer)
        {
            if (GameObject.FindGameObjectWithTag("Player"))
            {
                GetComponent<Player>().TakeDamage(2);
            }
        }
    }
}
