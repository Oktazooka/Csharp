
class LongestCommonPrefix {

    public static string LongestCommonPrefixFun(string[] input) {
        if (input.Length == 0) {
            return "";
        }
        
        string prefix = input[0];
        
        for (int i = 1; i < input.Length; i++) {
            prefix = CommonPrefix(prefix, input[i]);
            
            if (prefix == "") {
                break;
            }
        }
        
        return prefix;
    }
    
    private static string CommonPrefix(string str1, string str2) {
        int minLength = Math.Min(str1.Length, str2.Length);
        
        for (int i = 0; i < minLength; i++) {
            if (str1[i] != str2[i]) {
                return str1.Substring(0, i);
            }
        }
        
        return str1.Substring(0, minLength);
    }
}
