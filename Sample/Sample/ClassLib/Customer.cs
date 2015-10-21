using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Sample.ClassLib
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public DataTable EmployeeTable { get; set; }
    }

    public class Customer
    {
        [Required(ErrorMessage= "Missing First Name")]        
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Missing Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage="Missing Middle Initial")]
        public string MiddleInitial { get; set; }

        [Required(ErrorMessage="Missing Social Security Number")]
        [RegularExpression(@"^(\d{3}-?\d{2}-?\d{4}|XXX-XX-XXXX)$", ErrorMessage="Social Security Number is not in the correct format. Please ensure that is in XXX-XX-XXXX format.")]
        public string SSN { get; set; }

        [Required(ErrorMessage="Missing Date of Birth")]
        [RegularExpression(@"^(0[1-9]|1[012])/([123]0|[012][1-9]|31)/(19[0-9]{2}|2[0-9]{3})$", ErrorMessage="Invalid Date. Please ensure that date is in MM/DD/YYYY format.")]
        public string DOB { get; set; }

        [Required(ErrorMessage="Missing Customer's Address")]
        public string Address { get; set; }
        
        [Required(ErrorMessage="Missing Customer's Town")]
        public string Town { get; set; }

        [Required(ErrorMessage="Missing State")]
        public string State { get; set; }

        [Required(ErrorMessage="Missing Zip Code")]
        [RegularExpression(@"([0-9]{5})", ErrorMessage="Zip code is not in correct format. Please ensure that it is five digits long and is all numeric.")]
        public string ZipCode { get; set; }
        
        [Required(ErrorMessage = "Missing County")]
        public string County { get; set; }

        [Required(ErrorMessage = "Missing Phone Number")]
        [RegularExpression(@"^(\d{3}-?\d{3}-?\d{4}|XXX-XXX-XXXX)", ErrorMessage = "Phone Number is not in the correct format. Please ensure that is in XXX-XXX-XXXX format.")]
        public string PhoneNumber { get; set; }

        public string SpouseFirst { get; set; }


        public string SpouseLast { get; set; }

        public string Notes { get; set; }

        public DataTable dt { get; set; }
        public string StoredProcResult { get; set; }
        public int CustomerID { get; set; }
        public int ID { get; set; }
    }

    public class Policy
    {
        [Required(ErrorMessage = "Missing Policy Number")]
        public string PolicyNumber { get; set; }

        [Required(ErrorMessage = "Missing Customer's Age at Issue")]
        public string AgeAtIssue { get; set; }
        public DateTime DateWritten { get; set; }
        public DateTime DateEffective { get; set; }

        [Required(ErrorMessage = "Missing Policy Status")]
        public string PolicyStatus { get; set; }
        public int CompanyID { get; set; }
        public int PolicyTypeID { get; set; }
        public int PolicyID { get; set; }

        [Required(ErrorMessage = "Missing Policy Holder")]
        public string PolicyHolder { get; set; }

        [Required(ErrorMessage = "Missing Commission Percentage")]
        public double CommissionPercentage { get; set; }

        [Required(ErrorMessage = "Missing Renewal")]
        public double Renewal { get; set; }

        [Required(ErrorMessage = "Missing Billing Period")]
        public string Billing { get; set; }

        [Required(ErrorMessage = "Missing Premium")]
        public double Premium { get; set; }

        [Required(ErrorMessage = "Missing Initial Percentage")]
        public double InitialPercentage { get; set; }

        public DataTable PolicyList { get; set; }
        public DataTable CompanyName { get; set; }
        public DataTable PolicyType { get; set; }
    }

    public class AlternateContact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Relationship { get; set; }
        public string PhoneNumber { get; set; }
        public int AltContactID { get; set; }
        public DataTable AltContactDT { get; set; }
    }

    public class Company
    {
        public string CompanyName { get; set; }
        public string CompanyContactNumber { get; set; }
        public int CompanyID { get; set; }
        public DataTable CompanyTable { get; set; }
    }

    public class PolicyType
    {
        public string PolicyTypeName { get; set; }
        public string PolicyTypeDesc { get; set; }
        public int PolicyTypeID { get; set; }
        public DataTable PolicyTypeTable { get; set; }
    }

    public class Medicare
    {
        public string MedicareCard { get; set; }
        public string MedicareDateA { get; set; }
        public string MedicareDateB { get; set; }
        public bool Add { get; set; }
    }

    public class Reports
    {
        public PolicyTypeList[] policyTypeCount;
    }

    public class PolicyTypeList
    {
        public string PolicyTypeName { get; set; }
        public string PolicyTypeDesc { get; set; }
        public int PolicyTypeID { get; set; }
        public int PolicyTypeCount { get; set; }
    }
}