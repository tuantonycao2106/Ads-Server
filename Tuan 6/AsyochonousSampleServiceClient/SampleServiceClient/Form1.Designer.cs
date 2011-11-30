namespace SampleServiceClient
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbkieukn = new System.Windows.Forms.GroupBox();
            this.rdnet = new System.Windows.Forms.RadioButton();
            this.rdws = new System.Windows.Forms.RadioButton();
            this.rdbasic = new System.Windows.Forms.RadioButton();
            this.btnketnoi = new System.Windows.Forms.Button();
            this.btnngatkn = new System.Windows.Forms.Button();
            this.txttinhtrang = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbtentacgia = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbtendetai = new System.Windows.Forms.RichTextBox();
            this.btnthongtin = new System.Windows.Forms.Button();
            this.grbkieukn.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbkieukn
            // 
            this.grbkieukn.Controls.Add(this.rdnet);
            this.grbkieukn.Controls.Add(this.rdws);
            this.grbkieukn.Controls.Add(this.rdbasic);
            this.grbkieukn.Location = new System.Drawing.Point(15, 19);
            this.grbkieukn.Name = "grbkieukn";
            this.grbkieukn.Size = new System.Drawing.Size(200, 100);
            this.grbkieukn.TabIndex = 0;
            this.grbkieukn.TabStop = false;
            this.grbkieukn.Text = "Kiểu kết nối";
            // 
            // rdnet
            // 
            this.rdnet.AutoSize = true;
            this.rdnet.Location = new System.Drawing.Point(7, 66);
            this.rdnet.Name = "rdnet";
            this.rdnet.Size = new System.Drawing.Size(98, 17);
            this.rdnet.TabIndex = 2;
            this.rdnet.Text = "NetTCPBinding";
            this.rdnet.UseVisualStyleBackColor = true;
            // 
            // rdws
            // 
            this.rdws.AutoSize = true;
            this.rdws.Location = new System.Drawing.Point(7, 43);
            this.rdws.Name = "rdws";
            this.rdws.Size = new System.Drawing.Size(98, 17);
            this.rdws.TabIndex = 1;
            this.rdws.Text = "WSHttpBinding";
            this.rdws.UseVisualStyleBackColor = true;
            // 
            // rdbasic
            // 
            this.rdbasic.AutoSize = true;
            this.rdbasic.Checked = true;
            this.rdbasic.Location = new System.Drawing.Point(7, 20);
            this.rdbasic.Name = "rdbasic";
            this.rdbasic.Size = new System.Drawing.Size(106, 17);
            this.rdbasic.TabIndex = 0;
            this.rdbasic.TabStop = true;
            this.rdbasic.Text = "BasicHttpBinding";
            this.rdbasic.UseVisualStyleBackColor = true;
            // 
            // btnketnoi
            // 
            this.btnketnoi.Location = new System.Drawing.Point(221, 39);
            this.btnketnoi.Name = "btnketnoi";
            this.btnketnoi.Size = new System.Drawing.Size(75, 23);
            this.btnketnoi.TabIndex = 1;
            this.btnketnoi.Text = "Kết nối";
            this.btnketnoi.UseVisualStyleBackColor = true;
            this.btnketnoi.Click += new System.EventHandler(this.btnketnoi_Click);
            // 
            // btnngatkn
            // 
            this.btnngatkn.Location = new System.Drawing.Point(221, 82);
            this.btnngatkn.Name = "btnngatkn";
            this.btnngatkn.Size = new System.Drawing.Size(75, 23);
            this.btnngatkn.TabIndex = 2;
            this.btnngatkn.Text = "Ngắt kết nối";
            this.btnngatkn.UseVisualStyleBackColor = true;
            this.btnngatkn.Click += new System.EventHandler(this.btnngatkn_Click);
            // 
            // txttinhtrang
            // 
            this.txttinhtrang.Location = new System.Drawing.Point(22, 126);
            this.txttinhtrang.Name = "txttinhtrang";
            this.txttinhtrang.ReadOnly = true;
            this.txttinhtrang.Size = new System.Drawing.Size(193, 20);
            this.txttinhtrang.TabIndex = 3;
            this.txttinhtrang.Text = "Không có kết nối.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grbkieukn);
            this.groupBox1.Controls.Add(this.txttinhtrang);
            this.groupBox1.Controls.Add(this.btnketnoi);
            this.groupBox1.Controls.Add(this.btnngatkn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 162);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tên tác giả:";
            // 
            // rtbtentacgia
            // 
            this.rtbtentacgia.Location = new System.Drawing.Point(12, 197);
            this.rtbtentacgia.Name = "rtbtentacgia";
            this.rtbtentacgia.Size = new System.Drawing.Size(314, 71);
            this.rtbtentacgia.TabIndex = 6;
            this.rtbtentacgia.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên đề tài:";
            // 
            // rtbtendetai
            // 
            this.rtbtendetai.Location = new System.Drawing.Point(9, 317);
            this.rtbtendetai.Name = "rtbtendetai";
            this.rtbtendetai.Size = new System.Drawing.Size(314, 73);
            this.rtbtendetai.TabIndex = 8;
            this.rtbtendetai.Text = "";
            // 
            // btnthongtin
            // 
            this.btnthongtin.Location = new System.Drawing.Point(205, 398);
            this.btnthongtin.Name = "btnthongtin";
            this.btnthongtin.Size = new System.Drawing.Size(118, 23);
            this.btnthongtin.TabIndex = 9;
            this.btnthongtin.Text = "Lấy thông tin";
            this.btnthongtin.UseVisualStyleBackColor = true;
            this.btnthongtin.Click += new System.EventHandler(this.btnthongtin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 433);
            this.Controls.Add(this.btnthongtin);
            this.Controls.Add(this.rtbtendetai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtbtentacgia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "ServiceClient";
            this.grbkieukn.ResumeLayout(false);
            this.grbkieukn.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbkieukn;
        private System.Windows.Forms.RadioButton rdnet;
        private System.Windows.Forms.RadioButton rdws;
        private System.Windows.Forms.RadioButton rdbasic;
        private System.Windows.Forms.Button btnketnoi;
        private System.Windows.Forms.Button btnngatkn;
        private System.Windows.Forms.TextBox txttinhtrang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbtentacgia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbtendetai;
        private System.Windows.Forms.Button btnthongtin;
    }
}

