using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Problem2 : MonoBehaviour
{
    public int Yforce = 1;
    public int Xforce = 1;
    public Rigidbody2D Circle;
    void Start()
    {
        float rand = Random.Range(0, 2);
        if (rand == 1)
        {
            Yforce *= -1;
        }
        else
        {
            Yforce *= 1;
        }
        float rand2 = Random.Range(0, 2);
        if (rand2 == 1)
        {
            Xforce *= -1;
        }
        else
        {
            Xforce *= 1;
        }
        Circle.AddForce(new Vector2(Xforce * 100, Yforce * 100));
    }
}
