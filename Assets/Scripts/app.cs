using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class app : MonoBehaviour
{
    [SerializeField] int value1, value2;
    string allValues = " T�m De�erler: ";
    string divisibleByTwo = " �kiye Tam B�l�nenler: ";
    string divisibleByThree = " ��e Tam B�l�nenler: ";
    string divisibleByFour = " D�rde Tam B�l�nenler: ";
    string divisibleByFive = " Be�e Tam B�l�nenler: ";

    private void Start()
    {
        for (int i = value1; i <= value2; i++)
        {
            allValues += " -" + i.ToString();
            if (i % 2 == 0)
                divisibleByTwo += " -" + i.ToString();
            if (i % 3 == 0)
                divisibleByThree += " -" + i.ToString();
            if (i % 4 == 0)
                divisibleByFour += " -" + i.ToString();
            if (i % 5 == 0)
                divisibleByFive += " -" + i.ToString();
        }
        print(allValues);
        print(divisibleByTwo);
        print(divisibleByThree);
        print(divisibleByFour);
        print(divisibleByFive);
    }
}