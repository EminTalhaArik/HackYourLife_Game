using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public AudioClip bulletSound;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("CreeperEnemy"))
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<AudioSource>().PlayOneShot(bulletSound);
            collision.gameObject.GetComponent<CreeperMinecraft>().Damage();
            Destroy(this.gameObject);
        }

        if (collision.gameObject.CompareTag("ZombieEnemy"))
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<AudioSource>().PlayOneShot(bulletSound);
            collision.gameObject.GetComponent<ZombieMinecraft>().Damage();
            Destroy(this.gameObject);
        }

        if (!collision.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject);
        }
    }
}
