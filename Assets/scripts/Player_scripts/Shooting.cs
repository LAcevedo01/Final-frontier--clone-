using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    
    public Transform gun;
    public Vector2 direction;
    public GameObject Bullet;
    public float bulletSpeed;
    public Transform shootPoint;
    public float fireRate;
    float readyShot;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        direction = mousePos - (Vector2)gun.position;
        Facemouse();

        if (Input.GetMouseButton(0))
        {
            if (Time.time > readyShot)
            {
                readyShot = Time.time + 1 / fireRate;
                shoot();
            }

        }


    }

    void Facemouse()
    {
        gun.right = direction;
    }

    void shoot()
    {
        GameObject BulletIns = Instantiate(Bullet, shootPoint.position, shootPoint.rotation);
        BulletIns.GetComponent<Rigidbody2D>().AddForce(BulletIns.transform.right * bulletSpeed);
        Destroy(BulletIns, 1);
    }

    
}