public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] a = new int[] { 0, 0 };
        for (int i = 0; i < nums.Length; i++) {
            for (int j = i + 1; j < nums.Length; j++) {
                a[0] = nums[i];
                a[1] = nums[j];
                if (a[0] + a[1] == target) {
                    Console.WriteLine($"{i}, {j}");
                    return new int[] { i, j };
                }
            }
        }
        return a;
    }
}
