using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    /*
     A zero-indexed array A consisting of N integers is given. A triplet (P, Q, R) is triangular if 0 ≤ P < Q < R < N and:
    A[P] + A[Q] > A[R],
    A[Q] + A[R] > A[P],
    A[R] + A[P] > A[Q]
    that, given a zero-indexed array A consisting of N integers, returns 1 if there exists a triangular triplet for this array and returns 0 otherwise.
     * */


    class Triangle
    {
        public int solution(int[] A)
        {
            if(A.Length<3) return 0;
            Array.Sort(A);

            for(int i=0; i<A.Length-2;i++){
                if ((Int64)A[i] + (Int64)A[i + 1] > A[i + 2])
                    return 1;
            }

            return 0;
                
        }
    }
}
