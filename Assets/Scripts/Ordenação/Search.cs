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
        //Sortea um n�mero entre 10 e 100 para ser o tamanho do array
        int arrayCount = Random.Range(5, 10);
        array = new int[arrayCount];

        //Imprime no console o tamanho do array
        Debug.Log("Iniciado array de " + arrayCount + " posi��es.");

        //Itera o array e coloca um n�mero entre 1 e 1000 dentro dele
        for (int i = 0; i < arrayCount; i++)
        {
            array[i] = Random.Range(1, 1000);
        }

        PrintArray(arrayCount);
        BubbleSort();
        Debug.Log("Array Ordenado");
        PrintArray(arrayCount);
    }

    //M�todo de ordena��o do array
    private void BubbleSort()
    {

        bool toStop = true;
        //Decrementa os valores para fazer ordena��o
        for (int i = array.Length - 1; i > 0; i--) 
        { 
            for(int j = 0; j < i; j++)
            {
                //Realiza a troca dos valores do array para ordena��o
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
            if(toStop) //Se n�o tiver troca ele interrompe o looping
                break;
        }
    }

    //M�todo de busca bin�ria
    private int BinarySearch(int value)
    {
        int start = 0;
        int end = array.Length - 1;
        while (start <= end)
        {
            int middle = (start + end) / 2;
            if(value == array[middle]) //Verifica se o �ndice est� no meio do array
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

    //M�todo manual de pesquisar o n�mero no array
    private int DummySearch(int value)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == value)
            {
                Debug.Log("DummySearch precisou de " + i + " intera��es");
                return i;
            }
        }
        return -1;
    }

    //M�todo de imprimir o array atualizado no console
    private void PrintArray(int arrayCount)
    {
        string result = "N�meros: ";
        for(int i = 0; i < arrayCount; i++)
        {
            result += array[i].ToString();

        }
    }
}
