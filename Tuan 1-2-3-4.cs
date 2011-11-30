using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace Nhom18_MayChu
{
    public partial class Form1 : Form
    {
        bool serviceStarted = false;
        ServiceHost myhost = null;
        ServiceMetadataBehavior behavior;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnchay_Click(object sender, EventArgs e)
        {
            if (!serviceStarted)
            {
                Uri baseAddress;

                try
                {
                    if (rdbasic.Checked == true)
                    {
                        baseAddress = new Uri("http://localhost:8888/BasicHttpBinding");
                        BasicHttpBinding basic = new BasicHttpBinding();
                        basic.OpenTimeout = System.TimeSpan.Parse("00:00:30");
                        basic.CloseTimeout = System.TimeSpan.Parse("00:00:30");
                        basic.SendTimeout = System.TimeSpan.Parse("00:00:30");
                        basic.ReceiveTimeout = System.TimeSpan.Parse("00:00:30");
                        basic.MaxBufferPoolSize = 30000;
                        basic.MaxBufferSize = 30000;
                        basic.MaxReceivedMessageSize = 30000;
                        myhost = new ServiceHost(typeof(Service1), baseAddress);
                        myhost.AddServiceEndpoint(typeof(IService1), basic, baseAddress);

                        if (ckmex.Checked == true)
                        {
                            behavior = new ServiceMetadataBehavior();
                            behavior.HttpGetEnabled = true;
                            myhost.Description.Behaviors.Add(behavior);
                            behavior.HttpGetUrl = baseAddress;
                            myhost.AddServiceEndpoint(typeof(IMetadataExchange), basic, "MEX1");
                        }
                        myhost.Open();
                        lbtrangthai.Text = "Server đang chạy theo giao thức BasicHttpBinding";
                    }

                    if (rdws.Checked == true)
                    {
                        baseAddress = new Uri("http://localhost:8888/WSHttpBinding");
                        WSHttpBinding ws = new WSHttpBinding();
                        ws.CloseTimeout = System.TimeSpan.Parse("00:00:30");
                        ws.OpenTimeout = System.TimeSpan.Parse("00:00:30");
                        ws.ReceiveTimeout = System.TimeSpan.Parse("00:00:30");
                        ws.SendTimeout = System.TimeSpan.Parse("00:00:30");
                        ws.MaxBufferPoolSize = 30000;
                        ws.MaxReceivedMessageSize = 30000;
                        myhost = new ServiceHost(typeof(Service1), baseAddress);
                        myhost.AddServiceEndpoint(typeof(IService1), ws, baseAddress);

                        if (ckmex.Checked == true)
                        {
                            behavior = new ServiceMetadataBehavior();
                            behavior.HttpGetEnabled = true;
                            myhost.Description.Behaviors.Add(behavior);
                            behavior.HttpGetUrl = baseAddress;
                            myhost.AddServiceEndpoint(typeof(IMetadataExchange), ws, "MEX2");
                        }
                        myhost.Open();
                        lbtrangthai.Text = "Server đang chạy theo giao thức WSHttpBinding";
                    }

                    if (rdnet.Checked == true)
                    {
                        baseAddress = new Uri("net.tcp://localhost:8888/NetTCPBinding");
                        NetTcpBinding net = new NetTcpBinding();
                        net.CloseTimeout = System.TimeSpan.Parse("00:00:30");
                        net.OpenTimeout = System.TimeSpan.Parse("00:00:30");
                        net.SendTimeout = System.TimeSpan.Parse("00:00:30");
                        net.ReceiveTimeout = System.TimeSpan.Parse("00:00:30");
                        net.MaxBufferPoolSize = 30000;
                        net.MaxBufferSize = 30000;
                        net.MaxReceivedMessageSize = 30000;
                        myhost = new ServiceHost(typeof(Service1), baseAddress);
                        myhost.AddServiceEndpoint(typeof(IService1), net, baseAddress);
                        myhost.Open();
                        lbtrangthai.Text = "Server đang chạy theo giao thức NetTCPBinding";
                    }

                    pbtrangthai.Visible = true;
                    pbtrangthai.Style = ProgressBarStyle.Marquee;
                    pbtrangthai.MarqueeAnimationSpeed = 50;

                    serviceStarted = true;
                    grbkieukn.Enabled = false;
                    btndung.Enabled = true;
                    btnchay.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
