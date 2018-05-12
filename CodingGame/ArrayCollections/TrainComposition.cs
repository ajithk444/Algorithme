using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCollections
{

    public class TrainComposition
    {
        private LinkedList<int> _linkedList;

        public TrainComposition()
        {
            _linkedList = new LinkedList<int>();
        }

        public void AttachWagonFromLeft(int wagonId)
        {
            _linkedList.AddFirst(wagonId);
        }

        public void AttachWagonFromRight(int wagonId)
        {
            _linkedList.AddLast(wagonId);
        }

        public int DetachWagonFromLeft()
        {
            int value = _linkedList.First.Value;
            _linkedList.RemoveFirst();
            return value;
        }

        public int DetachWagonFromRight()
        {
            int value = _linkedList.Last.Value;
            _linkedList.RemoveLast();
            return value;
        }

    }
}
