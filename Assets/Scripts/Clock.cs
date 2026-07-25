using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    [SerializeField]
    Transform hoursPivot, minPivot, secPivot;

    void Awake()
    {
        hoursPivot.localRotation = Quaternion.Euler(0, 0, -30);
    }
}
