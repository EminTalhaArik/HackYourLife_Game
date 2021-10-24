using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreeperMinecraft : MonoBehaviour
{
    private GameObject player;
    public bool isOkey = true;

    private bool isFight = false;
    private float fightCooldown = 1f;

    public bool isInState = false;

    public float enemySpeed = 0.2f;
    private Animator myAnimator;

    public GameObject particleEffect;

    private float health = 3;

    public AudioClip creeperSound;

    private void Start()
    {
        myAnimator = GetComponent<Animator>();
        isOkey = true;
        isFight = false;
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void FixedUpdate()
    {
        isInState = GameObject.FindGameObjectWithTag("GameManager").GetComponent<StateManager>().isInIslandMinecraft;

        if (isFight)
        {
            fightCooldown -= Time.fixedDeltaTime;
            if (fightCooldown <= 0)
            {
                myAnimator.SetTrigger("isDestroy");
                GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().health -= 20f;
                fightCooldown = 5f;
            }
        }

        if (Vector2.Distance(this.transform.position, player.transform.position) < 20 && isInState && isOkey)
        {
            transform.position = new Vector2(Mathf.Lerp(this.transform.position.x, player.transform.position.x, enemySpeed * Time.fixedDeltaTime), this.transform.position.y);

            if (transform.position.x < player.transform.position.x)
            {
                transform.rotation = Quaternion.Euler(0, 0, 0);
            }
            else
            {
                transform.rotation = Quaternion.Euler(0, 180, 0);
            }
        }
    }

    public void Damage()
    {
        health--;
        HealthControl();
    }

    private void HealthControl()
    {
        if (health <= 0)
        {
            destroyObject();
        }
    }

    public void destroyObject()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<AudioSource>().PlayOneShot(creeperSound);
        Instantiate(particleEffect, this.transform.position, Quaternion.identity);

        if (isFight)
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().health -= 40f;
        } 

        Destroy(this.gameObject);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isFight = true;
            isOkey = false;
        }
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isFight = false;
            isOkey = true;
        }
    }
}
