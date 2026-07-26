using System;
using UnityEngine;

public class Clock : MonoBehaviour
{
    const float hoursToDegrees = -30f;
    const float minsToDegrees = -6f;
    const float secsToDegrees = -6f;


    [SerializeField]
    Transform hoursPivot, minPivot, secPivot;

    void Update()
    {
        TimeSpan time = DateTime.Now.TimeOfDay;
        hoursPivot.localRotation = Quaternion.Euler(0f, 0f, hoursToDegrees * (float)time.TotalHours);
        minPivot.localRotation = Quaternion.Euler(0f, 0f, minsToDegrees * (float)time.TotalMinutes);
        secPivot.localRotation = Quaternion.Euler(0f, 0f, secsToDegrees * (float)time.TotalSeconds);
    }
}
