using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class West : BaseEnemy
{
    public AudioSource ow;
    public AudioSource hehe;

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();

        Debug.Log("HeeHo I'm a West!");
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
        hehe.Play();
    }

    public override void TakeDamage(float damage)
    {
        ow.Play();
        base.TakeDamage(damage);

    }
    public override void TakeShootDamage(bullrt Shootdamage)
    {
        ow.Play();
        base.TakeShootDamage(Shootdamage);
    }
}
