
namespace BinaryTree;

public unsafe class Implementation
{

   public void MeasureStructSize()
   {
      int size = sizeof(Node);

      Console.WriteLine($"The size of this struct is: ${size} ");
   }

   public void WalkBiasedLeft(Node* node)
   {
       // Do something with the node;

       Console.WriteLine($"current->{node->id}, left -> {node->left->id} right-> {node->right->id}");

       WalkBiasedLeft(node->left);
   }
}
