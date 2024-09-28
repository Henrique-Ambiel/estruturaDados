using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//
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

    //M�todo de inserir elemento no fim da lista
    public void InsertLast(ListType inValue)
    {
        _count++; //Conta os n�s cada vez que um novo � adicionado
        Node<ListType> NewValue = new Node<ListType>(inValue); //Cria um n� para a lista

        //Verifica se a lista est� vazia
        if (_first == null)
        {
            _first = NewValue;
            _last = NewValue;
        } else
        {
            _last.next = NewValue; //O �ltimo valor deixa de ser o �ltimo valor e aponta para o novo valor inserido
            _last = NewValue; //O novo valor inserido passa a ser o �ltimo
        }
    }


}
