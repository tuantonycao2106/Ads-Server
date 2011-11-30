using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;

namespace SampleServiceHost
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public bool checkServer()
        {
            return true;
        }
        
        public string GetAuthours()
        {
            Thread.Sleep(5000);
            return "1.Cao Quốc Tuấn \n2.Lê Thanh Tùng";
        }

        public string GetProjectName()
        {
            Thread.Sleep(5000);
            return "Dịch vụ cung cấp thông tin quảng cáo";
        }
    }
}
