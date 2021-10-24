using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateExit : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameObject.FindGameObjectWithTag("GameManager").GetComponent<StateManager>().stateNumber = 9;
        }
    }
}
