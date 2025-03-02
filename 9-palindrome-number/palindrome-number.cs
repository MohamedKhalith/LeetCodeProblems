public class Solution {
    public bool IsPalindrome(int x) {
        var reminder=0; var dummy=x;
        var sum=0;
        if(x<0){
            return false;
        }
        while(x!=0){
            reminder = x%10;
            sum=sum*10+ reminder;
            x=x/10;
        }
        if(dummy==sum){
            return true;
        }
        return false;
    }
}