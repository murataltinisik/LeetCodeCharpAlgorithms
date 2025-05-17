int[] TwoSum(int[] nums, int target)
{
   // Iterate through each number in the array
   for (int i = 0; i < nums.Length; i++)
   {
      for (int j = i; j < nums.Length; j++)
      {
         if(i != j){
            // Check if their sum matches the target
            if (nums[i] + nums[j] == target)
            {
               // Store the matching numbers
               return new int[] { i, j };
            }
         }
      }
   }
 
   return new int[0];
}

int[] nums = new int[3] { 2, 3, 3 };
int[] result = TwoSum(nums, 6);

Console.WriteLine($"[{result[0]}, {result[1]}]");