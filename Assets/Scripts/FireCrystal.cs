using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCrystal : MonoBehaviour
{
    private Transform destination;
    [SerializeField] FireCrystal fc;
    public GameObject firePrefab;
    public float bulletForce = 20f;

    void Start()
    {
        destination = fc.transform;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.GetComponent<Firebolt>())
        {
            GameObject fire = Instantiate(firePrefab, collision.transform.position, collision.transform.rotation);
            collision.transform.position = new Vector2(destination.position.x, destination.position.y);
            Rigidbody2D rb = fire.GetComponent<Rigidbody2D>();
            rb.velocity = collision.GetComponent<Rigidbody2D>().velocity;
        }
    }
}
