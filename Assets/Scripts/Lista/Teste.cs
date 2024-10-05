using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teste : MonoBehaviour
{
   //Teste da Lista
    void Start()
    {
        MyList<int> myList = new MyList<int>(); 
        myList.InsertFirst(1);
        myList.InsertFirst(13);
        myList.InsertFirst(28);
        myList.InsertFirst(59);

        Debug.Log("Lista original");
        for (int i = 0; i < myList.GetCount(); i++)
        {
            Debug.Log("Index: " + i + " Valor: " + myList[i]);
        }
        Debug.Log("\n");
        Debug.Log("Lista alterada");
        myList.RemoveAt(myList.GetCount() - 1);
        myList[2] = 82;

        for (int i = 0; i < myList.GetCount(); i++)
        {
            Debug.Log("Index: " + i + " Valor: " + myList[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
