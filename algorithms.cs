using System;

namespace ArrayAlgorithims
{
    class Program
    {
        // arrays for testing the array algorithims
        static string[] stringTesterArray = new string[5] { "one", "two", "three", "four", "five" };
        static int[] intTesterArray = new int[5] { 1, 2, 3, 4, 5 };
        static double[] decimalTesterArray = new double[5] { 1.00, 2.00, 3.00, 4.00, 5.00 };
        static string[] names = new string[5] { "oi", "oi", "ay", "aie", "ae" };
        static string[] emails = new string[5] { "oi@gmail.com", "oi@gmail.com", "ay@gmail.com", "aie@gmail.com", "ae@gmail.com" };
        static void Main(string[] args)
        {
            string[] array = shiftArrayRight(stringTesterArray);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

        }
        // takes in an array and returns the sum of all it's elements
        static int sumOfArray(int[] array)
        {
            int sum = array[0]; // starts with the first number
            for (int i = 1; i < array.Length; i++) // loops for the length of the array, starting at one (we used 0 to start the sum), increasing by one
            {
                sum += array[i];// add the index's value to the sum
            }
            return sum;
        }
        // takes in an array and returns the smallest value in the array
        static int minOfArray(int[] array)
        {
            int min = array[0];// starts with the first number
            for (int i = 1; i < array.Length; i++) // loops for the length of the array, starting at one (we used 0 to start), increasing by one
            {
                if (array[i] < min)// if the current element is less than the current minimum
                {
                    min = array[i];// update the minimum
                }
            }
            return min;
        }
        // takes in an array and returns the biggest value's index in the array
        static int maxIndexOfArray(int[] array)
        {
            int maxIndex = 0;// starts with the first index
            for (int i = 1; i < array.Length; i++) // loops for the length of the array, starting at one (we used 0 to start), increasing by one
            {
                if (array[i] > array[maxIndex]) // if the current element is greater than the current maxiumum
                {
                    maxIndex = i; // update the maximum with the index
                }
            }
            return maxIndex;
        }
        // takes in an array and returns the mean average of it's elements
        static double meanOfArray(double[] array)
        {
            double sum = array[0]; // starts with the first index
            for (int i = 1; i < array.Length; i++)// loops for the length of the array, starting at one (we used 0 to start), increasing by one
            {
                sum += array[i]; // update sum
            }
            return sum / array.Length; // divide the sum by # of elements
        }
        // takes in an array and returns a new one with the same contents and length
        static string[] copyArray(string[] array)
        {
            string[] newArray = new string[array.Length];// creates a new array with the same length
            for (int i = 0; i < array.Length; i++) // loops for the length of the array, staring at 0 increasing by one
            {
                newArray[i] = array[i]; // set the element to equal the same element of the original
            }
            return newArray; // return the new array
        }
        // takes in an array and a string and returns true if the string is in the array
        static bool doesExist(string[] array, string m)
        {
            bool found = false;// auto sets return to false
            for (int i = 0; i < array.Length; i++) // loops for the length of the array, staring at 0 increasing by one
            {
                if (array[i] == m) // if the current element equals the string we want to find
                {
                    found = true; // it is found!
                }
            }
            return found;
        }
        // takes in an array and a string and returns the first index in which the string is found. returns -1 if the string cannot be found
        static int findString(string[] array, string m)
        {
            int indexOfString;// for the index of the element
            for (int i = 0; i < array.Length; i++) // loops for the length of the array, staring at 0 increasing by one
            {
                if (array[i] == m) // if the current element equals the string we want to find
                {
                    indexOfString = i; // update the index of string to be the index of the one we found
                    return indexOfString; // returns/exits the loop
                }
            }
            return -1;// returns -1 if we still haven't exited the loop
        }
        // takes in an array and returns the same array with one extra space
        static string[] increaseArraySizeByOne(string[] array)
        {
            // creates the new array we're going to return and increases the length by one
            string[] newArray = new string[array.Length + 1];
            for (int i = 0; i < array.Length; i++) // loops for the length of the array, staring at 0 increasing by one
            {
                newArray[i] = array[i]; // fills in the new array with the correct element
            }
            return newArray;
        }
        // searches one array (names) for a string (name) and gets the parallel array (email)'s data if found. returns a list of all the matching emails
        static string[] getEmailsWithName(string[] emails, string[] names, string name)
        {
            string[] matchingEmails = new string[names.Length]; // creates a list for matching emails
            int lastIndex = 0; // keeps track of the last index filled so we can make all emails consecutive in the list
            for (int i = 0; i < names.Length; i++) // loops for the length of the array, staring at 0 increasing by one
            {
                if (names[i] == name) // if we find the string
                {
                    matchingEmails[lastIndex] = emails[i]; // update the list with the element from the parallel array
                    lastIndex++; //  increase last index filled
                }
            }
            return matchingEmails;
        }
        // searches one array (names) for a string (name) and returns the index if found
        static int[] getEmailIndexWithName(string[] emails, string[] names, string name)
        {
            int[] matchingEmailIndexes = new int[names.Length]; // creates a list for matching indices
            int lastIndex = 0; // keeps track of the last index filled so we can make all items consecutive in the list
            for (int i = 0; i < names.Length; i++) // loops for the length of the array, staring at 0 increasing by one
            {
                if (names[i] == name) // if we find the string
                {
                    matchingEmailIndexes[lastIndex] = i; // udpate the list with the current index
                    lastIndex++; // increase last index filled
                }
            }
            return matchingEmailIndexes;
        }
        // gets an array and shifts it right (every element moves one index forward)
        static string[] shiftArrayRight(string[] array)
        {
            string[] shiftedArray = new string[array.Length]; // creates new array for result
            for (int i = 0; i < array.Length - 1; i++) // loops for the length of the array - 1 (because there is one less element), staring at 0 increasing by one
            {
                shiftedArray[i + 1] = array[i];// fills in the array one index ahead
            }
            return shiftedArray;
        }
        // gets an array and inserts a given element into it
        static string[] insertElement(string[] array, string element, int index)
        {
            bool pastIndex = false;// this variable tells us if we've gotten past the insert
            string[] finalArray = new string[array.Length + 1]; // cerates new array for result
            for (int i = 0; i < array.Length + 1; i++) // loops for the length of the array + 1 (because of extra element), staring at 0 increasing by one
            {
                if (i == index)// if we are at the place to insert the element
                {
                    finalArray[i] = element;// put in the element
                    pastIndex = true; // and now we are past the insert
                }
                else // if we are not at the place to insert
                {
                    if (!pastIndex) // if we before the insert,
                    {
                        finalArray[i] = array[i]; // place the element in the same spot
                    }
                    else // otherwise,
                    {
                        finalArray[i + 1] = array[i]; // place it forward
                    }
                }

            }
            return finalArray;
        }
        // gets an array and shifts it left (every element moves one index backwards)
        static string[] shiftArrayLeft(string[] array)
        {
            string[] shiftedArray = new string[array.Length]; // creates new array for result
            for (int i = 0; i < array.Length - 1; i++) // loops for the length of the array - 1 (because there;s one less element), staring at 0 increasing by one
            {
                shiftedArray[i] = array[i + 1]; // the shifted array's element is the same element at one index ahead
            }
            return shiftedArray;
        }
        // takes in an array and deletes the element in a given index
        static string[] deleteElement(string[] array, int index)
        {
            bool pastIndex = false; ;// this variable tells us if we've gotten past the deletion
            string[] finalArray = new string[array.Length - 1]; // creates new array for result
            for (int i = 0; i < array.Length - 1; i++) // loops for the length of the array - 1 (because there's one less element), staring at 0 increasing by one
            {
                if (i == index)// if we;re at the place of deletion
                {
                    pastIndex = true; // we're past it
                }
                if (!pastIndex)// if we're not past the plcae of deletion
                {
                    finalArray[i] = array[i]; // fill as normal
                }
                else // otherwise
                {
                    finalArray[i] = array[i + 1];// the element would be equal to the element one index ahead in the original array
                }
            }
            return finalArray;
        }
    }
}
