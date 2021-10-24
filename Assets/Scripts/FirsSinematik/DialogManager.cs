using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{
    public int activeCount = 0;
    public Dialog[] dialogs;

    public GameObject image;
    public GameObject text;

    private float cooldown = 1f;

    public GameObject animatorObject;

    public bool isEnd;

    private void Start()
    {
        DialogControl();
        print(dialogs.Length);
    }

    private void Update()
    {
        cooldown -= Time.deltaTime;
        if(Input.GetKeyDown(KeyCode.Space) && cooldown <= 0)
        {
            animatorObject.GetComponent<Animator>().SetTrigger("isOkey");
            activeCount++;
            DialogControl();
            cooldown = 1f;
        }
    }

    private void DialogControl()
    {
        if(activeCount < dialogs.Length)
        {
            image.GetComponent<Image>().sprite = dialogs[activeCount].dialogSprite;
            text.GetComponent<Text>().text = dialogs[activeCount].description;
        }
        else
        {
            if (isEnd)
            {
                SceneManager.LoadScene("MainMenu");
            }
            else
            {
                SceneManager.LoadScene("TutorialScene");
            }
        }
    }
}
