using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyMantar : MonoBehaviour
{

    private GameObject player;
    private bool isOkey = false;
    public float biggingPartition = 1f;

    public GameObject mantarObject;

    public AudioClip mantarSound;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        mantarObject.SetActive(true);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && mantarObject.activeSelf)
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<AudioSource>().PlayOneShot(mantarSound);
            isOkey = true;
            mantarObject.SetActive(false);
        }
    }

    public void mantarActivite()
    {
        mantarObject.SetActive(true);
    }

    private void FixedUpdate()
    {
        if (isOkey)
        {
            player.transform.localScale = Vector3.Lerp(this.transform.localScale, new Vector3(16f, 16f, 1f), biggingPartition);
            GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().isBig = true;
            GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().isMantar = false;
        }
    }
}
