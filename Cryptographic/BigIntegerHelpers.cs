using System.Numerics;

namespace Cryptographic
{
	internal static class BigIntegerHelpers
	{
		public static BigInteger Mod(this BigInteger num, BigInteger modulo)
		{
			BigInteger bigInteger = num % modulo;
			if (!(bigInteger < 0L))
			{
				return bigInteger;
			}
			return bigInteger + modulo;
		}
	}
}
