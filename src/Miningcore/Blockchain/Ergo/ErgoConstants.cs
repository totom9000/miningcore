using System;
using System.Linq;
using System.Text.RegularExpressions;

// ReSharper disable InconsistentNaming

namespace Miningcore.Blockchain.Ergo
{
    public static class ErgoConstants
    {
        public const uint ShareMultiplier = 256;
	// Mod 20211102
	public static double Pow2x32 = Math.Pow(2, 32);
        public const decimal SmallestUnit = 1000000000;
        public static Regex RegexChain = new("ergo-([^-]+)-.+", RegexOptions.Compiled);

        public static byte[] M = Enumerable.Range(0, 1024)
            .Select(x => BitConverter.GetBytes((ulong) x).Reverse())
            .SelectMany(byteArr => byteArr)
            .ToArray();
    }
}