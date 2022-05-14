using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D myBody;

    // speed should be 3
    // xBound should be 8
    public float speed, xBound;

    void Start()
    {
        transform.position = new Vector2(0, -4.137239f);
        myBody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");

        if (h > 0)
            myBody.velocity = Vector2.right * speed;
        else if (h < 0)
            myBody.velocity = Vector2.left * speed;
        else
            myBody.velocity = Vector2.zero;
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -xBound, xBound), transform.position.y);
    }
}
