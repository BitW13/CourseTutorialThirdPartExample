namespace ConsoleAppThirdPartFirstLecture.Common.Extensions
{
    public static class ArrayExtensions
    {
        public static bool EqualIntArrays(this int[] firstArray, int[] secondArray)
        {
            if (firstArray == null || secondArray == null)
            {
                return false;
            }

            if (firstArray.Length != secondArray.Length)
            {
                return false;
            }

            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
