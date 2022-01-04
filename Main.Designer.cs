
namespace SimplePaint
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxEspessuraDaCaneta = new System.Windows.Forms.ComboBox();
            this.buttonBorracha = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCorCaneta = new System.Windows.Forms.Button();
            this.panelPintura = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.buttonLimpar);
            this.groupBox1.Controls.Add(this.buttonSalvar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxEspessuraDaCaneta);
            this.groupBox1.Controls.Add(this.buttonBorracha);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonCorCaneta);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // buttonLimpar
            // 
            resources.ApplyResources(this.buttonLimpar, "buttonLimpar");
            this.buttonLimpar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.UseVisualStyleBackColor = false;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // buttonSalvar
            // 
            resources.ApplyResources(this.buttonSalvar, "buttonSalvar");
            this.buttonSalvar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.UseVisualStyleBackColor = false;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // comboBoxEspessuraDaCaneta
            // 
            resources.ApplyResources(this.comboBoxEspessuraDaCaneta, "comboBoxEspessuraDaCaneta");
            this.comboBoxEspessuraDaCaneta.FormattingEnabled = true;
            this.comboBoxEspessuraDaCaneta.Name = "comboBoxEspessuraDaCaneta";
            this.comboBoxEspessuraDaCaneta.SelectedIndexChanged += new System.EventHandler(this.comboBoxEspessuraDaCaneta_SelectedIndexChanged);
            // 
            // buttonBorracha
            // 
            resources.ApplyResources(this.buttonBorracha, "buttonBorracha");
            this.buttonBorracha.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonBorracha.Name = "buttonBorracha";
            this.buttonBorracha.UseVisualStyleBackColor = false;
            this.buttonBorracha.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonBorracha_MouseDown);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // buttonCorCaneta
            // 
            resources.ApplyResources(this.buttonCorCaneta, "buttonCorCaneta");
            this.buttonCorCaneta.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonCorCaneta.Name = "buttonCorCaneta";
            this.buttonCorCaneta.UseVisualStyleBackColor = false;
            this.buttonCorCaneta.Click += new System.EventHandler(this.buttonCorCaneta_Click);
            // 
            // panelPintura
            // 
            resources.ApplyResources(this.panelPintura, "panelPintura");
            this.panelPintura.BackColor = System.Drawing.Color.White;
            this.panelPintura.Name = "panelPintura";
            this.panelPintura.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelPintura_MouseDown);
            this.panelPintura.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelPintura_MouseMove);
            this.panelPintura.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelPintura_MouseUp);
            this.panelPintura.Resize += new System.EventHandler(this.panelPintura_Resize);
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Controls.Add(this.panelPintura);
            this.Controls.Add(this.groupBox1);
            this.Name = "Main";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Button buttonBorracha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxEspessuraDaCaneta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCorCaneta;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Panel panelPintura;
    }
}

