public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        
        HashSet<int> set1 = new HashSet<int>();
        HashSet<int> set2 = new HashSet<int>();
        foreach(var num in nums1)
        {
            set1.Add(num);
        }
        foreach(var num2 in nums2)
        {
            if(set1.Contains(num2))
            {
                set2.Add(num2);
            }
        }
        return set2.ToArray();
    }
}