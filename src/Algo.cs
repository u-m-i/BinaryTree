using System.Runtime.InteropServices;

namespace BinaryTree;

public unsafe class Implementation
{

    /// Takes the size of the struct type Node
   public void MeasureStructSize()
   {
      int size = sizeof(Node);

      Console.WriteLine($"The size of the struct Node is: {size} ");
   }

   /// Prints the measure of a null and non-null Node pointer
   public void MeasurePointerSize()
   {
        Node* pointer;

        Node root = new Node()
        {
            id = 450,
        };
        Node left = new Node()
        {
            id = 452,
        };
        Node right = new Node()
        {
            id = 454,
        };

        root.left = &left;
        root.right = &right;

        pointer = &root;

        Console.WriteLine($"The Node* size is = {sizeof(Node*)}");

        Console.WriteLine($"The Marshal.SizeOf and instance of Node = {Marshal.SizeOf(root)}");

        Console.WriteLine($"The size of the ushort = {sizeof(ushort)}");
    }


    public void Walk()
    {

        Node root = new Node()
        {
            id = 450,
        };
        Node left = new Node()
        {
            id = 452,
        };
        Node right = new Node()
        {
            id = 454,
        };

        root.left = &left;
        root.right = &right;

        WalkBiasedLeft(&root);
   }

   public void WalkBiasedLeft(Node* node)
   {
       // Do something with the node;

       //Console.WriteLine($"current->{node->id}, left -> {node->left->id} right-> {node->right->id}");

       WalkBiasedLeft(node->left);
   }
}
