using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatSwarm : MonoBehaviour
{
    [SerializeField] List<RatMovement> ratList;
    [SerializeField] public bool isBurning;
    
    public void StartBurn()
    {
        isBurning = true;
        foreach (RatMovement i in ratList)
        {
            //Set AI change
            //Change Sprite
        }


    }


    public void DestroySwarm()
    {

        foreach (RatMovement i in ratList)
          {
            Destroy(i);
          
          }
         
          
        
          
    }


    
}
