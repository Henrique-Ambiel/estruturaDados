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

    //M�todo que remove itens da lista e retorna o valor removido
    public ListType RemoveAt(int index)
    {
        Debug.Assert((index < _count && index >= 0), "Out of bounds"); //Exibe em caso de erro se n�o existir ind�ce
        Debug.Assert(_first != null, "Empty List"); //Exibe em caso de erro se a lista est� vazia

        --_count;
        if (index == 0) //Verifica se o elemento removido da lista � o primeiro
        {
            ListType result = _first.value; //Guarda o valor do n�

            Node<ListType> resultNode = _first; //N� que guarda o primeiro valor
            _first = resultNode.next; //Passa a refer�ncia para o novo valor
            if (_count == 0) //Se remover o �nico elemento da lista
                _last = _first;
            resultNode = null; //O n� passa a apontar para null

            return result; //Retorna o valor para o m�todo
        } 
        else
        {
            Node<ListType> prior = GetByIndex(index - 1); //N� anterior ao que ser� removido
            Node<ListType> nodeToRemove = prior.next; //N� que ser� removido
            prior.next = nodeToRemove.next;
            if (index == _count - 1) //Verifica se o n� � o �ltimo
                _last = prior;
            ListType result = nodeToRemove.value; //Guarda o valor do n� que ser� removido
            nodeToRemove.next = null;

            return result;
        }
    }

    //Permite que utilize operadores l�gicos do array em uma lista
    public ListType this[int index]
    {
        get { return GetByIndex(index).value; } 
        set { GetByIndex(index).value = value; }
    }

    //M�todo que retorna o n� que ser� removido
    private Node<ListType> GetByIndex(int index)
    {
        Debug.Assert((index < _count && index >= 0), "Out of bounds");
        Node<ListType> result = _first;

        for (int i = 0; i < index; i++) //Percorre os n�s at� chegar no que ir� remover
            result = result.next;

        return result;
    }
}

