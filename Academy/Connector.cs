using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;

using System.Configuration;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Data;

namespace Academy
{
	internal class Connector
	{
		readonly string CONNECTION_STRING;//= ConfigurationManager["PV_319_Import"].ConnectionString;
		SqlConnection connection;
		public Connector(string connection_string)
		{
			CONNECTION_STRING = ConfigurationManager.ConnectionStrings["PV_319_Import"].ConnectionString;
			connection = new SqlConnection(CONNECTION_STRING);
		}
		~Connector()
		{ 
			FreeConsole();
		}
		public DataTable Select(string columns, string tables, string condition = "")
		{
			DataTable table = null;
			string cmd = $"SELECT {columns} FROM {tables}";
			if (condition != "") cmd += $" WHERE {condition}";
			cmd += ";";
			SqlCommand command = new SqlCommand(cmd, connection);
			connection.Open();
			SqlDataReader reader = command.ExecuteReader();

			if (reader.HasRows)
			{
				//1) 
				table = new DataTable();
				//2) 
				for (int i = 0; i < reader.FieldCount; i++)
				{
					table.Columns.Add();
				}
				//3)
				while (reader.Read())
				{
					DataRow row = table.NewRow();
					for (int i = 0; i < reader.FieldCount; i++)
					{
						row[i] = reader[i];
					}
					table.Rows.Add(row);
				}
			}

			reader.Close();
			connection.Close();
			return table;
		}
		[DllImport("kernel32.dll")]
		public static extern bool AllocConsole();
		[DllImport("kernel32.dll")]
		public static extern bool FreeConsole();
	}
}

