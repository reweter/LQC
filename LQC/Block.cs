using System;

namespace LQC
{
    public sealed class Block : IBlock
    {
        //The hash from which the block was generated
        public string GenesisHash { get; }
        public BlockTask[] Tasks { get; }
        public decimal Reward { get; }
        public Difficulty Difficulty { get; }
        public Wallet Miner { get; }
        public DateTime CreatedOn { get; }
        public IChecker[] Checks { get; }
        public long Size { get; } //bytes

        public Block(string genesisHash, BlockTask[] tasks, decimal reward, Difficulty difficulty, Wallet miner, IChecker[] checks, long size)
        {
            try
            {
                if (genesisHash.Length == 64)
                    GenesisHash = genesisHash;
                else
                    throw new ArgumentException("GenesisHash cannot be longer than 64 characters since it is SHA256", nameof(genesisHash));

                if (tasks.Length >= 30)
                    Tasks = tasks;
                else
                    throw new ArgumentException("tasks[] cannot contain less than 30 elements", nameof(tasks));

                if (reward > 0)
                    Reward = reward;
                else
                    throw new ArgumentException("The reward cannot be less than 0 or equal to 0", nameof(reward));

                if (size >= 1073741824)
                    Size = size;
                else
                    throw new ArgumentException("Size cannot be less than 1073741824 bytes (1 gb.)", nameof(size));

                Difficulty = difficulty;
                Miner = miner;
                Checks = checks;
            }
            catch (Exception)
            {
            }
        }
    }

}
