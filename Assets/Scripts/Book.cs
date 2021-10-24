using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book : MonoBehaviour
{
    Game game;
    private void Awake()
    {
        game = FindObjectOfType<Game>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Firebolt>() || collision.GetComponent<Rat>())
        {
            Destroyed();
        }
        else if (collision.GetComponent<Fire>())
        {
            Destroyed();
        }
        
    }

    public void Destroyed()
    {
        game.BookDestroyed();
        Destroy(gameObject);
    }
}
