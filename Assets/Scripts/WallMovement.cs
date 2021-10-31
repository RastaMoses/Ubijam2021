using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMovement : MonoBehaviour
{
    [SerializeField] bool activated;

    public float speed;
    private float waitTime;
    public float startWaitTime;
    public Rigidbody2D rb;

    public Transform[] moveSpots;
    private int randomSpot;

    void Start()
    {
        waitTime = startWaitTime;
        randomSpot = Random.Range(0, moveSpots.Length);
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (!activated)
        {
            return;
        }

        transform.position = Vector3.MoveTowards(transform.position, moveSpots[randomSpot].position, speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, moveSpots[randomSpot].position) < 0.2f)
        {
            if (waitTime <= 0)
            {
                randomSpot = Random.Range(0, moveSpots.Length);
                waitTime = startWaitTime;
            }
            else
            {
                waitTime -= Time.deltaTime;
            }

        }
    }
    public void Freeze()
    {
        rb.constraints = RigidbodyConstraints2D.FreezeAll;
        GetComponent<WallMovement>().enabled = false;
    }
    public void SetActivated(bool activate)
    {
        activated = activate;
    }

    public void Activate()
    {
        SetActivated(true);
    }
}
