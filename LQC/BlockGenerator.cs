using System.Threading;

namespace LQC
{
    public class BlockGenerator
    {
        private Block LastBlock { get; set; }
        public CancellationToken CancelToken { get; set; } = new CancellationTokenSource().Token;

        public void Process()
        {
            while (true)
            {
                if (!CancelToken.IsCancellationRequested)
                {

                }
                else
                    break;
            }
        }
    }
}
