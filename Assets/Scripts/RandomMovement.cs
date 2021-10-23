using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMovement : MonoBehaviour
{
    public float speed;
    private float waitTime;
    public float startWaitTime;
    [SerializeField] Transform target;

    Vector2 moveSpots;
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    public void SetTarget()
    {
        waitTime = startWaitTime;

        moveSpots = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
        target.position = moveSpots;
    }
    

    void Update()
    {
        //transform.position = Vector2.MoveTowards(transform.position, moveSpots, speed * Time.deltaTime);

        if(Vector2.Distance(transform.position, moveSpots) < 0.2f)
        {
            if(waitTime <= 0){
                SetTarget();
            }
            else
            {
                waitTime -= Time.deltaTime;
            } 
            
        }


    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Fire>())
        {
            moveSpots = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
            target.position = moveSpots;
        }
    }
}
