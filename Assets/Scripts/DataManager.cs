using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataManager : MonoBehaviour
{

    public static string playerName;
    public InputField playerNameInput;
    public Text showPlayerName;


    void Awake()
    {
        DontDestroyOnLoad(this.gameObject); // don't destroy this game object when a new scene is loaded.
    }



    public void UpdateName()
    {
        playerName = playerNameInput.text;
        Debug.Log(playerName);
        showPlayerName.text = playerName;
    }
    public void ShowName()
    {
        showPlayerName.text = playerName;
        Debug.Log(playerName);
    }
}
