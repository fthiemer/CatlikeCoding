using System;
using UnityEngine;

public class Clock : MonoBehaviour
{
    private float degreesPerHour = -30f, degreesPerMinute = -6f, degreesPerSeconds = -6f;

    [SerializeField] Transform hoursPivot, minutesPivot, secondsPivot;

    public void FixedUpdate()
    {
        var time = DateTime.Now.TimeOfDay;
        hoursPivot.localRotation = Quaternion.Euler(0f, 0f, degreesPerHour * (float) time.TotalHours);
        minutesPivot.localRotation = Quaternion.Euler(0f, 0f, degreesPerMinute * (float) time.TotalMinutes);
        secondsPivot.localRotation = Quaternion.Euler(0f, 0f, degreesPerSeconds * (float) time.TotalSeconds);
    }
}
