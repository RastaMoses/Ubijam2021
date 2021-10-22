using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BesenMovement : MonoBehaviour
{

    public Transform target;
    public float speed;
    [SerializeField] float circleRadius;
    [SerializeField] Collider2D[] targetList;
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
        }
        else
        {
            target = targetList[0].transform;
        }
        aiSeeker.GetComponent<BesenAISeeker>().SetTarget(target);
    }

}
