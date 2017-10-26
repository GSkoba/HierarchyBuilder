using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    public class Criterion
    {
        public string data = null;
        public double weight = 0;
        public Criterion(string _data, double _weight = 0)
        {
            data = _data;
            weight = _weight;
        }
    }

    public class Element
    {
        public string data = null;
        public int selfIndex = 1;
        public int parentIndex = -1;
        public double weight = 0;
    }

    public class Node
    {
        public Element element;
        private List<Node> children = new List<Node>();
        private int depth = 1;
        private int elementsCount = 1;

        public Node(string _data)
        {
            element = new Element();
            element.data = _data;
        }

        public Node this[int i]
        {
            get { return children[i]; }
        }

        public Node Parent
        {
            get;
            private set;
        }


        public string Data
        {
            get { return element.data; }
        }

        public int Depth
        {
            get
            {
                TreeDepth();
                return depth;
            }
        }

        public int ElementsCount
        {
            get
            {
                ElementsCounting();
                return elementsCount;
            }
        }

        private void increaseDepth(int _depth)
        {
            if (depth < _depth)
                this.depth = _depth;

            if (Parent != null)
            {
                Parent.increaseDepth(depth + 1);
            }
            else return;
        }

        private void TreeDepth()
        {
            if (children.Count == 0)
            {
                increaseDepth(depth);
            }

            foreach (Node child in children)
            {
                child.TreeDepth();
            }
        }

        public Node AddChild(string _data)
        {
            Node node = new Node(_data) { Parent = this };
            node.element.parentIndex = element.selfIndex;
            node.element.selfIndex = (Depth + 1) + (ChildrenCount() - 1);
            children.Add(node);
            return node;
        }

        public void AddChildren(params string[] _data)
        {
            foreach (string newElement in _data)
                AddChild(newElement);
        }

        public bool RemoveChild(Node node)
        {
            return children.Remove(node);
        }

        public int ChildrenCount()
        {
            return children.Count;
        }

        private int ElementsCounting(int _elementsCount = 1)
        {
            foreach (Node child in children)
            {
                elementsCount = child.ElementsCounting(_elementsCount + 1);
                _elementsCount = elementsCount;
            }
            return _elementsCount;
        }

        private void DoHierarchy(int currentLevel, ref List<List<Node>> hierarchy)
        {
            if (currentLevel < hierarchy.Count)
                for (int i = 0; i < children.Count; i++)
                {
                    hierarchy[currentLevel].Add(children[i]);

                    children[i].DoHierarchy(currentLevel + 1, ref hierarchy);
                }
            else return;
        }

        private void SetHierarchyIndexes(int currentLevel, ref List<List<Node>> hierarchy)
        {
            for (int i = currentLevel; i < hierarchy.Count; i++)
            {
                for (int j = 0; j < hierarchy[i].Count; j++)
                {
                    hierarchy[i][j].element.parentIndex = hierarchy[i][j].Parent.element.selfIndex;
                    hierarchy[i][j].element.selfIndex = j + i;
                }
            }
        }

        private void NodeIntoElementIndexesTransfer(ref List<List<Node>> hierarchyList, ref List<List<Element>> hierarchy)
        {
            for (int currentLevel = 1; currentLevel < Depth; currentLevel++)
                for (int i = 0; i < hierarchyList[currentLevel].Count; i++)
                    hierarchy[currentLevel].Add(hierarchyList[currentLevel][i].element);
        }

        public static List<List<Element>> GetHierarchy(Node mainNode)
        {
            var hierarchyList = new List<List<Node>>();
            var hierarchy = new List<List<Element>>();

            for (int i = 0; i < mainNode.Depth; i++)
            {
                hierarchyList.Add(new List<Node>());
                hierarchy.Add(new List<Element>());
            }

            hierarchyList[0].Add(mainNode);
            hierarchy[0].Add(mainNode.element);

            mainNode.DoHierarchy(1, ref hierarchyList);
            mainNode.SetHierarchyIndexes(1, ref hierarchyList);

            mainNode.NodeIntoElementIndexesTransfer(ref hierarchyList, ref hierarchy);

            return hierarchy;
        }

        public static string[,] ListIntoStringArray(List<List<Element>> hierarchy)
        {
            int height = hierarchy.Count;
            int width = -1;

            foreach (List<Element> list in hierarchy)
                if (list.Count > width)
                    width = list.Count;

            string[,] hierarchyString = new string[height, width];

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    hierarchyString[i, j] = null;
                }
            }

            for (int i = 0; i < hierarchy.Count; i++)
            {
                for (int j = 0; j < hierarchy[i].Count; j++)
                {
                    hierarchyString[i, j] = hierarchy[i][j].parentIndex.ToString() + " " + hierarchy[i][j].selfIndex.ToString() + " " + hierarchy[i][j].data;
                }
            }

            return hierarchyString;
        }
    }
}
