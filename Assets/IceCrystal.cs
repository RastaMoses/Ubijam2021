using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceCrystal : MonoBehaviour
{
    public Rigidbody2D rb;
    [SerializeField] Rat[] ratList;
    [SerializeField] Broom[] besenList;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.GetComponent<Firebolt>())
        {
            ratList = FindObjectsOfType<Rat>();
            foreach(Rat i in ratList)
            {
                i.Freeze();
            }
            besenList = FindObjectsOfType<Broom>();
            foreach (Broom i in besenList)
            {
                i.Freeze();
            }
        }
    }
    
}
