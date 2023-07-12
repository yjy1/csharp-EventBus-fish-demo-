using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 事件总线_EventBus
{
    //钓鱼竿的实现：
    /// <summary>
    /// 鱼竿（被观察者）
    /// </summary>
    public class FishingRod
    {
        public delegate void FishingHandler(FishType type); //声明委托
        public event FishingHandler FishingEvent; //声明事件

        public void ThrowHook(FishingMan man)
        {
            Console.WriteLine("开始下钩！");

            //用随机数模拟鱼咬钩，若随机数为偶数，则为鱼咬钩
            if (new Random().Next() % 2 == 0)
            {
                var type = (FishType)new Random().Next(0, 5);
                Console.WriteLine("铃铛：叮叮叮，鱼儿咬钩了");
                if (FishingEvent != null)
                    FishingEvent(type);
            }
        }
    }
}
