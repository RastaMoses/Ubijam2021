using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateWall : MonoBehaviour
{
    public Camera cam;
    public GameObject wallPrefab;
    Vector2 mousePos;

    // Update is called once per frame
    void Update()
    {
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetButtonDown("Fire2"))
        {
            Create();
        }
    }

    void Create()
    {
        GameObject wall = Instantiate(wallPrefab, mousePos, Quaternion.Euler(0, 0, 45));
    }
}
