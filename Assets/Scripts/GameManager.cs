using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject codeArea;
    public GameObject[] computers;

    public int activeComputerId;

   public void codeEnd(string text)
    {
        if(text == computers[activeComputerId].GetComponent<ComputerManager>().hackCode)
        {
            print("Bu canavar çalýþýyorrrr.");
            computers[activeComputerId].GetComponent<ComputerManager>().hackCodeIsSucces();
            codeArea.GetComponent<InputField>().text = " ";
        }
    }
}
