using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Uimanager : MonoBehaviour
{
    int randomNum;

    public InputField input;
    public Text text;

    private void Start()
    {
        randomNum = UnityEngine.Random.Range(0, 101);

        Debug.Log(randomNum);
    }

    public void OnTrue()
    {
       
        if (Convert.ToInt32(input.text) > randomNum)
        {
            text.text = "¬веденое число больше заданного!";
        }
        if (Convert.ToInt32(input.text) < randomNum)
        {
            text.text = "¬веденое число меньше заданного!";
        }
        if (Convert.ToInt32(input.text) == randomNum)       
        {
            text.text = "ѕоздравл€ю, вы угадали число!";
        }
    }
}
