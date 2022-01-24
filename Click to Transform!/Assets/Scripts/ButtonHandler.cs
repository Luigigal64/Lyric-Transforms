using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonHandler : MonoBehaviour
{
    public static int count;
    public void ButtonVanish()
    {
        count += 1;
        //sfx
        EventSystem.current.currentSelectedGameObject.SetActive(false);
    }
}



