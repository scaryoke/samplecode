using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using Sample.ClassLib;

namespace Sample.ClassLib.Repository
{
    #region Customer
    public class CustomerRepository : BaseRepository
    {
        public string AddCustomer(Customer customer)
        {
            SqlCommand cmd = new SqlCommand("sp_AddCustomer");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@SSN", customer.SSN));
            cmd.Parameters.Add(new SqlParameter("@FirstName", customer.FirstName));
            cmd.Parameters.Add(new SqlParameter("@LastName", customer.LastName));
            cmd.Parameters.Add(new SqlParameter("@MiddleInitial", customer.MiddleInitial));
            cmd.Parameters.Add(new SqlParameter("@PhoneNumber", customer.PhoneNumber));
            cmd.Parameters.Add(new SqlParameter("@DateofBirth", customer.DOB));
            cmd.Parameters.Add(new SqlParameter("@Street", customer.Address));
            cmd.Parameters.Add(new SqlParameter("@City", customer.Town));
            cmd.Parameters.Add(new SqlParameter("@State", customer.State));
            cmd.Parameters.Add(new SqlParameter("@ZipCode", customer.ZipCode));
            cmd.Parameters.Add(new SqlParameter("@County", customer.County));
            cmd.Parameters.Add(new SqlParameter("@CustomerNotes", customer.Notes));
            cmd.Parameters.Add(new SqlParameter("@SpousefName", customer.SpouseFirst));
            cmd.Parameters.Add(new SqlParameter("@SpouselName", customer.SpouseLast));
            SqlParameter param = new SqlParameter("@CustomerKey", SqlDbType.Int);
            param.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(param);

            String Temp = ExecuteNonQuery(cmd);
            AppData.Instance.customer.CustomerID = Convert.ToInt32(cmd.Parameters["@CustomerKey"].Value);
            return Temp;
        }

        public void UpdateCustomer(Customer customer)
        {
            SqlCommand cmd = new SqlCommand("sp_UpdateCustomer");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@SSN", customer.SSN));
            cmd.Parameters.Add(new SqlParameter("@FirstName", customer.FirstName));
            cmd.Parameters.Add(new SqlParameter("@LastName", customer.LastName));
            cmd.Parameters.Add(new SqlParameter("@MiddleInitial", customer.MiddleInitial));
            cmd.Parameters.Add(new SqlParameter("@PhoneNumber", customer.PhoneNumber));
            cmd.Parameters.Add(new SqlParameter("@DateofBirth", customer.DOB));
            cmd.Parameters.Add(new SqlParameter("@Street", customer.Address));
            cmd.Parameters.Add(new SqlParameter("@City", customer.Town));
            cmd.Parameters.Add(new SqlParameter("@State", customer.State));
            cmd.Parameters.Add(new SqlParameter("@ZipCode", customer.ZipCode));
            cmd.Parameters.Add(new SqlParameter("@County", customer.County));
            cmd.Parameters.Add(new SqlParameter("@CustomerNotes", customer.Notes));
            cmd.Parameters.Add(new SqlParameter("@SpousefName", customer.SpouseFirst));
            cmd.Parameters.Add(new SqlParameter("@SpouselName", customer.SpouseLast));
            cmd.Parameters.Add(new SqlParameter("@PrimaryKey", customer.ID));

            ExecuteNonQuery(cmd);
        }

        public DataTable SearchCustomer(string SpName, string searchVal)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            switch (SpName)
            {
                case "LastName":
                    cmd.CommandText = "sp_SearchCustomer";
                    break;
            }
            cmd.Parameters.Add(new SqlParameter("@SearchValue", string.Format("%{0}%", searchVal)));

            AppData.Instance.customer.dt = ExecuteNonQueryReturn(cmd);

            return OrderResults(AppData.Instance.customer.dt);
        }

        private DataTable OrderResults(DataTable dt)
        {
            DataTable dataTable = new DataTable();
            DataRow WorkRow;
            dataTable.Columns.Add(new DataColumn("First Name", typeof(string)));
            dataTable.Columns.Add(new DataColumn("Last Name", typeof(string)));
            dataTable.Columns.Add(new DataColumn("City", typeof(string)));
            dataTable.Columns.Add(new DataColumn("County", typeof(string)));
            foreach (DataRow row in dt.Rows)
            {
                WorkRow = dataTable.NewRow();
                WorkRow["First Name"] = row["CustomerFirstName"].ToString();
                WorkRow["Last Name"] = row["CustomerLastName"].ToString();
                WorkRow["City"] = row["City"].ToString();
                WorkRow["County"] = row["County"].ToString();
                dataTable.Rows.Add(WorkRow);
            }

            return dataTable;
        }
    }

    #endregion

    #region Alternate Contact
    public class AlternateContactRepository : BaseRepository
    {
        public string AddAltContact(AlternateContact altContact, int CustomerID)
        {
            SqlCommand cmd = new SqlCommand("sp_AddAlternateContact");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@FirstName", altContact.FirstName));
            cmd.Parameters.Add(new SqlParameter("@LastName", altContact.LastName));
            cmd.Parameters.Add(new SqlParameter("@Relationship", altContact.Relationship));
            cmd.Parameters.Add(new SqlParameter("@PhoneNumber", altContact.PhoneNumber));
            cmd.Parameters.Add(new SqlParameter("@CustomerID", CustomerID));

            return ExecuteNonQuery(cmd);
        }

        public string UpdateAltContact(AlternateContact altContact, int CustomerID)
        {
            SqlCommand cmd = new SqlCommand("sp_UpdateAlternateCustomer");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@FirstName", altContact.FirstName));
            cmd.Parameters.Add(new SqlParameter("@LastName", altContact.LastName));
            cmd.Parameters.Add(new SqlParameter("@Relationship", altContact.Relationship));
            cmd.Parameters.Add(new SqlParameter("@PhoneNumber", altContact.PhoneNumber));
            cmd.Parameters.Add(new SqlParameter("@CustomerID", CustomerID));

            return ExecuteNonQuery(cmd);
        }

        public DataTable GetAltContact(int CustomerID)
        {
            SqlCommand cmd = new SqlCommand("sp_GetAlternateContact");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@CustomerID", CustomerID));

            AppData.Instance.AltContact.AltContactDT = ExecuteNonQueryReturn(cmd);
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("First Name", typeof(string)));
            dt.Columns.Add(new DataColumn("Last Name", typeof(string)));
            dt.Columns.Add(new DataColumn("Phone Number", typeof(string)));
            DataRow WorkRow;
            foreach (DataRow row in AppData.Instance.AltContact.AltContactDT.Rows)
            {
                WorkRow = dt.NewRow();
                WorkRow["First Name"] = row["AltFirstName"].ToString();
                WorkRow["Last Name"] = row["AltLastName"].ToString();
                WorkRow["Phone Number"] = row["AltPhone"].ToString();
                dt.Rows.Add(WorkRow);

            }

            return dt;
        }
    }
    #endregion

    #region Medicare
    public class MedicareRepository : BaseRepository
    {
        public string AddMedicare(Medicare medicare, int CustomerID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_AddMedicare");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MedicareCardNumber", medicare.MedicareCard));
                cmd.Parameters.Add(new SqlParameter("@MedicareA_DateEnrolled", medicare.MedicareDateA));
                cmd.Parameters.Add(new SqlParameter("@MedicareB_DateEnrolled", medicare.MedicareDateB));
                cmd.Parameters.Add(new SqlParameter("@Customer_ID", CustomerID));

                return ExecuteNonQuery(cmd);
            }
            catch (Exception ex)
            {
                return "Sorry, the system is down right now. Please contact your system administrator.";
            }
        }

        public DataTable GetMedicare(int CustomerID)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("sp_GetMedicare");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@CustomerID", CustomerID));

                dt = ExecuteNonQueryReturn(cmd);
            }
            catch (Exception ex)
            {

            }

            return dt;
        }

        public string UpdateMedicare(Medicare medicare, int CustomerID)
        {
            string result = "";
            try
            {
                SqlCommand cmd = new SqlCommand("sp_UpdateMedicare");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MedicareCardNumber", medicare.MedicareCard));
                cmd.Parameters.Add(new SqlParameter("@MedicareA_DateEnrolled", medicare.MedicareDateA));
                cmd.Parameters.Add(new SqlParameter("@MedicareB_DateEnrolled", medicare.MedicareDateB));
                cmd.Parameters.Add(new SqlParameter("@Customer_ID", CustomerID));

                result = ExecuteNonQuery(cmd);
            }
            catch (Exception ex)
            {
                result = "Sorry, the system is down right now. Please contact your system administrator.";
            }
            return result;
        }
    }
    #endregion

    #region Policy
    public class PolicyRepository : BaseRepository
    {
        public DataTable GetCompanies()
        {
            SqlCommand cmd = new SqlCommand("sp_GetCompanies");
            cmd.CommandType = CommandType.StoredProcedure;

            return ExecuteNonQueryReturn(cmd);
        }

        public DataTable GetPolicies(int customerID)
        {
            SqlCommand cmd = new SqlCommand("sp_GetCustomerPolicies");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@CustomerID", customerID));
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("Policy Number", typeof(string)));
            dt.Columns.Add(new DataColumn("Policy Type", typeof(string)));
            AppData.Instance.policy.PolicyList = ExecuteNonQueryReturn(cmd);

            SqlCommand cmd1 = new SqlCommand("sp_GetPolicyTypes");
            cmd1.CommandType = CommandType.StoredProcedure;

            AppData.Instance.policy.PolicyType = ExecuteNonQueryReturn(cmd1);

            DataRow WorkRow;

            foreach (DataRow row in AppData.Instance.policy.PolicyList.Rows)
            {
                WorkRow = dt.NewRow();
                WorkRow["Policy Number"] = row["PolicyNumber"].ToString();
                WorkRow["Policy Type"] = AppData.Instance.policy.PolicyType.Rows[Convert.ToInt32(row["PolicyType_ID"].ToString()) - 1]["PolicyType"].ToString();
                dt.Rows.Add(WorkRow);

            }


            return dt;
        }

        public DataTable GetPolicyTypes()
        {
            SqlCommand cmd = new SqlCommand("sp_GetPolicyTypes");
            cmd.CommandType = CommandType.StoredProcedure;

            return ExecuteNonQueryReturn(cmd);
        }

        public string AddPolicy(Policy policy, int customerID, int EmployeeID)
        {
            string result = string.Empty;
            try
            {
                SqlCommand cmd = new SqlCommand("sp_AddPolicy");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@PolicyNumber", policy.PolicyNumber));
                cmd.Parameters.Add(new SqlParameter("@AgeAtIssue", policy.AgeAtIssue));
                cmd.Parameters.Add(new SqlParameter("@DateWritten", policy.DateWritten));
                cmd.Parameters.Add(new SqlParameter("@DateEffective", policy.DateEffective));
                cmd.Parameters.Add(new SqlParameter("@Premium", policy.Premium));
                cmd.Parameters.Add(new SqlParameter("@PolicyStatus", policy.PolicyStatus));
                cmd.Parameters.Add(new SqlParameter("@CommissionPercentage", policy.CommissionPercentage));
                cmd.Parameters.Add(new SqlParameter("@Renewal", policy.Renewal));
                cmd.Parameters.Add(new SqlParameter("@CompanyID", policy.CompanyID));
                cmd.Parameters.Add(new SqlParameter("@EmployeeID", EmployeeID));
                cmd.Parameters.Add(new SqlParameter("@Billing", policy.Billing));
                cmd.Parameters.Add(new SqlParameter("@InitialPercentage", policy.InitialPercentage));
                cmd.Parameters.Add(new SqlParameter("@PolicyHolder", policy.PolicyHolder));
                cmd.Parameters.Add(new SqlParameter("@CustomerID", customerID));
                cmd.Parameters.Add(new SqlParameter("@PolicyTypeID", policy.PolicyTypeID));
                cmd.Parameters.Add(new SqlParameter("@EmployeeUserName", HttpContext.Current.User.Identity.Name));
                result = ExecuteNonQuery(cmd);

            }
            catch (Exception ex)
            {
                result = customerID + " " + ex.Message + " " + ex.StackTrace;
                //result = "Sorry, the system is down right now. Please contact your system administrator.";
            }
            return result;
        }

        public string UpdatePolicy(Policy policy)
        {
            string result = string.Empty;
            try
            {
                SqlCommand cmd = new SqlCommand("sp_UpdatePolicy");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@PolicyNumber", policy.PolicyNumber));
                cmd.Parameters.Add(new SqlParameter("@AgeAtIssue", policy.AgeAtIssue));
                cmd.Parameters.Add(new SqlParameter("@DateWritten", policy.DateWritten));
                cmd.Parameters.Add(new SqlParameter("@DateEffective", policy.DateEffective));
                cmd.Parameters.Add(new SqlParameter("@Premium", policy.Premium));
                cmd.Parameters.Add(new SqlParameter("@PolicyStatus", policy.PolicyStatus));
                cmd.Parameters.Add(new SqlParameter("@CommissionPercentage", policy.CommissionPercentage));
                cmd.Parameters.Add(new SqlParameter("@Renewal", policy.Renewal));
                cmd.Parameters.Add(new SqlParameter("@CompanyID", policy.CompanyID));
                cmd.Parameters.Add(new SqlParameter("@Billing", policy.Billing));
                cmd.Parameters.Add(new SqlParameter("@InitialPercentage", policy.InitialPercentage));
                //cmd.Parameters.Add(new SqlParameter("@PolicyHolder", policy.PolicyHolder));
                cmd.Parameters.Add(new SqlParameter("@PolicyTypeID", policy.PolicyTypeID));
                cmd.Parameters.Add(new SqlParameter("@PolicyID", policy.PolicyID));

                result = ExecuteNonQuery(cmd);

            }
            catch (Exception ex)
            {
                result = ex.Message + " " + ex.StackTrace;
                //result = "Sorry, the system is down right now. Please contact your system administrator.";
            }
            return result;
        }
    }
    #endregion

    #region Company
    public class CompanyRepository : BaseRepository
    {
        public string AddCompany(Company company)
        {
            string result = string.Empty;
            try
            {
                SqlCommand cmd = new SqlCommand("sp_AddCompany");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Company", company.CompanyName));
                cmd.Parameters.Add(new SqlParameter("@ContactNum", company.CompanyContactNumber));

                result = ExecuteNonQuery(cmd);
            }
            catch (Exception ex)
            {
                result = "Sorry, the system is unable to add a company right now. Please try again later.";
            }
            return result;
        }

        public DataTable GetCompanies()
        {
            DataTable dataTable = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("sp_GetAllCompanies");
                cmd.CommandType = CommandType.StoredProcedure;

                AppData.Instance.company.CompanyTable = ExecuteNonQueryReturn(cmd);

                DataRow WorkRow;
                dataTable.Columns.Add(new DataColumn("Company Name", typeof(string)));

                foreach (DataRow row in AppData.Instance.company.CompanyTable.Rows)
                {
                    WorkRow = dataTable.NewRow();
                    WorkRow["Company Name"] = row["Company"].ToString();
                    dataTable.Rows.Add(WorkRow);
                }
            }
            catch (Exception ex)
            {

            }
            return dataTable;
        }

        public string UpdateCompany(Company company)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_UpdateCompany");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Company", company.CompanyName));
                cmd.Parameters.Add(new SqlParameter("@ContactNum", company.CompanyContactNumber));
                cmd.Parameters.Add(new SqlParameter("@CompanyID", company.CompanyID));
                return ExecuteNonQuery(cmd);
            }
            catch (Exception ex)
            {
                return "Sorry, the system is down right now. Please contact your system administrator.";
            }
        }
    }
    #endregion

    #region PolicyType
    public class PolicyTypeRepository : BaseRepository
    {
        public string AddPolicyType(PolicyType policyType)
        {
            string result = "";
            try
            {
                SqlCommand cmd = new SqlCommand("sp_AddPolicyType");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@PolicyType", policyType.PolicyTypeName));
                cmd.Parameters.Add(new SqlParameter("@PolicyTypeDesc", policyType.PolicyTypeDesc));
                result = ExecuteNonQuery(cmd);

            }
            catch (Exception ex)
            {
                result = "Sorry, the system is down right now. Please try again later.";
            }
            return result;
        }

        public DataTable GetAllPolicyTypes()
        {
            SqlCommand cmd = new SqlCommand("sp_GetAllPolicyTypes");
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("Policy Type", typeof(string)));
            dt.Columns.Add(new DataColumn("Policy Type Description", typeof(string)));
            DataRow WorkRow;
            AppData.Instance.policyType.PolicyTypeTable = ExecuteNonQueryReturn(cmd);
            foreach (DataRow row in AppData.Instance.policyType.PolicyTypeTable.Rows)
            {
                WorkRow = dt.NewRow();
                WorkRow["Policy Type"] = row["PolicyType"].ToString();
                WorkRow["Policy Type Description"] = row["PolicyTypeDescription"].ToString();
                dt.Rows.Add(WorkRow);
                WorkRow = dt.NewRow();
            }
            return dt;
        }

        public string UpdatePolicyType(PolicyType polType)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_UpdatePolicyType");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@PolicyType", polType.PolicyTypeName));
                cmd.Parameters.Add(new SqlParameter("@PolicyTypeDesc", polType.PolicyTypeDesc));
                cmd.Parameters.Add(new SqlParameter("@PolicyTypeID", polType.PolicyTypeID));

                return ExecuteNonQuery(cmd);
            }
            catch (Exception ex)
            {
                return "Sorry, the system is down right now. Please contact your system administrator.";
            }
        }
    }
    #endregion

    #region Employee
    public class EmployeeRepository : BaseRepository
    {
        public string AddEmployee(Employee employee)
        {
            string result = string.Empty;
            try
            {
                SqlCommand cmd = new SqlCommand("sp_AddEmployee");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@FirstName", employee.FirstName));
                cmd.Parameters.Add(new SqlParameter("@LastName", employee.LastName));
                cmd.Parameters.Add(new SqlParameter("@EmployeeUser", employee.UserName));

                result = ExecuteNonQuery(cmd);
            }
            catch (Exception ex)
            {
                result = "Sorry, the system is done right now. Please contact your system administrator.";
            }
            return result;
        }

        public DataTable GetAllEmployees()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_GetAllEmployee");
            cmd.CommandType = CommandType.StoredProcedure;
            AppData.Instance.employee.EmployeeTable = ExecuteNonQueryReturn(cmd);
            dt.Columns.Add(new DataColumn("First Name", typeof(string)));
            dt.Columns.Add(new DataColumn("Last Name", typeof(string)));
            DataRow WorkRow;
            foreach (DataRow row in AppData.Instance.employee.EmployeeTable.Rows)
            {
                WorkRow = dt.NewRow();
                WorkRow["First Name"] = row["FirstName"].ToString();
                WorkRow["Last Name"] = row["LastName"].ToString();
                dt.Rows.Add(WorkRow);
                WorkRow = dt.NewRow();
            }

            return dt;
        }

        public bool GetEmployee(string userName)
        {
            bool result = false;
            try
            {
                SqlCommand cmd = new SqlCommand("sp_GetEmployee");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@UserName", userName));

                DataTable dt = ExecuteNonQueryReturn(cmd);

                AppData.Instance.employee.EmployeeID = Convert.ToInt32(dt.Rows[0]["Employee_ID"].ToString());
                result = true;
            }
            catch (Exception ex)
            {
                string Terry = ex.Message;
            }
            return result;
        }

        public string UpdateEmployee(Employee employee)
        {
            string result = string.Empty;
            try
            {
                SqlCommand cmd = new SqlCommand("sp_UpdateEmployee");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@FirstName", employee.FirstName));
                cmd.Parameters.Add(new SqlParameter("@LastName", employee.LastName));
                cmd.Parameters.Add(new SqlParameter("@EmployeeID", employee.EmployeeID));

                result = ExecuteNonQuery(cmd);
            }
            catch (Exception ex)
            {
                result = "Sorry, the system is done right now. Please contact your system administrator.";
            }
            return result;
        }
    }
    #endregion

    #region Reports
    public class ReportRepository : BaseRepository
    {
        private Reports report = new Reports();
        public PolicyTypeList[] policyTypeCount;

        public string ViewReports(int EmployeeID)
        {
            DataTable dt = new DataTable();
            try
            {            
                SqlCommand cmd = new SqlCommand("sp_ViewReports");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@StartDate", string.Format("01/01/{0}", DateTime.Now.ToString("yyyy"))));
                cmd.Parameters.Add(new SqlParameter("@EmployeeID", EmployeeID));

                dt = ExecuteNonQueryReturn(cmd);
                return BuildReport(dt, DateTime.Now.Year);
            }
            catch (Exception ex)
            {
                return ex.Message + ex.StackTrace;
            }

        }

        public string BuildReport(DataTable dt, int year)
        {
            GetAllPolicyTypes();
            string Report = "";
            DateTime date;
            DateTime testDate;
            DataRow[] rows;
            try
            {
                for (int x = 1; x <= DateTime.Now.Month; x++)
                {
                    date = new DateTime(year, x, 1);
                    testDate = new DateTime(year, x, DateTime.DaysInMonth(year, x));
                    Report += string.Format("\nSales in {0} {1}\n", date.ToString("MMMM"), date.Year);
                    rows = dt.Select("DateWritten >= '" + date + "' and DateWritten <= '" + testDate.ToString("MM/dd/yyyy") + "'");

                    foreach (DataRow row in rows)
                    {
                        AppData.Instance.reports.policyTypeCount[Convert.ToInt32(row["PolicyType_ID"].ToString()) - 1].PolicyTypeCount++;
                    }
                    for (int j = 0; j < AppData.Instance.reports.policyTypeCount.Length; j++)
                    {
                        Report += string.Format("\tPolicy Type {0} Sold: {1}\n", AppData.Instance.reports.policyTypeCount[j].PolicyTypeName, AppData.Instance.reports.policyTypeCount[j].PolicyTypeCount);
                    }
                    ResetCounters();
                }
            }
            catch (Exception ex)
            {
                Report = "Sorry, the system is down right now. Please contact your system administrator.";
            }

            return Report;
        }

        public void ResetCounters()
        {
            foreach (PolicyTypeList polType in AppData.Instance.reports.policyTypeCount)
            {
                polType.PolicyTypeCount = 0;
            }
        }

        public void GetAllPolicyTypes()
        {
            SqlCommand cmd = new SqlCommand("sp_GetAllPolicyTypes");
            cmd.CommandType = CommandType.StoredProcedure;
            AppData.Instance.policyType.PolicyTypeTable = ExecuteNonQueryReturn(cmd);
            try
            {
                AppData.Instance.reports.policyTypeCount = new PolicyTypeList[AppData.Instance.policyType.PolicyTypeTable.Rows.Count];
                PolicyTypeList polTypeList;
                int x = 0;
                foreach (DataRow row in AppData.Instance.policyType.PolicyTypeTable.Rows)
                {
                    polTypeList = new PolicyTypeList();
                    polTypeList.PolicyTypeID = Convert.ToInt32(row["PolicyType_ID"].ToString());
                    polTypeList.PolicyTypeName = row["PolicyType"].ToString();
                    polTypeList.PolicyTypeCount = 0;
                    AppData.Instance.reports.policyTypeCount[x] = polTypeList;
                    x++;
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
    #endregion

}