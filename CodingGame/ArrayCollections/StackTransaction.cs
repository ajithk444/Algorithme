using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCollections
{
    //practice picture stack-transaction

    class StackTransaction
    {
        private Stack<int> _stack;
        private Stack<History> _history;

        public struct History
        {
            public int Value;
            public string Operation;
        }
        
        public StackTransaction()
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            _stack = new Stack<int>();
            _history = new Stack<History>();
           
        }

        public void push(int value)
        {
            if (_history.Count() > 0)
                _history.Push(new History {Value=value, Operation="push"});
            
            _stack.Push(value);
        }

        public int top()
        {
            if (_stack.Count > 0)
                return _stack.Peek();
            else
                return 0;
        }

        public void pop()
        {
            if (_stack.Count > 0)
            {
                int value=_stack.Pop();
                if (_history.Count > 0)
                    _history.Push(new History{Value=value, Operation="pop" });
 
            }
        }

        public void begin()
        {
            _history.Push(new History { Value=0, Operation="begin" });
        }

        public bool rollback()
        {
            try
            {
                History temp = _history.Pop();
                while(temp.Operation!="begin"){
                    if (temp.Operation == "push")
                    {
                        _stack.Pop();
                    }
                    else if (temp.Operation == "pop")
                    {
                        _stack.Push(temp.Value);
                    }

                    temp=_history.Pop();
                } 
               
            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }

        public bool commit()
        {
            try
            {
                History temp = _history.Pop();
                while (temp.Operation != "begin")
                {
                    temp = _history.Pop();
                }
            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }

        public static void test()
        {
            // Define your tests here
            StackTransaction sol = new StackTransaction();
            sol.push(42);
            //Contract.Assert(sol.top() == 42, "top() should be 42");
            Console.WriteLine("Test1 : top value is {0}", sol.top());
            sol.begin();
            sol.push(15);
            sol.push(17);
            sol.begin();
            sol.pop();
            Console.WriteLine("The top value is : "+sol.top());
            sol.push(96);
            sol.push(29);
            PrintStack(sol._stack);
            sol.rollback();
            PrintStack(sol._stack);
            sol.push(36);
            sol.commit();
            PrintStack(sol._stack);

            
        }

        public static void PrintStack(Stack<int> temp)
        {
            foreach (int i in temp)
                Console.Write(i+" ");

            Console.WriteLine();
        }
    }
}
