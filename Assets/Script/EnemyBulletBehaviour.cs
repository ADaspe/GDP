using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletBehaviour : MonoBehaviour
{
    public float lifeTime;
    private float timeToDestroy;
    public float speed;
    public Rigidbody2D rb;

    private void Start()
    {
        timeToDestroy = Time.time + lifeTime;
    }
    void Update()
    {
        rb.velocity = Vector2.left * speed * Time.deltaTime;
        if(Time.time >= timeToDestroy)
        {
            Destroy(this);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Coucou");

        Debug.Log("Layer : "+ (collision.gameObject.layer == LayerMask.NameToLayer("Player")));
        if (collision.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            collision.gameObject.GetComponent<PlayerLifeHandler>().LoseLife();
            Destroy(gameObject);
        }
        else if (collision.gameObject.layer == LayerMask.NameToLayer("Wall"))
        {
            Destroy(gameObject);
        }
    }
}
