using UnityEngine;
using TMPro;
using System;

public class DigitalClock : MonoBehaviour
{
    [SerializeField]
    TMP_Text timeText;
    bool showSeconds = true;
    void Update()
    {
        timeText.text = showSeconds
        ? DateTime.Now.ToString("HH:mm:ss")
        : DateTime.Now.ToString("HH:mm");
    }
    public void SetShowSeconds(bool value)
    {
        showSeconds = value;
    }
}