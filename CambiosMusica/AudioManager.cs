using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    [SerializeField] AudioSource soundEffects;
    [SerializeField] AudioClip damagePlayer;
    [SerializeField] AudioClip damagEnemy;
    [SerializeField] AudioClip attackPlayer;
    [SerializeField] AudioClip attackEnemy;
    [SerializeField] AudioClip damageDuumy;
    [SerializeField] AudioClip deadPlayer;
    [SerializeField] AudioClip deadEnemy;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void DamagePlayer()
    {
        soundEffects.clip = damagePlayer;
        soundEffects.Play();
    }

    public void AttackPlayer()
    {
        soundEffects.clip = attackPlayer;
        soundEffects.Play();
    }

    public void DamageDummy()
    {
        soundEffects.clip = damageDuumy;
        soundEffects.Play();
    }

    public void DeadPlayer()
    {
        soundEffects.clip = deadPlayer;
        soundEffects.Play();
    }

    public void DeadEnemy()
    {
        soundEffects.clip = deadEnemy;
        soundEffects.Play();
    }

    public void DamageEnemy()
    {
        soundEffects.clip = damagEnemy;
        soundEffects.Play();
    }
}
