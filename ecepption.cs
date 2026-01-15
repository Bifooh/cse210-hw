static void Main (string[] args){
    try
    {
        int numerator = 10;
        int denominator = 0;
        int result = numerator / denominator;
        Console.WriteLine($"Result: {result}");
    }
    catch (Exception e)
    {

        Console.WriteLine($"An error occurred: {e,toString()}");
    }
}