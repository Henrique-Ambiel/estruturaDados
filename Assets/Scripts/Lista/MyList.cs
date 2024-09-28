using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyList<ListType> //Protege a classe Node, permitindo que os dados dela estejam protegidos
{
    //Classe n�
    private class Node<NodeType> //Find replace se aplica apenas a dado, define um tipo g�nerico que pode ser resgatado a qualquer momento do c�digo em qualquer tipo (int, float etc)
    {
        public NodeType value; //Valor do primeiro n�
        public Node<NodeType> next; //Refer�ncia para o pr�ximo n�

        public Node() //Construtor que pega o valor padr�o
        {
            this.value = default(NodeType); //Busca valor padr�o
            next = null;
        }

        public Node(NodeType inValue, Node<NodeType> inNext = null) //Construtor que podemos inserir qualquer valor
        {
            this.value = inValue;
            this.next = inNext;
        }

    }

    private Node<ListType> _first; //Primeiro elemento
    private Node<ListType> _last; //�ltimo elemento
    private int _count; //Contador

    //Inicializa as vari�veis da classe MyList
    public MyList()
    {
        _first = null;
        _last = null;
        _count = 0;
    }

    //Construtor que exp�e o valor de count
    public int GetCount() { return _count; }

    //M�todo de inserir elemento no fim da lista
    public void InsertLast(ListType inValue)
    {
        _count++; //Conta os n�s cada vez que um novo � adicionado
        Node<ListType> newValue = new Node<ListType>(inValue); //Cria um n� para a lista

        //Verifica se a lista est� vazia
        if (_first == null)
        {
            _first = newValue;
            _last = newValue;
        } else
        {
            _last.next = newValue; //O �ltimo valor deixa de ser o �ltimo valor e aponta para o novo valor inserido
            _last = newValue; //O novo valor inserido passa a ser o �ltimo
        }
    }

    //M�todo de inserir elemento no in�cio da lista
    public void InsertFirst(ListType inValue)
    {
        _count++;//Conta os n�s cada vez que um novo � adicionado
        Node<ListType> newValue = new Node<ListType>(inValue);//Cria um n� para a lista

        //Verifica se a lista est� vazia
        if(_first == null)
        {
            _first = newValue;
            _last = newValue;
        } else
        {
            newValue.next = _first; //O novo valor inserido passa a ser o primeiro
            _first = newValue; //O primeiro valor deixa de ser o primeiro valor e aponta para o novo valor inserido
        }
    }
}

