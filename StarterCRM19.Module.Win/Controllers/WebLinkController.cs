using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Win.Editors;
using DevExpress.XtraEditors;
using StarterCRM19.Module.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarterCRM19.Module.Win.Controllers
{
    public class WebLinkController : ViewController<DetailView>   //Want to create a controller over detail view thus inherited from ViewController<DetailView>
    {
        StringPropertyEditor websiteEditor;
        public WebLinkController()
        {
            TargetObjectType = typeof(Company);   //we want to effect the company detail view
        }

        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();

            websiteEditor = View.FindItem("Website") as StringPropertyEditor;    //Created a string editor to edit the website property of company

            if(websiteEditor?.Control != null)
            {
                websiteEditor.Control.Font = new Font(websiteEditor.Control.Font, FontStyle.Underline);    //make the font of the website underlined
                websiteEditor.Control.ForeColor = Color.Blue;   //make the font of the website blue
                websiteEditor.Control.DoubleClick += Control_DoubleClick;    //add double click event
            }
        }

        private void Control_DoubleClick(object sender, EventArgs e)
        {
            TextEdit edit = (TextEdit)sender;   //catch the sender
            Process.Start(edit.Text);    //make the link text work so the website opens
        }

        protected override void OnDeactivated()
        {
            if (websiteEditor?.Control != null)
            {
                websiteEditor.Control.DoubleClick -= Control_DoubleClick;
            }

                base.OnDeactivated();
        }
    }
}
