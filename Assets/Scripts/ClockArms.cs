using System;
using UnityEngine;

public class ClockArms : MonoBehaviour
{
    [SerializeField]
    Transform hoursPivot, minsPivot, secsPivot;

    const float hoursToDeg = 30, minsToDeg = 6, secsToDeg = 6;

    // Update is called once per frame
    void Update()
    {
        var now = DateTime.Now.TimeOfDay;
        hoursPivot.localRotation = Quaternion.Euler(hoursToDeg * (float)now.TotalHours, 0, 0);
        minsPivot.localRotation = Quaternion.Euler(minsToDeg * (float)now.TotalMinutes, 0, 0);
        secsPivot.localRotation = Quaternion.Euler(secsToDeg * (float)now.TotalSeconds, 0, 0);
    }
}
