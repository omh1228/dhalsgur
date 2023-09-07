using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericContainer<T>
{
    private T[] items;
    private int currentlndex = 0;


    public GenericContainer(int capccity)
    {
        items = new T[capccity];
    }

    public void Add(T item)
    {
        if (currentlndex < items.Length)
        {
            items[currentlndex] = item;
            currentlndex++;
        }
    }

    public T[] GetItems()
    {
        return items;
    }
}
