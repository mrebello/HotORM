using Index = Microsoft.SqlServer.Management.Smo.Index;

namespace Hot.ORM;

public partial class Form1 : Form {
    public Form1() {
        InitializeComponent();
    }

    ORM orm = new(Config.GetConnectionString("DefaultConnection").Trim().ExpandConfig());

    private void button1_Click(object sender, EventArgs e) {

        MessageBox.Show("Conf1: " + HotORM.Properties.Settings.Default.conf1 + " | Conf2: " + HotORM.Properties.Settings.Default.conf2);
        HotORM.Properties.Settings.Default.Reload();
        MessageBox.Show("Conf1: " + HotORM.Properties.Settings.Default.conf1 + " | Conf2: " + HotORM.Properties.Settings.Default.conf2);

        HotORM.Properties.Settings.Default.conf1 = "Teste da configuração 4";
        HotORM.Properties.Settings.Default.Save();

        MessageBox.Show("Conf1: " + HotORM.Properties.Settings.Default.conf1 + " | Conf2: " + HotORM.Properties.Settings.Default.conf2);


        //Scripter scr = new Scripter(server);
        //scr.Options.DriAllConstraints = true;
        //scr.Options.DriIncludeSystemNames = true;
        //scr.Options.IncludeIfNotExists = true;

        //// Cria CREATEs
        //scr.Options.ScriptDrops = false;

        foreach (Table t in orm.Tabelas) {
            lb_Tabela.Items.Add(t);
        }

        //foreach (Table t in db.Tables) {
        //    foreach (Index i in t.Indexes) {
        //        r += scr.Script(new UrnCollection() { i.Urn });
        //    }
        //    foreach (Check i in t.Checks) {

        //        r += scr.Script(new UrnCollection() { i.Urn });
        //    }
        //}
        //foreach (Table t in db.Tables) {
        //    foreach (ForeignKey i in t.ForeignKeys) {

        //        r += scr.Script(new UrnCollection() { i.Urn });
        //    }
        //}

        //textBox1.Text = r;
    }

    private void lb_Tabela_SelectedIndexChanged(object sender, EventArgs e) {
        Table t = (Table)lb_Tabela.SelectedItem;

        textBox1.Text = orm.TableStruct(t);
    }
}