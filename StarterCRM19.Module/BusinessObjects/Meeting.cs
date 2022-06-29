using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace StarterCRM19.Module.BusinessObjects
{
    [DefaultClassOptions]
    [MapInheritance(MapInheritanceType.ParentTable)]  //instead of creating a meeting table in sql, puts everything into the event table
    
    public class Meeting : Event
    { 
        public Meeting(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            
        }


        CompanyContact primaryContact;
        Company company;

        [ImmediatePostData]
        public Company Company
        {
            get => company;
            set => SetPropertyValue(nameof(Company), ref company, value);
        }
        
        [DataSourceProperty("Company.CompanyContacts")]  //creates the list to be selected from
        public CompanyContact PrimaryContact
        {
            get => primaryContact;
            set => SetPropertyValue(nameof(PrimaryContact), ref primaryContact, value);
        }

    }
}