using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCollections
{
    public class Path
    {
        public string CurrentPath { get; private set; }

        public Path(string path)
        {
            this.CurrentPath = path;
        }

        public Path Cd(string newPath)
        {
            Stack<string> stack = new Stack<string>(CurrentPath.Split('/'));
            string[] path = newPath.Split('/');
            foreach (string s in path)
            {
                if (s.Equals("..")) stack.Pop();
                else stack.Push(s);
            }
            string[] strs = stack.ToArray();
            Array.Reverse(strs);
            return new Path(String.Join("/", strs));

        }
    }
}
