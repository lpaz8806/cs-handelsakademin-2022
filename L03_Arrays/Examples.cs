namespace L03_Arrays;

static class Examples
{
    public static bool[] EratosthenesSieve(int max)
    {
        var isPrime = new bool[max + 1];
        
        Array.Fill(isPrime, true);  // Let's consider all numbers to
        isPrime[0] = isPrime[1] = false; // be primes except 0 and 1
        
        for (int i = 2; i < max; i++)   // 
        {
            if(!isPrime[i])
               continue;

            // each multiple of i (except i itself) up to max are
            // not primes, so we should mark them as false
            for (int k = 2; k * i < max; k++)
                isPrime[k * i] = false;
        }
        
        return isPrime;
    }
}