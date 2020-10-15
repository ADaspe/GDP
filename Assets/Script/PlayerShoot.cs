using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    bool isShooting;
    public GameObject projectile;
    public GameObject projectileOrigin;
    public float shootDelay;
    private void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space"))
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
        Instantiate(projectile, projectileOrigin.transform.position, quaternion.identity);
        yield return new WaitForSeconds(shootDelay);
        isShooting = false;
    }
}
