using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFallow : MonoBehaviour
{

    private GameObject player;

    public float maxX;
    public float maxY;
    public float minX;
    public float minY;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(player.transform.position.x, minX, maxX), Mathf.Clamp(player.transform.position.y, minY, maxY), transform.position.z);
    }
}
