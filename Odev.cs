using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Odev : MonoBehaviour
{
    void Start()
    {
        int value1 = -12;
        int value2 = 34;

        int secim = 3;

        if (secim == 1)
        {
            AllValue(value1, value2);
        }
        else if (secim == 2)
        {
            ýkýyebolum(value1, value2);
        }
        else if (secim == 3)
        {
            ucebolum(value1, value2);
        }
        else if (secim == 4)
        {
            dordebolum(value1, value2);
        }
        else if (secim == 5)
        {
            besebolum(value1, value2);
        }

    }

    void AllValue(int value1, int value2)
    {
        for (int i = value1; i <= value2; i++)
        {
            print(i);
        }
    }

    void ýkýyebolum(int value1, int value2)
    {
        for (int i = value1; i <= value2; i++)
        {
            if (i % 2 == 0)
            {
                print(i);
            }
        }
    }
    void ucebolum(int value1, int value2)
    {
        for (int i = value1; i <= value2; i++)
        {
            if (i % 3 == 0)
            {
                print(i);
            }
        }
    }
    void dordebolum(int value1, int value2)
    {
        for (int i = value1; i <= value2; i++)
        {
            if (i % 4 == 0)
            {
                print(i);
            }
        }
    }
    void besebolum(int value1, int value2)
    {
        for (int i = value1; i <= value2; i++)
        {
            if (i % 5 == 0)
            {
                print(i);
            }
        }
    }
}
