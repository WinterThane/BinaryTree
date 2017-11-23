namespace BinaryTree
{
    public class Node<T>
    {
        public T Element { get; set; }
        public Node<T> LeftNode { get; set; }
        public Node<T> RightNode { get; set; }

        public Node(T element)
        {
            Element = element;
        }

        public override string ToString()
        {
            string nodeString = "[" + Element + " ";

            if(LeftNode == null && RightNode == null)
            {
                nodeString += " (leaf) ";
            }

            if(LeftNode != null)
            {
                nodeString += "Left: " + LeftNode.ToString();
            }

            if(RightNode != null)
            {
                nodeString += "Right: " + RightNode.ToString();
            }

            nodeString += "] ";

            return nodeString;
        }
    }
}
