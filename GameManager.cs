using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    int levelToUnlock,topLevel;
    public static GameManager instance;
    private void Awake() {
        instance = this;
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    public void CompleteLevel()
    {
        FindObjectOfType<AudioManager>().Play("Win");
        levelToUnlock = Int16.Parse(SceneManager.GetActiveScene().name.Split(' ').GetValue(1).ToString());
        topLevel = PlayerPrefs.GetInt("levelReached");
        if(topLevel==0)
            topLevel=1;
        if(topLevel == levelToUnlock){
            PlayerPrefs.SetInt("levelReached",levelToUnlock+1);
        }
        SceneManager.LoadScene("LevelSelect");
    }
    public void Restart()
    {
        FindObjectOfType<AudioManager>().Play("Death");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
