using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Sample_WCF.MyFirstWCFTestService;

namespace Sample_WCF
{
    public partial class DetailsToWCF : System.Web.UI.Page
    {
        NameClient client;
        Name p;
        protected void Page_Load(object sender, EventArgs e)
        {
            client = new NameClient("BasicHttpBinding_IName");
            p = new Name();
        }

        public void Display_result(Object sender,EventArgs e)
        {
            p.firstname = Fname.Value;
            p.lastname = Lname.Value;
            result.Text = client.UrNameIs(p);
        }
    }
}