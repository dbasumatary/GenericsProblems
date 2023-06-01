namespace GenericsProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MinIntegers minIntegers = new MinIntegers();
            //minIntegers.FindMinInteger();

            //MinFloat minFloat = new MinFloat();
            //minFloat.FindMinFloat();

            //MinString minString = new MinString();
            //minString.FindMinString();

            //MinimumOfThree minimumOfThree = new MinimumOfThree();
            //minimumOfThree.FindMinimumOfThree<int>(14,26,12);
            //minimumOfThree.FindMinimumOfThree<float>(4.55f, 4.45f, 4.47f);
            //minimumOfThree.FindMinimumOfThree<string>("ab", "abd", "ac");

            Minimum<int> intObj = new Minimum<int>(3,6,4);
            intObj.TestMinimum<int>();

            Minimum<float> floatObj = new Minimum<float>(45.3f, 45.2f, 45.22f);
            floatObj.TestMinimum<float>();

            Minimum<string> stringObj = new Minimum<string>("hii", "hi", "hiii");
            stringObj.TestMinimum<string>();

            DeleteArray deleteArray = new DeleteArray();
            int[] intArray = new int[] {44,45,43,46};
            deleteArray.DeleteInt(intArray, 2);

            double[] doubleArray = new double[] { 23.4, 25.34, 76.4, 69.56, 48.31};
            deleteArray.DeleteDouble(doubleArray, 3);

            char[] charArray = new char[] { 'a', 'b', 'c', 'd' };
            deleteArray.DeleteChar(charArray, 1);

            DeleteArrayWithGenerics arrayWithGenerics = new DeleteArrayWithGenerics();
            arrayWithGenerics.DeleteMethods(intArray, 2);
            arrayWithGenerics.DeleteMethods(doubleArray, 3);
            arrayWithGenerics.DeleteMethods(charArray, 0);

        }
    }
}