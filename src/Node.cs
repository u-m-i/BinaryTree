
namespace BinaryTree;

public unsafe struct Node
{
    public ushort id; // 2 bytes

    public Node* left, right;

    public Node** edges;


   // If both pointers are null the node is a leaf
//   public unsafe bool IsLeaf 
//   {
//      get 
//      {
//         return left == null && right == null;
//      }
//   }
//
//
    public Node* GetNode(in byte index)
    {
        if(index > 1)
            return null;

        // Check if exists
        return edges[index];
    }

    public bool SetNode(in byte index,Node* pointer)
    {
        if(index > 1 || index < 0 || pointer == null)
            return false;

        edges[index] = pointer;
        return true;
    }


    public Node* GetNodeSimple(in byte index)
    {
        if(index == 1)
            return right;

        return left;
    }


//   public Node* GetNode(byte offside)
//   {
//      // This size
//      int size = sizeof(Node);
//
//      Console.WriteLine($"The size of this struct is: ${size} ");
//
//      // Then shorten by a known size
//      // sum the offside
//
//      return left;
//   }
}
