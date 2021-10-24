using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class at0m : MonoBehaviour
{
    public GameObject atomPlace;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            atomPlace.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            atomPlace.SetActive(false);
        }
    }
}
