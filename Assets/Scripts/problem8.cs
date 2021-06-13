using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class problem8 : MonoBehaviour
{
    public Text ScoreText;
    private int Score;
    public problem6 BoxSpawner;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Square")
        {
            Destroy(collision.gameObject);
            Score += 1;
            Invoke("Respawn", 3f);
        }
    }
    private void Update()
    {
        ScoreText.text = "Score :" + Score.ToString();
    }
    void Respawn()
    {
        BoxSpawner.totalBox -= 1;
    }
}