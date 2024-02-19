
namespace BinaryTree;

public unsafe class Implementation
{

   public void MeasureStructSize()
   {
      int size = sizeof(Node);

      Console.WriteLine($"The size of this struct is: ${size} ");
   }
}