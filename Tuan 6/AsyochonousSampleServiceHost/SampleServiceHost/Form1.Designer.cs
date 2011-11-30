namespace SampleServiceHost
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
            this.lbtrangthai = new System.Windows.Forms.Label();
            this.grbkieukn = new System.Windows.Forms.GroupBox();
            this.rdbasic = new System.Windows.Forms.RadioButton();
            this.rdws = new System.Windows.Forms.RadioButton();
            this.rdnet = new System.Windows.Forms.RadioButton();
            this.ckmex = new System.Windows.Forms.CheckBox();
            this.btnchay = new System.Windows.Forms.Button();
            this.btndung = new System.Windows.Forms.Button();
            this.grbkieukn.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbtrangthai
            // 
            this.lbtrangthai.AutoSize = true;
            this.lbtrangthai.Location = new System.Drawing.Point(17, 134);
            this.lbtrangthai.Name = "lbtrangthai";
            this.lbtrangthai.Size = new System.Drawing.Size(114, 13);
            this.lbtrangthai.TabIndex = 0;
            this.lbtrangthai.Text = "Không tìm thấy Server.";
            // 
            // grbkieukn
            // 
            this.grbkieukn.Controls.Add(this.rdnet);
            this.grbkieukn.Controls.Add(this.rdws);
            this.grbkieukn.Controls.Add(this.rdbasic);
            this.grbkieukn.Location = new System.Drawing.Point(13, 13);
            this.grbkieukn.Name = "grbkieukn";
            this.grbkieukn.Size = new System.Drawing.Size(130, 100);
            this.grbkieukn.TabIndex = 1;
            this.grbkieukn.TabStop = false;
            this.grbkieukn.Text = "Kiểu kết nối:";
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
            // ckmex
            // 
            this.ckmex.AutoSize = true;
            this.ckmex.Checked = true;
            this.ckmex.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckmex.Location = new System.Drawing.Point(169, 12);
            this.ckmex.Name = "ckmex";
            this.ckmex.Size = new System.Drawing.Size(79, 17);
            this.ckmex.TabIndex = 2;
            this.ckmex.Text = "Show MEX";
            this.ckmex.UseVisualStyleBackColor = true;
            // 
            // btnchay
            // 
            this.btnchay.Location = new System.Drawing.Point(165, 50);
            this.btnchay.Name = "btnchay";
            this.btnchay.Size = new System.Drawing.Size(75, 23);
            this.btnchay.TabIndex = 3;
            this.btnchay.Text = "Chạy";
            this.btnchay.UseVisualStyleBackColor = true;
            this.btnchay.Click += new System.EventHandler(this.btnchay_Click);
            // 
            // btndung
            // 
            this.btndung.Location = new System.Drawing.Point(165, 90);
            this.btndung.Name = "btndung";
            this.btndung.Size = new System.Drawing.Size(75, 23);
            this.btndung.TabIndex = 4;
            this.btndung.Text = "Dừng";
            this.btndung.UseVisualStyleBackColor = true;
            this.btndung.Click += new System.EventHandler(this.btndung_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 164);
            this.Controls.Add(this.btndung);
            this.Controls.Add(this.btnchay);
            this.Controls.Add(this.ckmex);
            this.Controls.Add(this.grbkieukn);
            this.Controls.Add(this.lbtrangthai);
            this.Name = "Form1";
            this.Text = "ServiceHost";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbkieukn.ResumeLayout(false);
            this.grbkieukn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbtrangthai;
        private System.Windows.Forms.GroupBox grbkieukn;
        private System.Windows.Forms.RadioButton rdnet;
        private System.Windows.Forms.RadioButton rdws;
        private System.Windows.Forms.RadioButton rdbasic;
        private System.Windows.Forms.CheckBox ckmex;
        private System.Windows.Forms.Button btnchay;
        private System.Windows.Forms.Button btndung;
    }
}

