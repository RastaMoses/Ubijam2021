using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Firebolt>() || collision.GetComponent<Rat>())
        {
            Destroy(gameObject);
        }
        else if (collision.GetComponent<Fire>())
        {
            Destroy(gameObject);
        }
        
    }

    private void OnDestroy()
    {
        FindObjectOfType<Game>().BookDestroyed();
    }
}
