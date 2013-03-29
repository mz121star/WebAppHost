namespace WebAppHost
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblstatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.webKitBrowser1 = new WebKit.WebKitBrowser();
            this.choosebtn = new System.Windows.Forms.ToolStripSplitButton();
            this.iEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webkitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblstatus,
            this.choosebtn});
            this.statusStrip1.Location = new System.Drawing.Point(0, 541);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(698, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblstatus
            // 
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(0, 17);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 22);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(698, 541);
            this.webBrowser1.TabIndex = 1;
            // 
            // webKitBrowser1
            // 
            this.webKitBrowser1.BackColor = System.Drawing.Color.White;
            this.webKitBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webKitBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webKitBrowser1.Name = "webKitBrowser1";
            this.webKitBrowser1.Size = new System.Drawing.Size(698, 541);
            this.webKitBrowser1.TabIndex = 2;
            this.webKitBrowser1.Url = new System.Uri("about:blank", System.UriKind.Absolute);
            // 
            // choosebtn
            // 
            this.choosebtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.choosebtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.webkitToolStripMenuItem,
            this.iEToolStripMenuItem});
            this.choosebtn.Image = ((System.Drawing.Image)(resources.GetObject("choosebtn.Image")));
            this.choosebtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.choosebtn.Name = "choosebtn";
            this.choosebtn.Size = new System.Drawing.Size(71, 20);
            this.choosebtn.Text = "选择内核";
            // 
            // iEToolStripMenuItem
            // 
            this.iEToolStripMenuItem.Name = "iEToolStripMenuItem";
            this.iEToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.iEToolStripMenuItem.Text = "IE";
            this.iEToolStripMenuItem.Click += new System.EventHandler(this.iEToolStripMenuItem_Click);
            // 
            // webkitToolStripMenuItem
            // 
            this.webkitToolStripMenuItem.Name = "webkitToolStripMenuItem";
            this.webkitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.webkitToolStripMenuItem.Text = "webkit";
            this.webkitToolStripMenuItem.Click += new System.EventHandler(this.webkitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 563);
            this.Controls.Add(this.webKitBrowser1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblstatus;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStripSplitButton choosebtn;
        private System.Windows.Forms.ToolStripMenuItem webkitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iEToolStripMenuItem;
        private WebKit.WebKitBrowser webKitBrowser1;
    }
}

