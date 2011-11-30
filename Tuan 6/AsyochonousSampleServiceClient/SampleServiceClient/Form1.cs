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
using SampleServiceHost;
using System.Threading;

namespace SampleServiceClient
{
    public partial class Form1 : Form
    {
        IService1 service = null;
        static EndpointAddress address;
        static ChannelFactory<IService1> factory;
        bool checkConnect;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnketnoi_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdbasic.Checked == true)
                {
                    address = new EndpointAddress(new Uri("http://localhost:8888/BasicHttpBinding"));
                    factory = new ChannelFactory<IService1>(new System.ServiceModel.BasicHttpBinding(), address);
                    service = factory.CreateChannel();
                    checkConnect = service.checkServer();
                }
                else if (rdws.Checked == true)
                {
                    address = new EndpointAddress(new Uri("http://localhost:8888/WSHttpBinding"));
                    factory = new ChannelFactory<IService1>(new WSHttpBinding(), address);
                    service = factory.CreateChannel();
                    checkConnect = service.checkServer();
                }
                else if (rdnet.Checked == true)
                {
                    address = new EndpointAddress(new Uri("net.tcp://localhost:8888/NetTcpBinding"));
                    factory = new ChannelFactory<IService1>(new NetTcpBinding(), address);
                    service = factory.CreateChannel();
                    checkConnect = service.checkServer();
                }
                if(checkConnect = service.checkServer())
                {
                    txttinhtrang.Text = "Đã kết nối với Server!";
                    btnngatkn.Focus();
                    grbkieukn.Enabled = false;
                    btnketnoi.Enabled = false;
                    btnngatkn.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                txttinhtrang.Text = "Lỗi kết nối!";
            }
        }

        private void btnngatkn_Click(object sender, EventArgs e)
        {
            service = null;
            txttinhtrang.Text = "Ngắt kết nối!";
            grbkieukn.Enabled = true;
            btnketnoi.Enabled = true;
            btnngatkn.Enabled = false;
        }

        void ThreadLayThongTin()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            rtbtentacgia.Text = service.GetAuthours();
            rtbtendetai.Text = service.GetProjectName();
        }
        private void btnthongtin_Click(object sender, EventArgs e)
        {
            if (checkConnect)
            {
                rtbtentacgia.Text = "Đang thực hiện...";
                rtbtendetai.Text = "Đang thực hiện...";
                Thread tacgia = new Thread(ThreadLayThongTin);
                tacgia.Start();
            }
            else
            {
                MessageBox.Show("Chưa kết nối tới server.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
