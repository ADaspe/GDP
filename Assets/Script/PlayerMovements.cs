using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.Mathematics;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    private int x, y;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        x = y = 0;
        if (Input.GetKey("z"))
        {
            y = 1;
        }
        if (Input.GetKey("s"))
        {
            y = -1;
        }
        if (Input.GetKey("q")){

            x = -1;
        }
        if (Input.GetKey("d"))
        {
            x = 1;
        }


        Move(new Vector2(x,y));
    }

    public void Move(Vector2 dir)
    {
        rb.velocity=speed * dir * Time.deltaTime;
    }
}
