using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;
using WcfServiceLibrary1;

namespace WCF_Console_Host
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost sh = new ServiceHost(typeof(SampleTestService));

            sh.AddServiceEndpoint(typeof(IName), new BasicHttpBinding(), "http://localhost:8733/Design_Time_Addresses/WcfServiceLibrary1/SampleTestService/basic");

            sh.AddServiceEndpoint(typeof(IName), new WSHttpBinding(), "http://localhost:8733/Design_Time_Addresses/WcfServiceLibrary1/SampleTestService/ws");

            sh.AddServiceEndpoint(typeof(IName), new NetTcpBinding(), "net.tcp://localhost:8734/Design_Time_Addresses/WcfServiceLibrary1/SampleTestService/");

            try
            {
                sh.Open();
                Console.WriteLine("Connection is opened...........");
                print(sh);
                Console.Read();
                sh.Close();
                Console.WriteLine("Connection is closing........");
                Console.Read();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                sh.Abort();

            }

        }

        static void print(ServiceHost s)
        {
            Console.WriteLine(s.Description.ServiceType);

            foreach(ServiceEndpoint se in   s.Description.Endpoints )
            {
                Console.WriteLine(se.Address);
                Console.ReadLine();
            }
        }

    }
}
