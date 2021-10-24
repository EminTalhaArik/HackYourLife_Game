using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject gun;
    public GameObject mantar;

    public bool isGun = false;
    public bool isMantar = false;
    public bool isBig = false;

    public float health = 100f;

    public bool isTutotial = false;

    private void Start()
    {
        gun.SetActive(false);
    }

    private void FixedUpdate()
    {
        if (isGun)
        {
            gun.SetActive(true);
            isMantar = false;
            transform.localScale = new Vector3(8, 8, 8);
        }
        else
        {
            gun.SetActive(false);
        }

        if (isMantar)
        {
            mantar.SetActive(true);
            gun.SetActive(false);
            isGun = false;
        }
        else
        {
            mantar.SetActive(false);
        }

        if(health <= 0)
        {
            GameObject.FindGameObjectWithTag("GameManager").GetComponent<MenuManager>().FÝnishGame();
        }

        if (!isTutotial)
        {
            GameObject.FindGameObjectWithTag("HealthBar").GetComponent<HealthBar>().setHealth(health);
        }
    }
}
