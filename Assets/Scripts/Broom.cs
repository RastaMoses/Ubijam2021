using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Broom : MonoBehaviour
{
    public void SetNewTarget()
    {
        GetComponent<BesenMovement>().NewTarget();
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
