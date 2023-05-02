using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using UnityEngine.UI;

public class PointsChange : MonoBehaviour
{
    public static int points;
    public Text pointsText;

    public Text Name;
    public static string PlayerName;


    // Start is called before the first frame update
    void Start()
    {
        Name.text = "Currently playing: " + DataManager.playerName.ToString();
        Debug.Log(PlayerName);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            pointsText.text = points.ToString();
            points++;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            pointsText.text = points.ToString();
            points--;
        }
    }

    public void upPointsButton()
    {
        pointsText.text = points.ToString();
        points++;
    }
    public void downPointsButton()
    {
        pointsText.text = points.ToString();
        points--;
    }







    private Save CreateSaveGameObject()
    {
        Save save = new Save();

        save.saveName = Name;
        save.savePoints = points;

        return save;
    }

    public void SaveGame()
    {
        // 1
        Save save = CreateSaveGameObject();

        // 2
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/gamesave.save");
        bf.Serialize(file, save);
        file.Close();

        // 3
        PlayerName = "";
        points = 0;
        Name.text = "Name: " + DataManager.playerName.ToString();
        pointsText.text = "Points: " + points;

        Debug.Log("Game Saved");
    }

    public void LoadGame()
    {
        // 1
        if (File.Exists(Application.persistentDataPath + "/gamesave.save"))
        {


            // 2
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/gamesave.save", FileMode.Open);
            Save save = (Save)bf.Deserialize(file);
            file.Close();



            // 4
            Name.text = "Name: " + save.saveName;
            pointsText.text = "Pointss: " + save.savePoints;
            Name = save.saveName;
            points = save.savePoints;

            Debug.Log("Game Loaded");
        }
        else
        {
            Debug.Log("No game saved!");
        }
    }



    public void SaveAsJSON()
    {
        Save save = CreateSaveGameObject();
        string json = JsonUtility.ToJson(save);

        Debug.Log("Saving as JSON: " + json);
    }




}
