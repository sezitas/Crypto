using System;
using System.Numerics;
using System.Windows.Forms;

namespace RSADemo
{
    public class PrimeGenerator
    {
        private Random randomGenerator = new Random();
        private const int MILLER_RABIN_ACCURACY = 64;
        private int[] lowPrimes = {3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97
                   , 101, 103, 107, 109, 113, 127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179
                   , 181, 191, 193, 197, 199, 211, 223, 227, 229, 233, 239, 241, 251, 257, 263, 269
                   , 271, 277, 281, 283, 293, 307, 311, 313, 317, 331, 337, 347, 349, 353, 359, 367
                   , 373, 379, 383, 389, 397, 401, 409, 419, 421, 431, 433, 439, 443, 449, 457, 461
                   , 463, 467, 479, 487, 491, 499, 503, 509, 521, 523, 541, 547, 557, 563, 569, 571
                   , 577, 587, 593, 599, 601, 607, 613, 617, 619, 631, 641, 643, 647, 653, 659, 661
                   , 673, 677, 683, 691, 701, 709, 719, 727, 733, 739, 743, 751, 757, 761, 769, 773
                   , 787, 797, 809, 811, 821, 823, 827, 829, 839, 853, 857, 859, 863, 877, 881, 883
                   , 887, 907, 911, 919, 929, 937, 941, 947, 953, 967, 971, 977, 983, 991, 997 };

        public PrimeGenerator()
        {

        }

        public BigInteger GeneratePrime(int bytesNum)
        {
            bool primeFound = false;
            BigInteger primeCandidate = -1;

            while (!primeFound)
            {
                do
                {
                    primeCandidate = GetRandomBigInteger(bytesNum);
                }
                while (primeCandidate < 2 || primeCandidate % 2 == 0);


                if (IsPrime(primeCandidate, bytesNum))
                {
                    primeFound = true;
                    break;
                }
            }
            return primeCandidate;
        }

        private bool IsPrime(BigInteger primeCandidate, int bytesNum)
        {
            if (primeCandidate % 2 != 0)
            {
                foreach (int i in lowPrimes)
                {
                    if (primeCandidate == i)
                        return true;
                    if (primeCandidate % i == 0)
                        return false;
                }
                return MillerRabinTest(primeCandidate, bytesNum, MILLER_RABIN_ACCURACY);
            }
            return false;

        }

        private bool MillerRabinTest(BigInteger primeCandidate, int bytesNum, int accuracy)
        {
            int powOfTwo = 0;
            BigInteger m = primeCandidate - 1;
            BigInteger t;

            while (m % 2 == 0)
            {
                powOfTwo++;
                m /= 2;
            }

            t = m;

            while (accuracy > 0)
            {
                bool continueWitness = false;
                accuracy--;

                BigInteger a = GetRandomBigInteger(bytesNum);

                if (primeCandidate < 0)
                {
                    primeCandidate = -primeCandidate;
                }

                while ((2 > a) || (a > m - 2))
                {
                    a = GetRandomBigInteger(bytesNum);

                    if (primeCandidate < 0)
                    {
                        primeCandidate = -primeCandidate;
                    }
                }

                BigInteger x = RepeatedSquaringExp(a, t, primeCandidate);

                if ((1 == x) || (primeCandidate - 1 == x))
                {
                    continue;
                }

                int r = powOfTwo;

                do
                {
                    x = (x * x) % primeCandidate;

                    if (1 == x)
                    {
                        return false;
                    }

                    if (primeCandidate - 1 == x)
                    {
                        continueWitness = true;
                        break;
                    }

                    r -= 1;

                } while (r - 1 > 0);

                if (true == continueWitness)
                {
                    continue;
                }

                return false;

            }

            return true;
        }

        public BigInteger GetRandomBigInteger(int bytesNum)
        {
            byte[] randomInts = new byte[bytesNum];

            randomGenerator.NextBytes(randomInts);

            return new BigInteger(randomInts);
        }

        public BigInteger RepeatedSquaringExp(BigInteger x, BigInteger y, BigInteger mod)
        {
            BigInteger result = 1;

            if (y == 0)
            {
                return 1;
            }

            while (y != 1)
            {
                if (0 == y % 2)
                {
                    x = (x * x) % mod;
                    y = y / 2;
                }
                else
                {
                    result = (result * x) % mod;
                    y = y - 1;
                }
            }

            return (result * x) % mod;
        }

        public BigInteger RepeatedSquaringExp(BigInteger x, BigInteger y)
        {
            BigInteger result = 1;

            if (y == 0)
            {
                return 1;
            }

            while (y != 1)
            {
                if (0 == y % 2)
                {
                    x = (x * x);
                    y = y / 2;
                }
                else
                {
                    result = (result * x);
                    y = y - 1;
                }
            }

            return (result * x);
        }

        public BigInteger GCD(BigInteger x, BigInteger y)
        { 
                BigInteger d = x;
                BigInteger i = y;
                BigInteger r;

                while (i != 0)
                {
                    r = d % i;
                    d = i;
                    i = r;
                }

                return d;

        }
    }
}