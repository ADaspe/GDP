using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShortcutManagement;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    private bool isShooting;
    public GameObject bullet;
    public GameObject fireZone;
    // Start is called before the first frame update
    void Start()
    {
        isShooting = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isShooting)
        {
            isShooting = true;
            StartCoroutine("ShootBurst");
        }
    }

    IEnumerator ShootBurst()
    {

        Shoot();
        yield return new WaitForSeconds(0.3f);
        Shoot();
        yield return new WaitForSeconds(0.3f);
        Shoot();
        yield return new WaitForSeconds(1.5f);
        isShooting = false;
    }

    public void Shoot()
    {
        Instantiate(bullet, fireZone.transform.position, new Quaternion());
    }
}
