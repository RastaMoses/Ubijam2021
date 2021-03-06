using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

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
        
            
            if (Input.GetButtonDown("Fire1"))
            {
                if (EventSystem.current.IsPointerOverGameObject())
                {
                    Debug.Log("Mouse over UI elements");
                    return;
                }


                var game = FindObjectOfType<Game>();
                int mana = game.GetMana();
                if (mana > 0)
                {
                    Shoot();
                    //shoot = false;
                    game.LoseMana();
                    this.enabled = false;
                    img.gameObject.SetActive(false);
                }
            }
        
    }

    void Shoot()
    {
        FindObjectOfType<SFX>().EnergySFX();
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
    }
}
