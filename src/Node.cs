using System;

namespace BinaryTree;

public unsafe ref struct Node
{

   private Node* left, right ;


   // If both pointers are null the node is a leaf
   public unsafe bool IsLeaf 
   {
      get 
      {
         return left == null && right == null;
      }
   }


   public Node* GetNode(byte offside)
   {
      // This size
      int size = sizeof(Node);

      Console.WriteLine($"The size of this struct is: ${size} ");

      // Then shorten by a known size
      // sum the offside

      return right;
   }
}