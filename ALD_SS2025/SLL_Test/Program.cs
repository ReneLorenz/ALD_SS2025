using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLL_Test
{
  internal class Program
  {
    private class Student
    {
      private int MatNr;
      private String Name;

      public override bool Equals(object obj)
      {
        Student other = (Student)obj;
        return other.MatNr.Equals(this.MatNr);
      }
    }
    static void Main(string[] args)
    {
      SinglyLinkedList.SinglyLinkedList<int> sll = 
        new SinglyLinkedList.SinglyLinkedList<int>();

      sll.Add(10);
      sll.Add(11);
      sll.Add(12);

      sll.Remove(11);

      
    }
  }
}
