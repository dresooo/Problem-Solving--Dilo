using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Problem7 : MonoBehaviour
{
    public Text ScoreText;
    private int Score;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Square")
        {
            Destroy(collision.gameObject);
            Score += 1;
        }
    }
    private void Update()
    {
        ScoreText.text = "Score :" + Score.ToString();
    }
}