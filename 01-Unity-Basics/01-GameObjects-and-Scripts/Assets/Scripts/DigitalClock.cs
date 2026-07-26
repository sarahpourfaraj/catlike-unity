using UnityEngine;
using TMPro;
using System;

public class DigitalClock : MonoBehaviour
{
    [SerializeField]
    TMP_Text timeText;
    void Update()
    {
        timeText.text = DateTime.Now.ToString("HH:mm:ss");
    }
}