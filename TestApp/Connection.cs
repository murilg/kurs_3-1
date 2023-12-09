using Microsoft.Data.SqlClient;

namespace TestApp;

public class Connection {
    public static SqlConnectionStringBuilder Constr = new SqlConnectionStringBuilder()
    {
        DataSource = "localhost,1433",
        InitialCatalog = "RTA",
        IntegratedSecurity = true,
        TrustServerCertificate = true,
    };
}