using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    public float speed;
    private Vector2 move;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        move = new Vector2(0, 0);
        if (Input.GetKey("z"))
        {
            move += new Vector2(0, 1*Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            move += new Vector2(0, -1*Time.deltaTime);
        }
        if (Input.GetKey("q")){
            move += new Vector2(-1*Time.deltaTime, 0);
        }
        if (Input.GetKey("d"))
        {
            move += new Vector2(1*Time.deltaTime, 0);
        }
        Move(move);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("ça marche ?");
    }
    public void Move(Vector2 dir)
    {
        rb.AddForce(speed * dir);
    }
}
