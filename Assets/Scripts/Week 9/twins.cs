using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class twins : BaseEnemy
{
    public AudioSource oof;
    public AudioSource mwahaha;

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();

        Debug.Log("HeeHo were a twins!");
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
    }

    protected override void Attack()
    {
        base.Attack();
        Debug.Log(this.gameObject.name + " deals " + attackDamage + " damage to you!");
        mwahaha.Play();
    }

    public override void TakeDamage(float damage)
    {
        oof.Play();
        base.TakeDamage(damage);
       
    }
    public override void TakeShootDamage(bullrt Shootdamage)
    {
        oof.Play();
        base.TakeShootDamage(Shootdamage);
    }

}
