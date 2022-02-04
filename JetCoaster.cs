using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testRC
{
    public class JetCoaster
    {
        public static int ride
            (int k, int[] g, int r)
        {
            //スタックの生成
            var stack = new Stack<int>();
            //キューの生成
            var queue = new Queue<int>();
            //リストの作成
            var list = new List<int>();
            
            //キューに配列を登録
            for(int i=0;i < g.Length; i++)
            {
                queue.Enqueue(g[i]);
            }

            for (int a = 0; a < r; a++)
            {
                int value = queue.Peek();

                while (value <= k)
                {
                    stack.Push(value);
                    //乗った人を最後尾にする
                    queue.Enqueue(queue.Dequeue());
                    value = stack.Peek() + queue.Peek();
                }

                list.Add(stack.Pop());
            }
            return list.Sum();
        }
    }
}
