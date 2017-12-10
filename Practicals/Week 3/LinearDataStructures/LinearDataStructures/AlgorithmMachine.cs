using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearDataStructures
{
    public class AlgorithmMachine
    {
        public AlgorithmMachine() { }

        //Checks if String has even number of brackets, in the correct order
        public bool IsBalanced(String characterString)
        {
            bool balanced = true;
            StringStack stack = new StringStack();
            foreach (char item in characterString)
            {
                if (item.Equals('{'))
                    stack.Push(item.ToString());
                if (item.Equals('}'))//Pops the corresponding fowards bracket if it exists
                    if (!stack.IsEmpty())
                        stack.Pop();
                    else
                        balanced = false;
            }
            if (!stack.IsEmpty()) //If the stack still contains values the string is not balanced
                balanced = false;
            return balanced;
        }

        //Evaluates the given postfix expression, returning the integer result
        public int PostfixParser(String expression)
        {
            IntStack stack = new IntStack();
            foreach (char item in expression)//Iterates through each character in expression
                if (item != '+' && item != '*')
                    stack.Push(Convert.ToInt32(new string(item, 1))); //Pushes converted character to the stack if it is an integer
                else if (item.Equals('+'))
                    stack.Push(stack.Pop() + stack.Pop()); //Pushes the result of the previous two ints in the stack - adding them together
                else if (item.Equals('*'))
                    stack.Push(stack.Pop() * stack.Pop()); //Pushes the result of the previous two ints in the stack - multiplying them together
            return stack.Pop();  //Result is the remaining value in the stack            
        }

        //Checks whether a given word is a palindrome
        public bool IsPalindrome(String word)
        {
            bool isPalindrome = true;
            StringStack stack = new StringStack();
            StringQueue queue = new StringQueue();
            foreach (char item in word)
            {
                stack.Push(item.ToString());
                queue.Push(item.ToString());
            }
            //Compares values from top of stack and bottom of queue to see if they match 
            for (int i = 0; i < stack.Count(); i++)
                if (stack.Pop() != queue.Pop())
                    isPalindrome = false;
            return isPalindrome; //Returns a true value if there were no mismatches
        }
    }
}
