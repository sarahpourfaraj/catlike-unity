using UnityEngine;
using TMPro;
using System;

public class DigitalClock : MonoBehaviour
{
    [SerializeField] TMP_Text timeText; bool showSeconds = true; bool is24HourFormat = true;
    void Update()
    {
        string format;

        if (is24HourFormat)
        {
            format = showSeconds ? "HH:mm:ss" : "HH:mm";
        }
        else
        {
            format = showSeconds ? "hh:mm:ss tt" : "hh:mm tt";
        }

        timeText.text = DateTime.Now.ToString(format);
    }
    public void SetShowSeconds(bool value)
    {
        showSeconds = value;
    }
    public void SetTimeFormat(bool is24Hour)
{
    is24HourFormat = is24Hour;
}
}