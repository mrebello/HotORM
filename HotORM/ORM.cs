
namespace Hot.ORM;

public class ORM {
    Server server;
    string? database = null;

    public ORM(string connectionString) {
        BD_simples BD = new();
        var builder = new System.Data.Common.DbConnectionStringBuilder();
        builder.ConnectionString = connectionString;

        var sc = new ServerConnection(BD.sqlConnectionOpened);
        server = new Server(sc);
    }

    Database? _db = null;
    private readonly object db_block = new object();
    Database db {
        get {
            lock (db_block) {
                if (_db == null) {
                    _db = server.Databases[database ?? server.ConnectionContext.CurrentDatabase];
                }
            }
            return _db;
        }
    }


    public static Microsoft.SqlServer.Management.Smo.Index? PrimaryIndex(Table t) {
        Microsoft.SqlServer.Management.Smo.Index? pri = null;

        foreach (Microsoft.SqlServer.Management.Smo.Index i in t.Indexes) {
            if (i.IndexKeyType == IndexKeyType.DriPrimaryKey) {
                pri = i;
                break;
            }
        }

        return pri;
    }

    public static bool FKfrom(Table t, string field) {
        bool r = false;
        foreach (ForeignKey f in t.ForeignKeys) {
            if (f.Columns.Contains(field)) {
                r = true;
                break;
            }
        }
        return r;
    }


    public string TableStruct(Table t) {
        string r = "";

        var primaryindex = PrimaryIndex(t);

        if (primaryindex!=null && FKfrom(t, primaryindex.IndexedColumns[0].Name)) {   // Chave primária em FK = tabela de especialização
            r += "Chave primária em FK = tabela de especialização" + Environment.NewLine;
        }


        foreach (Column f in t.Columns) {
            if (f.Computed) throw new NotImplementedException("Coluna computada não implementado.");
            string c = "";

            c += f.ID + " ";
            c += f.Name + " ";
            c += f.DataType.Name;
            if (f.Identity) c += "Identidade";

            r += c + Environment.NewLine;
        }


        foreach (ForeignKey i in t.ForeignKeys) {
            r += i.Name; //   scr.Script(new UrnCollection() { i.Urn });
        }
        foreach (Check i in t.Checks) {
            r += i.Name; // scr.Script(new UrnCollection() { i.Urn });
        }
        return r;
    }


    public TableCollection Tabelas {
        get {
            return db.Tables;
        }
    }

}
