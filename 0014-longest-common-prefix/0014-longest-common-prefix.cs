public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        StringBuilder output= new StringBuilder();
        if(strs==null || strs.Length==0){
            return string.Empty;
        }
        for(int charIndex=0;charIndex<strs[0].Length;charIndex++){
            char currentIndex = strs[0][charIndex];
            for(int strIndex=1;strIndex<strs.Length;strIndex++){
                if(charIndex>=strs[strIndex].Length || strs[strIndex][charIndex]!=currentIndex){
                    return output.ToString();
                }
            }
            output.Append(currentIndex);
        }
        return output.ToString();
    }
}