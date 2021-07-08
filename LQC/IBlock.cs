using System;

namespace LQC
{
    interface IBlock
    {
        public string GenesisHash { get; }
        public BlockTask[] Tasks { get; }
        public decimal Reward { get; }
        public Difficulty Difficulty { get; }
        public Wallet Miner { get; }
        public DateTime CreatedOn { get; }
        public IChecker[] Checks { get; }
        public long Size { get; } //bytes
    }
}
