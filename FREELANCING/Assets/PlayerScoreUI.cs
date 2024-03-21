using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerScoreUI : MonoBehaviour
{
    private void OnEnable()
    {
        PlayerScore.UpdateScoreUI += ChangeText;
    }
    private void OnDisable()
    {
        PlayerScore.UpdateScoreUI -= ChangeText;
    }
    private void ChangeText(int value)
    {
        TextMeshProUGUI text = gameObject.GetComponent<TextMeshProUGUI>();
        text.text = value.ToString();
    }
}
