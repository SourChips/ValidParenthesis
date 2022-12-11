public class Solution {
    public bool IsValid(string s) {        
    int length = s.Length;
    Stack<char> stack = new Stack<char>();
    Dictionary<char, char> dict = new Dictionary<char, char>();
    dict.Add(')','(');
    dict.Add(']','[');
    dict.Add('}','{');    
    for(int i=0; i < length; i++){
        if(dict.ContainsKey(s[i])){            
           if(stack.Any() && stack.Peek() == dict[s[i]]){
               stack.Pop();
           } 
           else{
               return false;
           }           
        }
        else {
            stack.Push(s[i]);
        }
    }
    if(stack.Any()) return false; else return true;
    }
}