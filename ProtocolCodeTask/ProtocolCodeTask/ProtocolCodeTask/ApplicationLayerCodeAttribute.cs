using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtocolCodeTask
{
    /// <summary>
    /// 应用层功能的特性类
    /// </summary>
    public class ApplicationLayerCodeAttribute : Attribute
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="Name">功能名称</param>
        /// <param name="ID">功能报文ID</param>
        public ApplicationLayerCodeAttribute(string Name, int ID)
            : this(Name, ID, 8) { }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="Name">功能名称</param>
        /// <param name="ID">功能报文ID</param>
        /// <param name="FrameHeadLength">功能报文帧头长度</param>
        public ApplicationLayerCodeAttribute(string Name, int ID, int FrameHeadLength)
        {
            this.Name = Name;
            this.ID = ID;
            this.bID = new byte[] { (byte)(ID & 0xFF), (byte)((ID >> 8) & 0xFF) };
            this.FrameHeadLength = FrameHeadLength;
        }

        /// <summary>
        /// 功能名称
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// 功能报文ID
        /// </summary>
        public int ID { get; private set; }
        /// <summary>
        /// 功能报文帧头长度
        /// </summary>
        public int FrameHeadLength { get; private set; }
        /// <summary>
        /// 功能报文ID在报文中的序列
        /// </summary>
        public byte[] bID { get; private set; }
    }
}
