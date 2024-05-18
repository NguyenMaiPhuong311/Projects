using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource musicClip;

    public AudioClip background;
    
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
