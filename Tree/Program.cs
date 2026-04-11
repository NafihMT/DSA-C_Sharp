using static System.Net.Mime.MediaTypeNames;

namespace Tree
{
    internal class Program
    {

        public class Node
        {
            public int Data;
            public Node left;
            public Node right;

            public Node(int data)
            {
                Data = data;
                left = null;
                right = null;
            }
        }

        public class BST
        {
            public Node root;
            public BST()
            {
                root = null;
            }


            public Node Insert(Node root, int data)
            {
                if(root == null)
                {
                    return new Node(data);
                }

                if (data < root.Data)
                {
                    root.left = Insert(root.left, data);
                }
                else if (data > root.Data)
                {
                    root.right = Insert(root.right, data);
                }
                return root;
            }

            public Node Delete(Node root, int data)
            {
                if(root == null)
                {
                    return null;
                }
                if (root.Data > data)
                {
                    root.left = Delete(root.left, data);

                }
                else if (root.Data < data)
                {
                    root.right = Delete(root.right, data);
                }

                else
                {
                    // Case 1

                    if(root.right == null)
                    {
                        return root.left;
                    }
                    if(root.left == null)
                    {
                        return root.right;
                    }

                    // Case 2

                    Node minNode = FindMin(root.right);             // left most node(Minimum value) in right tree
                    root.Data = minNode.Data;                       // replace root.data with inorder successor
                    root.right = Delete(root.right, minNode.Data);  // Deleting inorder successor(root.right)
                }
                return root;
            }            
            
            public Node FindMin(Node root)
            {
                while(root.left != null)
                {
                    root = root.left;
                }
                return root;
            }

           public void InOrder(Node root)
           {
                if(root != null)
                {
                    InOrder(root.left);
                    Console.Write(root.Data + " ");
                    InOrder(root.right);

                }
           }
            public void PreOrder(Node root)
            {
                if (root != null)
                {
                    Console.Write(root.Data + " ");
                    PreOrder(root.left);
                    PreOrder(root.right);
                }
            }

            public void PostOrder(Node root)
            {
                if (root != null)
                {
                    PostOrder(root.left);
                    PostOrder(root.right);
                    Console.Write(root.Data + " ");
                }
            }
            //--------------------------------------------------

            // DFS 
                                    // 1. Put root in queue
                                    // 2. Remove front node and print it
                                    // 3. Add its left child
                                    // 4. Add its right child
                                    // 5. Repeat until queue is empty

            public void LevelOrder(Node root)
            {
                if(root == null)
                {
                    return;
                }
                Queue<Node> queue = new Queue<Node>();      
                queue.Enqueue(root);                        // 1 
                while (queue.Count > 0)
                {
                    Node current = queue.Dequeue();         // 2
                    Console.WriteLine(current.Data);        // 2
                    if(current.left != null)
                    {
                        queue.Enqueue(current.left);        //3
                    }
                    if (current.right != null)          
                    {   
                        queue.Enqueue(current.right);       //4
                    }

                }
            }

            



        }

        static void Main(string[] args)
        {
            BST t = new BST();
            t.root = t.Insert(t.root, 21);
            t.root = t.Insert(t.root, 11);
            t.root = t.Insert(t.root, 34);
            t.root = t.Insert(t.root, 29);
            t.root = t.Insert(t.root, 37);

            Console.WriteLine("In order Before Deletion");
            t.InOrder(t.root);

            t.Delete(t.root,29);
            Console.WriteLine("\nInorder After deletion");
            t.InOrder(t.root);


            Console.WriteLine("\nPreorder After deletion");
            t.PreOrder(t.root);
            Console.WriteLine("\nPostorder After deletion");

            t.PostOrder(t.root);





        }
    }
}
