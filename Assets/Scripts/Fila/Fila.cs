using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

//Variaveis da classe Fila
public class Fila
{
    private int[] _memory;
    private int _size;
    private int _count;
    private int _front;
    private int _rear;

    //Construtor da Fila (deixa o objeto em estado v�lido, em que pode funcionar)
    public Fila(int size = 10)
    {
        _size = size;
        _memory = new int[_size];
        _count = 0;
        _front = 0;
        _rear = 0;
    }

    //Metodo de entrar na fila
    public bool EnQueue(int value)
    {
        //Verifica��o dse a fila est� cheia
        if(IsFull())
            return false;

        //Verifica��o se pode adicionar elementos na fila
        if(_rear == _size && _front != 0)
        {
            for (int i = 0; i < _count; i++)
                _memory[i] = _memory[_front + i];

            _front = 0;
            _rear = _count;
        }

        _memory[_rear++] = value;
        ++_count;
        return true;
    }

    //M�todo desenfileirar
    public int DeQueue()
    {
        if (IsEmpty())
        {
            Debug.Assert(true, "Out of bounds!");
        }
       --_count;
      //Retorna o elemento retirado no inicio da fila
      return _memory[_front++];
    }

    //Metodo de verificar se a fila est� cheia (quantidade de elementos = capacidade m�xima da fila)
    public bool IsFull() {return (_count == _size);}


    public bool IsEmpty() { return _front == _rear; }
}

public class FilaLoop
{
    private int[] memory;
    private int _size;
    private int _count;
    private int _front;
    private int _rear;
}

