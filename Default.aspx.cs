using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChangeImg
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /// <summary>
            /// Change images in an interval of days
            /// </summary>
            /// Author:     rapharma

            //Date setted according with _begindate.AddDays(2) of the "for"
            //Two days before the DateTime.Now.Date
            DateTime _vbegindate = new DateTime(2016, 07, 11);

            int count = 0;
            //This quantity of images depends of your folder
            int qtdimages = 6;
            //Setting images changes limit
            qtdimages += 1;

            for (DateTime _begindate = _vbegindate; _begindate.Date < DateTime.Now.Date; _begindate = _begindate.AddDays(2))
            {
                count += 1;
                //When limit of images in the folder is reached, it back to first image
                if (count == qtdimages)
                {
                    count = 1;
                }
            }
            Response.Write("<h1>Change images in an interval of days:</h1> ");
            Response.Write("<img src='imgs/image" + count + ".jpg'/>");
             

        }
    }
}