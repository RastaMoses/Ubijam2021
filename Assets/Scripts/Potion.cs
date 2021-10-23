using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion : MonoBehaviour
{
    [SerializeField] GameObject gasPrefab;
    public void GasCloud()
    {
        Instantiate(gasPrefab);
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Firebolt>())
        {
            GasCloud();
            
        }
        if (collision.GetComponent<Rat>())
        {
            GasCloud();
            collision.GetComponent<Rat>().DestroySelf();
        }
    }
}
