public class Solution {
    public int[] TwoSum(int[] nums, int target) {

            var result = new List<int>();

            for (var i = 0; i < nums.Count(); i++)
            {
                for (var j = i+1; j < nums.Count(); j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        result.Add(i);
                        result.Add(j);
                    }
                }
            }
            return result.ToArray();
    }
}