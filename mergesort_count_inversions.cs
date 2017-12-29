using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    
    static long countInversions(int[] a) {
        if(a == null || a.Length == 1)
            return 0;
        int[] b = (int[])a.Clone();
        return mergeSort(a,0,a.Length,b);
    }
    static long mergeSort(int[] a, int start, int end, int[] b){
        if(end-start < 2)
            return 0;
        int midpoint = (start+end)/2;
		long count = mergeSort(b,0,midpoint,a);
        count += mergeSort(b,midpoint,end,a);
        return count+merge(a,start,midpoint, end,b);
    }
    static long merge(int[] A,int start, int midpoint, int end, int[] B){
        int i = start, j = midpoint, count = 0;
        for (int k = start; k < end; k++) {
            if (i < midpoint && (j >= end || A[i] <= A[j])) {
                B[k] = A[i];
                i = i + 1;
            } else {
                count+=midpoint-1;
                B[k] = A[j];
                j = j + 1;
            }
        }
        return count;
    }
    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < t; a0++){
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);
            long result = countInversions(arr);
            Console.WriteLine(result);
        }
    }
}
