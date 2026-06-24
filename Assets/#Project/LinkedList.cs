using Unity.Collections;
using UnityEngine;

public class Node<T> //on veut établir un "type" générique pour notre class
{
    public Node<T> next; //le type de notre variable générique (int ou string) = <T>
    public T value;   

    public Node(T val) //----> constructeur
    {
        value = val; // quand on creer une value on n'a pas de valeur on a juste créer la case
    }
}



public class LinkedList
{
    public Node<int> first;
    public Node<int> last;

    public void Add(int element)// void car on veut ajouter (ca ne renvoie rien)
    {
        Node<int> node = new(element);
        if(first == null && last == null)
        {
            first = node;
            last = node;
        }else //si on a deja qqun dans la liste on va remplacer le dernier par l'élément qu'on a créer.
        {
            last.next = node; //ici on rempli la case qu'on a creer.
            last = node;
        }
    }
    
}
