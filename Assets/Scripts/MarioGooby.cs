using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarioGooby : MonoBehaviour
{
    public float speed = 1f;

    public GameObject pos1;
    public GameObject pos2;

    private GameObject nextPos;
    public AudioClip goobySound;

    private void Start()
    {
        nextPos = pos1;
    }

    private void FixedUpdate()
    {
        if(transform.position == pos1.transform.position)
        {
            nextPos = pos2;
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else if(transform.position == pos2.transform.position)
        {
            nextPos = pos1;
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }

        transform.position = Vector2.MoveTowards(transform.position, nextPos.transform.position, speed * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().isBig)
            {
                GameObject.FindGameObjectWithTag("Player").GetComponent<AudioSource>().PlayOneShot(goobySound);
                Destroy(this.gameObject);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (!collision.gameObject.GetComponent<Player>().isBig)
            {
                collision.gameObject.GetComponent<Player>().health -= 50f;
            }
        }
    }
}
