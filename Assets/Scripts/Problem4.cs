using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Problem4 : MonoBehaviour
{
    public Rigidbody2D Circle;
private void Update()
    {
        float move = Input.GetAxis("Horizontal");
        float move2 = Input.GetAxis("Vertical");
        Circle.velocity = new Vector2(move * Time.deltaTime * 2000, move2 * Time.deltaTime * 2000);

    }
}
