using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{

    [SerializeField] List<Dirt> dirtList;
    
    // Start is called before the first frame update
    void Start()
    {
        dirtList = new List<Dirt>();
        foreach (Dirt i in FindObjectsOfType<Dirt>())
        {
            dirtList.Add(i);
        }
        
    }

    public void UpdateDirtList()
    {
        dirtList = new List<Dirt>();
        foreach (Dirt i in FindObjectsOfType<Dirt>())
        {
            dirtList.Add(i);
        }

        if (dirtList.Count == 0)
        {
            Win();
        }


    }
    // Update is called once per frame
    void Update()
    {
        
    }

    void Win()
    {
        print("Level Clear!");
    }

    public void BookDestroyed()
    {
        Lose();
    }
    
    void Lose()
    {
        print("Game Over!");
    }
}
