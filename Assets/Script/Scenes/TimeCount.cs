using System.Collections;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public float timeRemaining = 60f;
    public bool timeIsRunning = true;
    public TMP_Text timeText;

    void Start()
    {
        UpdateTimeDisplay(timeRemaining);
    }

    void Update()
    {
        if (timeIsRunning && timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            if (timeRemaining <= 0)
            {
                timeRemaining = 0;
                timeIsRunning = false;
                TimerEnded();
            }
            UpdateTimeDisplay(timeRemaining);
        }
    }

    void UpdateTimeDisplay(float timeToDisplay)
    {
        int minutes = Mathf.FloorToInt(timeToDisplay / 60);
        int seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    void TimerEnded()
    {
        Debug.Log("Timer has ended!");
        // Add any additional logic for when the timer reaches zero.
    }
}