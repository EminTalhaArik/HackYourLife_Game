using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyGun : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletPos;
    public float bulletForce;
    private float cooldown = 0.2f;

    public AudioClip shotSound;

    private void Update()
    {
        cooldown -= Time.deltaTime;
        if (Input.GetMouseButtonDown(0) && cooldown <= 0)
        {
            GameObject spawnObject = Instantiate(bulletPrefab, bulletPos.position, Quaternion.identity);
            GameObject.FindGameObjectWithTag("Player").GetComponent<AudioSource>().PlayOneShot(shotSound);
            spawnObject.GetComponent<Rigidbody2D>().AddForce(transform.right * -1 * bulletForce);
            cooldown = 0.2f;
        }
    }
}
