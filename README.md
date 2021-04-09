The main data structure that was used to complete the project is called a trie. It is a type of tree that is used mainly for storing strings. The trie is made up of many nodes, every character in a word that is added to the trie is made into a node. These nodes are connected by branches which links each node together. Every node also marks its parent node as well so that we can travel up and down the branches to find, delete, or add words.  Each parent node is not limited to two children nodes like a binary search tree and it can technically have one for every different child a parent node has. I also used a list to keep track of the endpoints in each of the words added to the trie. 

Big O notations worst case:

GetWordsPrefix: This method is O(N2) because the foreach loop gives you O(N), but when you call the method GetWords This method turns out to be O(N2) because there is a while loop within a foreach loop. If you add O(N2) + O(N) it will give you O(N2).

Add: This method is just O(N) because you are adding items and the number of items you add is based upon the length of the word you want to add. 

Delete: This method was tricky figuring out the worst case big O however, I believe it to be O(N). This is due to the fact that the time it takes to delete the word is based upon the length of the word which you want to delete. The foreach loop goes through and initially searches for the word inputted into the method this gives us O(N). The next part goes through and deletes the word. If you look at the worst case for deleting a word it would be the entire length of the word which would be O(N) making the method O(2N) which is just O(N).

GetAllWords: This method is also O(N2) because it calls the GetWords method as well which is O(N2.).
