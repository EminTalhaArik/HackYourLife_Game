using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pacman : MonoBehaviour
{
    public float defaultCooldown = 5f;
    private float cooldown;
    private bool isOkey = false;

    private void Start()
    {
        cooldown = defaultCooldown;
    }

    private void FixedUpdate()
    {
        if (isOkey)
        {

            cooldown -= Time.deltaTime;
            if (cooldown <= 0)
            {
                print("Yakalandýn");
            }
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isOkey = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isOkey = false;
        }
    }

}
