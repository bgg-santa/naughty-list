using System;

namespace NaughtyChecker
{
    class Program
    {
        private static byte[] naughtyList;

        static void Main(string[] args)
        {
            Console.WriteLine("Secret list: ");
            string rleB64 = Console.ReadLine();
            string b64 = decompressRle(rleB64);
            naughtyList = Convert.FromBase64String(b64);

            Console.WriteLine("Child name (or enter to quit): ");
            string childName = Console.ReadLine();
            while (childName != "")
            {
                bool maybeNaughty = IsProbablyNaughty(childName);
                Console.WriteLine("{0} is {1}", childName, maybeNaughty ? "probably naughty >:o" : "definitely nice! :D");
                Console.WriteLine("Child name (or enter to quit): ");
                childName = Console.ReadLine();
            }
        }

        static string decompressRle(string rleStr)
        {
            // TODO implement RLE decompression
            return rleStr;
        }

        static void AddToNaughtyList(string childName)
        {
            int hash = childName.GetHashCode() & 0x7FFFFFFF;
            byte bit = (byte)(1 << (hash & 7));
            naughtyList[hash % naughtyList.Length] |= bit;
        }

        static bool IsProbablyNaughty(string childName)
        {
            int hash = childName.GetHashCode() & 0x7FFFFFFF;
            byte bit = (byte)(1 << (hash & 7));
            return (naughtyList[hash % naughtyList.Length] & bit) != 0;
        }

    }
}
