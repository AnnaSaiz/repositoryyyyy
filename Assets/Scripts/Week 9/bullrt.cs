using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullrt : MonoBehaviour
{
    public float ShootDamage;
    

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemies")
        {
            Debug.Log("found");
            BaseEnemy enemyy = collision.gameObject.GetComponent<BaseEnemy>();
            if (enemyy != null)
            {
                enemyy.TakeDamage(ShootDamage);
            }
        }
    }
}
