using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RecordScore : MonoBehaviour
{
    public TextMeshProUGUI recordText;
    public TextMeshProUGUI scoreText;
    public void RecordAndScore()
    {
        int lastScore = PlayerPrefs.GetInt("LastScore");
        int recordScore = PlayerPrefs.GetInt("RecordScore");

        if (lastScore > recordScore)
        {
            recordScore = lastScore;
            PlayerPrefs.SetInt("RecordScore", recordScore);
            recordText.text = recordScore.ToString();
            scoreText.text = lastScore.ToString();
        }
        else
        {
            scoreText.text = lastScore.ToString();
            recordText.text = recordScore.ToString();
        }
    }
    public void RecordOnly()
    {
        int recordScore = PlayerPrefs.GetInt("RecordScore");
        recordText.text = recordScore.ToString();
    }
}
