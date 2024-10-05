using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teste : MonoBehaviour
{
   //Teste da Lista
    void Start()
    {
        MyList<int> myList = new MyList<int>(); //Pega a lista e seus elementos
        myList.InsertFirst(1);
        myList.InsertFirst(13);
        myList.InsertFirst(28);
        myList.InsertFirst(59);

        Debug.Log("Lista original"); //Imprime a lista no consoler
        for (int i = 0; i < myList.GetCount(); i++) //Imprime os valores um por um 
        {
            Debug.Log("Index: " + i + " - Valor: " + myList[i]);
        }
        Debug.Log("\n"); //Quebra de linha
        Debug.Log("Lista alterada"); //Nova lista
        myList.RemoveAt(myList.GetCount() - 1); //Remove o último elemento da lista original
        myList[2] = 82; //Novo valor da lista

        for (int i = 0; i < myList.GetCount(); i++) //Imprime os novos valores da lista
        {
            Debug.Log("Index: " + i + " Valor: " + myList[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
