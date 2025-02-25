using UnityEngine;
using TMPro;
namespace Scenes.GameScene
{
    public class GameManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float timeRemaining = 60f;
    public bool timeIsRunning = true;
    public TMP_Text timeText;
    public static GameManager Instance;

    void Start()
    {
        UpdateTimeDisplay(timeRemaining);
        UpdateScoreUI();
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

        public int count = 0;
        public TextMeshProUGUI scoreText;

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }

    
        public void AddScore(int value)
        {
            count += value;
            UpdateScoreUI();
        }

        private void UpdateScoreUI()
        {
            if (scoreText != null)
            {
                scoreText.text = "SCORE : " + count;
            }
            else
            {
                Debug.LogWarning("Score Text is not assigned in TrashJudgeManager!");
            }
}
}
}



