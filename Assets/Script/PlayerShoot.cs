using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    bool isShooting;
    public GameObject projectile;
    public Transform projectileOrigin;
    float shootDelay;
    private void Start()
    {
        projectileOrigin = GetComponentInChildren<Transform>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("Space"))
        {
            if(!isShooting)
            {
                isShooting = true;
                StartCoroutine("Shoot");
            }
        }
    }

    public IEnumerator Shoot()
    {
        Instantiate(projectile, transform.position, quaternion.identity);
        yield return new WaitForSeconds(shootDelay);
        isShooting = false;
    }
}
