public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            if (digits[i] < 9)
            {
                digits[i]++;
                return digits;
            }
            digits[i] = 0; // Set the current digit to 0 and continue the carry-over
        }
        // If all digits were 9, we need an additional digit at the start
        int[] result = new int[digits.Length + 1];
        result[0] = 1; // Place 1 at the beginning
        return result;
    }
}