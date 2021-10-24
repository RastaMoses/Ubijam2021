using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dirt : MonoBehaviour
{
    Game game;
    private void Awake()
    {
        game = FindObjectOfType<Game>();
    }

    public void Destroyed()
    {
        Debug.Log("Dirt Destroy");
        gameObject.SetActive(false);
        game.UpdateDirtList();
        Destroy(gameObject);
    }
}
