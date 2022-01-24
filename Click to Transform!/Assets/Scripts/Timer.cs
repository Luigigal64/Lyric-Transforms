using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    float currentTime = 0f;
    float startingTime = 10f;

    public AudioSource audioSource;

    public AudioClip LoseSound;

    [SerializeField] Text CountDownText;
    [SerializeField] Text HowToPlayText;
    [SerializeField] Text LoseText;

    public GameObject Lyric;
    public GameObject LyricLose;
    public GameObject Horns;
    public GameObject Mouth;
    public GameObject LHand;
    public GameObject RHand;
    public GameObject Tail;

    void Start()
    {
        currentTime = startingTime;
        Invoke("GameOver", 14.0f);
    }

    void Update()
    {
        Invoke("TimerClock", 2.0f);
        Destroy(HowToPlayText, 2.0f);
        
    }

    void TimerClock()
    {
        currentTime -= 1 * Time.deltaTime;
        CountDownText.text = currentTime.ToString("0");

        if (currentTime <= 0)
        {
            currentTime = 0;
        }
    }

    void GameOver() 
    {
        LoseText.gameObject.SetActive(true);
        
        
        audioSource.PlayOneShot(LoseSound);
        Lyric.gameObject.SetActive(false);
        Horns.gameObject.SetActive(false);
        Mouth.gameObject.SetActive(false);
        LHand.gameObject.SetActive(false);
        RHand.gameObject.SetActive(false);
        Tail.gameObject.SetActive(false);
        LyricLose.gameObject.SetActive(true);

    }
}
