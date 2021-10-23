using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Broom : MonoBehaviour
{
    bool alreadyTimed;
    [SerializeField] float idleTimer = 5f;
    private void Start()
    {
       StartCoroutine(broomTimer());
    }

    
    
    public void SetNewTarget()
    {
        GetComponent<BesenMovement>().NewTarget();
        
            
    }
    IEnumerator broomTimer()
    {
        
        yield return new WaitForSeconds(idleTimer);
        if (transform.position == GetComponent<BesenMovement>().target.transform.position)
        {
            Debug.Log("hi");
            if (alreadyTimed)
            {
                yield return null;
                Destroy(gameObject);
            }
            else
            {
                alreadyTimed = true;
                yield return broomTimer();
            }

        }
        else
        {
            yield return broomTimer();
        }
        Debug.Log("nope");
    }
    public void Freeze()
    {     
        GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
        Debug.Log("hit");
        GetComponent<Pathfinding.AIPath>().enabled = false;
        GetComponent<RatMovement>().enabled = false;
    }
   


    

}
