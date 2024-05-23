
namespace WinFormsApp1;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        button1 = new Button();
        button2 = new Button();
        button3 = new Button();
        button4 = new Button();
        button5 = new Button();
        button6 = new Button();
        button7 = new Button();
        button8 = new Button();
        button9 = new Button();
        button0 = new Button();
        buttonBranco = new Button();
        buttonCorrige = new Button();
        buttonConfirma = new Button();
        timer = new System.Windows.Forms.Timer(components);
        panelDigitar = new Panel();
        pnFim = new Panel();
        txt = new Label();
        lblPartido = new Label();
        lblNome = new Label();
        label3 = new Label();
        label2 = new Label();
        txtPresidente2 = new TextBox();
        txtPresidente1 = new TextBox();
        label1 = new Label();
        presidente = new Label();
        picFoto = new PictureBox();
        panelDigitar.SuspendLayout();
        pnFim.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)picFoto).BeginInit();
        SuspendLayout();
        // 
        // button1
        // 
        button1.BackColor = Color.FromArgb(64, 64, 64);
        button1.FlatStyle = FlatStyle.Popup;
        button1.ForeColor = SystemColors.ButtonHighlight;
        button1.Location = new Point(709, 247);
        button1.Name = "button1";
        button1.Size = new Size(59, 44);
        button1.TabIndex = 1;
        button1.Text = "1";
        button1.UseVisualStyleBackColor = false;
        button1.Click += btn1_Click;
        // 
        // button2
        // 
        button2.BackColor = Color.FromArgb(64, 64, 64);
        button2.FlatStyle = FlatStyle.Popup;
        button2.ForeColor = SystemColors.ButtonHighlight;
        button2.Location = new Point(784, 247);
        button2.Name = "button2";
        button2.Size = new Size(59, 44);
        button2.TabIndex = 2;
        button2.Text = "2";
        button2.UseVisualStyleBackColor = false;
        button2.Click += btn2_Click;
        // 
        // button3
        // 
        button3.BackColor = Color.FromArgb(64, 64, 64);
        button3.FlatStyle = FlatStyle.Popup;
        button3.ForeColor = SystemColors.ButtonHighlight;
        button3.Location = new Point(859, 247);
        button3.Name = "button3";
        button3.Size = new Size(59, 44);
        button3.TabIndex = 3;
        button3.Text = "3";
        button3.UseVisualStyleBackColor = false;
        button3.Click += btn3_Click;
        // 
        // button4
        // 
        button4.BackColor = Color.FromArgb(64, 64, 64);
        button4.FlatStyle = FlatStyle.Popup;
        button4.ForeColor = SystemColors.ButtonHighlight;
        button4.Location = new Point(709, 311);
        button4.Name = "button4";
        button4.Size = new Size(59, 44);
        button4.TabIndex = 4;
        button4.Text = "4";
        button4.UseVisualStyleBackColor = false;
        button4.Click += btn4_Click;
        // 
        // button5
        // 
        button5.BackColor = Color.FromArgb(64, 64, 64);
        button5.FlatStyle = FlatStyle.Popup;
        button5.ForeColor = SystemColors.ButtonHighlight;
        button5.Location = new Point(784, 311);
        button5.Name = "button5";
        button5.Size = new Size(59, 44);
        button5.TabIndex = 5;
        button5.Text = "5";
        button5.UseVisualStyleBackColor = false;
        button5.Click += btn5_Click;
        // 
        // button6
        // 
        button6.BackColor = Color.FromArgb(64, 64, 64);
        button6.FlatStyle = FlatStyle.Popup;
        button6.ForeColor = SystemColors.ButtonHighlight;
        button6.Location = new Point(859, 311);
        button6.Name = "button6";
        button6.Size = new Size(59, 44);
        button6.TabIndex = 6;
        button6.Text = "6";
        button6.UseVisualStyleBackColor = false;
        button6.Click += btn6_Click;
        // 
        // button7
        // 
        button7.BackColor = Color.FromArgb(64, 64, 64);
        button7.FlatStyle = FlatStyle.Popup;
        button7.ForeColor = SystemColors.ButtonHighlight;
        button7.Location = new Point(709, 374);
        button7.Name = "button7";
        button7.Size = new Size(59, 44);
        button7.TabIndex = 7;
        button7.Text = "7";
        button7.UseVisualStyleBackColor = false;
        button7.Click += btn7_Click;
        // 
        // button8
        // 
        button8.BackColor = Color.FromArgb(64, 64, 64);
        button8.FlatStyle = FlatStyle.Popup;
        button8.ForeColor = SystemColors.ButtonHighlight;
        button8.Location = new Point(784, 374);
        button8.Name = "button8";
        button8.Size = new Size(59, 44);
        button8.TabIndex = 8;
        button8.Text = "8";
        button8.UseVisualStyleBackColor = false;
        button8.Click += btn8_Click;
        // 
        // button9
        // 
        button9.BackColor = Color.FromArgb(64, 64, 64);
        button9.FlatStyle = FlatStyle.Popup;
        button9.ForeColor = SystemColors.ButtonHighlight;
        button9.Location = new Point(859, 374);
        button9.Name = "button9";
        button9.Size = new Size(59, 44);
        button9.TabIndex = 9;
        button9.Text = "9";
        button9.UseVisualStyleBackColor = false;
        button9.Click += btn9_Click;
        // 
        // button0
        // 
        button0.BackColor = Color.FromArgb(64, 64, 64);
        button0.FlatStyle = FlatStyle.Popup;
        button0.ForeColor = SystemColors.ButtonHighlight;
        button0.Location = new Point(784, 436);
        button0.Name = "button0";
        button0.Size = new Size(59, 44);
        button0.TabIndex = 10;
        button0.Text = "0";
        button0.UseVisualStyleBackColor = false;
        button0.Click += btn0_Click;
        // 
        // buttonBranco
        // 
        buttonBranco.BackColor = Color.White;
        buttonBranco.FlatStyle = FlatStyle.Popup;
        buttonBranco.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        buttonBranco.ForeColor = SystemColors.ActiveCaptionText;
        buttonBranco.Location = new Point(674, 501);
        buttonBranco.Name = "buttonBranco";
        buttonBranco.Size = new Size(81, 44);
        buttonBranco.TabIndex = 11;
        buttonBranco.Text = "BRANCO";
        buttonBranco.TextAlign = ContentAlignment.TopCenter;
        buttonBranco.UseVisualStyleBackColor = false;
        buttonBranco.Click += btnBranco_Click;
        // 
        // buttonCorrige
        // 
        buttonCorrige.BackColor = Color.FromArgb(255, 128, 0);
        buttonCorrige.FlatStyle = FlatStyle.Popup;
        buttonCorrige.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        buttonCorrige.ForeColor = SystemColors.ActiveCaptionText;
        buttonCorrige.Location = new Point(773, 501);
        buttonCorrige.Name = "buttonCorrige";
        buttonCorrige.Size = new Size(85, 44);
        buttonCorrige.TabIndex = 12;
        buttonCorrige.Text = "CORRIGE";
        buttonCorrige.TextAlign = ContentAlignment.TopCenter;
        buttonCorrige.UseVisualStyleBackColor = false;
        buttonCorrige.Click += btnCorrige_Click;
        // 
        // buttonConfirma
        // 
        buttonConfirma.BackColor = Color.Green;
        buttonConfirma.FlatStyle = FlatStyle.Popup;
        buttonConfirma.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        buttonConfirma.ForeColor = Color.Black;
        buttonConfirma.Location = new Point(874, 485);
        buttonConfirma.Name = "buttonConfirma";
        buttonConfirma.Size = new Size(96, 61);
        buttonConfirma.TabIndex = 13;
        buttonConfirma.Text = "CONFIRMA";
        buttonConfirma.TextAlign = ContentAlignment.TopCenter;
        buttonConfirma.UseVisualStyleBackColor = false;
        buttonConfirma.Click += btnConfirma_Click;
        // 
        // panelDigitar
        // 
        panelDigitar.Controls.Add(pnFim);
        panelDigitar.Controls.Add(lblPartido);
        panelDigitar.Controls.Add(lblNome);
        panelDigitar.Controls.Add(label3);
        panelDigitar.Controls.Add(label2);
        panelDigitar.Controls.Add(txtPresidente2);
        panelDigitar.Controls.Add(txtPresidente1);
        panelDigitar.Controls.Add(label1);
        panelDigitar.Controls.Add(presidente);
        panelDigitar.Controls.Add(picFoto);
        panelDigitar.Location = new Point(62, 194);
        panelDigitar.Name = "panelDigitar";
        panelDigitar.Size = new Size(540, 339);
        panelDigitar.TabIndex = 14;
        // 
        // pnFim
        // 
        pnFim.Controls.Add(txt);
        pnFim.Location = new Point(3, 0);
        pnFim.Name = "pnFim";
        pnFim.Size = new Size(534, 336);
        pnFim.TabIndex = 9;
        // 
        // txt
        // 
        txt.AutoSize = true;
        txt.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        txt.Location = new Point(208, 134);
        txt.Name = "txt";
        txt.Size = new Size(68, 38);
        txt.TabIndex = 0;
        txt.Text = "FIM";
        // 
        // lblPartido
        // 
        lblPartido.AutoSize = true;
        lblPartido.Font = new Font("Segoe UI Variable Text", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lblPartido.Location = new Point(93, 280);
        lblPartido.Name = "lblPartido";
        lblPartido.Size = new Size(24, 22);
        lblPartido.TabIndex = 8;
        lblPartido.Text = "--";
        // 
        // lblNome
        // 
        lblNome.AutoSize = true;
        lblNome.Location = new Point(83, 244);
        lblNome.Name = "lblNome";
        lblNome.Size = new Size(21, 20);
        lblNome.TabIndex = 7;
        lblNome.Text = "--";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI Variable Text", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label3.Location = new Point(14, 280);
        label3.Name = "label3";
        label3.Size = new Size(73, 22);
        label3.TabIndex = 6;
        label3.Text = "Partido:";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI Variable Text", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label2.Location = new Point(14, 242);
        label2.Name = "label2";
        label2.Size = new Size(63, 22);
        label2.TabIndex = 5;
        label2.Text = "Nome:";
        // 
        // txtPresidente2
        // 
        txtPresidente2.BorderStyle = BorderStyle.FixedSingle;
        txtPresidente2.Location = new Point(144, 107);
        txtPresidente2.Name = "txtPresidente2";
        txtPresidente2.Size = new Size(38, 27);
        txtPresidente2.TabIndex = 4;
        // 
        // txtPresidente1
        // 
        txtPresidente1.BorderStyle = BorderStyle.FixedSingle;
        txtPresidente1.Location = new Point(100, 107);
        txtPresidente1.Name = "txtPresidente1";
        txtPresidente1.Size = new Size(38, 27);
        txtPresidente1.TabIndex = 3;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI Variable Text", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label1.Location = new Point(14, 107);
        label1.Name = "label1";
        label1.Size = new Size(80, 22);
        label1.TabIndex = 2;
        label1.Text = "Numero:";
        // 
        // presidente
        // 
        presidente.AutoSize = true;
        presidente.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
        presidente.Location = new Point(100, 30);
        presidente.Name = "presidente";
        presidente.Size = new Size(195, 41);
        presidente.TabIndex = 1;
        presidente.Text = "PRESIDENTE";
        // 
        // picFoto
        // 
        picFoto.Location = new Point(342, 30);
        picFoto.Name = "picFoto";
        picFoto.Size = new Size(166, 171);
        picFoto.TabIndex = 0;
        picFoto.TabStop = false;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
        BackgroundImageLayout = ImageLayout.None;
        ClientSize = new Size(1030, 618);
        Controls.Add(panelDigitar);
        Controls.Add(buttonConfirma);
        Controls.Add(buttonCorrige);
        Controls.Add(buttonBranco);
        Controls.Add(button0);
        Controls.Add(button9);
        Controls.Add(button8);
        Controls.Add(button7);
        Controls.Add(button6);
        Controls.Add(button5);
        Controls.Add(button4);
        Controls.Add(button3);
        Controls.Add(button2);
        Controls.Add(button1);
        Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        Name = "Form1";
        Text = "ss";
        Load += Form1_Load;
        panelDigitar.ResumeLayout(false);
        panelDigitar.PerformLayout();
        pnFim.ResumeLayout(false);
        pnFim.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)picFoto).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Button button1;
    private Button button2;
    private Button button3;
    private Button button4;
    private Button button5;
    private Button button6;
    private Button button7;
    private Button button8;
    private Button button9;
    private Button button0;
    private Button buttonBranco;
    private Button buttonCorrige;
    private Button buttonConfirma;
    private System.Windows.Forms.Timer timer;
    private EventHandler Timer_Tick;
    private Panel panelDigitar;
    private Label label1;
    private Label presidente;
    private PictureBox picFoto;
    private TextBox txtPresidente2;
    private TextBox txtPresidente1;
    private Label lblPartido;
    private Label lblNome;
    private Label label3;
    private Label label2;
    private Panel pnFim;
    private Label txt;
    private Label AcaoFinal;
}
