using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SFX : MonoBehaviour
{
    [SerializeField] Slider sfxSlider;

    [SerializeField] AudioClip gasClip;
    [SerializeField] AudioClip[] ratClips;
    [SerializeField] AudioClip burnClip;
    [SerializeField] AudioClip iceClip;
    [SerializeField] AudioClip cobwebClip;
    [SerializeField] AudioClip fireClip;
    [SerializeField] AudioClip energyClip;
    [SerializeField] AudioClip hitClip;
    [SerializeField] AudioClip teleportClip;
    [SerializeField] AudioClip bookClip;
    [SerializeField] AudioClip wallClip;
    [SerializeField] AudioClip broomClip;
    AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        sfxSlider.value = 0.5f;
    }
    public void GasSFX()
    {
        AudioSource.PlayClipAtPoint(gasClip, transform.position);
    }
    public void CobwebSFX()
    {
        AudioSource.PlayClipAtPoint(cobwebClip, transform.position);
    }
    public void HitSFX()
    {
        AudioSource.PlayClipAtPoint(hitClip, transform.position);
    }
    public void BookSFX()
    {
        AudioSource.PlayClipAtPoint(bookClip, transform.position);
    }

    public void RatSFX()
    {
        var i = Random.Range(0, ratClips.Length);
        var stickClip = ratClips[i];
        audioSource.clip = stickClip;
        audioSource.Play();
    }

    public void BurnSFX()
    {
        audioSource.clip = burnClip;
        audioSource.Play();
    }
    public void IceSFX()
    {
        audioSource.clip = iceClip;
        audioSource.Play();
    }

    public void EnergySFX()
    {
        audioSource.clip = energyClip;
        audioSource.Play();
    }

    public void FireSFX()
    {
        audioSource.clip = fireClip;
        audioSource.Play();
    }
    public void TeleportSFX()
    {
        audioSource.clip = teleportClip;
        audioSource.Play();
    }
    public void WallSFX()
    {
        audioSource.clip = wallClip;
        audioSource.Play();
    }
    public void BroomSFX()
    {
        audioSource.clip = broomClip;
        audioSource.Play();
    }

    private void Update()
    {
        audioSource.volume = sfxSlider.value;
    }
}

