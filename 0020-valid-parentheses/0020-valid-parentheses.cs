public class Solution {
    public bool IsValid(string s) {
        char[] stack = new char[s.Length];
        int top= -1;
        foreach(char ch in s){
            if(ch=='(' || ch=='[' || ch =='{'){
                stack[++top]=ch;
            }
            else if(ch==')' || ch==']' || ch =='}'){

                if(top==-1) return false;
                char last = stack[top--];
                if((ch==')' && last!='(') || (ch=='}' && last!='{') || (ch==']' && last!='[')){
                    return false;
                }
            }
        }
        return top == -1;
    }
}