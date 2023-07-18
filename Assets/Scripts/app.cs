using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class app : MonoBehaviour
{
    [SerializeField] int value1, value2;
    List<int> allValues = new List<int>();
    List<int> divisibleByTwo = new List<int>();
    List<int> divisibleByThree = new List<int>();
    List<int> divisibleByFour = new List<int>();
    List<int> divisibleByFive = new List<int>();

    private void Start()
    {
        for (int i = value1; i <= value2; i++)
        {
            allValues.Add(i);
            if (i % 2 == 0)
                divisibleByTwo.Add(i);
            if (i % 3 == 0)
                divisibleByThree.Add(i);
            if (i % 4 == 0)
                divisibleByFour.Add(i);
            if (i % 5 == 0)
                divisibleByFive.Add(i);
        }

        writer(allValues, "All values: ");
        writer(divisibleByTwo, "Divisible By two");
        writer(divisibleByThree, "Divisible by three");
        writer(divisibleByFour, "Divisible by four");
        writer(divisibleByFive, "Divisible by five");
    }

    void writer(List<int> list, string condition)
    {
        print(condition);
        foreach (var item in list)
        {
            print(item);
        }
    }
}