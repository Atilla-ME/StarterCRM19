using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Layout;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using StarterCRM19.Module.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StarterCRM19.Module.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class CreateMeetingFromCompanyController : ViewController
    {
        // Use CodeRush to create Controllers and Actions with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/403133/
        public CreateMeetingFromCompanyController()
        {
            InitializeComponent();
            // Target required Views (via the TargetXXX properties) and create their Actions.
        }
        protected override void OnActivated()
        {
            base.OnActivated();
            // Perform various tasks depending on the target View.
        }
        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();
            // Access and customize the target View control.
        }
        protected override void OnDeactivated()
        {
            // Unsubscribe from previously subscribed events and release other references and resources.
            base.OnDeactivated();
        }

        private void actionCreateMeeting_CustomizePopupWindowParams(object sender, CustomizePopupWindowParamsEventArgs e)
        {
            Company company = (Company)View.CurrentObject;  //Get the object from the view the application is in
            IObjectSpace objectSpace = View.ObjectSpace.CreateNestedObjectSpace();   //object space is the connection with db. 
            Meeting meeting = objectSpace.CreateObject<Meeting>();    //Create a meeting in the Objectspace
            meeting.Company = objectSpace.GetObject<Company>(company);   //Get the company from Objectspace using the object we got from the view. Assign the company to meeting's Company property 
            e.View = Application.CreateDetailView(objectSpace, meeting);   //application creates a view based on given ObjectSpace and object and shows as pop up window
        }
    }
}
