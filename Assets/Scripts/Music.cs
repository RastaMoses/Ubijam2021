using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Music : MonoBehaviour
{
    [SerializeField] bool NewMusic;
    [SerializeField] Slider musicSlider;
    AudioSource audioSource;
    private void Awake()
    {
        if (!NewMusic)
        {
            int gameObjectCount = FindObjectsOfType<Music>().Length;
            if (gameObjectCount > 1)
            {

                Destroy(gameObject);
                gameObject.SetActive(false);
            }
            else
            {
                DontDestroyOnLoad(gameObject);
            }

            
        }
        audioSource = GetComponent<AudioSource>();
        musicSlider.value = 0.5f;
        musicSlider.value = PlayerPrefs.GetFloat("MusicVolume", .5f);
        


    }
    public void ChangeMusic(AudioClip newMusic)
    {
        audioSource.clip = newMusic;
        audioSource.Play();
    }

    private void Update()
    {
        audioSource.volume = musicSlider.value;
        PlayerPrefs.SetFloat("MusicVolume", audioSource.volume);

    }
}
