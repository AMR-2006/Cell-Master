using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class GenGenerate : MonoBehaviour
{

    public GameObject[] text;
    public int[] digit;
    public void DigitChange(int number)
    {
        if (digit[number-1] == 10)
        {
            digit[number-1] = 0;
            text[number-1].GetComponent<Text>().text = digit[number-1].ToString();
            Debug.Log(number-1);
            return;
        }

        if (digit[number-1] < 10)
        {
            digit[number-1]++;
            text[number-1].GetComponent<Text>().text = digit[number-1].ToString();
            Debug.Log(number-1);
            return;
        }
    }

    public void AutoGenerate()
    {
        int i = 0;
        while (i < 5)
        {
            digit[i] = Random.Range(0, 9);
            print(i);
            i++;
        }

        i = 0;
        while (i < 5)
        {
            text[i].GetComponent<Text>().text = digit[i].ToString();
            print(i);
            i++;
        }
    }

    public void ApplyGen()
    {

        GameVars.EnemySpawnTime = digit[4]+1;
        if (digit[0] != 0)
        {
            if (digit[1] != 0)
            {
                int multiplier = Random.Range(0, digit[2]);
                if (multiplier != 0)
                {
                    GameVars.MaxHealth = digit[0] * digit[1] * digit[2] + digit[3];
                }
                else
                {
                    GameVars.MaxHealth = digit[0] * digit[1] + digit[3];
                }
            }
            else
            {
                int multiplier = Random.Range(0, digit[2]) + digit[3];
                if (multiplier != 0)
                {
                    GameVars.MaxHealth = digit[0] * digit[1] * digit[2] + digit[3];
                }
                else
                {
                    GameVars.MaxHealth = digit[0] + digit[3];
                }
            }
        }
        else
        {
            if (digit[1] != 0)
            {
                int multiplier = Random.Range(0, digit[2]) + digit[3];
                if (multiplier != 0)
                {
                    GameVars.MaxHealth = digit[1] * digit[2] + digit[3];
                }
                else
                {
                    GameVars.MaxHealth = digit[1] + digit[3];
                }
            }
            else
            {
                int multiplier = Random.Range(0, digit[2]) + digit[3];
                if (multiplier != 0)
                {
                    GameVars.MaxHealth = digit[0] * digit[2] + digit[3];
                }
                else
                {
                    GameVars.MaxHealth = digit[0] + digit[3];
                }
            }
        }
    }
}
