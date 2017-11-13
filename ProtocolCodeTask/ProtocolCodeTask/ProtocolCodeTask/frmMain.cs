using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProtocolCodeTask
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            ProtocolCode pc = new ProtocolCode();
            string ma = "001234554321";
            pc.MeterAddress = Common.HexStringToByteArray(ma).Reverse().ToArray();
            string dtd = "00010000";
            pc.DI3ToDI01 = Common.HexStringToByteArray(dtd).Reverse().ToArray();
            pc.FECount = 0;
            txt645Result.Text = Common.ByteArrayToHexString(pc.Get645());
        }

        private void btnApp_Click(object sender, EventArgs e)
        {
            ProtocolCode pc = new ProtocolCode();
            pc.AppLayerFunction = "集中器主动抄表";
            pc.ProtocolType = 2;
            pc.FrameNo = 1;
            pc.TimeOut = 15000;
            txtAppResult.Text = Common.ByteArrayToHexString(pc.GetAppLayer());
        }

        private void btnDataLinkLayer_Click(object sender, EventArgs e)
        {
            ProtocolCode pc = new ProtocolCode();
            pc.SNID = 1;
            pc.TargetTEI = "000000000000";
            pc.SourceTEI = "000000000000";
            pc.MSDUNo = 1;
            pc.RestartTime = 0;
            pc.RouteTotalTime = 0;
            pc.RouteRemainderTime = 0;
            pc.SendType = 0;
            pc.SendTime = 1;
            pc.BroadcastDirection = 0;
            pc.NetworkingNo = 1;
            pc.MSDUType = "0-网络管理消息";
            pc.SourceMAC = "000000000000";
            pc.TargetMAC = "000000000000";
            txtDataLinkLayerResult.Text = Common.ByteArrayToHexString(pc.GetDataLinkLayer());
        }
    }
}
