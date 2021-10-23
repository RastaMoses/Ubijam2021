using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatSwarm : MonoBehaviour
{
    [SerializeField] List<Rat> ratList;
    [SerializeField] public bool isBurning;
    
    public void StartBurn()
    {
        isBurning = true;
        foreach (Rat i in ratList)
        {
            //Set AI change
            i.GetComponent<RatMovement>().enabled = false;
            i.GetComponent<RandomMovement>().enabled = true;
            StartCoroutine(KillRat());
            i.GetComponent<RandomMovement>().SetTarget();
            //Change Sprite
        }
    }
    IEnumerator KillRat()
        {
            yield return new WaitForSeconds(3f);
            DestroySwarm();
        }

    public void DestroySwarm()
    {

        foreach (Rat i in ratList)
          {
            Object.Destroy(i);
          
          }
                
    }
}
