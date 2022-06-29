using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Win.Editors;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarterCRM19.Module.Win.Controllers
{
    public class GridCustomizationController : ViewController<ListView> //we want to effect listviews thus inherited from ViewController<ListView>
    {
        public GridCustomizationController()
        {

        }

        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();
            GridListEditor editor = View.Editor as GridListEditor;
            if(editor != null)
            {
                Font font = editor.GridView.Appearance.HeaderPanel.Font;
                editor.GridView.Appearance.HeaderPanel.Font = new Font(font, FontStyle.Bold);
            }
        }
    }
}
