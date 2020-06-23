using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ScoreScript : MonoBehaviour
{

    private GUIStyle guiStyle = new GUIStyle();
    public static int totalScoreINT = 0;

    private void OnGUI()
    {
        int TextWidth = 45;
        string totalScoreString = totalScoreINT.ToString();
        GUI.contentColor = Color.black;
        guiStyle.fontSize = 20;
        GUI.Label(new Rect(22, 10, TextWidth, Screen.width - TextWidth), "Score: ", guiStyle);
        GUI.Label(new Rect(80, 10, TextWidth, Screen.width - TextWidth), totalScoreString, guiStyle);
    }
}
