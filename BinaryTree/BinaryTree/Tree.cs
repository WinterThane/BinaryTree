using System;

namespace BinaryTree
{
    public class Tree<T>
    {
        public Node<T> Root { get; set; }

        public Tree()
        {
            Root = null;
        }

        public void Insert(T x)
        {
            Root = Insert(x, Root);
        }

        public void Remove(T x)
        {
            Root = Remove(x, Root);
        }

        public void RemoveMin()
        {
            Root = RemoveMin(Root);
        }

        public T FindMin()
        {
            return ElementAt(FindMin(Root));
        }

        public T FindMax()
        {
            return ElementAt(FindMax(Root));
        }

        public T Find(T x)
        {
            return ElementAt(Find(x, Root));
        }

        private T ElementAt(Node<T> t)
        {
            return t == null ? default(T) : t.Element;
        }      

        protected Node<T> Insert(T x, Node<T> t)
        {
            if (t == null)
            {
                t = new Node<T>(x);
            }
            else if ((x as IComparable).CompareTo(t.Element) < 0)
            {
                t = t.LeftNode;
            }
            else if ((x as IComparable).CompareTo(t.Element) > 0)
            {
                t = t.RightNode;
            }
            else
            {
                throw new Exception("Number already exists.");
            }

            return t;
        }

        private Node<T> Find(T x, Node<T> t)
        {
            while(t != null)
            {
                if((x as IComparable).CompareTo(t.Element) < 0)
                {
                    t = t.LeftNode;
                }
                else if ((x as IComparable).CompareTo(t.Element) > 0)
                {
                    t = t.RightNode;
                }
                else
                {
                    return t;
                }
            }

            return null;
        }

        private Node<T> FindMin(Node<T> t)
        {
            if (t != null)
            {
                while (t.LeftNode != null)
                {
                    t = t.LeftNode;
                }
            }

            return t;
        } 

        private Node<T> FindMax(Node<T> t)
        {
            if(t != null)
            {
                while(t.RightNode != null)
                {
                    t = t.RightNode;
                }
            }

            return t;
        }   

        private Node<T> RemoveMin(Node<T> t)
        {
            if(t == null)
            {
                throw new Exception("Number not found.");
            }
            else if(t.LeftNode != null)
            {
                t.LeftNode = RemoveMin(t.LeftNode);
                return t;
            }
            else
            {
                return t.RightNode;
            }
        }     

        protected Node<T> Remove(T x, Node<T> t)
        {
            if(t == null)
            {
                throw new Exception("Number not found.");
            }
            else if((x as IComparable).CompareTo(t.Element) < 0)
            {
                t.LeftNode = Remove(x, t.LeftNode);
            }
            else if ((x as IComparable).CompareTo(t.Element) > 0)
            {
                t.RightNode = Remove(x, t.RightNode);
            }
            else if(t.LeftNode != null && t.RightNode != null)
            {
                t.Element = FindMin(t.RightNode).Element;
                t.RightNode = RemoveMin(t.RightNode);
            }
            else
            {
                t = (t.LeftNode != null) ? t.LeftNode : t.RightNode;
            }

            return t;
        }

        public void MakeEmpty()
        {
            Root = null;
        }

        public bool IsEmpty()
        {
            return Root == null;
        }

        public override string ToString()
        {
            return Root.ToString();
        }
    }
}
