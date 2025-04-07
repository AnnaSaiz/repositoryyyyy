using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public GameObject playerr;
    public bool foundPowerUp;

    public GameObject powerupHealth;
    public GameObject powerupSpeed;
    public GameObject powerupSheild;

    public PlayerRPG playerRPG;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  
        public virtual void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "PowerUps")
        {
            Debug.Log("foundPowerUps");
            foundPowerUp = true;    
        }
    }

}

