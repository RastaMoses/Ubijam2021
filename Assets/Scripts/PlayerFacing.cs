using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFacing : MonoBehaviour
{
    Vector3 mouse_pos;
     //Assign to the object you want to rotate
    Vector3 object_pos;
    float angle;
    bool gamePaused;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (gamePaused)
        {
            return;
        }
        mouse_pos = Input.mousePosition;
        mouse_pos.z = 5.23f; //The distance between the camera and object
        object_pos = Camera.main.WorldToScreenPoint(transform.position);
        mouse_pos.x = mouse_pos.x - object_pos.x;
        mouse_pos.y = mouse_pos.y - object_pos.y;
        angle = Mathf.Atan2(mouse_pos.y, mouse_pos.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler( new Vector3(0, 0, angle + -90));

    }
    
    public void SetGamePause(bool paused)
    {
        gamePaused = paused;
    }
    


}
