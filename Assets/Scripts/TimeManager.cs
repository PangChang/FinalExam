using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public Text remainingTimeText;
    public static float gametimelimit = SliderValue.timelimit;
    public static float timeRemaining;

    // Start is called before the first frame update
    void Start()
    {
        timeRemaining = gametimelimit;
        remainingTimeText.text = gametimelimit.ToString("F2") + "(seconds) left";
    }


    // Update is called once per frame
    void Update()
    {
        timeRemaining -= Time.deltaTime;
        if (timeRemaining >= 0)
        {
            remainingTimeText.text = timeRemaining.ToString("F2") + "(seconds) left";
        }
        else
        {
            remainingTimeText.text = "Game over";
            SceneManager.LoadScene("3Exit");

        }

    }
}
