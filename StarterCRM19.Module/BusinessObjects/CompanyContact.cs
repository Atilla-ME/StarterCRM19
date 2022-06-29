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
    [ImageName("BO_Lead")]  //adds an in-built image to CompanyContacts visual
    [DefaultProperty("FullName")]  //Gives the specified property's value when the object is called. Default first property
 
    public class CompanyContact : BaseObject
    { 
        public CompanyContact(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            
        }


        Company company;
        string emailAddress;
        string phoneNumber;
        string lastName;
        string firstName;

        public string FirstName
        {
            get => firstName;
            set => SetPropertyValue(nameof(FirstName), ref firstName, value);
        }

        public string LastName
        {
            get => lastName;
            set => SetPropertyValue(nameof(LastName), ref lastName, value);
        }

        public string PhoneNumber
        {
            get => phoneNumber;
            set => SetPropertyValue(nameof(PhoneNumber), ref phoneNumber, value);
        }

        public string EmailAddress
        {
            get => emailAddress;
            set => SetPropertyValue(nameof(EmailAddress), ref emailAddress, value);
        }

        
        [Association("Company-CompanyContacts")]
        public Company Company
        {
            get => company;
            set => SetPropertyValue(nameof(Company), ref company, value);
        }

        [VisibleInDetailView(false)] //this property won't be shown on DetailView
        [VisibleInListView(false)]  //this property won't be shown on ListView
        public string FullName
        {
            get
            {
                return ObjectFormatter.Format("{FirstName} {LastName}", this, EmptyEntriesMode.RemoveDelimiterWhenEntryIsEmpty);
            }
        }
    }
}