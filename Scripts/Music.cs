using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{

    public MichaelJacksonMode moonWalkSongCall;

    //public AudioSource BillyJean;

    public AudioSource Track1;

    public AudioSource Track2;

    public AudioSource Track3;

    public AudioSource Track4;

    //public AudioSource Track5;

    //public PlayerController playerControllerScript;

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
        TrackSelector = Random.Range(0, 4);

        //bool leftback = Input.GetKeyDown(KeyCode.A);
        //bool rightback = Input.GetKeyDown(KeyCode.D);

        /*if (leftback && PlayerController.facingRight == true)
        {
            Track5.Play();
        }
        else if (rightback && PlayerController.facingRight == false)
        {
            Track5.Play();
        }*/
        if (TrackSelector == 0)
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

    // Update is called once per frame
    void Update()
    {
        if (Track1.isPlaying == false && Track2.isPlaying == false && Track3.isPlaying == false && Track4.isPlaying == false && GetComponent<MichaelJacksonMode>().BillyJean.isPlaying == false)
        {
            TrackSelector = Random.Range(0, 4);

            /*bool leftback = Input.GetKeyDown(KeyCode.A);
            bool rightback = Input.GetKeyDown(KeyCode.D);

            if (leftback && PlayerController.facingRight == true)
            {
                Track5.Play();
            }
            else if (rightback && PlayerController.facingRight == false)
            {
                Track5.Play();
            }*/
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
        if (GetComponent<MichaelJacksonMode>().BillyJean.isPlaying == true)
        {
            Track1.Pause();
            Track2.Pause();
            Track3.Pause();
            Track4.Pause();
}
    }
}
