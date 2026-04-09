public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        List<int> set1 = new List<int>();
        List<int> set2 = new List<int>();
        foreach(var num in nums1){
            set1.Add(num);
        }
        foreach(var num2 in nums2){
            if(set1.Contains(num2)){
                set2.Add(num2);
                set1.Remove(num2);
            }
        }
        return set2.ToArray();
    }
}