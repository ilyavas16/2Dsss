using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bullet;

    void Update()
    {
        if (Input.GetButtonDown("Fire1")) // fire1 это обозначение юнити для лкм
        {
            Shoot();
        }    
    }

    void Shoot()
    {
        Instantiate(bullet, firePoint.position, firePoint.rotation); // что будет вылетать, откуда, 
    }                                                                // какое вращение или направление
}
