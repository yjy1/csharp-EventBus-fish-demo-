﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 事件总线_EventBus
{
    public class EventData : IEventData
    {
        /// <summary>
        /// 事件发生的时间
        /// </summary>
        public DateTime EventTime { get; set; }

        /// <summary>
        /// 触发事件的对象
        /// </summary>
        public Object EventSource { get; set; }

        public EventData()
        {
            EventTime = DateTime.Now;
        }
    }
}
