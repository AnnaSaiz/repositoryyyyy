using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEnemy : MonoBehaviour
{
    public float health = 100f;
    public float speed = 3f;
    public float attackDamage = 10f;

    private float timer = 0f;

    [SerializeField] protected float attackInterval = 1f;

    private PlayerRPG player;

    public float distanceFrom;
    public GameObject enemy;
    
    

    // Start is called before the first frame update
    protected virtual void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerRPG>();
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        timer += Time.deltaTime;
        distanceFrom = Vector3.Distance(player.transform.position, enemy.transform.position);

        if(timer >= attackInterval)
        {
           if(distanceFrom < 3f)
            {
                Attack();
                timer = 0f;
            }
           
        }
    }

    protected virtual void Attack()
    {
      
        player.TakeDamage(attackDamage);
    }

    public virtual void Move()
    {
        
    }

    public virtual void TakeDamage(float damage)
    {
        health -= damage;
      

        if(health <= 0f)
        {
            Destroy(this.gameObject);
        }

        Debug.Log("ow");
    }
    public virtual void TakeShootDamage(bullrt Shootdamage)
    {
        health -= Shootdamage.ShootDamage; 
        if(health <= 0f)
        {
            Destroy(this.gameObject);
        }

        Debug.Log("ow");
    }
    
}
