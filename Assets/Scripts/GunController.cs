using UnityEngine;
using System.Collections;
[RequireComponent(typeof(AudioSource))]
public class GunController : MonoBehaviour
{

    public AudioSource audio;
    public bool isFiring;

    public BulletController bullet;
    public float bulletSpeed;

    public float timeBetweenShots;
    private float shotCounter;

    public Transform firePoint;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isFiring || (Input.GetKey(KeyCode.JoystickButton7)))
        {
            shotCounter -= Time.deltaTime;
            if (shotCounter <= 0)
            {
                shotCounter = timeBetweenShots;
                BulletController newBullet = Instantiate(bullet, firePoint.position, firePoint.rotation) as BulletController;
                newBullet.speed = bulletSpeed;
                audio.Play();
            }
        }
        else
        {
            shotCounter = 0;
        }
    }
}
