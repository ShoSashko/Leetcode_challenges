public class Solution {
    public int[] SumZero(int n) {
        int[] res = new int[n];
        int k = 0;
    
        if(n % 2 != 0)
            res[k++] = 0;
    
        int start = 1;    
        
        while(k < n)
        {
            res[k++] = start;
            res[k++] = -start;
            start++;
        }
        
        return res;
    }
}
