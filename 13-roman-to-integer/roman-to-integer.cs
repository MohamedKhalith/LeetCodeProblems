public class Solution {
    public int RomanToInt(string s) {
        Dictionary<string,int> romanValues= new Dictionary<string,int>();
        romanValues.Add("I",1);
        romanValues.Add("V", 5);
        romanValues.Add("X", 10);
        romanValues.Add("L", 50);
        romanValues.Add("C", 100);
        romanValues.Add("D", 500);
        romanValues.Add("M", 1000);

        int romanValue = 0;
        int previousValue = 0;
        for(int i = s.Length-1; i>=0; i--){
            romanValues.TryGetValue(s[i].ToString(), out int result);
            if(result < previousValue){
                romanValue= romanValue - result;
                previousValue= result;
            }
            else{
                romanValue= romanValue + result;
                previousValue= result;
            }
        }
        return romanValue;
    }
}