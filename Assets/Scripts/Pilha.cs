using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Classe pilha com as variaveis inteiras array, size e top
public class Pilha
{
    private int[] array;
    private int size;
    private int count;

    //Construtor para realizar a inicialização da classe
    public Pilha() { array = null; size = 0; count = 0; }
    public Pilha(int inSize)
    {
        this.size = inSize;
        this.array = new int[size];
        this.count = 0;
    }

    //Método Push - insere o valor no topo da pilha
    public bool Push(int item)
    {
        //++this.top;
        if ((this.count + 1) >= this.size)
            return false;

        this.array[this.count++] = item;
        return true;
    }

    //Metódo Pop - retira o dado do topo da pilha
    public int Pop()
    {
        if (this.count == 0)
            Debug.Assert(false, "Out of bounds");


        return this.array[--this.count];
    }

    //Método Top - exibi o que esta no topo sem remover
    public int Top()
    {
        if (this.count == 0)
            Debug.Assert(false, "Out of bounds");


        return this.array[this.count - 1];
    }
    //Retorna qual o tamanho da pilha, quantos elementos tem na pilha e limpa a pilha
    public int Size() { return this.size; }
    public int Count() { return this.count; }
    public void Clear() { this.count = 0; }
}