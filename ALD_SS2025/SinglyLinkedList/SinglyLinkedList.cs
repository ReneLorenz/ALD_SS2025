using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList
{
  public class SinglyLinkedList<T>
  {
    public SinglyLinkedList()
    {
      head = null;
      tail = null;
      count = 0;
    }

    private class Node<T>
    {
      public Node(T value)
      {
        this.Value = value;
      }
      public T Value { get; private set; }
      public Node<T> next { get; set; }
    }

    Node<T> head;
    Node<T> tail;
    int count;

    public void Add(T value)
    {
      count++;
      if(head == null) //list is empty
      {
        Node<T> element = new Node<T>(value);
        head = element;
        //head.Value = value;
        tail = head;
        return;
      }

      //constant
      tail.next = new Node<T>(value);
      //tail.next.Value = value;
      tail = tail.next;

      //linar
      //Node<T> current = head;
      //while (current.next != null)
      //{
      //  current = current.next;
      //}

      ////current is the last element of the list
      //current.next = new Node<T>();
      //current.next.Value = value;
    }

    int Size()
    {
      return count;
    }

    public bool Remove(T value)
    {
      if (head == null) return false; //in case of empty list

      Node<T> prev = null;
      Node<T> current = head;
      while(current.next != null)
      {
        if(current.Value.Equals(value))
        {
          if(current == head)
          {
            head = head.next;
          }
          else
          {
            prev.next = current.next;
          }

          count--;
          return true;
        }

        prev = current;
        current = current.next;
      }

      return false;
    }
  }
}
