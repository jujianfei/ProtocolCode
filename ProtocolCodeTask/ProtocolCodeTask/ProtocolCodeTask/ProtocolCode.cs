using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtocolCodeTask
{
    public class ProtocolCode
    {
        public ProtocolCode()
        {
            this.meterAddress = new byte[] { 0x21, 0x43, 0x55, 0x34, 0x12, 0x00 };
            this.dI3ToDI0 = new byte[] { 0x33, 0x33, 0x34, 0x33 };
        }

        /// <summary>
        /// 645生成的报文结果
        /// </summary>
        private static byte[] result645 = Common.HexStringToByteArray("");

        /// <summary>
        /// 数据链路层生成的报文结果
        /// </summary>
        private static byte[] resultAppLayer = Common.HexStringToByteArray("");

        /// <summary>
        /// 应用层协议版本号(固定为1)6bits
        /// </summary>
        private string ApplicationLayerVersion = "000001";

        /// <summary>
        /// 配置字(抄表)4bits
        /// </summary>
        private string Config = "0000";

        /// <summary>
        /// 数据链路层协议版本号(固定为0)3bits
        /// </summary>
        private string DataLinkLayerVersion = "000";

        #region DL/T 645-2007配置参数

        private byte[] meterAddress;
        /// <summary>
        /// 电能表地址
        /// </summary>
        public byte[] MeterAddress
        {
            get { return meterAddress; }
            set { meterAddress = value; }
        }

        private byte[] dI3ToDI0;
        /// <summary>
        /// 数据标识(DI3-DI0)
        /// </summary>
        public byte[] DI3ToDI01
        {
            get { return dI3ToDI0; }
            set { dI3ToDI0 = value; }
        }

        private int fECount;
        /// <summary>
        /// 帧头FE数量
        /// </summary>
        public int FECount
        {
            get { return fECount; }
            set { fECount = value; }
        }

        #endregion

        #region 应用层配置参数

        private string appLayerFunction;
        /// <summary>
        /// 应用层功能
        /// </summary>
        public string AppLayerFunction
        {
            get { return appLayerFunction; }
            set { appLayerFunction = value; }
        }

        private int protocolType;
        /// <summary>
        /// 645规约类型
        /// </summary>
        public int ProtocolType
        {
            get { return protocolType; }
            set { protocolType = value; }
        }

        private int frameNo;
        /// <summary>
        /// 报文序列
        /// </summary>
        public int FrameNo
        {
            get { return frameNo; }
            set { frameNo = value; }
        }

        private int timeOut;
        /// <summary>
        /// 超时时间(ms)
        /// </summary>
        public int TimeOut
        {
            get { return timeOut; }
            set { timeOut = value; }
        }

        #endregion

        #region 数据链路层配置参数

        private int sNID;
        /// <summary>
        /// 短网络标识
        /// </summary>
        public int SNID
        {
            get { return sNID; }
            set { sNID = value; }
        }

        private string targetTEI;
        /// <summary>
        /// 原始目的TEI
        /// </summary>
        public string TargetTEI
        {
            get { return targetTEI; }
            set { targetTEI = value; }
        }

        private string sourceTEI;
        /// <summary>
        /// 原始源TEI
        /// </summary>
        public string SourceTEI
        {
            get { return sourceTEI; }
            set { sourceTEI = value; }
        }

        private int mSDUNo;
        /// <summary>
        /// MSDU序列号
        /// </summary>
        public int MSDUNo
        {
            get { return mSDUNo; }
            set { mSDUNo = value; }
        }

        private int restartTime;
        /// <summary>
        /// 重启次数
        /// </summary>
        public int RestartTime
        {
            get { return restartTime; }
            set { restartTime = value; }
        }

        private int routeTotalTime;
        /// <summary>
        /// 路由总跳数
        /// </summary>
        public int RouteTotalTime
        {
            get { return routeTotalTime; }
            set { routeTotalTime = value; }
        }

        private int routeRemainderTime;
        /// <summary>
        /// 路由剩余跳数
        /// </summary>
        public int RouteRemainderTime
        {
            get { return routeRemainderTime; }
            set { routeRemainderTime = value; }
        }

        private int sendType;
        /// <summary>
        /// 发送类型
        /// </summary>
        public int SendType
        {
            get { return sendType; }
            set { sendType = value; }
        }

        private int sendTime;
        /// <summary>
        /// 发送次数限值
        /// </summary>
        public int SendTime
        {
            get { return sendTime; }
            set { sendTime = value; }
        }

        private int broadcastDirection;
        /// <summary>
        /// 广播方向
        /// </summary>
        public int BroadcastDirection
        {
            get { return broadcastDirection; }
            set { broadcastDirection = value; }
        }

        private int networkingNo;
        /// <summary>
        /// 组网序列号
        /// </summary>
        public int NetworkingNo
        {
            get { return networkingNo; }
            set { networkingNo = value; }
        }

        private string mSDUType;
        /// <summary>
        /// MSDU类型
        /// </summary>
        public string MSDUType
        {
            get { return mSDUType; }
            set { mSDUType = value; }
        }

        private string targetMAC;
        /// <summary>
        /// 原始目的地址
        /// </summary>
        public string TargetMAC
        {
            get { return targetMAC; }
            set { targetMAC = value; }
        }

        private string sourceMAC;
        /// <summary>
        /// 原始源地址
        /// </summary>
        public string SourceMAC
        {
            get { return sourceMAC; }
            set { sourceMAC = value; }
        }

        private bool isContainMAC;
        /// <summary>
        /// MAC帧头中是否携带MAC地址
        /// </summary>
        public bool IsContainMAC
        {
            get { return isContainMAC; }
            set { isContainMAC = value; }
        }

        private bool isUseAgentMainPath;
        /// <summary>
        /// 当前报文是否根据代理主路径模式进行转发
        /// </summary>
        public bool IsUseAgentMainPath
        {
            get { return isUseAgentMainPath; }
            set { isUseAgentMainPath = value; }
        }

        private bool isRepairedPath;
        /// <summary>
        /// 本帧报文在传输中是否经过路径修复
        /// </summary>
        public bool IsRepairedPath
        {
            get { return isRepairedPath; }
            set { isRepairedPath = value; }
        }

        #endregion

        /// <summary>
        /// 获取生成的645报文
        /// </summary>
        /// <returns></returns>
        public byte[] Get645()
        {
            byte[] Answer = new byte[] { 0x68, 0x22, 0x00, 0x00, 0x00, 0x00, 0x00, 0x68, 0x11, 0x04 };
            //表地址
            for (int i = 0; i < 6; i++)
            {
                Answer[i + 1] = meterAddress[i];
                if (i < 4)
                    dI3ToDI0[i] += 0x33;
            }
            #region 《组645帧》
            List<byte> l_Answer = new List<byte>();
            //FE头
            for (int i = 0; i < FECount; i++)
                l_Answer.Add(0xFE);
            List<byte> l_Command = Answer.ToList<byte>();
            //数据区
            l_Command.AddRange(dI3ToDI0);
            //校验和与结束符
            l_Command.AddRange(new byte[] { Common.CalcCSCommon(l_Command.ToArray(), 0, l_Command.Count), 0x16 });
            l_Answer.AddRange(l_Command);
            Answer = l_Answer.ToArray();
            #endregion

            result645 = l_Answer.ToArray();
            return result645;
        }

        /// <summary>
        /// 获取生成的应用层报文
        /// </summary>
        /// <returns></returns>
        public byte[] GetAppLayer()
        {
            byte[] Cmd645 = result645;
            ApplicationLayerCode AppLayerCode = (ApplicationLayerCode)GetIndex(appLayerFunction);
            List<byte> l_Answer = new List<byte>();
            //报文端口号(固定为0x10)
            l_Answer.Add(0x10);
            //报文ID
            l_Answer.AddRange(AppLayerCode.GetbID());
            //报文控制字(默认为0)
            l_Answer.Add(0);

            #region 《应用层-抄表》

            StringBuilder sb = new StringBuilder();
            //协议版本号
            sb.Append(ApplicationLayerVersion);
            //帧头长度
            sb.Append(Convert.ToString(AppLayerCode.GetFrameHeadLength(), 2).PadLeft(6, '0'));
            //配置字
            sb.Append(Config);
            //转发数据规约类型
            sb.Append(Convert.ToString(protocolType, 2).PadLeft(4, '0'));
            //转发数据长度（数据区内容长度）
            sb.Append(Convert.ToString(Cmd645.Length, 2).PadLeft(12, '0'));
            l_Answer.AddRange(GetByteListByString(sb.ToString()));
            //报文序号
            int No = frameNo;
            l_Answer.AddRange(new byte[] { (byte)(No & 0xFF), (byte)((No >> 8) & 0xFF) });
            //设备超时时间
            byte to = (byte)(timeOut / 100);
            l_Answer.Add(to);
            //选项字
            l_Answer.Add(0);
            //数据区
            l_Answer.AddRange(result645);

            #endregion
            resultAppLayer = l_Answer.ToArray();
            return resultAppLayer;
        }

        /// <summary>
        /// 获取生成的数据链路层报文
        /// </summary>
        /// <returns></returns>
        public byte[] GetDataLinkLayer()
        {
            byte[] CmdAppLayer = resultAppLayer;
            List<byte> l_Answer = new List<byte>();

            #region 《数据链路层-MAC帧头》
            StringBuilder sb = new StringBuilder();
            //版本
            sb.Append(DataLinkLayerVersion);
            //短网络标识
            int SNID = sNID;
            string sSNID = Convert.ToString(SNID, 2).PadLeft(5, '0');
            sb.Append(sSNID.Substring(sSNID.Length - 5, 5));
            //原始目的TEI
            sb.Append(targetTEI.Substring(targetTEI.Length - 12, 12));
            //原始源TEI
            sb.Append(sourceTEI.Substring(sourceTEI.Length - 12, 12));
            l_Answer.AddRange(GetByteListByString(sb.ToString()));
            sb.Clear();
            //MSDU序列号
            int No = mSDUNo;
            l_Answer.AddRange(new byte[] { (byte)(No & 0xFF), (byte)((No >> 8) & 0xFF) });
            //MSDU长度
            sb.Append(Convert.ToString(CmdAppLayer.Length, 2).PadLeft(11, '0'));
            //重启次数
            sb.Append(Convert.ToString(restartTime, 2).PadLeft(4, '0'));
            //代理主路径
            sb.Append(isUseAgentMainPath ? "1" : "0");
            //路由总跳数
            sb.Append(Convert.ToString(routeTotalTime, 2).PadLeft(4, '0'));
            //路由剩余跳数
            sb.Append(Convert.ToString(routeRemainderTime, 2).PadLeft(4, '0'));
            //发送类型
            sb.Append(Convert.ToString(sendType, 2).PadLeft(3, '0'));
            //发送次数限值
            sb.Append(Convert.ToString(sendTime, 2).PadLeft(5, '0'));
            //广播方向
            sb.Append(Convert.ToString(broadcastDirection, 2).PadLeft(2, '0'));
            //路径修复标志
            sb.Append(isRepairedPath ? "1" : "0");
            //MAC地址标志
            sb.Append(isContainMAC ? "1" : "0");
            //保留
            sb.Append("0000");
            l_Answer.AddRange(GetByteListByString(sb.ToString()));
            sb.Clear();
            //组网序列号
            l_Answer.Add((byte)networkingNo);
            //MSDU类型
            l_Answer.Add(byte.Parse(mSDUType.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries)[0]));
            //保留
            l_Answer.Add(0);
            if (isContainMAC)
            {
                //原始目的地址
                for (int i = 0; i < 6; i++)
                    l_Answer.Add(Convert.ToByte(targetMAC.Substring(10 - i * 2, 2), 16));
                //原始源地址
                for (int i = 0; i < 6; i++)
                    l_Answer.Add(Convert.ToByte(sourceMAC.Substring(10 - i * 2, 2), 16));
            }
            #endregion

            //MSDU
            l_Answer.AddRange(CmdAppLayer);

            //CRC32校验
            CRC32Cls CRC = new CRC32Cls();
            ulong crc32 = CRC.GetCRC32Str(Common.ByteArrayToHexString(resultAppLayer));
            l_Answer.AddRange(new byte[] { (byte)(crc32 & 0xFF), (byte)((crc32 >> 8) & 0xFF), (byte)((crc32 >> 16) & 0xFF), (byte)((crc32 >> 24) & 0xFF) });

            return l_Answer.ToArray();

        }

        /// <summary>
        /// 通过二进制字符串获取byte列表
        /// </summary>
        /// <param name="Bits">二进制字符串(Length为8的整数倍)</param>
        /// <returns>byte列表</returns>
        private List<byte> GetByteListByString(string Bits)
        {
            List<byte> l_b = new List<byte>();
            for (int i = 0; i < Bits.Length; i += 8)
                l_b.Add(Convert.ToByte(Bits.Substring(i, 8), 2));
            return l_b;
        }

        /// <summary>
        /// 获取ApplicationLayerCode的索引
        /// </summary>
        public int GetIndex(string name)
        {
            List<string> l_Layer = new List<string>();
            Array Code = Enum.GetValues(typeof(ApplicationLayerCode));
            for (int i = 0; i < Code.Length; i++)
                l_Layer.Add(((ApplicationLayerCode)Code.GetValue(i)).GetName());
            int index = l_Layer.FindIndex(o => o == name);
            return index;
        }
    }
}
