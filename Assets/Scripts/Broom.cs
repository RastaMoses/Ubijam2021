using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Broom : MonoBehaviour
{
    public bool active;
    bool alreadyTimed;
    [SerializeField] float idleTimer = 5f;
    private void Start()
    {
       StartCoroutine(broomTimer());
    }

    
    
    public void SetNewTarget()
    {
        FindObjectOfType<SFX>().BroomSFX();
        GetComponent<BesenMovement>().NewTarget();
        
            
    }
    IEnumerator broomTimer()
    {
        
        yield return new WaitForSeconds(idleTimer);
        if (active) 
        {
            if (transform.position == GetComponent<BesenMovement>().target.transform.position)
            {
                GetComponent<BesenMovement>().NewTarget();
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
        else
        {
            yield return broomTimer();
        }
        
    }
    public void Freeze()
    {     
        if (active)
        {
            GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
            Debug.Log("hit");
            GetComponent<Pathfinding.AIPath>().enabled = false;
            GetComponent<BesenMovement>().enabled = false;
        }
        
    }

    



}
