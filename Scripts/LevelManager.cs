using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public int currentLevel;

    private MenuManager menu;
    // Start is called before the first frame update
    public void StartLevel()
    {
        Time.timeScale = 1;
        menu.HideScreens();
    }
    void Start()
    {
        menu = FindObjectOfType<MenuManager>();

        if (currentLevel == 0)
        {
            menu.ShowStartScreen();
            Time.timeScale = 0;  
        }
    }

    public void NextLevel(){
        SceneManager.LoadScene(currentLevel+1);
    }

    public void ResetGame()
    {
        SceneManager.LoadScene(0);
    }

    public void LoseLevel()
    {
        Time.timeScale = 0;
        menu.ShowLoseScreen();
    }
}
