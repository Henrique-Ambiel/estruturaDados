using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dataTest : MonoBehaviour
{
    void Start()
    {
        Pilha pilha = new Pilha(10);
        pilha.Push(1);

        //Debug.Log(Pilha.array[0]);

        /*int i = 0;

        int index;

        Pilha pilha = new Pilha(i); */
    }
}