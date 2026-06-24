using UnityEngine;

public class TestLinkedList : MonoBehaviour
{
    LinkedList list;
    
    void Start()
    {
        list = new();
        list.Add(4);
        list.Add(7);
        list.Add(1);
        list.Add(9);

        Debug.Log(list.first.value);
        Debug.Log(list.first.next.value);
        Debug.Log(list.first.next.next.value);
        Debug.Log(list.first.next.next.next.value);

        var curerntNode = list.first;
        while(curerntNode != null)//car le dernier next pointe vers "null", on veut qu'il affiche tous les éléments de la liste avant de s'arreter, si on met = list.last, il s'arrete avant le dernier.
        {
            Debug.Log(curerntNode.value);
            curerntNode = curerntNode.next;
        }

//------------------- autre facon de parcourir la liste -----------------------------------------//
        for (var currentNode2 = list.first; currentNode2 != null; currentNode2 = currentNode2.next)
        {
            Debug.Log(currentNode2.value);
        }
    }

    
}
