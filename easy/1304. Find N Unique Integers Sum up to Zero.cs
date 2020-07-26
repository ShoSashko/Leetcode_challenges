public class Solution {
    public int[] SumZero(int n) {
        List<int> list = new List<int>();
        int count = 1;
        
        if(n % 2 == count){
            list.Add(0);  
        }

        while(list.Count != n){
            list.Add(count);
            list.Add(-count);
            count++;
        }
        
        return list.ToArray();
    }
}
