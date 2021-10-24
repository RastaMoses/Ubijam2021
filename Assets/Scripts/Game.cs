using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    [SerializeField] int currentMana;
    [SerializeField] int maxMana = 3;
    [SerializeField] List<Dirt> dirtList;

    public float timeRemaining = 10;
    public bool timerIsRunning = false;
    public Text timeText;

    public int GetMana()
    {
        return currentMana;
    }
    
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
            GameObject.Find("Player").GetComponent<Shooting>().enabled = false;
            GameObject.Find("Player").GetComponent<ActivateMirrors>().enabled = false;

            //Start Game Over Timer
            timerIsRunning = true;
        }
    }
    void Update()
    {
        if(timerIsRunning)
        {
            if(timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                Lose();
                timeRemaining = 0;
                timerIsRunning = false;
            }
        }
    }
    void DisplayTime(float timeToDisplay)
    {
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        float milliSeconds = (timeToDisplay % 1) * 1000;
        timeText.text = string.Format("{0:00}:{1:000}", seconds, milliSeconds);
    }

    




    void Win()
    {
        print("Level Clear!");
    }

    public void BookDestroyed()
    {
        FindObjectOfType<SFX>().BookSFX();
        Lose();
    }
    
    void Lose()
    {
        print("Game Over!");
    }
}
