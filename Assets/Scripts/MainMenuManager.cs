using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    private bool isBilgiActive = false;

    public GameObject bilgiObject;

    public void ExitGame()
    {
        Application.Quit();
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("FirstSýnematic");
    }

    public void BilgiActive()
    {
        isBilgiActive = !isBilgiActive;
        BilgiControl();
    }

    private void BilgiControl()
    {
        if (isBilgiActive)
        {
            bilgiObject.SetActive(true);
        }
        else
        {
            bilgiObject.SetActive(false);
        }
    }
}
