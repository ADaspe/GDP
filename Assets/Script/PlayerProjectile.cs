using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProjectile : MonoBehaviour
{
    public float speed, damage;
    public LayerMask enemies, environment;
    public Vector2 size;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(speed, 0, 0)*Time.deltaTime, Space.World);

        Collider2D[] hit = Physics2D.OverlapBoxAll(transform.position, size, enemies);
        foreach (Collider2D enemy in hit)
        {
            if (enemy.GetComponent<EnemyDie>())
            {
                enemy.GetComponent<EnemyDie>().Damage(damage);
                GameObject.Destroy(gameObject);
            }
        }
        Collider2D wall = Physics2D.OverlapBox(transform.position, size, environment);
        if (wall)
        {
            GameObject.Destroy(gameObject);
        }
    }
}
