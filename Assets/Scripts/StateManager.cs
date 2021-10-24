using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour
{
    public int stateNumber;
    
    public bool isInIslandPacman;
    public bool isInIslandMario;
    public bool isInIslandMinecraft;

    private void FixedUpdate()
    {
        if(stateNumber == 0)
        {
            isInIslandPacman = true;   
        }
        else
        {
            isInIslandPacman = false;
        }

        if (stateNumber == 1)
        {
            isInIslandMario = true;
        }
        else
        {
            isInIslandMario = false;
        }

        if (stateNumber == 2)
        {
            isInIslandMinecraft = true;
        }
        else
        {
            isInIslandMinecraft = false;
        }

        if(stateNumber == 9)
        {
            isInIslandMario = false;
            isInIslandMinecraft = false;
            isInIslandPacman = false;
        }
    }
}
