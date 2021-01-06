using System;

namespace FindMaximumTask
{
    /// <summary>
    /// Class for operations with array.
    /// </summary>
    public static class ArrayExtension
    {
        /// <summary>
        /// Finds the element of the array with the maximum value.
        /// </summary>
        /// <param name="array"> Source array. </param>
        /// <returns>The element of the array with the maximum value.</returns>
        /// <exception cref="ArgumentNullException">Thrown when array is null.</exception>
        /// <exception cref="ArgumentException">Thrown when array is empty.</exception>
        public static int FindMaximum(int[] array)
        {
            if (array is null)
            {
                throw new ArgumentNullException($"Thrown when array is null. {nameof(array)}");
            }

            if (array.Length == 0)
            {
                throw new ArgumentException($"Thrown when array is empty. {nameof(array)}");
            }

            return Max(array, array.Length);
        }

        public static int Max(int[] array, int i)
        {
            if (array is null)
            {
                throw new ArgumentNullException($"Thrown when array is null. {nameof(array)}");
            }

            if (i == 1)
            {
                return array[0];
            }

            return Math.Max(array[i - 1], Max(array, i - 1));
        }
    }
}
