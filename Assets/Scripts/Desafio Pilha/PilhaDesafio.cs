using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PilhaDesafio : MonoBehaviour
{
    //Vari�veis
    public int first;
    public int last;
    public int count;
    public int []size;

    //Construtor que inicializa as vari�veis
    public PilhaDesafio(int first, int last, int count, int []size) 
    {
        this.first = 0;
        this.last = 0;
        this.count = 0;
        this.size = new int[5];
    }

    //M�todo que visualiza o topo da pilha 
    public int Top(int first, int count)
    {
        
    }

    //M�todo verifica se a pilha est� vazia
    public bool IsEmpty()
    {
        count = 0;
        if(first < 0)
        {
            Debug.Log("A pilha est� cheia");
            return true;
        }
        else
        {
            Debug.Log("A pilha n�o est� vazia");
            return false;
        }        
    }

    //M�todo que adiciona um elemento ao topo da pilha 
    public int Push(int first, int last, int count, int []size)
    {
        
    }

    //M�todo que remove o primeiro elemento do topo da pilha
    public int Pop(int first, int last, int count, int []size) 
    { 
        
    }

    //Remove todos os elementos da pilha
    public int Clear(int count, int size)
    {

    }
}
