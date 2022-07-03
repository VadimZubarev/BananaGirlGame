using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MichaelJacksonMode : MonoBehaviour
{
    public AudioSource BillyJean;

    public PlayerController playerControllerScript;
    //public MusicWithJackson musicScript;

    public void stopMusic()
    {
        AudioSource[] audios = FindObjectsOfType<AudioSource>();
        foreach (AudioSource a in audios)
        {
            a.Pause();
        }
    }

    void Start()
    {
        if (Input.GetKeyDown(KeyCode.A) && PlayerController.facingRight == true)
        {
            //stopMusic();
            BillyJean.Play();
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            BillyJean.Pause();
        }
        else if (Input.GetKeyDown(KeyCode.D) && PlayerController.facingRight == false)
        {
            //stopMusic();
            BillyJean.Play();
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            BillyJean.Pause();
        }
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) && PlayerController.facingRight == true)
        {
            //stopMusic();
            BillyJean.Play();
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            BillyJean.Pause();
        }
        else if (Input.GetKeyDown(KeyCode.D) && PlayerController.facingRight == false)
        {
            //stopMusic();
            BillyJean.Play();
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            BillyJean.Pause();
        }
    }
    /*void Start()
    {
        bool leftwalk = Input.GetKey(KeyCode.A);
        bool rightwalk = Input.GetKey(KeyCode.D);
        if (leftwalk && PlayerController.facingRight == true)
        {
            //stopMusic();
            BillyJean.Play();
        }
        else if (rightwalk && PlayerController.facingRight == false)
        {
            //stopMusic();
            BillyJean.Play();
        }
    }

    
    void Update()
    {
        bool leftwalk = Input.GetKey(KeyCode.A);
        bool rightwalk = Input.GetKey(KeyCode.D);
        if (leftwalk && PlayerController.facingRight == true)
        {
            //stopMusic();
            BillyJean.Play();
        }
        else if (rightwalk && PlayerController.facingRight == false)
        {
            //stopMusic();
            BillyJean.Play();
        }
        else
        {
            BillyJean.Stop();
        }
    }*/

    /*void Start()
    {
        bool leftwalk = Input.GetKey(KeyCode.A);
        bool rightwalk = Input.GetKey(KeyCode.D);
        if (leftwalk)
        {
            //stopMusic();
            BillyJean.Play();
        }
        else if (rightwalk)
        {
            //stopMusic();
            BillyJean.Play();
        }
    }


    void Update()
    {
        bool leftwalk = Input.GetKey(KeyCode.A);
        bool rightwalk = Input.GetKey(KeyCode.D);
        if (leftwalk)
        {
            //stopMusic();
            BillyJean.Play();
        }
        else if (rightwalk)
        {
            //stopMusic();
            BillyJean.Play();
        }
        else
        {
            BillyJean.Stop();
        }
    }*/
    /*void Start()
    {
        if (Input.GetKey(KeyCode.A))
        {
            BillyJean.loop = true;
            BillyJean.Play();
        }
        else
        {
            BillyJean.loop = false;
            BillyJean.Stop();
        }
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            BillyJean.loop = true;
            BillyJean.Play();
        }
        else
        {
            BillyJean.loop = false;
            BillyJean.Stop();
        }
    }*/
}
