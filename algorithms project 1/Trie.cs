using System;
using System.Collections.Generic;
using System.Text;

namespace algorithms_project_1
{
    class Trie
    {


        public List<Node> endLetterNode = new List<Node>();
        public Node root;
        public Trie()
        {
            this.root = new Node(' ', null);
        }


        public void Add(string oldWord) //O(N)
        {
            string word = oldWord.ToLower();
            var parent = root;
            for (int i = 0; i < word.Length; i++)
            {
                var child = parent.HasChildWithCharacter(word[i]);
                if (child == null)
                {
                    var node = new Node(word[i], parent);


                    parent.branches.Add(node);
                    parent = node;
                }

                else
                {
                    parent = child;
                }



            }
            if(parent.isEndofWord == true)
            {
                Console.WriteLine("word already exsists");
                return;
            }
            parent.isEndofWord = true;
            if (parent.isEndofWord == true)
            {
                endLetterNode.Add(parent);

            }
           
            
            
        }


        public string GetWordsForPrefix(string prefix) //O(N) + O(N^2) --> O(N^2)
        {
            prefix = prefix.ToLower();
            var currentNode = root;
            var result = currentNode;

            string letters = null;

            string[] returnArray = new string[] { };

            foreach (var c in prefix)
            {
                currentNode = currentNode.HasChildWithCharacter(c);
                if (currentNode == null)
                    return "Could not find string";
                result = currentNode;

            }
            if (result != null)
            {
                returnArray = GetWords(currentNode, prefix);
                for (int i = 0; i < returnArray.Length; i++)
                {
                    letters += returnArray[i] + " ";
                }
            }
            else
            {
                letters = "please input a string";
            }

            return letters;
        }

        public string[] GetWords(Node parentNode, string prefix) //O(N^2)
        {


            Node currentNode;
            string letters = null;
            string lettersAddedToArray = null;
            foreach (var end in endLetterNode)
            {

                currentNode = end;
                letters = currentNode.key.ToString();
                while (currentNode != parentNode)
                {
                    if (currentNode != null)
                    {
                        currentNode = currentNode.HasParentNode(currentNode);

                    }
                    if (currentNode != null && currentNode != parentNode)
                    {
                        letters += currentNode.key.ToString();
                    }
                    if (currentNode == null)
                    {
                        break;
                    }

                }
                if (currentNode == parentNode)
                {
                    char[] charArray = letters.ToCharArray();
                    Array.Reverse(charArray);
                    string word = new string(charArray);
                    lettersAddedToArray += prefix + word + ",";

                }
            }
            string[] wordList = lettersAddedToArray.Split(",");
            return wordList;
        }

        public string Delete(string word) //O(N) 
        {
            word = word.ToLower();
            var currentNode = root;
            var result = currentNode;

            foreach (var c in word)
            {
                currentNode = currentNode.HasChildWithCharacter(c);
                if (currentNode == null)
                    return "Error word not found";
                result = currentNode;

            }
            if (result.isEndofWord == false)
            {
                return "Please enter the full word you wish to be deleted";
            }
            else
            {
                endLetterNode.Remove(result);
                while (result != root)
                {

                    result = currentNode.HasParentNode(currentNode);
                    if (result.branches.Count < 2)
                    {
                        result.branches.Remove(currentNode);
                        currentNode = result;
                        
                    }
                    else
                    {
                        break;
                    }


                }
                return word + " has been deleted";
            }

        }

        public string GetAllWords()//O(N) + O(N^2) --> O(N^2)
        {
            string[] z = new string[] { };
            string str = null;
            z = GetWords(root, "");

            for (int i = 0; i < z.Length; i++)
            {
                str += z[i] + " ";
            }
            return str;
        }
        

}
}
