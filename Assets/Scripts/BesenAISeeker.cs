using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BesenAISeeker : MonoBehaviour
{
    [SerializeField] GameObject target;
    public void SetTarget(Transform newTarget)
    {
        target = newTarget.gameObject;
    }
    // Update is called once per frame
    void Update()
    {
        
        if(target.gameObject == null)
        {
            FindObjectOfType<BesenMovement>().NewTarget();
        }
        else
        {
            transform.position = target.transform.position;
        }
    }
}
