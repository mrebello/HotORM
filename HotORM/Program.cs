global using Microsoft.SqlServer;
global using Microsoft.SqlServer.Management;
global using Microsoft.SqlServer.Management.Common;
global using Microsoft.SqlServer.Management.Smo;
using Hot.ORM;

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
        Application.Run(new Form1());
    }
}