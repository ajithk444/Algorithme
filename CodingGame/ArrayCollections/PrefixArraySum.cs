using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCollections
{
    /*
    A zero-indexed array A consisting of N integers is given. An equilibrium index of this array is any integer P such that 0 ≤ P < N and the sum of elements of lower indices is equal to the sum of elements of higher indices, i.e. 
    A[0] + A[1] + ... + A[P−1] = A[P+1] + ... + A[N−2] + A[N−1].
    Sum of zero elements is assumed to be equal to 0. This can happen if P = 0 or if P = N−1.
     */


    class PrefixArraySum
    {
        public int solution(int[] A)
        {
            if (A.Length < 1) return -1;
            long sum = 0;
            long sumLeft = 0;
            long sumRight = 0;
            int N=A.Length;
            
            for(int i=0; i<N; i++) sum+=A[i];

            for (int i = 0; i < N; i++)
            {
                sumRight = sum - A[i] - sumLeft;
                if (sumLeft==sumRight) return i;
                sumLeft += A[i];
            }

            return -1;

        }
    }
}
