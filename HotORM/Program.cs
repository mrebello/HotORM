global using Microsoft.SqlServer;
global using Microsoft.SqlServer.Management;
global using Microsoft.SqlServer.Management.Common;
global using Microsoft.SqlServer.Management.Smo;
using Hot.Extensions;
using Hot.ORM;
using System.Diagnostics;

namespace HotORM;

/// <summary>
/// Classe de programa padrão para criação da aplicação.
/// As configurações do 'builder' e 'app' estão no appsettings.json, que
/// é incorporado no executável da aplicação. Configurações padrão estão
/// incluídas nas DLLs das bibliotecas (Hot.DLL e HotAPI.DLL)
/// </summary>
public class Program {
    /// <summary>
    /// Método 'main' padrão da HotAPI
    /// </summary>
    /// <param name="args"></param>
    public static void Main(string[] args) {
        Debug.WriteLine(Config.Infos());

        Debug.WriteLine(BD.SQLScalar("select 'Server: ' + @@SERVERNAME + ' DB:' + db_name() + ' | APP: ' + APP_NAME() + ' | user: ' + user_name()") as string);
        Debug.WriteLine(BD.Corp.SQLScalar("select 'Server: ' + @@SERVERNAME + ' DB:' + db_name() + ' | APP: ' + APP_NAME() + ' | user: ' + user_name()") as string);
        Debug.WriteLine(BD.ERP_SA.SQLScalar("select 'Server: ' + @@SERVERNAME + ' DB:' + db_name() + ' | APP: ' + APP_NAME() + ' | user: ' + user_name()") as string);
        Debug.WriteLine(BD.Corp_SA.SQLScalar("select 'Server: ' + @@SERVERNAME + ' DB:' + db_name() + ' | APP: ' + APP_NAME() + ' | user: ' + user_name()") as string);

        Application.Run(new Form1());
    }
}