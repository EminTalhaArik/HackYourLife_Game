using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diken : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Player>().health -= 100f;
        }
    }
}
