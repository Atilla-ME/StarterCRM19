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
    
    public class Company : BaseObject
    { 
        public Company(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();  
        }


        string shippingAddress;
        string billingAddress;
        string phoneNumber;
        string website;
        string companyName;

        public string CompanyName
        {
            get => companyName;
            set => SetPropertyValue(nameof(CompanyName), ref companyName, value);
        }


        public string Website
        {
            get => website;
            set => SetPropertyValue(nameof(Website), ref website, value);
        }


        public string PhoneNumber
        {
            get => phoneNumber;
            set => SetPropertyValue(nameof(PhoneNumber), ref phoneNumber, value);
        }


        public string BillingAddress
        {
            get => billingAddress;
            set => SetPropertyValue(nameof(BillingAddress), ref billingAddress, value);
        }

        
        public string ShippingAddress
        {
            get => shippingAddress;
            set => SetPropertyValue(nameof(ShippingAddress), ref shippingAddress, value);
        }

    }
}