using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
  }
  /**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

  public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {
    var result=new List<IList<int>>();
		if(root==null){
				return result;
		}
		Stack<TreeNode> stack1 = new Stack<TreeNode>();
		Stack<TreeNode> stack2 = new Stack<TreeNode>();
		stack1.Push(root);

		while(stack1.Count>0 || stack2.Count > 0)
		{
			while (stack1.Count > 0)
			{
					int count=stack1.Count;
					var levels=new List<int>();  

					for(int i=0; i<count;i++){                      
					
					TreeNode node = stack1.Pop();
					levels.Add(node.val);
					if (node.left != null)
					{
							stack2.Push(node.left);
					}
					if (node.right != null)
					{
							stack2.Push(node.right);
					}
					}
					result.Add(levels);
																							
			}
	
			while (stack2.Count > 0)
			{
					int size=stack2.Count;
					var sublist=new List<int>();
					for(int i=0; i<size;i++){
					TreeNode node = stack2.Pop();
					sublist.Add(node.val);
					if (node.right != null)
					{
							stack1.Push(node.right);
					}
					if (node.left != null)
					{
							stack1.Push(node.left);
					}
					} 
					result.Add(sublist);
			}

							
		}


return result;
    }
}
