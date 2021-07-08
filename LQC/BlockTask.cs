using System;

namespace LQC
{
    public sealed class BlockTask : IChecker
    {
        public int Index { get; }
        public string Value { get; }

        public BlockTask(int index, string value)
        {
            try
            {
                if (index < 8192)
                    Index = index;
                else
                    throw new ArgumentException("The index cannot be greater than or equal to 8192", nameof(Index));

                Value = value;
            }
            catch (Exception)
            {
            }
        }
    }
}
