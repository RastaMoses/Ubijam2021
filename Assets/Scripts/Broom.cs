using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Broom : MonoBehaviour
{
    public void SetNewTarget()
    {
        GetComponent<BesenMovement>().NewTarget();
    
    }

    public void Freeze()
    {     
        GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
        Debug.Log("hit");
        GetComponent<Pathfinding.AIPath>().enabled = false;
        GetComponent<RatMovement>().enabled = false;
    }
}
