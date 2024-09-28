using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyList<ListType> //Protege a classe Node, permitindo que os dados dela estejam protegidos
{
    //Classe nó
    private class Node<NodeType> //Find replace se aplica apenas a dado, define um tipo génerico que pode ser resgatado a qualquer momento do código em qualquer tipo (int, float etc)
    {
        public NodeType value; //Valor do primeiro nó
        public Node<NodeType> next; //Referência para o próximo nó

        public Node() //Construtor que pega o valor padrão
        {
            this.value = default(NodeType); //Busca valor padrão
            next = null;
        }

        public Node(NodeType inValue, Node<NodeType> inNext = null) //Construtor que podemos inserir qualquer valor
        {
            this.value = inValue;
            this.next = inNext;
        }

    }

    private Node<ListType> _first; //Primeiro elemento
    private Node<ListType> _last; //Último elemento
    private int _count; //Contador

    //Inicializa as variáveis da classe MyList
    public MyList()
    {
        _first = null;
        _last = null;
        _count = 0;
    }

    //Construtor que expõe o valor de count
    public int GetCount() { return _count; }

    //Método de inserir elemento no fim da lista
    public void InsertLast(ListType inValue)
    {
        _count++; //Conta os nós cada vez que um novo é adicionado
        Node<ListType> newValue = new Node<ListType>(inValue); //Cria um nó para a lista

        //Verifica se a lista está vazia
        if (_first == null)
        {
            _first = newValue;
            _last = newValue;
        } else
        {
            _last.next = newValue; //O último valor deixa de ser o último valor e aponta para o novo valor inserido
            _last = newValue; //O novo valor inserido passa a ser o último
        }
    }

    //Método de inserir elemento no início da lista
    public void InsertFirst(ListType inValue)
    {
        _count++;//Conta os nós cada vez que um novo é adicionado
        Node<ListType> newValue = new Node<ListType>(inValue);//Cria um nó para a lista

        //Verifica se a lista está vazia
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

