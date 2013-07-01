using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;

namespace MedicalDefinition.Utilities
{
    public class Utils
    {

        public static SqlConnection GetConnection()
        {
            String bdStringSql = "Data Source=CTDIR-26464-CBG;Initial Catalog=inventario;Integrated Security=True";

            SqlConnection connection = new SqlConnection(bdStringSql);

            return connection;
        }


        public static void WriteEventLog(Exception ex, String methodExc)
        {
            if (!EventLog.SourceExists("MedicalDanilo"))
            {
                EventLog.CreateEventSource("MedicalDanilo", "MedicalDanilo");
            }
            EventLog logg = new EventLog("MedicalDanilo");
            logg.Source = "MedicalDanilo";
            String mensaje = methodExc + "\n" + ex.Message + ex.StackTrace;
            logg.WriteEntry(mensaje);
            logg.Close();
        }
    }
}
