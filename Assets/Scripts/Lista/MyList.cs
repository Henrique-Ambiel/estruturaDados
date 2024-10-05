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

    //Método que remove itens da lista e retorna o valor removido
    public ListType RemoveAt(int index)
    {
        Debug.Assert((index < _count && index >= 0), "Out of bounds"); //Exibe em caso de erro se não existir indíce
        Debug.Assert(_first != null, "Empty List"); //Exibe em caso de erro se a lista está vazia

        --_count;
        if (index == 0) //Verifica se o elemento removido da lista é o primeiro
        {
            ListType result = _first.value; //Guarda o valor do nó

            Node<ListType> resultNode = _first; //Nó que guarda o primeiro valor
            _first = resultNode.next; //Passa a referência para o novo valor
            if (_count == 0) //Se remover o único elemento da lista
                _last = _first;
            resultNode = null; //O nó passa a apontar para null

            return result; //Retorna o valor para o método
        } 
        else
        {
            Node<ListType> prior = GetByIndex(index - 1); //Nó anterior ao que será removido
            Node<ListType> nodeToRemove = prior.next; //Nó que será removido
            prior.next = nodeToRemove.next;
            if (index == _count - 1) //Verifica se o nó é o último
                _last = prior;
            ListType result = nodeToRemove.value; //Guarda o valor do nó que será removido
            nodeToRemove.next = null;

            return result;
        }
    }

    //Permite que utilize operadores lógicos do array em uma lista
    public ListType this[int index]
    {
        get { return GetByIndex(index).value; } 
        set { GetByIndex(index).value = value; }
    }

    //Método que retorna o nó que será removido
    private Node<ListType> GetByIndex(int index)
    {
        Debug.Assert((index < _count && index >= 0), "Out of bounds");
        Node<ListType> result = _first;

        for (int i = 0; i < index; i++) //Percorre os nós até chegar no que irá remover
            result = result.next;

        return result;
    }
}

