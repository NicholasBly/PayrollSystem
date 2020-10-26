using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OleDb;
using System.Net;
using System.Data;

namespace PayrollSystem
{
    public class clsDataLayer
    {
        // This function gets the user activity from the tblUserActivity
        public static dsUserActivity GetUserActivity(string Database)
        {
            dsUserActivity DS;
            OleDbConnection sqlConn;
            OleDbDataAdapter sqlDA;
            sqlConn = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + Database);
            sqlDA = new OleDbDataAdapter("select * from tblUserActivity", sqlConn);
            DS = new dsUserActivity();
            sqlDA.Fill(DS.tblUserActivity);
            return DS;
        }
        // This function saves the user activity
        public static void SaveUserActivity(string Database, string FormAccessed)
        {
            OleDbConnection conn = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;" +
            "Data Source=" + Database);
            conn.Open();
            OleDbCommand command = conn.CreateCommand();
            string strSQL;
            strSQL = "Insert into tblUserActivity (UserIP, FormAccessed) values ('" +
            GetIP4Address() + "', '" + FormAccessed + "')";
            command.CommandType = CommandType.Text;
            command.CommandText = strSQL;
            command.ExecuteNonQuery();
            conn.Close();
        }
        // This function gets the IP Address
        public static string GetIP4Address()
        {
            string IP4Address = string.Empty;
            foreach (IPAddress IPA in
            Dns.GetHostAddresses(HttpContext.Current.Request.UserHostAddress))
            {
                if (IPA.AddressFamily.ToString() == "InterNetwork")
                {
                    IP4Address = IPA.ToString();
                    break;
                }
            }
            if (IP4Address != string.Empty)
            {
                return IP4Address;
            }
            foreach (IPAddress IPA in Dns.GetHostAddresses(Dns.GetHostName()))
            {
                if (IPA.AddressFamily.ToString() == "InterNetwork")
                {
                    IP4Address = IPA.ToString();
                    break;
                }
            }
            return IP4Address;
        }

        // This function saves the personnel data
        public static bool SavePersonnel(string Database, string FirstName, string LastName,
        string PayRate, string StartDate, string EndDate)
        {
            bool recordSaved;
            // Generate new transaction
            OleDbTransaction myTransaction = null;
            try
            {
                // establish connection to database
                OleDbConnection conn = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;" +
                "Data Source=" + Database);
                conn.Open();
                OleDbCommand command = conn.CreateCommand();
                string strSQL;
                // Begin Transaction
                myTransaction = conn.BeginTransaction();
                command.Transaction = myTransaction;
                // generate string to insert values into database
                strSQL = "Insert into tblPersonnel " +
                "(FirstName, LastName) values ('" +
                FirstName + "', '" + LastName + "')";
                // Set commandtype to text
                command.CommandType = CommandType.Text;
                command.CommandText = strSQL;
                // execute SQL query
                command.ExecuteNonQuery();
                // generate string to insert values into database
                strSQL = "Update tblPersonnel " +
                "Set PayRate=" + PayRate + ", " +
                "StartDate='" + StartDate + "', " +
                "EndDate='" + EndDate + "' " +
                "Where ID=(Select Max(ID) From tblPersonnel)";
                // Set commandtype to text
                command.CommandType = CommandType.Text;
                command.CommandText = strSQL;
                // execute SQL query
                command.ExecuteNonQuery();

                // Commit data
                myTransaction.Commit();

                conn.Close();
                // close connection to database
                recordSaved = true;
            }
            catch (Exception ex)
            {
                // Rollback transaction after exception
                myTransaction.Rollback();
                recordSaved = false;
            }
            return recordSaved;
        }
        public static dsPersonnel GetPersonnel(string Database)
        {
            dsPersonnel DS;
            OleDbConnection sqlConn;
            OleDbDataAdapter sqlDA;
            sqlConn = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + Database);
            sqlDA = new OleDbDataAdapter("select * from tblPersonnel", sqlConn);
            DS = new dsPersonnel();
            sqlDA.Fill(DS.tblPersonnel);
            return DS;
        }
        public static dsPersonnel GetPersonnel(string Database, string strSearch)
        {
            dsPersonnel DS;
            OleDbConnection sqlConn;
            OleDbDataAdapter sqlDA;
            sqlConn = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + Database);

            if (strSearch == null || strSearch.Trim() == "")
            {
                sqlDA = new OleDbDataAdapter("select * from tblPersonnel", sqlConn);
            }
            else
            {
                sqlDA = new OleDbDataAdapter("select * from tblPersonnel where LastName = '" + strSearch + "'", sqlConn);
            }

            DS = new dsPersonnel();
            sqlDA.Fill(DS.tblPersonnel);
            return DS;
        }

        // This function verifies a user in the tblUser table
        public static dsUser VerifyUser(string Database, string UserName, string UserPassword)
        {
            // Define database objects
            dsUser DS;
            OleDbConnection sqlConn;
            OleDbDataAdapter sqlDA;
            // set sqlConn connection
            sqlConn = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;" +
            "Data Source=" + Database);
            // set sqlDA to get username and password values
            sqlDA = new OleDbDataAdapter("Select SecurityLevel from tblUserLogin " +
            "where UserName like '" + UserName + "' " +
            "and UserPassword like '" + UserPassword + "'", sqlConn);
            // define DS as dsUser object
            DS = new dsUser();
            // refresh rows in table
            sqlDA.Fill(DS.tblUserLogin);
            // return DS
            return DS;
        }

        public static bool SaveUser(string Database, string UserID, string UserPassword, string SecurityLevel)
        {
            bool userSaved;
            OleDbTransaction myTransaction = null;

            try
            {
                OleDbConnection conn = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;" +
                "Data Source=" + Database);
                conn.Open();
                OleDbCommand command = conn.CreateCommand();
                string strSQL;
                // Begin Transaction
                myTransaction = conn.BeginTransaction();
                command.Transaction = myTransaction;
                // generate string to insert values into database
                strSQL = "Insert into tblUserLogin " +
                "(UserName, UserPassword, SecurityLevel) values ('" +
                UserID + "', '" + UserPassword + "', '" + SecurityLevel + "')";
                // Set commandtype to text
                command.CommandType = CommandType.Text;
                command.CommandText = strSQL;
                // execute SQL query
                command.ExecuteNonQuery();
                // generate string to insert values into database

                // Commit data
                myTransaction.Commit();

                conn.Close();
                // close connection to database
                userSaved = true;
            }

            catch
            {
                userSaved = false;
            }
            return userSaved;
        }
    }
}