using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    private GameObject player;
    public bool isInState = false;

    public float enemySpeed = 0.2f;

    public bool isPacman;

    private bool isOkey = false;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void FixedUpdate()
    {

        isInState = GameObject.FindGameObjectWithTag("GameManager").GetComponent<StateManager>().isInIslandPacman;
        isOkey = true;
        
       
        if(Vector2.Distance(this.transform.position,player.transform.position) < 50 && isInState && isOkey)
        {
            transform.position = Vector2.Lerp(this.transform.position, player.transform.position, enemySpeed * Time.fixedDeltaTime);

            if(transform.position.x < player.transform.position.x)
            {
                transform.rotation = Quaternion.Euler(0, 180, 0);
            }
            else
            {
                transform.rotation = Quaternion.Euler(0, 0, 0);
            }
        }
    }
}
