using System;
using System.Collections.Generic;

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

        // --- MY STEP-BY-STEP PLAN ---

        // 1. Create a brand new array of doubles. Set its size to match the 'length' variable.

        // 2. Set up a basic 'for' loop that counts from 0 up to 'length - 1'.

        // 3. Inside the loop, find the value for the current spot. 

        //    Multiply the base 'number' by (current loop index + 1).

        // 4. Save that calculated number directly into the array at the current index.

        // 5. Once the loop finishes all items, return the completed array.

        // Step 1: Make an empty array with the right size
        double[] finalArray = new double[length];

        // Step 2: Use a loop to visit every slot in the array
        for (int position = 0; position < length; position++)
        {
            // Step 3 & 4: Calculate the multiple and save it
            // Position 0 gets: number * 1, Position 1 gets: number * 2, etc.
            finalArray[position] = number * (position + 1);
        }

        // Step 5: Send back the array filled with multiples
        return finalArray;
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

        // --- MY STEP-BY-STEP PLAN ---

        // 1. Find the exact point where the list needs to be split. 

        //    This point is found by subtracting the 'amount' from the total number of items in the list.

        // 2. Use 'GetRange' to grab the group of numbers starting from that split point to the end.

        // 3. Use 'RemoveRange' to erase that same group of numbers from the back of the original list.

        // 4. Use 'InsertRange' to place those copied numbers back in at index 0 (the very start of the list).

        // Step 1: Calculate where the cut happens

        int cutPosition = data.Count - amount;

        // Step 2: Extract and copy the moving elements from the back

        List<int> movingPart = data.GetRange(cutPosition, amount);

        // Step 3: Remove the moving elements from their old spot at the back

        data.RemoveRange(cutPosition, amount);

        // Step 4: Paste the copied elements into the front of the list

        data.InsertRange(0, movingPart);

    }
}