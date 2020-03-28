using System;
using System.Data.OleDb;

namespace Ajandam
{
	/// <summary>
	/// Summary description for conn.
	/// </summary>
	public class conn
	{
		public static OleDbConnection oledbconn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Soruce=ajandam.mdb");


		public conn()
		{
			//
			// TODO: Add constructor logic here
			//
		}
	}
}
