using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BesenMovement : MonoBehaviour
{

    public Transform target;
    public float speed;
    [SerializeField] float circleRadius;
    public Collider2D[] targetList;
    [SerializeField] LayerMask targetLayer;
    [SerializeField] Transform aiSeeker;


    private void Start()
    {
        NewTarget();
    }

    public void NewTarget()
    {
        targetList = Physics2D.OverlapCircleAll(transform.position, circleRadius, targetLayer);
        if (targetList.Length == 0)
        {
            target = transform;
            
            GetComponent<Animator>().SetBool("Moving", false);
        }
        else
        {
            if (GetComponent<Broom>().active)
            {
                GetComponent<Animator>().SetBool("Moving", true);
            }
            
            if(targetList[0] == null)
            {
                target = targetList[1].transform;
            }
                      
             target = targetList[0].transform;
                        
        }
        aiSeeker.GetComponent<BesenAISeeker>().SetTarget(target);
    }

}
