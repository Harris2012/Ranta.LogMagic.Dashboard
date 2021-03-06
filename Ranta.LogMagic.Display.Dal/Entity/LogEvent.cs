﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ranta.LogMagic.Display.Dal.Entity
{
    /// <summary>
    /// 数据层实体
    /// </summary>
    public class LogEvent
    {
        /// <summary>
        /// 自增长编号，与业务无关
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 事件编号
        /// </summary>
        public Guid Guid { get; set; }

        /// <summary>
        /// 触发事件的应用程序编号
        /// </summary>
        public int AppId { get; set; }

        /// <summary>
        /// 事件级别
        /// </summary>
        public int LogTypeId { get; set; }

        /// <summary>
        /// 事件源，一般是触发事件的类
        /// </summary>
        public string Source { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 正文
        /// </summary>
        public string Content { get; set; }
    }
}
