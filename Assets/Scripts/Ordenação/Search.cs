using System.Collections;
using System.Collections.Generic;
using UnityEditor.AnimatedValues;
using UnityEngine;

public class Search : MonoBehaviour
{
    //Array a ser ordenado
    private int[] array = null;
    
    void Start()
    {
        //Sortea um número entre 10 e 100 para ser o tamanho do array
        int arrayCount = Random.Range(5, 10);
        array = new int[arrayCount];

        //Imprime no console o tamanho do array
        Debug.Log("Iniciado array de " + arrayCount + " posições.");

        //Itera o array e coloca um número entre 1 e 1000 dentro dele
        for (int i = 0; i < arrayCount; i++)
        {
            array[i] = Random.Range(1, 1000);
        }

        PrintArray(arrayCount);
        BubbleSort();
        Debug.Log("Array Ordenado");
        PrintArray(arrayCount);
    }

    //Método de ordenação do array
    private void BubbleSort()
    {

        bool toStop = true;
        //Decrementa os valores para fazer ordenação
        for (int i = array.Length - 1; i > 0; i--) 
        { 
            for(int j = 0; j < i; j++)
            {
                //Realiza a troca dos valores do array para ordenação
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
            if(toStop) //Se não tiver troca ele interrompe o looping
                break;
        }
    }

    //Método de busca binária
    private int BinarySearch(int value)
    {
        int start = 0;
        int end = array.Length - 1;
        while (start <= end)
        {
            int middle = (start + end) / 2;
            if(value == array[middle]) //Verifica se o índice está no meio do array
                return middle;

            if (value > array[middle])
            {
                start = middle + 1;
            }
            else if(value < array[middle])
            { 
                end = middle - 1;
            }
        }

        return -1;
    }

    //Método manual de pesquisar o número no array
    private int DummySearch(int value)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == value)
            {
                Debug.Log("DummySearch precisou de " + i + " interações");
                return i;
            }
        }
        return -1;
    }

    //Método de imprimir o array atualizado no console
    private void PrintArray(int arrayCount)
    {
        string result = "Números: ";
        for(int i = 0; i < arrayCount; i++)
        {
            result += array[i].ToString();

        }
    }
}
