using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float forceOfBullet;
    public Transform bulletSpawnPosition;

    public float shootDamage;

  
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(2))
        {
            GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPosition.position, bulletSpawnPosition.rotation);
            bullet.GetComponent<Rigidbody>().AddForce(bullet.transform.forward *  forceOfBullet);

            bullrt bulletscript = bullet.GetComponent<bullrt>();
            if (bulletscript != null )
            {
                bulletscript.ShootDamage = shootDamage;
            }

            Destroy(bullet, 2f);
        }
    }

  
    

}
