namespace Hot.ORM;

partial class Form1 {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        button1 = new Button();
        textBox1 = new TextBox();
        lb_Tabela = new ListBox();
        SuspendLayout();
        // 
        // button1
        // 
        button1.Location = new Point(12, 12);
        button1.Name = "button1";
        button1.Size = new Size(164, 30);
        button1.TabIndex = 0;
        button1.Text = "button1";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // textBox1
        // 
        textBox1.Location = new Point(384, 47);
        textBox1.Multiline = true;
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(495, 468);
        textBox1.TabIndex = 2;
        // 
        // lb_Tabela
        // 
        lb_Tabela.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        lb_Tabela.FormattingEnabled = true;
        lb_Tabela.Location = new Point(12, 47);
        lb_Tabela.Name = "lb_Tabela";
        lb_Tabela.Size = new Size(231, 706);
        lb_Tabela.TabIndex = 3;
        lb_Tabela.SelectedIndexChanged += lb_Tabela_SelectedIndexChanged;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(6F, 13F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(882, 769);
        Controls.Add(lb_Tabela);
        Controls.Add(textBox1);
        Controls.Add(button1);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button button1;
    private TextBox textBox1;
    private ListBox lb_Tabela;
}