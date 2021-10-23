using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] int currentMana;
    [SerializeField] int maxMana = 3;
    [SerializeField] List<Dirt> dirtList;
    
    // Start is called before the first frame update
    void Start()
    {
        dirtList = new List<Dirt>();
        foreach (Dirt i in FindObjectsOfType<Dirt>())
        {
            dirtList.Add(i);
        }
        currentMana = maxMana;
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
    
    public void LoseMana()
    {
        currentMana--;
        //Update UI
        if (currentMana <= 0)
        {
            //Lock Spells
            //Start Game Over Timer
        }

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
