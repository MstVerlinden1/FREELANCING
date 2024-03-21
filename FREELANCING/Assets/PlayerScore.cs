using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    public delegate void UpdateScore(int score);
    public static UpdateScore UpdateScoreUI;

    private int score;
    private List<int> scores = new List<int>();
    private void OnEnable()
    {
        Target.ApplyScore += AddScore;
    }
    private void OnDisable()
    {
        Target.ApplyScore -= AddScore;
    }
    private void AddScore()
    {
        score += 1;
        if (UpdateScoreUI != null)
        {
            UpdateScoreUI(Score);
        }
    }
    public int Score
    {
        get
        {
            return score;
        }
    }
}
