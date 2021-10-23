using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceCrystal : MonoBehaviour
{
    public Rigidbody2D rb;
    [SerializeField] Rat[] ratList;
    [SerializeField] Broom[] besenList;
    [SerializeField] WallMovement[] wallList;
    [SerializeField] FireCrystal[] frList;

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
            wallList = FindObjectsOfType<WallMovement>();
            foreach (WallMovement i in wallList)
            {
                i.Freeze();
            }
            frList = FindObjectsOfType<FireCrystal>();
            foreach(FireCrystal i in frList)
            {
                i.DestroySelf();
            }
        }
    }
}
