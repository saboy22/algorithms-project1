using System;
using System.Collections.Generic;
using System.Text;

namespace algorithms_project_1
{
    class Node
    {
        public char key;
        public List<Node> branches;
        public bool isEndofWord = false;
        public Node parent;
        public Node(char key, Node parent)
        {
            this.key = key;
            this.branches = new List<Node>();
            this.parent = parent;
            
        }

        public Node HasChildWithCharacter(char c)
        {
            for (int i = 0; i < this.branches.Count; i++)
            {
                var x = this.branches[i];
                if (x.key == c)
                {
                    return x;
                }
            }
            return null;
        }

        public Node[] GetChildren(string prefix)
        {
            Node[] branched = new Node[36];
            string letters = prefix;
            
            var i = 0;
            foreach (var branch in branches)
            {

                branched[i] = branch;
                i++;
            }
            return branched;
        }

        public Node HasParentNode(Node c)
        {
            var x = c.parent;
            
            return x;
        }

        


    }
}
