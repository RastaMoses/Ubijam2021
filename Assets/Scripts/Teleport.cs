using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    [SerializeField] bool activated;
    [SerializeField] Teleport mirror2;
    [SerializeField] Sprite activatedSprite;
    private Transform destination;
    public float distance = 0.2f;
    [SerializeField] float resetTimer = 0.5f;
    bool waitForReset;

    void Start()
    {
        
            destination = mirror2.transform;
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collision");
        if (!activated)
        {
            return;
        }
        
        
        else if (waitForReset)
        {
            Debug.Log("Wait for Reset");
            
        }
        else if(Vector2.Distance(transform.position, collision.transform.position) > distance)

        {
            
            Debug.Log("Teleport");
            collision.transform.position = new Vector2(destination.position.x, destination.position.y);

            mirror2.StartTimer();
            
        }
    }

    public void StartTimer()
    {
        StartCoroutine(ResetTimer());
    }
     IEnumerator ResetTimer()
    {
        waitForReset = true;
        yield return new WaitForSeconds(resetTimer);
        waitForReset = false;
    }

    public void SetActivated(bool activate)
    {
        activated = activate;
        var spriteList = GetComponentsInChildren<SpriteRenderer>();
        foreach(SpriteRenderer i in spriteList)
        {
            i.sprite = activatedSprite;
        }
    }

    public void ActivateBoth()
    {
        SetActivated(true);
        mirror2.SetActivated(true);
    }
}
