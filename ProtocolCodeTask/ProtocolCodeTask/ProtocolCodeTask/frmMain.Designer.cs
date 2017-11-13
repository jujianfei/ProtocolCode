namespace ProtocolCodeTask
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTest = new System.Windows.Forms.Button();
            this.txt645Result = new System.Windows.Forms.TextBox();
            this.txtAppResult = new System.Windows.Forms.TextBox();
            this.btnApp = new System.Windows.Forms.Button();
            this.txtDataLinkLayerResult = new System.Windows.Forms.TextBox();
            this.btnDataLinkLayer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(203, 55);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(122, 23);
            this.btnTest.TabIndex = 0;
            this.btnTest.Text = "生成645报文";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // txt645Result
            // 
            this.txt645Result.Location = new System.Drawing.Point(26, 105);
            this.txt645Result.Name = "txt645Result";
            this.txt645Result.Size = new System.Drawing.Size(521, 21);
            this.txt645Result.TabIndex = 1;
            // 
            // txtAppResult
            // 
            this.txtAppResult.Location = new System.Drawing.Point(26, 217);
            this.txtAppResult.Name = "txtAppResult";
            this.txtAppResult.Size = new System.Drawing.Size(521, 21);
            this.txtAppResult.TabIndex = 3;
            // 
            // btnApp
            // 
            this.btnApp.Location = new System.Drawing.Point(203, 167);
            this.btnApp.Name = "btnApp";
            this.btnApp.Size = new System.Drawing.Size(122, 23);
            this.btnApp.TabIndex = 2;
            this.btnApp.Text = "生成应用层报文";
            this.btnApp.UseVisualStyleBackColor = true;
            this.btnApp.Click += new System.EventHandler(this.btnApp_Click);
            // 
            // txtDataLinkLayerResult
            // 
            this.txtDataLinkLayerResult.Location = new System.Drawing.Point(26, 332);
            this.txtDataLinkLayerResult.Name = "txtDataLinkLayerResult";
            this.txtDataLinkLayerResult.Size = new System.Drawing.Size(521, 21);
            this.txtDataLinkLayerResult.TabIndex = 5;
            // 
            // btnDataLinkLayer
            // 
            this.btnDataLinkLayer.Location = new System.Drawing.Point(203, 282);
            this.btnDataLinkLayer.Name = "btnDataLinkLayer";
            this.btnDataLinkLayer.Size = new System.Drawing.Size(122, 23);
            this.btnDataLinkLayer.TabIndex = 4;
            this.btnDataLinkLayer.Text = "生成数据链路层报文";
            this.btnDataLinkLayer.UseVisualStyleBackColor = true;
            this.btnDataLinkLayer.Click += new System.EventHandler(this.btnDataLinkLayer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 409);
            this.Controls.Add(this.txtDataLinkLayerResult);
            this.Controls.Add(this.btnDataLinkLayer);
            this.Controls.Add(this.txtAppResult);
            this.Controls.Add(this.btnApp);
            this.Controls.Add(this.txt645Result);
            this.Controls.Add(this.btnTest);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "测试用例";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.TextBox txt645Result;
        private System.Windows.Forms.TextBox txtAppResult;
        private System.Windows.Forms.Button btnApp;
        private System.Windows.Forms.TextBox txtDataLinkLayerResult;
        private System.Windows.Forms.Button btnDataLinkLayer;
    }
}

