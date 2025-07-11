public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        
        // Step 1: Create an array of size 'length' to store the multiples.
        // Step 2: Use a loop to fill the array. For each index i (from 0 to length-1):
        //         - Calculate the multiple as number * (i + 1)
        //         - Store the result in the array at index i
        // Step 3: Return the filled array.
        double[] multiples = new double[length];
        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }
        return multiples;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Step 1: Determine the split point. The last 'amount' elements will move to the front.
        //         The split point is at index data.Count - amount.
        // Step 2: Use GetRange to get the last 'amount' elements (to move to the front).
        // Step 3: Use GetRange to get the first part (from start to split point).
        // Step 4: Clear the original list.
        // Step 5: Add the last 'amount' elements to the list.
        // Step 6: Add the first part to the list after that.
        int splitPoint = data.Count - amount;
        List<int> endPart = data.GetRange(splitPoint, amount);
        List<int> startPart = data.GetRange(0, splitPoint);
        data.Clear();
        data.AddRange(endPart);
        data.AddRange(startPart);
    }
}
