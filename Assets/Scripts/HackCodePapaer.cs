using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HackCodePapaer : MonoBehaviour
{
    public GameObject KeyCodeButton;
    public GameObject hackCodePaper;

    public GameObject CodeText;
    public GameObject HeaderText;

    public string header;
    public string code;

    private bool isOkey = false;

    public bool isTutorial = false;

    private void Start()
    {
        KeyCodeButton.SetActive(false);
    }

    private void Update()
    {
        if (isOkey)
        {
            KeyCodeButton.SetActive(true);

            if (Input.GetKeyDown(KeyCode.E))
            {
                hackCodePaper.SetActive(true);
                CodeText.GetComponent<Text>().text = code;
                HeaderText.GetComponent<Text>().text = header;
            }
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isOkey = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isOkey = false;
            KeyCodeButton.SetActive(false);
            if (!isTutorial)
            {
                hackCodePaper.SetActive(false);
            }
        }
    }
}
