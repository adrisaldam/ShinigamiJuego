using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Health : MonoBehaviour
{
    //Enemy enemy;
    public float playerHealth;
    public GameObject HealthBarPanel;
    Slider slider;
    public ParticleSystem impactEffect;
    public bool playerIsDead = false;
    [SerializeField] GameObject audioDamage;
    [SerializeField] GameObject musicManage;
    AudioManagerMusic musicChange;
    AudioManager soundDamage;

    private void Start()
    {
        //enemy = GetComponent<Enemy>();
        slider = HealthBarPanel.GetComponent<Slider>();
        slider.value = playerHealth;
        soundDamage = audioDamage.GetComponent<AudioManager>();
        musicChange = musicManage.GetComponent<AudioManagerMusic>();
    }
    public void TakeDamage(float damage)
    {
        playerHealth -= damage;
        slider.value = playerHealth;
        soundDamage.DamagePlayer();
        //Aqui tengo que poner sonido de daño a jugador
        if (playerHealth <= 0)
        {
            //Aquí sonido de muerte de jugador
            FindObjectOfType<Manager>().EndGame(); //Esto consume mucho recurso :c
            gameObject.SetActive(false);//temporal
            soundDamage.DeadPlayer();
            musicChange.Lose();
            //Aquí sonido de GameOver
        }

    }
}
