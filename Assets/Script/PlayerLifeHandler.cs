using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLifeHandler : MonoBehaviour
{

    public float maxHP;
    [SerializeField]
    private float currentHP;
    public bool isDead;
    // Start is called before the first frame update
    void Start()
    {
        currentHP = maxHP;
        isDead = false;
    }

    public void LoseLife(int damage = 10)
    {
        currentHP -= damage;
        if (currentHP <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        isDead = true;
        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<ParticleBehavior>().Burst();
        GameObject.Destroy(gameObject);
    }
}
