using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySearch
    {
        // Member Variables
        public Node RootNode;

        // Constructor

        // Methods
        public void AddNode(Node nodeToAdd)
        {            
            if (RootNode == null)
            {
                RootNode = nodeToAdd;
                return;
            }
            Node CurrentNode = RootNode;

            while (true)
            {

                if (nodeToAdd.nodeData < CurrentNode.nodeData)
                {
                    if (CurrentNode.NodeLeft == null)
                    {
                        CurrentNode.NodeLeft = nodeToAdd;
                        break;
                    }
                    else
                    {
                        CurrentNode = CurrentNode.NodeLeft;
                    }
                
                }
                else
                {
                    if (CurrentNode.NodeRight == null)
                    {
                        CurrentNode.NodeRight = nodeToAdd;
                        break;
                    }
                    else
                    {
                        CurrentNode = CurrentNode.NodeRight;
                    }
                
                }
            }
        }

        public bool SearchTree(int valueToSearch)
        {
            Node CurrentNodeToSearch = RootNode;

            while (true)
            {
                if (valueToSearch == CurrentNodeToSearch.nodeData)
                {
                    return true;
                }
                else if (valueToSearch < CurrentNodeToSearch.nodeData)
                {
                    if (CurrentNodeToSearch.NodeLeft != null)
                    {
                        CurrentNodeToSearch = CurrentNodeToSearch.NodeLeft;
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (valueToSearch > CurrentNodeToSearch.nodeData)
                {
                    if (CurrentNodeToSearch.NodeRight != null)
                    {
                        CurrentNodeToSearch = CurrentNodeToSearch.NodeRight;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
    }
}
