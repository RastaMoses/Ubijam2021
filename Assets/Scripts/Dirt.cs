using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dirt : MonoBehaviour
{
    

    private void OnDestroy()
    {
        
        FindObjectOfType<Game>().UpdateDirtList();
    }
}
