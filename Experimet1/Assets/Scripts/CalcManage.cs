using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class CalcManage : MonoBehaviour
{
    public InputField input_1;
    public InputField input_2;

    public Text resultText;

    int result;

    int num_1, num_2;


    public void Sum()
    {
        num_1 = Convert.ToInt32(input_1.text);

        num_2 = Convert.ToInt32(input_2.text);

        result = num_1 + num_2;

        Debug.Log(result);

        resultText.text = (result).ToString();
    }

    public void Dif()
    {
        num_1 = Convert.ToInt32(input_1.text);

        num_2 = Convert.ToInt32(input_2.text);

        result = num_1 - num_2;

        Debug.Log(result);

        resultText.text = (result).ToString();
    }


    public void Divide()
    {
        num_1 = Convert.ToInt32(input_1.text);

        num_2 = Convert.ToInt32(input_2.text);

        result = num_1 / num_2;

        Debug.Log(result);

        resultText.text = (result).ToString();
    }


    public void Multiply()
    {
        num_1 = Convert.ToInt32(input_1.text);

        num_2 = Convert.ToInt32(input_2.text);

        result = num_1 * num_2;

        Debug.Log(result);

        resultText.text = (result).ToString();
    }    


}
