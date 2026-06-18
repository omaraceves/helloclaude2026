public static class Operations
{
    public static int FloorLogOfN(int n)
    {
        //special cases
        //log base2 of n, when n = 0 is undefined, 2^??? = 0
        //log base2 of n, when n = 1 is 0, because 2^0 = 1
        if(n == 0) 
            throw new Exception("undefined");
        if(n == 1)
            return 0;

        var result = 0;
        result = RecursiveLogOfN(n, result);

        return result;
    }

    private static int RecursiveLogOfN(int n, int result)
    {
        if(n == 1)
            return result;

        result = result + 1;
        n = n/2;
        return RecursiveLogOfN(n, result);
    }
}