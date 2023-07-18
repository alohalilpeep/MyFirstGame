using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoseScreen : RecordScore
{
    public void Start()
    {
        RecordAndScore();
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void BackToGame()
    {
        SceneManager.LoadScene(1);
    }
}
