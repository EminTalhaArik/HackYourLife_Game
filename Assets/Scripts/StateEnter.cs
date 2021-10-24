using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateEnter : MonoBehaviour
{
    public bool isHomeState;
    public bool isPacmanState;
    public bool isMarioState;
    public bool isMinecraftState;
    public bool isEndState;

    public int activeStateCount;

    private void FixedUpdate()
    {
        if (isPacmanState)
        {
            activeStateCount = 0;
        }
        else if (isMarioState)
        {
            activeStateCount = 1;
        }
        else if(isMinecraftState)
        {
            activeStateCount = 2;
        }
        else if (isHomeState)
        {
            activeStateCount = 3;
        }
        else
        {
            activeStateCount = 4;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameObject.FindGameObjectWithTag("GameManager").GetComponent<StateManager>().stateNumber = activeStateCount;
        }
    }
}
