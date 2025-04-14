using ServiceStack.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Redis
{
    public class Program
    {
        static void Main(string[] args)
        {
            using(IRedisClient client=new RedisClient()) {

                for(int i = 0; i < 5000; i++)
                {
                client.Set<string>("test"+i,i.ToString());

                }
                    }
        }
    }
}
