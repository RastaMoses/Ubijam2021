using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    [SerializeField] int currentMana;
    [SerializeField] int maxMana = 3;
    [SerializeField] List<Dirt> dirtList;

    [SerializeField] float timeRemaining;
    public bool timerIsRunning = false;
    public bool win = false;

    public GameObject playerUI;
    public GameObject pauseUI;
    public GameObject gameOverUI;

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
        if(timerIsRunning && win != true)
        {
            if(timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                
            }
            else
            {
                Lose();
                timeRemaining = 0;
                timerIsRunning = false;
            }
        }
    }
    

    




    void Win()
    {
        Time.timeScale = 0f;
        FindObjectOfType<SceneLoader>().LoadNextLevel();
    }

    public void BookDestroyed()
    {
        Lose();
    }
    
    void Lose()
    {
        Time.timeScale = 0f;
        pauseUI.SetActive(false);
        playerUI.SetActive(false);
        gameOverUI.SetActive(true);
    }
}
