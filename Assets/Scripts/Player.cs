using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private Vector3 initialVelocity;
    [SerializeField]
    private Vector3 lastFrameVelocity;
    private Rigidbody2D rb;

    void Start()
    {
        
    }

    private void OnEnable()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = initialVelocity;
    }

    public Rigidbody2D RB;
    public float Speed = 5;
    void Update()
    {
        lastFrameVelocity = rb.velocity;
        Vector2 vel = new Vector2(0, 0);

        if (Input.GetKey(KeyCode.RightArrow))
        {
            vel.x = Speed;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            vel.x = -Speed;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            vel.y = Speed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            vel.y = -Speed;
        }
        RB.velocity = vel;

    }
}
