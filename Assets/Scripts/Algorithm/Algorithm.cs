using System;

namespace QTC
{
    public static class Algorithm
    {
        private static Random random = new Random(DateTime.Now.Millisecond); 
        
        /// 从 [1, N] 中等概率，随机地挑选 K 个整数
        public static int[] NChooseK(int N, int K)
        {
            var result = new int[K];
            if (N <= 0 || K > N)
            {
                for (var i = 0; i < result.Length; i++)
                {
                    result[i] = i + 1;
                }
                return result;
            }
            
            var selection = K;
            var remains = N;
            for (int i = 1; i < N+1; i++)
            {
                if (selection < 1)
                    break;

                if (random.Next(1, remains) <= selection)
                {
                    result[K - selection] = i;
                    selection--;
                }

                remains--;
            }

            return result;
        }
    }
}