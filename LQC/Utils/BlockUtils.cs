using System;

namespace LQC.Utils
{
    public static class BlockUtils
    {
        public const long GbSize = 1073741824;
        public const int Package = 8192;
        public const int HashForFile = 128;

        public static Difficulty GetDifficulty()
        {
            Random rand = new Random();
            int sum = rand.Next(0, 31);

            Difficulty diff;

            if (sum >= 0 && sum <= 16 || sum >= 26)
                diff = Difficulty.E;
            else if (sum >= 15 && sum <= 20)
                diff = Difficulty.M;
            else if (sum >= 20 && sum <= 24)
                diff = Difficulty.H;
            else if (sum >= 24 && sum <= 26)
                diff = Difficulty.I;
            else
                diff = Difficulty.E;

            return diff;
        }

        public static long GetBlockSize(Difficulty diff)
        {
            Random rand = new Random();
            long size = GbSize;

            switch (diff)
            {
                case Difficulty.E:
                    size = rand.Next(1, 6) * GbSize;
                    break;
                case Difficulty.M:
                    size = rand.Next(6, 14) * GbSize;
                    break;
                case Difficulty.H:
                    size = rand.Next(14, 26) * GbSize;
                    break;
                case Difficulty.I:
                    size = rand.Next(30, 51) * GbSize;
                    break;
            }

            return size;
        }

        public static void SetBlockTasks(Block block)
        {
            int filesCount = Convert.ToInt32(block.Size / Package);
            long HashCount = filesCount * HashForFile;

            int generations = block.Difficulty switch
            {
                Difficulty.E => 32 * 
            };
        }
    }
}
