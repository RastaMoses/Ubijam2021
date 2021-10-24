using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateMirrors : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown("s"))
        {
            var game = FindObjectOfType<Game>();
            int mana = game.GetMana();
            if(mana > 0)
            {
                Portals();
                game.LoseMana();
            }
        }
    }

    void Portals()
    {
        FindObjectOfType<Teleport>().ActivateBoth();
    }
}
