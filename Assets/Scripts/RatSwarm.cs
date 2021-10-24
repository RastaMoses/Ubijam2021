using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatSwarm : MonoBehaviour
{
    [SerializeField] List<Rat> ratList;
    [SerializeField] public bool isBurning;
    [SerializeField] float burnTime;
    
    public void StartBurn()
    {
        isBurning = true;
        FindObjectOfType<SFX>().BurnSFX();
        foreach (Rat i in ratList)
        {
            //Set AI change
            i.GetComponent<RatMovement>().enabled = false;
            i.GetComponent<RandomMovement>().enabled = true;
            StartCoroutine(KillRat());
            i.GetComponent<RandomMovement>().SetTarget();
            i.GetComponentInChildren<Animator>().SetTrigger("startRun");
        }
    }
    IEnumerator KillRat()
        {
            yield return new WaitForSeconds(burnTime);
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
