using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager1 : MonoBehaviour
{
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource musicClip;

    public AudioClip background;
    public AudioClip newplayer;
    public AudioClip barr;
    // Start is called before the first frame update
    private void Start()
    {
        musicSource.clip = background;
        musicSource.Play();
    }


    // Update is called once per frame
    public void PlayClip(AudioClip Clip)
    {
        musicClip.PlayOneShot(Clip);
    }
}
