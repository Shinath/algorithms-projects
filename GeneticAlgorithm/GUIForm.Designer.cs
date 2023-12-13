namespace GeneticAlgorithm
{
    partial class GUIForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxD = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mainDashboard = new System.Windows.Forms.DataGridView();
            this.indexNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xReal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.functionValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gFunctionValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qvalue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.r = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxPk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.breedingDashboard = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xbinAfterSelection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parents = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kids = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.populationAfterBreeding = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.geneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.populationAfterMutations = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xreals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fxreal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxPm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.elitaCheckBox = new System.Windows.Forms.CheckBox();
            this.textBoxT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainDashboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breedingDashboard)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(454, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "D=";
            // 
            // comboBoxD
            // 
            this.comboBoxD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxD.Items.AddRange(new object[] {
            "0,1",
            "0,01",
            "0,001",
            "0,0001"});
            this.comboBoxD.Location = new System.Drawing.Point(484, 12);
            this.comboBoxD.Name = "comboBoxD";
            this.comboBoxD.Size = new System.Drawing.Size(101, 21);
            this.comboBoxD.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(12, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "a=";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(43, 12);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(100, 20);
            this.textBoxA.TabIndex = 9;
            this.textBoxA.Text = "-2";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(900, 10);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 10;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(182, 12);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(100, 20);
            this.textBoxB.TabIndex = 12;
            this.textBoxB.Text = "3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(153, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "b=";
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(326, 12);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(100, 20);
            this.textBoxN.TabIndex = 14;
            this.textBoxN.Text = "10";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(296, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "N=";
            // 
            // mainDashboard
            // 
            this.mainDashboard.AllowUserToAddRows = false;
            this.mainDashboard.AllowUserToDeleteRows = false;
            this.mainDashboard.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.mainDashboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainDashboard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.indexNumber,
            this.xReal,
            this.functionValue,
            this.gFunctionValue,
            this.PValue,
            this.Qvalue,
            this.r});
            this.mainDashboard.Location = new System.Drawing.Point(16, 39);
            this.mainDashboard.Name = "mainDashboard";
            this.mainDashboard.ReadOnly = true;
            this.mainDashboard.Size = new System.Drawing.Size(744, 401);
            this.mainDashboard.TabIndex = 15;
            // 
            // indexNumber
            // 
            this.indexNumber.HeaderText = "Lp.";
            this.indexNumber.Name = "indexNumber";
            this.indexNumber.ReadOnly = true;
            this.indexNumber.Width = 50;
            // 
            // xReal
            // 
            this.xReal.HeaderText = "x";
            this.xReal.Name = "xReal";
            this.xReal.ReadOnly = true;
            // 
            // functionValue
            // 
            this.functionValue.HeaderText = "f(x)";
            this.functionValue.Name = "functionValue";
            this.functionValue.ReadOnly = true;
            this.functionValue.Width = 150;
            // 
            // gFunctionValue
            // 
            this.gFunctionValue.HeaderText = "g(x)";
            this.gFunctionValue.Name = "gFunctionValue";
            this.gFunctionValue.ReadOnly = true;
            // 
            // PValue
            // 
            this.PValue.HeaderText = "p(x)";
            this.PValue.Name = "PValue";
            this.PValue.ReadOnly = true;
            // 
            // Qvalue
            // 
            this.Qvalue.HeaderText = "q(x)";
            this.Qvalue.Name = "Qvalue";
            this.Qvalue.ReadOnly = true;
            // 
            // r
            // 
            this.r.HeaderText = "r";
            this.r.Name = "r";
            this.r.ReadOnly = true;
            // 
            // textBoxPk
            // 
            this.textBoxPk.Location = new System.Drawing.Point(638, 11);
            this.textBoxPk.Name = "textBoxPk";
            this.textBoxPk.Size = new System.Drawing.Size(100, 20);
            this.textBoxPk.TabIndex = 17;
            this.textBoxPk.Text = "0,75";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(602, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Pk=";
            // 
            // breedingDashboard
            // 
            this.breedingDashboard.AllowUserToAddRows = false;
            this.breedingDashboard.AllowUserToDeleteRows = false;
            this.breedingDashboard.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.breedingDashboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.breedingDashboard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.xbinAfterSelection,
            this.parents,
            this.pc,
            this.kids,
            this.populationAfterBreeding,
            this.geneNumber,
            this.populationAfterMutations,
            this.xreals,
            this.fxreal});
            this.breedingDashboard.Location = new System.Drawing.Point(766, 39);
            this.breedingDashboard.Name = "breedingDashboard";
            this.breedingDashboard.ReadOnly = true;
            this.breedingDashboard.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.breedingDashboard.Size = new System.Drawing.Size(1093, 401);
            this.breedingDashboard.TabIndex = 18;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "populacja po selekcji";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // xbinAfterSelection
            // 
            this.xbinAfterSelection.HeaderText = "xbin";
            this.xbinAfterSelection.Name = "xbinAfterSelection";
            this.xbinAfterSelection.ReadOnly = true;
            // 
            // parents
            // 
            this.parents.HeaderText = "rodzice";
            this.parents.Name = "parents";
            this.parents.ReadOnly = true;
            // 
            // pc
            // 
            this.pc.HeaderText = "pc";
            this.pc.Name = "pc";
            this.pc.ReadOnly = true;
            this.pc.Width = 50;
            // 
            // kids
            // 
            this.kids.HeaderText = "dzieci";
            this.kids.Name = "kids";
            this.kids.ReadOnly = true;
            // 
            // populationAfterBreeding
            // 
            this.populationAfterBreeding.FillWeight = 200F;
            this.populationAfterBreeding.HeaderText = "populacja";
            this.populationAfterBreeding.Name = "populationAfterBreeding";
            this.populationAfterBreeding.ReadOnly = true;
            // 
            // geneNumber
            // 
            this.geneNumber.HeaderText = "geny";
            this.geneNumber.Name = "geneNumber";
            this.geneNumber.ReadOnly = true;
            // 
            // populationAfterMutations
            // 
            this.populationAfterMutations.HeaderText = "po mutacji";
            this.populationAfterMutations.Name = "populationAfterMutations";
            this.populationAfterMutations.ReadOnly = true;
            // 
            // xreals
            // 
            this.xreals.HeaderText = "x";
            this.xreals.Name = "xreals";
            this.xreals.ReadOnly = true;
            // 
            // fxreal
            // 
            this.fxreal.HeaderText = "f(x)";
            this.fxreal.Name = "fxreal";
            this.fxreal.ReadOnly = true;
            // 
            // textBoxPm
            // 
            this.textBoxPm.Location = new System.Drawing.Point(781, 12);
            this.textBoxPm.Name = "textBoxPm";
            this.textBoxPm.Size = new System.Drawing.Size(100, 20);
            this.textBoxPm.TabIndex = 20;
            this.textBoxPm.Text = "0,005";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(745, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Pm=";
            // 
            // elitaCheckBox
            // 
            this.elitaCheckBox.AutoSize = true;
            this.elitaCheckBox.Checked = true;
            this.elitaCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.elitaCheckBox.Location = new System.Drawing.Point(1090, 15);
            this.elitaCheckBox.Name = "elitaCheckBox";
            this.elitaCheckBox.Size = new System.Drawing.Size(46, 17);
            this.elitaCheckBox.TabIndex = 22;
            this.elitaCheckBox.Text = "Elita";
            this.elitaCheckBox.UseVisualStyleBackColor = true;
            // 
            // textBoxT
            // 
            this.textBoxT.Location = new System.Drawing.Point(1178, 14);
            this.textBoxT.Name = "textBoxT";
            this.textBoxT.Size = new System.Drawing.Size(100, 20);
            this.textBoxT.TabIndex = 24;
            this.textBoxT.Text = "50";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(1148, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "T=";
            // 
            // GUIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1864, 471);
            this.Controls.Add(this.textBoxT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.elitaCheckBox);
            this.Controls.Add(this.textBoxPm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.breedingDashboard);
            this.Controls.Add(this.textBoxPk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainDashboard);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxD);
            this.Controls.Add(this.label4);
            this.Name = "GUIForm";
            this.Text = "Implementacja AG Wiktoria Kalata 20057";
            ((System.ComponentModel.ISupportInitialize)(this.mainDashboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breedingDashboard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView mainDashboard;
        private System.Windows.Forms.TextBox textBoxPk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn indexNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn xReal;
        private System.Windows.Forms.DataGridViewTextBoxColumn functionValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn gFunctionValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn PValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qvalue;
        private System.Windows.Forms.DataGridViewTextBoxColumn r;
        private System.Windows.Forms.DataGridView breedingDashboard;
        private System.Windows.Forms.TextBox textBoxPm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn xbinAfterSelection;
        private System.Windows.Forms.DataGridViewTextBoxColumn parents;
        private System.Windows.Forms.DataGridViewTextBoxColumn pc;
        private System.Windows.Forms.DataGridViewTextBoxColumn kids;
        private System.Windows.Forms.DataGridViewTextBoxColumn populationAfterBreeding;
        private System.Windows.Forms.DataGridViewTextBoxColumn geneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn populationAfterMutations;
        private System.Windows.Forms.DataGridViewTextBoxColumn xreals;
        private System.Windows.Forms.DataGridViewTextBoxColumn fxreal;
        private System.Windows.Forms.CheckBox elitaCheckBox;
        private System.Windows.Forms.TextBox textBoxT;
        private System.Windows.Forms.Label label3;
    }
}

