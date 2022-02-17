using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.PlayerLoop;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject loseScreen;
    public GameObject startScreen;
    public TextMeshProUGUI notificationText;
    public GameObject notification;
    private bool canCloseNotification;
    public void HideScreens()
    {
        startScreen.SetActive(false);
        loseScreen.SetActive(false);
    }
    public void ShowStartScreen()
    {
        startScreen.SetActive(true);
    }
    
    public void ShowLoseScreen()
    {
        loseScreen.SetActive(true);
    }

    public void ShowNotification(string text)
    {
        notification.SetActive(true);
        notificationText.text = text;
        canCloseNotification = false;
        Invoke("WaitAndAllowClose",1.4f);
    }

    void WaitAndAllowClose()
    {
        canCloseNotification = true;
        }
    void Update()
    {
        if (Input.anyKey && canCloseNotification)
        {
            notification.SetActive(false);

        }
    }
}
