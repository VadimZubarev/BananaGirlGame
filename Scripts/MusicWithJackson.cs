using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicWithJackson : MonoBehaviour
{
    

    public AudioSource Track1;

    public AudioSource Track2;

    public AudioSource Track3;

    public AudioSource Track4;

    public AudioSource Track5;

    public PlayerController playerControllerScript;

    public int TrackSelector;

    public int TrackHistory;

    public static void stopMusic()
    {
        AudioSource[] audios = FindObjectsOfType<AudioSource>();
        foreach (AudioSource a in audios)
        {
            a.Pause();
        }
    }

    void Start()
    {
        AudioSource[] audios = FindObjectsOfType<AudioSource>();
        TrackSelector = Random.Range(0, 4);

        bool leftback = Input.GetKey(KeyCode.A);
        bool rightback = Input.GetKey(KeyCode.D);

        if (leftback && PlayerController.facingRight == true)
        {
            stopMusic();
            Track5.Play();
        }
        else if (rightback && PlayerController.facingRight == false)
        {
            stopMusic();
            Track5.Play();
        }
        else if (TrackSelector == 0)
        {
            Track1.Play();
            TrackHistory = 1;
        } 
        else if (TrackSelector == 1)
        {
            Track2.Play();
            TrackHistory = 2;
        }
        else if (TrackSelector == 2)
        {
            Track3.Play();
            TrackHistory = 3;
        }
        else if (TrackSelector == 3)
        {
            Track4.Play();
            TrackHistory = 4;
        }

    }

    void Update()
    {
        bool leftback = Input.GetKey(KeyCode.A);
        bool rightback = Input.GetKey(KeyCode.D);

        if (leftback && PlayerController.facingRight == true)
        {
            stopMusic();
            Track5.Play();
        }
        else if (rightback && PlayerController.facingRight == false)
        {
            stopMusic();
            Track5.Play();
        }
        else
        {
            Track5.Stop();
        }

        if (Track1.isPlaying == false && Track2.isPlaying == false && Track3.isPlaying == false && Track4.isPlaying == false && Track5.isPlaying == false)
        {
            TrackSelector = Random.Range(0, 4);

            if (TrackSelector == 0 && TrackHistory != 1)
            {
                Track1.Play();
                TrackHistory = 1;
            } 
            else if (TrackSelector == 1 && TrackHistory != 2)
            {
                Track2.Play();
                TrackHistory = 2;
            }
            else if (TrackSelector == 2 && TrackHistory != 3)
            {
                Track3.Play();
                TrackHistory = 3;
            }
            else if (TrackSelector == 3 && TrackHistory != 4)
            {
                Track4.Play();
                TrackHistory = 4;
            }
        }
    }
}
