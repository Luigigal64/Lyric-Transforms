using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AllGone : MonoBehaviour
{
    public ButtonHandler count;

    public bool WinTime = false;

    public Text WinText;

    public AudioSource audioSource;

    public AudioClip ElectroWin;

    float currentTime = 0f;

    public int Complete;


    // Start is called before the first frame update
    void FixedUpdate()
    {
        if (ButtonHandler.count >= 5)
        {
            WinScreen();
        }


        if (currentTime <= 0)
        {
            currentTime = 0;
        }

    }

    // Update is called once per frame
    void WinScreen()
    {
        if (WinTime == false)
        {
            SceneManager.LoadScene("Complete");
            WinTime = true;
            audioSource.PlayOneShot(ElectroWin);
            WinText.gameObject.SetActive(true);
        }
    }

}
