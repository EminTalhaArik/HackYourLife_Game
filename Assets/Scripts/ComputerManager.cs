using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ComputerManager : MonoBehaviour
{
    public int computerId;
    public string hackCode;

    public GameObject codePlace;
    public GameObject gameManager;

    public bool isGun = true;
    public bool isMantar = true;
    public bool isTutorial = false;


    private void Start()
    {
        codePlace.SetActive(false);
    }

    public void hackCodeIsSucces()
    {
        if (isGun)
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().isGun = true;
        }
        else if(isMantar)
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().isMantar = true;
        }
        else if (isTutorial)
        {
            SceneManager.LoadScene("GameScene");
        }
        else
        {
            SceneManager.LoadScene("EndSinematic");
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            codePlace.gameObject.SetActive(true);
            gameManager.GetComponent<GameManager>().activeComputerId = computerId;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            codePlace.SetActive(false);
        }
    }
}
