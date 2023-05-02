using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderValue : MonoBehaviour
{
    public Slider mySlider;
    public static float timelimit = 30.0f;
    public Text timeText;


    public void TimeLimitchange()
    {
        timelimit = mySlider.value;
        timeText.text = "Time Limit is " + mySlider.value.ToString();

    }
}
