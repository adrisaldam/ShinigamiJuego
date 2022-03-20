using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManagerMusic : MonoBehaviour
{

    [SerializeField] AudioSource music;
    [SerializeField] AudioClip game;
    [SerializeField] AudioClip lose;


    private void Awake()
    {
        music.clip = game;
        music.Play();
    }

    public void Lose()
    {
        music.clip = lose;
        music.Play();
    }
}
