public class Solution {
    public int Reverse(int x) {
        int div=0; int sum=0;
        while(x!=0){
            div= x%10;
            if(sum>int.MaxValue/10 || sum<int.MinValue/10) {
                return 0;
            }
            sum=(sum*10)+div;
            x=x/10;
        }
        return sum;
    }
}