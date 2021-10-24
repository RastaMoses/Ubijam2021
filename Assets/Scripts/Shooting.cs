using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    //public bool shoot = false;
    public GameObject img;

    public float bulletForce = 20f;
    void Update()
    {
        //if (shoot == true)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                Shoot();
                //shoot = false;
                this.enabled = false;
                img.gameObject.SetActive(false);
            }
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
    }
}
