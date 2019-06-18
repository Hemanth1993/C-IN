using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace C1ILDGen
{
    class WatcherSqlClient
    {

        #region Fields
        private SqlConnection sqlConnection;    //SQl connection database
        private String strSrvrName;     //Stores the name of the server
        private String strDBName;   //Stores the name of the Database
        private Boolean bTrustedConnect; //Authenticationm ode
        private String strUserName;         //Stores the name of the user
        private String strPWD;    //Stores user the password
        private String strConnectString; //Database connection string
        private int nCommandTimeOut = 0; //Time out value

        private int nErrorID;           //Stores error id
        private String strErrorQuery; //Stores the error Query
        private String strErrorMessage; //Stores the error message
        #endregion

        #region StaticFields
        /// <summary>
        /// No error.
        /// </summary>
        public static int nConnectionError = 0;
        /// <summary>
        /// The error occured in a query.
        /// </summary>
        public static int nQueryError = 1;
        /// <summary>
        /// The error occured in a stored procedure.
        /// </summary>
        public static int nStoredProcedureError = 1;
        /// <summary>
        /// The error occured in a view.
        /// </summary>
        public static int nViewError = 2;
        #endregion

        #region Events
        /// <summary>
        /// Event is launched when an error occurs. To know the type of the error, use the ErrorId property.
        /// <seealso cref="ErrorId"/>
        /// </summary>
        public event EventHandler ErrorOccured;
        #endregion

        #region Constructors
        /// <summary>
        /// General Constructor for the class.
        /// The connection string will be generated from the values sent. 
        /// </summary>
        /// <param name="strServerName">Name of the server</param>
        /// <param name="strDBName">Name of the database</param>
        /// <param name="bTrustedConnect">Use Windows Authentification or not</param>
        /// <remarks>if bTrustedConnection is set to true, strLogin and strPassword are useless</remarks>
        /// <param name="strUserName">Login value to access the database</param>
        /// <param name="strPassword">Password value to access the database</param>
        public WatcherSqlClient(string strServerName, string strDatabaseName, bool bTrustedConnection, string strLogin, string strPassword)
        {
            strSrvrName = strServerName;
            strDBName = strDatabaseName;
            bTrustedConnect = bTrustedConnection;
            strUserName = strLogin;
            strPWD = strPassword;

            strConnectString = "server=\'" + strServerName + "\';Database=\'" + strDatabaseName + "\';";

            if (bTrustedConnection)
            {
                strConnectString += "trusted_connection=\'yes\';";
                strConnectString += "integrated security=SSPI;persist security info=False;Pooling=true;Max Pool Size=1;Min Pool Size=1";
            }
            else
            {
                //strConnectString += "user id=\'" + strLogin + "\';password=\'" + strPassword + "\';Pooling=true;Max Pool Size=1;Min Pool Size=1";
                strConnectString = @"Data Source=" + strServerName + ";Initial Catalog=" + strDatabaseName + "; user ID=" + strLogin + ";Password=" + strPassword + ";";
            }
            sqlConnection = new SqlConnection(strConnectString);
            OpenConnection();
        }
        /// <summary>
        /// General Constructor for the class.
        /// The connection string will be generated from the values sent. 
        /// </summary>
        /// <param name="strServerName">Name of the server</param>
        /// <param name="strDBName">Name of the database</param>
        /// <param name="bTrustedConnect">Use Windows Authentification or not</param>
        /// <remarks>if bTrustedConnection is set to true, strLogin and strPassword are useless</remarks>
        /// <param name="strUserName">Login value to access the database</param>
        /// <param name="strPassword">Password value to access the database</param>
        public WatcherSqlClient(string strServerName, string strDatabaseName, bool bTrustedConnection, string strLogin, string strPassword, string connectionString)
        {
            strSrvrName = strServerName;
            strDBName = strDatabaseName;
            bTrustedConnect = bTrustedConnection;
            strUserName = strLogin;
            strPWD = strPassword;

            strConnectString = "server=\'" + strServerName + "\';Database=\'" + strDatabaseName + "\';";

            if (bTrustedConnection)
            {
                strConnectString += connectionString;
            }
            else
            {
                strConnectString += "user id=\'" + strLogin + "\';password=\'" + strPassword + "\';Pooling=true;Max Pool Size=1;Min Pool Size=1";
            }
            sqlConnection = new SqlConnection(strConnectString);
            OpenConnection();
        }

        public SqlConnection Connection
        {
            get { return sqlConnection; }
        }
        /// <summary>
        /// Constructor for the class.
        /// The connection string will be created with Windows Authentification. 
        /// </summary>
        /// <param name="strServerName">Name of the server</param>
        /// <param name="strDBName">Name of the database</param>
        public WatcherSqlClient(string strServerName, string strDatabaseName) : this(strServerName, strDatabaseName, true, "", "")
        { }

        /// <summary>
        /// Constructor for the class.
        /// The connection string will be created using Login/Password authentification
        /// </summary>
        /// <param name="strServerName">Name of the server</param>
        /// <param name="strDBName">Name of the database</param>
        /// <param name="strUserName">Login value to access the database</param>
        /// <param name="strPassword">Password value to access the database</param>
        public WatcherSqlClient(string strServerName, string strDatabaseName, string strLogin, string strPassword) : this(strServerName, strDatabaseName, false, strLogin, strPassword)
        { }

        /// <summary>
        /// Constructor for the class.
        /// The connection string must be provided.
        /// </summary>
        /// <param name="strConnectString">The full connection string to use to access the database</param>
        public WatcherSqlClient(String strConnectionString)
        {
            strSrvrName = @"";
            strDBName = @"";
            bTrustedConnect = false;
            strUserName = "";
            strPWD = "";
            strConnectString = strConnectionString;
            sqlConnection = new SqlConnection(strConnectString);
            //			OpenConnection();
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets the error id when a problems occurs 
        /// </summary>
        /// <value>Id of the error</value>
        /// <remarks>ErrorId only makes sense after the ErrorOccured event has been triggered. The value can be tested with the static fields</remarks>
        //XXX should use enumeration
        public int ErrorId
        {
            get { return nErrorID; }
        }
        /// <summary>
        /// Gets the name of the query or the stored procedure that causes the system to crash
        /// </summary>
        /// <value>Id of the error</value>
        /// <remarks>ErrorQuery only makes sense after an ErrorOccured event of type nQueryError, nStoredProcedureError or nViewError has been triggered.</remarks>
        public String ErrorQuery
        {
            get { return strErrorQuery; }
        }
        /// <summary>
        /// Gets system error message thrown when the system crashed
        /// </summary>
        /// <value>System message error</value>
        /// <remarks>ErrorQuery only makes sense after an ErrorOccured event of type nQueryError, nStoredProcedureError or nViewError has been triggered.</remarks>
        public String ErrorMessage
        {
            get { return strErrorMessage; }
        }
        /// <summary>
        /// Gets or sets the connection string used to connect to the database.</summary>
        /// <value>Connection string to connect to the database</value>
        /// <remarks>The connection string should be set at creation time only</remarks>
        public String ConnectionString
        {
            get { return strConnectString; }
            set { strConnectString = value; }
        }
        /// <summary>
        /// Gets or sets the command time out for all the queries and stored procedures</summary>
        /// <value>Number of seconds to wait until stopping the execution of the query or stored procedure</value>
        /// <remarks>The default value is set to 3600</remarks>
        public int CommandTimeOut
        {
            get { return nCommandTimeOut; }
            set { nCommandTimeOut = value; }
        }
        #endregion

        #region ConnectionMethods
        /// <summary>
        /// Open the connection.
        /// </summary>
        /// <remarks>The connection is opened on a per use basis, don't bother opening it in the beginning</remarks>
        public void OpenConnection()
        {
            try
            {
                //connection has already been created with the strConnectString
                if (sqlConnection.State == ConnectionState.Closed)
                    sqlConnection.Open();
            }
            catch (Exception e)
            {
                SetErrorMessage(nConnectionError, "", e.Message);
                if (ErrorOccured != null) ErrorOccured(this, new EventArgs());
                throw new Exception(e.Message);
            }
        }
        /// <summary>
        /// Close the connection.
        /// </summary>
        public void CloseConnection()
        {
            if (sqlConnection != null)
                sqlConnection.Close();
        }

        /// <summary>
        /// Release resources.
        /// </summary>
        public void DisposeConnection()
        {
            // make sure connection is closed
            if (sqlConnection != null)
            {
                sqlConnection.Dispose();
                sqlConnection = null;
            }
        }
        #endregion

        #region SQLMethods
        /// <summary>
        /// Connects to the database and attempts to execute a SELECT query.
        /// </summary>
        /// <param name="strQuery">The SELECT query to execute</param>
        /// <param name="strTableName">The name of the table that will be filled in the returned DataSet</param>
        /// <returns>A DataSet with the result of the querry</returns>
        /// <remarks>If a problem occurs, the ErrorOccured event will be triggered and the ErrorId, ErrorQuery, ErrorMessage values will be set</remarks>
        public DataSet Query(String strQuery, String strTableName)
        {
            DataSet dataSet = new DataSet();
            try
            {
                SqlCommand sqlCmd = new SqlCommand(strQuery, sqlConnection);
                sqlCmd.CommandTimeout = nCommandTimeOut;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCmd);
                sqlDataAdapter.Fill(dataSet, strTableName);
                sqlDataAdapter.Dispose();
                sqlCmd.Dispose();
            }
            catch (Exception e)
            {
                SetErrorMessage(nQueryError, strQuery, e.Message);
                dataSet.Tables.Add(new DataTable());
                if (ErrorOccured != null) ErrorOccured(this, new EventArgs());
            }
            return (dataSet);
        }

        public DataSet Query(String strQuery, String tableName, SqlTransaction sqlTrans)
        {
            DataSet dataSet = new DataSet();
            try
            {
                SqlCommand sqlCmd = new SqlCommand(strQuery, sqlConnection);
                sqlCmd.Transaction = sqlTrans;
                sqlCmd.CommandTimeout = nCommandTimeOut;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCmd);
                sqlDataAdapter.Fill(dataSet, tableName);
                sqlDataAdapter.Dispose();
                sqlCmd.Dispose();
            }
            catch (Exception e)
            {
                SetErrorMessage(nQueryError, strQuery, e.Message);
                dataSet.Tables.Add(new DataTable());
                if (ErrorOccured != null) ErrorOccured(this, new EventArgs());
            }
            return (dataSet);
        }
        /// <summary>
        /// Connects to the database and attempts to execute an INSERT/UPDATE query.
        /// </summary>
        /// <param name="strQuery">The INSERT/UPDATE query to execute</param>
        /// <remarks>If a problem occurs, the ErrorOccured event will be triggered and the ErrorId, ErrorQuery, ErrorMessage values will be set</remarks>
        public void Query(String strQuery)
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand(strQuery, sqlConnection);
                sqlCmd.CommandTimeout = nCommandTimeOut;
                sqlCmd.ExecuteNonQuery();
                sqlCmd.Dispose();
            }
            catch (Exception e)
            {
                SetErrorMessage(nQueryError, strQuery, e.Message);
                if (ErrorOccured != null) ErrorOccured(this, new EventArgs());
            }
        }
        /// <summary>
        /// Connects to the database and attempts to execute an INSERT/UPDATE query.
        /// </summary>
        /// <param name="strQuery">The INSERT/UPDATE query to execute</param>
        /// <remarks>If a problem occurs, the ErrorOccured event will be triggered and the ErrorId, ErrorQuery, ErrorMessage values will be set</remarks>
        public void Query(String strQuery, SqlTransaction sqlTrans)
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand(strQuery, sqlConnection);
                sqlCmd.CommandTimeout = nCommandTimeOut;
                sqlCmd.Transaction = sqlTrans;
                sqlCmd.ExecuteNonQuery();
                sqlCmd.Dispose();
            }
            catch (Exception e)
            {
                SetErrorMessage(nQueryError, strQuery, e.Message);
                if (ErrorOccured != null) ErrorOccured(this, new EventArgs());
            }
        }
        /// <summary>
        /// Connects to the database and attempts to execute a COUNT query.
        /// </summary>
        /// <param name="strQuery">The COUNT query to execute</param>
        /// <remarks>If a problem occurs, the ErrorOccured event will be triggered and the ErrorId, ErrorQuery, ErrorMessage values will be set</remarks>
        public int CountQuery(String strQuery, SqlTransaction sqlTrans)
        {
            int nCount = -1;
            try
            {
                SqlCommand sqlCmd = new SqlCommand(strQuery, sqlConnection);
                sqlCmd.CommandTimeout = nCommandTimeOut;
                sqlCmd.Transaction = sqlTrans;
                object oCount = sqlCmd.ExecuteScalar();
                if (oCount != null)
                    nCount = (int)oCount;
                sqlCmd.Dispose();
            }
            catch (Exception e)
            {
                SetErrorMessage(nQueryError, strQuery, e.Message);
                if (ErrorOccured != null) ErrorOccured(this, new EventArgs());
            }
            return (nCount);
        }
        #endregion

        #region StoredProcedureMethods
        /// <summary>
        /// Create command object used to call stored procedure.
        /// </summary>
        /// <param name="strProcedureName">Name of stored procedure.</param>
        /// <param name="parameters">Parameters for stored procedure.</param>
        /// <returns>SqlCommand object.</returns>
        private SqlCommand CreateProcedureCommand(string strProcedureName, SqlParameter[] parameters)
        {
            SqlCommand sqlCmd = new SqlCommand(strProcedureName, sqlConnection);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandTimeout = nCommandTimeOut;

            // add proc parameters
            if (parameters != null)
            {
                foreach (SqlParameter sqlParameter in parameters)
                    sqlCmd.Parameters.Add(sqlParameter);
            }

            // return param
            sqlCmd.Parameters.Add(
                new SqlParameter("ReturnValue", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, 0, 0, string.Empty, DataRowVersion.Default, null));
            return sqlCmd;
        }

        /// <summary>
        /// Run stored procedure.
        /// </summary>
        /// <param name="strProcedureName">Name of the stored procedure.</param>
        /// <returns>Stored procedure return value.</returns>
        public int RunStoredProcedure(string strProcedureName)
        {
            int nRetVal = -1;
            try
            {
                SqlCommand sqlCmd = CreateProcedureCommand(strProcedureName, null);
                sqlCmd.ExecuteNonQuery();
                nRetVal = (int)sqlCmd.Parameters["ReturnValue"].Value;
            }
            catch (Exception e)
            {
                SetErrorMessage(nStoredProcedureError, strProcedureName, e.Message);
                if (ErrorOccured != null) ErrorOccured(this, new EventArgs());
            }
            return (nRetVal);
        }

        /// <summary>
        /// Run stored procedure.
        /// </summary>
        /// <param name="strProcedureName">Name of the stored procedure.</param>
        /// <param name="parameters">Stored procedure parameters.</param>
        /// <returns>Stored procedure return value.</returns>
        public int RunStoredProcedure(string strProcedureName, SqlParameter[] parameters, SqlTransaction sqlTrans)
        {
            int nRetVal = -1;
            try
            {
                SqlCommand sqlCmd = CreateProcedureCommand(strProcedureName, parameters);
                if (sqlTrans != null)
                    sqlCmd.Transaction = sqlTrans;
                sqlCmd.ExecuteNonQuery();
                nRetVal = (int)sqlCmd.Parameters["ReturnValue"].Value;
            }
            catch (Exception e)
            {
                SetErrorMessage(nStoredProcedureError, strProcedureName, e.Message);
                if (ErrorOccured != null) ErrorOccured(this, new EventArgs());
            }
            return nRetVal;
        }

        /// <summary>
        /// Run stored procedure.
        /// </summary>
        /// <param name="strProcedureName">Name of the stored procedure.</param>
        /// <param name="dataSet">Return result of procedure.</param>
        /// <returns>Stored procedure return value.</returns>
        public int RunStoredProcedure(string strProcedureName, out DataSet dataSet)
        {
            int nRetVal = -1;
            dataSet = new DataSet();
            try
            {
                SqlCommand sqlCmd = CreateProcedureCommand(strProcedureName, null);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCmd);
                sqlDataAdapter.Fill(dataSet);
                nRetVal = (int)sqlCmd.Parameters["ReturnValue"].Value;
            }
            catch (Exception e)
            {
                SetErrorMessage(nStoredProcedureError, strProcedureName, e.Message);
                dataSet.Tables.Add(new DataTable());
                if (ErrorOccured != null) ErrorOccured(this, new EventArgs());
            }
            return nRetVal;
        }
        /// <summary>
        /// Run stored procedure.
        /// </summary>
        /// <param name="strProcedureName">Name of the stored procedure.</param>
        /// <param name="parameters">Stored procedure parameters.</param>
        /// <param name="dataSet">Return result of procedure.</param>
        /// <returns>Stored procedure return value.</returns>
        public int RunStoredProcedure(string strProcedureName, SqlParameter[] parameters, out DataSet dataSet)
        {
            int nRetVal = -1;
            dataSet = new DataSet();
            try
            {
                SqlCommand sqlCmd = CreateProcedureCommand(strProcedureName, parameters);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCmd);
                sqlDataAdapter.Fill(dataSet);
                nRetVal = (int)sqlCmd.Parameters["ReturnValue"].Value;
            }
            catch (Exception e)
            {
                SetErrorMessage(nStoredProcedureError, strProcedureName, e.Message);
                dataSet.Tables.Add(new DataTable());
                if (ErrorOccured != null) ErrorOccured(this, new EventArgs());
            }
            return nRetVal;
        }

        /// <summary>
        /// Create input parameter.
        /// </summary>
        /// <param name="strParameterName">Name of param.</param>
        /// <param name="parameterType">Param type.</param>
        /// <param name="nParameterSize">Param size.</param>
        /// <param name="parameterValue">Param value.</param>
        /// <returns>New input parameter.</returns>
        public SqlParameter CreateInParameter(string strParameterName, SqlDbType parameterType, int nParameterSize, object parameterValue)
        {
            return CreateParameter(strParameterName, parameterType, nParameterSize, ParameterDirection.Input, parameterValue);
        }

        /// <summary>
        /// Create output param.
        /// </summary>
        /// <param name="strParameterName">Name of param.</param>
        /// <param name="parameterType">Param type.</param>
        /// <param name="nParameterSize">Param size.</param>
        /// <returns>New output parameter.</returns>
        public SqlParameter CreateOutParameter(string strParameterName, SqlDbType parameterType, int nParameterSize)
        {
            return CreateParameter(strParameterName, parameterType, nParameterSize, ParameterDirection.Output, null);
        }

        /// <summary>
        /// Create return param.
        /// </summary>
        /// <returns>New return parameter.</returns>
        public SqlParameter CreateReturnParameter()
        {
            return CreateParameter("returnname", SqlDbType.Int, 4, ParameterDirection.ReturnValue, null);
        }

        /// <summary>
        /// Make stored procedure parameter.
        /// </summary>
        /// <param name="strParameterName">Name of param.</param>
        /// <param name="parameterType">Param type.</param>
        /// <param name="nParameterSize">Param size.</param>
        /// <param name="Direction">Param direction.</param>
        /// <param name="parameterValue">Param value.</param>
        /// <returns>New parameter.</returns>
        public SqlParameter CreateParameter(string strParameterName, SqlDbType parameterType, Int32 nParameterSize, ParameterDirection Direction, object parameterValue)
        {
            SqlParameter sqlParameter;
            if (nParameterSize > 0)
            {
                sqlParameter = new SqlParameter(strParameterName, parameterType, nParameterSize);
            }
            else
            {
                sqlParameter = new SqlParameter(strParameterName, parameterType);
            }

            sqlParameter.Direction = Direction;

            if (!(Direction == ParameterDirection.Output && parameterValue == null))
            {
                sqlParameter.Value = parameterValue;
            }
            return sqlParameter;
        }
        #endregion

        #region ViewMethods
        /// <summary>
        /// Run view.
        /// </summary>
        /// <param name="strViewName">Name of the view.</param>
        /// <param name="dataSet">Return result of view.</param>
        /// <returns>View return value.</returns>
        public int RunView(string strViewName, out DataSet dataSet)
        {
            int nRetVal = -1;
            dataSet = new DataSet();
            try
            {
                SqlCommand sqlCmd = CreateViewCommand(strViewName);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCmd);
                sqlDataAdapter.Fill(dataSet);
                nRetVal = (int)sqlCmd.Parameters["ReturnValue"].Value;
            }
            catch (Exception e)
            {
                SetErrorMessage(nViewError, strViewName, e.Message);
                dataSet.Tables.Add(new DataTable());
                if (ErrorOccured != null) ErrorOccured(this, new EventArgs());
            }
            return nRetVal;
        }

        /// <summary>
        /// Create command object used to call view.
        /// </summary>
        /// <param name="viewName">Name of view.</param>
        /// <returns>SqlCommand object.</returns>
        private SqlCommand CreateViewCommand(string strViewName)
        {
            SqlCommand sqlCmd = new SqlCommand(strViewName, sqlConnection);
            //sqlCmd.CommandType = CommandType.TableDirect;
            return sqlCmd;
        }
        #endregion

        /// <summary>
        /// Sets the error id,error queryand error message
        /// </summary>
        /// <param name="nErrorID">Error id</param>
        /// <param name="strErrorQuery">Query failed</param>
        /// <param name="strErrorMessage">Error message</param>
        void SetErrorMessage(int nErrorId, string strErrQuery, string strErrMessage)
        {
            nErrorID = nErrorId;
            strErrorQuery = strErrQuery;
            strErrorMessage = strErrMessage;
        }

    }
}
