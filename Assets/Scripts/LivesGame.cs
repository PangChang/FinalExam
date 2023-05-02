using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesGame : MonoBehaviour
{
    public int livesChanging = 0;
    public Text RemainingLives;

    // Start is called before the first frame update
    void Start()
    {
        livesChanging = LivesSelect.lives;
        RemainingLives.text = livesChanging.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            RemainingLives.text = livesChanging.ToString();
            livesChanging++;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            RemainingLives.text = livesChanging.ToString();
            livesChanging--;
        }
        RemainingLives.text = livesChanging.ToString();
    }
    public void LivesIncrease()
    {
        livesChanging++;
        RemainingLives.text = livesChanging.ToString();
    }
    public void LivesDecrease()
    {
        livesChanging--;
        RemainingLives.text = livesChanging.ToString();
    }
}
