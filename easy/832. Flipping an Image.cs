public class Solution {
    public int[][] FlipAndInvertImage(int[][] A) {
        return A.Select(x => x.Reverse().Select(y => 1 - y).ToArray()).ToArray();
    }
}
