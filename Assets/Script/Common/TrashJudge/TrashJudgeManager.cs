namespace MyGameNamespace  // Change this to your game's namespace
{
    using UnityEngine;
    using TMPro;

    public class TrashJudgeManager : MonoBehaviour
    {
        public static TrashJudgeManager Instance;
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

        private void Start()
        {
            UpdateScoreUI();
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
