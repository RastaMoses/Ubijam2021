using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateMirrors : MonoBehaviour
{
    public GameObject img;

    Vector3 mouse_pos;
    //Assign to the object you want to rotate
    GameObject [] mirror_pos;
    GameObject[] wall_pos;
    [SerializeField] float tolerance;
    Teleport mirror;
    WallMovement mwall;
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            var game = FindObjectOfType<Game>();
            int mana = game.GetMana();
            if(mana > 0)
            {
                mouse_pos = Input.mousePosition;
                mirror_pos = GameObject.FindGameObjectsWithTag("Mirror");
                foreach(GameObject i in mirror_pos)
                {
                    var objectWorldPos = Camera.main.WorldToScreenPoint(i.transform.position);
                    objectWorldPos.z = 0;
                    mouse_pos.z = 0;
                    if (Vector2.Distance(mouse_pos, objectWorldPos) <= tolerance)
                    {
                        mirror = i.GetComponent<Teleport>();
                        Portals();
                        game.LoseMana();
                        this.enabled = false;
                        img.gameObject.SetActive(false);
                    }
                }
                wall_pos = GameObject.FindGameObjectsWithTag("mWall");
                foreach(GameObject i in wall_pos)
                {
                    var objectWorldPos = Camera.main.WorldToScreenPoint(i.transform.position);
                    objectWorldPos.z = 0;
                    mouse_pos.z = 0;
                    if (Vector2.Distance(mouse_pos, objectWorldPos) <= tolerance)
                    {
                        mwall = i.GetComponent<WallMovement>();
                        MoveWalls();
                        game.LoseMana();
                        this.enabled = false;
                        img.gameObject.SetActive(false);
                    }
                }
                
            }
        }
    }

    void MoveWalls()
    {
        mwall.Activate();
    }

    void Portals()
    {
        mirror.ActivateBoth();
    }
}
