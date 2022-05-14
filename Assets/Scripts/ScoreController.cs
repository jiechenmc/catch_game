using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ScoreController : MonoBehaviour
{
    public Text scoreText;
    private int score;

    void Start()
    {
    }

    void Update()
    {
        scoreText.text = score.ToString();

    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Bomb")
        {
            Destroy(target.gameObject);
            Destroy(gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    private void OnTriggerExit2D(Collider2D target)
    {
        if (target.tag == "Coin")
        {
            Destroy(target.gameObject);
            score++;
        }

    }
}
