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

    private void OnDestroy()
    {
        game.UpdateDirtList();
    }
}
