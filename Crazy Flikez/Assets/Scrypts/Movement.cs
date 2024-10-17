using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float Speed = 1f;
    private Rigidbody2D rb;
    public Animator anim;
    public Vector2 moveVector;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        Walk();
        Reflect();
    }

    void Walk()
    {
        moveVector.x = Input.GetAxis("Horizontal");
        moveVector.y = Input.GetAxis("Vertical");
        anim.SetFloat("SpeedX", Mathf.Abs(moveVector.x));
        anim.SetFloat("SpeedY", Mathf.Abs(moveVector.y));
        rb.velocity = new Vector2(Speed * moveVector.x, Speed * moveVector.y);
    }

    static public bool faceRight;

    void Reflect()
    {
        if((moveVector.x < 0 && !faceRight) || (moveVector.x > 0 && faceRight))
        {
            transform.localScale *= new Vector2(-1, 1);
            faceRight = !faceRight;
        }
    }

}
