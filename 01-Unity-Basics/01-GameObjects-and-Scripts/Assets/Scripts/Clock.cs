using System;
using UnityEngine;

public class Clock : MonoBehaviour
{
    const float hoursToDegrees = -30f;
    const float minsToDegrees = -6f;
    const float secsToDegrees = -6f;

    [SerializeField]
    private Transform hoursPivot, minPivot, secPivot;

    private bool showSeconds = true;

    void Update()
    {
        TimeSpan time = DateTime.Now.TimeOfDay;

        hoursPivot.localRotation =
            Quaternion.Euler(0f, 0f, hoursToDegrees * (float)time.TotalHours);

        minPivot.localRotation =
            Quaternion.Euler(0f, 0f, minsToDegrees * (float)time.TotalMinutes);

        if (showSeconds)
        {
            secPivot.localRotation =
                Quaternion.Euler(0f, 0f, secsToDegrees * (float)time.TotalSeconds);
        }
    }

    public void SetShowSeconds(bool value)
    {
        showSeconds = value;
        secPivot.gameObject.SetActive(value);
    }
}