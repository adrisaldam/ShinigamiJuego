using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dummy : MonoBehaviour
{
    public float dummyHealth;
    public float damage2Dummy;
    public ParticleSystem deadDummyEffect;
    public GameObject HealthBarPanel;
    Slider slider;
    [SerializeField]
    GameObject soundDumy;
    AudioManager audioDumy;

    private void Start()
    {
        HealthBarPanel.SetActive(false);
        slider = HealthBarPanel.GetComponent<Slider>();
        slider.value = dummyHealth;
        audioDumy = soundDumy.GetComponent<AudioManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Wepon"))
        {
            HealthBarPanel.SetActive(true);
            dummyHealth -= damage2Dummy/2;
            slider.value = dummyHealth;
            audioDumy.DamageDummy();
            //Aqui va sonido de golpe a dumy    

            if (dummyHealth<= 0)
            {
                deadDummyEffect.Play();
                Destroy(gameObject);
                audioDumy.DeadEnemy();
                //Aqui va sonido de muerte enemigo
            }
        }
    }
}
