using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gas : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Broom>())
        {
            collision.gameObject.GetComponent<Broom>().SetNewTarget();
            DestroySelf();
        }

        else if (collision.gameObject.GetComponent<Firebolt>())
        {
            collision.gameObject.GetComponent<Firebolt>().DestroySelf();
        }
        else if (collision.gameObject.GetComponent<Fire>())
        {
            //collision.gameObject.GetComponent<Fire>().DestroySelf();
            DestroySelf();
        }
    }

    public void DestroySelf()
    {
        GetComponent<Dirt>().Destroyed();
        Destroy(gameObject);
    }


}
