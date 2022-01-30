using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public int currentLevel;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    public void NextLevel(){
        SceneManager.LoadScene(currentLevel+1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
