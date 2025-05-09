using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeEnemy : BaseEnemy

{
    public AudioSource bloop;
    public AudioSource eh;

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();

        Debug.Log("HeeHo I'm a slime!");
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
        eh.Play();
    }

    public override void TakeDamage(float damage)
    {
        bloop.Play();
        base.TakeDamage(damage);
       
    }
    public override void TakeShootDamage(bullrt Shootdamage)
    {
        bloop.Play();
        base.TakeShootDamage(Shootdamage);
    }

}
