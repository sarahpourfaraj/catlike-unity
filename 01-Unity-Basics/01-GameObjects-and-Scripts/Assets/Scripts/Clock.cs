using System;
using UnityEngine;

public class Clock : MonoBehaviour
{
    const float hoursToDegrees = -30f;
    const float minsToDegrees = -6f;
    const float secsToDegrees = -6f;


    [SerializeField]
    Transform hoursPivot, minPivot, secPivot;

    void Awake()
    {
        var time = DateTime.Now;
        hoursPivot.localRotation = Quaternion.Euler(0f, 0f, hoursToDegrees * time.Hour);
        minPivot.localRotation = Quaternion.Euler(0f, 0f, minsToDegrees * time.Minute);
        secPivot.localRotation = Quaternion.Euler(0f, 0f, secsToDegrees * time.Second);
    }
}
