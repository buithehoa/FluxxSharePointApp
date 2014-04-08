using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FluxxSharePointAppWeb.Pages {
  public partial class Default : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
      Uri hostWeb = new Uri("https://fluxxtest.packard.org/");
      string appOnlyAccessToken = TokenHelper.GetS2SAccessTokenWithWindowsIdentity(hostWeb, null);
      Response.Write(appOnlyAccessToken);
    }
  }
}
