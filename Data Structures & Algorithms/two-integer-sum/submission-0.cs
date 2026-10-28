public class Solution {
    public int[] TwoSum(int[] nums, int target)
    {
        var count = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            var dif = target - nums[i];

            if (count.ContainsKey(dif))
            {
                return new int[] { count[dif], i };
            }
            
            count[nums[i]] = i;
        }

        return [];
        
    }
}
