using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Save
{
    public List<int> livingTargetPositions = new List<int>();
    public List<int> livingTargetsTypes = new List<int>();

    public Text saveName;
    public int savePoints = 0;


}
