using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public Toggle toggleButton;
    public AudioSource audioSource; // ADDED
    public Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>(); //ADDED  
        toggleButton = GetComponent<Toggle>();

    }


    public void PlayMusic(bool newValue)
    {
        if (newValue == false)
        {
            audioSource.Pause();
        }
        else
        {
            audioSource.Play();
        }

    }

}
