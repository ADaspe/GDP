using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class ParticleBehavior : MonoBehaviour
{

    public bool isEmitter; //is this object the emitter or the emitted ?
    public GameObject particles;
    public float lifetime = 0.6f;
    // Start is called before the first frame update
    void Start()
    {
        if (!isEmitter)
        {
            GameObject.Destroy(gameObject, lifetime);
        }
    }

   
    public void Burst()
    {
        Instantiate(particles, transform.position, quaternion.identity);
    }
}
