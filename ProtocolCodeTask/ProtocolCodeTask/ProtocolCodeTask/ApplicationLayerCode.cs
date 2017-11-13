using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtocolCodeTask
{
    /// <summary>
    /// 应用层功能码
    /// </summary>
    public enum ApplicationLayerCode
    {
        /// <summary>
        /// 集中器主动抄表
        /// </summary>
        [ApplicationLayerCodeAttribute("集中器主动抄表", 0x1, 8)]
        TerminalReadMeter = 0,

        /// <summary>
        /// 路由主动抄表
        /// </summary>
        [ApplicationLayerCodeAttribute("路由主动抄表", 0x2, 8)]
        RouteReadMeter = 1,

        /// <summary>
        /// 集中器主动并发抄表
        /// </summary>
        [ApplicationLayerCodeAttribute("集中器主动并发抄表", 0x3, 8)]
        TerminalConcurrentReadMeter = 2,

        /// <summary>
        /// 校时
        /// </summary>
        [ApplicationLayerCodeAttribute("校时", 0x4, 8)]
        Timing = 3,

        /// <summary>
        /// 通信测试
        /// </summary>
        [ApplicationLayerCodeAttribute("通信测试", 0x6)]
        CommunicationTest = 4,

        /// <summary>
        /// 事件上报
        /// </summary>
        [ApplicationLayerCodeAttribute("事件上报", 0x8)]
        EventReporting = 5,

        /// <summary>
        /// 查询从节点主动注册
        /// </summary>
        [ApplicationLayerCodeAttribute("查询从节点主动注册", 0x11)]
        QuerySlaveActiveRegistration = 6,

        /// <summary>
        /// 启动从节点主动注册
        /// </summary>
        [ApplicationLayerCodeAttribute("启动从节点主动注册", 0x12)]
        StartSlaveActiveRegistration = 7,

        /// <summary>
        /// 停止从节点主动注册
        /// </summary>
        [ApplicationLayerCodeAttribute("停止从节点主动注册", 0x13)]
        StopSlaveActiveRegistration = 8,

        /// <summary>
        /// 确认/否认
        /// </summary>
        [ApplicationLayerCodeAttribute("确认/否认", 0x20)]
        ConfirmOrDeny = 9,

        /// <summary>
        /// 数据汇集
        /// </summary>
        [ApplicationLayerCodeAttribute("数据汇集", 0x21)]
        DataGathering = 10,

        /// <summary>
        /// 开始升级
        /// </summary>
        [ApplicationLayerCodeAttribute("开始升级", 0x30)]
        StartUpgrade = 11,

        /// <summary>
        /// 停止升级
        /// </summary>
        [ApplicationLayerCodeAttribute("停止升级", 0x31)]
        StopUpgrade = 12,

        /// <summary>
        /// 传输文件数据
        /// </summary>
        [ApplicationLayerCodeAttribute("传输文件数据", 0x32)]
        TransferFileData = 13,

        /// <summary>
        /// 传输文件数据(单播转本地广播)
        /// </summary>
        [ApplicationLayerCodeAttribute("传输文件数据(单播转本地广播)", 0x33)]
        TransferFileDataByBroadcast = 14,

        /// <summary>
        /// 查询站点升级状态
        /// </summary>
        [ApplicationLayerCodeAttribute("查询站点升级状态", 0x34)]
        QuerySiteUpgradeStatus = 15,

        /// <summary>
        /// 执行升级
        /// </summary>
        [ApplicationLayerCodeAttribute("执行升级", 0x36)]
        ExecutiveUpgrade = 16,

        /// <summary>
        /// 查询站点信息
        /// </summary>
        [ApplicationLayerCodeAttribute("查询站点信息", 0x36)]
        QuerySiteInfomation = 17
    }

    /// <summary>
    /// 应用层功能码的枚举拓展函数类
    /// </summary>
    public static class ApplicationLayerCodeExtensions
    {
        /// <summary>
        /// 获取功能名称。
        /// </summary>
        /// <param name="Code">功能码</param>
        /// <returns>功能名称</returns>
        public static string GetName(this ApplicationLayerCode Code)
        {
            string Target = string.Empty;
            ApplicationLayerCodeAttribute attr = Common.GetEnumAttribute<ApplicationLayerCodeAttribute>(Code);
            if (attr == null)
                Target = "此功能码没有对应的功能名称";
            else
                Target = attr.Name;
            return Target;
        }

        /// <summary>
        /// 获取功能报文ID。
        /// </summary>
        /// <param name="Code">功能码</param>
        /// <returns>功能报文ID</returns>
        public static int GetID(this ApplicationLayerCode Code)
        {
            int Target = -1;
            ApplicationLayerCodeAttribute attr = Common.GetEnumAttribute<ApplicationLayerCodeAttribute>(Code);
            if (attr == null)
                Target = -1;
            else
                Target = attr.ID;
            return Target;
        }

        /// <summary>
        /// 获取功能报文ID在报文中的序列。
        /// </summary>
        /// <param name="Code">功能码</param>
        /// <returns>功能报文ID在报文中的序列</returns>
        public static byte[] GetbID(this ApplicationLayerCode Code)
        {
            byte[] Target = null;
            ApplicationLayerCodeAttribute attr = Common.GetEnumAttribute<ApplicationLayerCodeAttribute>(Code);
            if (attr == null)
                Target = null;
            else
                Target = attr.bID.Clone() as byte[];
            return Target;
        }

        /// <summary>
        /// 获取功能报文帧头长度。
        /// </summary>
        /// <param name="Code">功能码</param>
        /// <returns>功能报文帧头长度</returns>
        public static int GetFrameHeadLength(this ApplicationLayerCode Code)
        {
            int Target = -1;
            ApplicationLayerCodeAttribute attr = Common.GetEnumAttribute<ApplicationLayerCodeAttribute>(Code);
            if (attr == null)
                Target = -1;
            else
                Target = attr.FrameHeadLength;
            return Target;
        }
    }
}
