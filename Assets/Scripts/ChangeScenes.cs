using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScenes : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("2Game");
    }

    public void FinishGame()
    {
        if (Time.timeScale == 0f)
        {
            return;  // ignore click
        }

        else
        {
            SceneManager.LoadScene("3Exit");
        }
    }
    public void RestartGame()
    {
        SceneManager.LoadScene("1Intro");
    }
    public void ExitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
