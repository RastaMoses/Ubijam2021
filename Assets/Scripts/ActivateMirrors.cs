using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateMirrors : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown("s"))
        {
            Portals();
        }
    }

    void Portals()
    {
        FindObjectOfType<Teleport>().ActivateBoth();
    }
}
