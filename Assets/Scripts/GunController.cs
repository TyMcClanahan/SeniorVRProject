using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject particvleSystemeExtraCredit;
    public Transform muzzlePoint;
    public bool isItLeft = false;
    public float shootForce = 10.0f;
    public float roundsPerMinute = 60.0f;
    private float cooldown;


    public void Start()
    {
        cooldown = 60f / roundsPerMinute;
    }

    public void Update()
    {
        if (isItLeft)
        {
            if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.LTouch) && Time.time >= cooldown)
            {
                Shoot();
                cooldown = Time.time + 1f / (roundsPerMinute / 60.0f);
            }
        }
        if (!isItLeft)
        {
            {
                if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.RTouch) && Time.time >= cooldown)
                {
                    Shoot();
                    cooldown = Time.time + 1f / (roundsPerMinute / 60.0f);
                }
            }
        }

        void Shoot()
        {
            if (bulletPrefab != null && muzzlePoint != null)
            {
                Instantiate(particvleSystemeExtraCredit, muzzlePoint.position, muzzlePoint.rotation);
                GameObject bullet = Instantiate(bulletPrefab, muzzlePoint.position, muzzlePoint.rotation);
                Rigidbody rb = bullet.GetComponent<Rigidbody>();

                if (rb != null)
                {
                    rb.AddForce(muzzlePoint.forward * shootForce, ForceMode.Impulse);
                }
            }
        }
    }
}