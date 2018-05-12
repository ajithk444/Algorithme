using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    /*
    A non-empty zero-indexed array A consisting of N integers is given. The product of triplet (P, Q, R) equates to A[P] * A[Q] * A[R] (0 ≤ P < Q < R < N).
    For example, array A such that:
      A[0] = -3
      A[1] = 1
      A[2] = 2
      A[3] = -2
      A[4] = 5
      A[5] = 6 
    contains the following example triplets:
    (0, 1, 2), product is −3 * 1 * 2 = −6
    (1, 2, 4), product is 1 * 2 * 5 = 10
    (2, 4, 5), product is 2 * 5 * 6 = 60
    Your goal is to find the maximal product of any triplet.
     */
    class MaxProductOfThree
    {
        public int solution(int[] A) {
            Array.Sort(A);
            int max=A.Length - 1;
            int result1=A[max]*A[max-1]*A[max-2];
            int result2=A[0]*A[1]*A[max];
            return Math.Max(result1, result2);
        }

     
    }
}
