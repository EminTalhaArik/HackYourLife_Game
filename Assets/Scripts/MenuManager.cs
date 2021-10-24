using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject panelObject;

    private void Start()
    {
        Time.timeScale = 1f;
        panelObject.SetActive(false);
    }

    public void FÝnishGame()
    {
        Time.timeScale = 0f;
        panelObject.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
