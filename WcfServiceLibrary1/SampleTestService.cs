using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace WcfServiceLibrary1
{
    [DataContract]
    public class Name
    {
        [DataMember]
        public string firstname;
        [DataMember]
        public string lastname;
    }

    [ServiceContract]
    public interface IName
    {
        [OperationContract]
        string UrNameIs(Name sample);
    }
    [ServiceBehavior(InstanceContextMode=InstanceContextMode.Single)]
    public class SampleTestService : IName
    {
        public string UrNameIs(Name sample)
        {
            return string.Format("My Name is {0} {1}", sample.firstname, sample.lastname);
        }
    }



}
