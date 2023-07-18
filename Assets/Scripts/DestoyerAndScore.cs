using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class DestoyerAndScore : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] private AudioSource EnemyDestroy;
    private int score = 0;
    private void Update()
    {
        PlayerPrefs.SetInt("LastScore", score);
        scoreText.text = score.ToString();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            Destroy(collision.gameObject);
            EnemyDestroy.Play();
            score++;
        }
    }
}
