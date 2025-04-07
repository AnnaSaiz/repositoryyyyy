using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public enum powerupclass
{
    healthy,
    speed,
    sheild

}


public class PowerUpChild : PowerUp
{
    public float healthAmount;

    public powerupclass WhichPowerUp;

    public override void OnCollisionEnter(Collision collision)
    {
        base.OnCollisionEnter(collision);

        if (WhichPowerUp == powerupclass.healthy)
        {
            playerRPG.health += 10f;

            Destroy(powerupHealth);
        }
        else if (WhichPowerUp == powerupclass.speed)
        {
            

            Destroy(powerupSpeed);
        }
        else if (WhichPowerUp == powerupclass.sheild)
        {

            Destroy(powerupSheild);
        }
    }
}
