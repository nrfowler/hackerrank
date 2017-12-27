using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static long countInversions(int[] arr) {
        if(arr == null || arr.Length ==1)
            return 0;
        
        int[] b = (int[])arr.Clone();
        return mergeSort(arr,0,arr.Length,b, 0);
        
    }
    static long mergeSort(int[] a, int start, int end, int[] b, int count){
        if(end-start < 2)
            return 0;
        int midpoint = (start+end)/2;
        mergeSort(a,0,midpoint,b, count);
        mergeSort(a,midpoint,a.Length,b,count);
        return count+merge(a,start,midpoint, end,b);
    }
    static long merge(int[] A,int start, int midpoint, int end, int[] B){
        int i = start, j = midpoint, count = 0;
        for (int k = start; k < end; k++) {
            if (i < midpoint && (j >= end || A[i] <= A[j])) {
                B[k] = A[i];
                i = i + 1;
            } else {
                count++;
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
