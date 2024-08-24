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

    //Construtor da Fila
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
        if(IsFull())
            return false;

        _memory[_rear++] = value;
        ++_count;
        return true;
    }

    //Metodo de verificar se a fila está cheia
    public bool IsFull() {return (_count == _size);}
}

public class FilaLoop
{
    private int[] memory;
    private int _size;
    private int _count;
    private int _front;
    private int _rear;
}

