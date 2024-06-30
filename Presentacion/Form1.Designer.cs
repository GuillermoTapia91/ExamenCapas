namespace Presentacion
{
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
            this.btnListarRegion = new System.Windows.Forms.Button();
            this.dgvRegion = new System.Windows.Forms.DataGridView();
            this.RegionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Enabled = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtRegionName = new System.Windows.Forms.TextBox();
            this.btnInsertRegion = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEditRegionID = new System.Windows.Forms.TextBox();
            this.txtEditRegionName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEditRegion = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDeleteRegion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDeleteRegion = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegion)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnListarRegion
            // 
            this.btnListarRegion.Location = new System.Drawing.Point(22, 300);
            this.btnListarRegion.Name = "btnListarRegion";
            this.btnListarRegion.Size = new System.Drawing.Size(106, 31);
            this.btnListarRegion.TabIndex = 0;
            this.btnListarRegion.Text = "Listar";
            this.btnListarRegion.UseVisualStyleBackColor = true;
            this.btnListarRegion.Click += new System.EventHandler(this.btnListarRegion_Click);
            // 
            // dgvRegion
            // 
            this.dgvRegion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RegionId,
            this.RegionName,
            this.Enabled});
            this.dgvRegion.Location = new System.Drawing.Point(158, 300);
            this.dgvRegion.Name = "dgvRegion";
            this.dgvRegion.RowHeadersWidth = 51;
            this.dgvRegion.RowTemplate.Height = 29;
            this.dgvRegion.Size = new System.Drawing.Size(436, 353);
            this.dgvRegion.TabIndex = 1;
            // 
            // RegionId
            // 
            this.RegionId.DataPropertyName = "RegionId";
            this.RegionId.HeaderText = "RegionId";
            this.RegionId.MinimumWidth = 6;
            this.RegionId.Name = "RegionId";
            this.RegionId.Width = 125;
            // 
            // RegionName
            // 
            this.RegionName.DataPropertyName = "RegionName";
            this.RegionName.HeaderText = "RegionName";
            this.RegionName.MinimumWidth = 6;
            this.RegionName.Name = "RegionName";
            this.RegionName.Width = 125;
            // 
            // Enabled
            // 
            this.Enabled.DataPropertyName = "Enabled";
            this.Enabled.HeaderText = "Enabled";
            this.Enabled.MinimumWidth = 6;
            this.Enabled.Name = "Enabled";
            this.Enabled.Width = 125;
            // 
            // txtRegionName
            // 
            this.txtRegionName.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtRegionName.Location = new System.Drawing.Point(238, 38);
            this.txtRegionName.Name = "txtRegionName";
            this.txtRegionName.Size = new System.Drawing.Size(189, 27);
            this.txtRegionName.TabIndex = 2;
            // 
            // btnInsertRegion
            // 
            this.btnInsertRegion.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnInsertRegion.Location = new System.Drawing.Point(737, 35);
            this.btnInsertRegion.Name = "btnInsertRegion";
            this.btnInsertRegion.Size = new System.Drawing.Size(133, 29);
            this.btnInsertRegion.TabIndex = 3;
            this.btnInsertRegion.Text = "Crear Región";
            this.btnInsertRegion.UseVisualStyleBackColor = true;
            this.btnInsertRegion.Click += new System.EventHandler(this.btnInsertRegion_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label.Location = new System.Drawing.Point(17, 42);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(215, 20);
            this.label.TabIndex = 4;
            this.label.Text = "Nombre de la Region a Crear:";
            this.label.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID de la Region a editar: ";
            // 
            // txtEditRegionID
            // 
            this.txtEditRegionID.Location = new System.Drawing.Point(200, 39);
            this.txtEditRegionID.Name = "txtEditRegionID";
            this.txtEditRegionID.Size = new System.Drawing.Size(125, 27);
            this.txtEditRegionID.TabIndex = 6;
            // 
            // txtEditRegionName
            // 
            this.txtEditRegionName.Location = new System.Drawing.Point(556, 39);
            this.txtEditRegionName.Name = "txtEditRegionName";
            this.txtEditRegionName.Size = new System.Drawing.Size(170, 27);
            this.txtEditRegionName.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nuevo Nombre de la Región: ";
            // 
            // btnEditRegion
            // 
            this.btnEditRegion.Location = new System.Drawing.Point(733, 39);
            this.btnEditRegion.Name = "btnEditRegion";
            this.btnEditRegion.Size = new System.Drawing.Size(133, 29);
            this.btnEditRegion.TabIndex = 9;
            this.btnEditRegion.Text = "Editar Región";
            this.btnEditRegion.UseVisualStyleBackColor = true;
            this.btnEditRegion.Click += new System.EventHandler(this.btnEditRegion_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Controls.Add(this.btnInsertRegion);
            this.groupBox1.Controls.Add(this.txtRegionName);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(876, 96);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crear Región";
            // 
            // txtDeleteRegion
            // 
            this.txtDeleteRegion.Location = new System.Drawing.Point(209, 27);
            this.txtDeleteRegion.Name = "txtDeleteRegion";
            this.txtDeleteRegion.Size = new System.Drawing.Size(125, 27);
            this.txtDeleteRegion.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "ID de la Region a eliminar: ";
            // 
            // btnDeleteRegion
            // 
            this.btnDeleteRegion.Location = new System.Drawing.Point(733, 23);
            this.btnDeleteRegion.Name = "btnDeleteRegion";
            this.btnDeleteRegion.Size = new System.Drawing.Size(133, 29);
            this.btnDeleteRegion.TabIndex = 13;
            this.btnDeleteRegion.Text = "Eliminar Region";
            this.btnDeleteRegion.UseVisualStyleBackColor = true;
            this.btnDeleteRegion.Click += new System.EventHandler(this.btnDeleteRegion_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Lavender;
            this.groupBox2.Controls.Add(this.btnEditRegion);
            this.groupBox2.Controls.Add(this.txtEditRegionName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtEditRegionID);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(876, 92);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Editar Región";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Lavender;
            this.groupBox3.Controls.Add(this.btnDeleteRegion);
            this.groupBox3.Controls.Add(this.txtDeleteRegion);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(12, 216);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(876, 64);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Eliminar Región";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 665);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvRegion);
            this.Controls.Add(this.btnListarRegion);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegion)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnListarRegion;
        private DataGridView dgvRegion;
        private DataGridViewTextBoxColumn RegionId;
        private DataGridViewTextBoxColumn RegionName;
        private DataGridViewTextBoxColumn Enabled;
        private TextBox txtRegionName;
        private Button btnInsertRegion;
        private Label label;
        private Label label1;
        private TextBox txtEditRegionID;
        private TextBox txtEditRegionName;
        private Label label2;
        private Button btnEditRegion;
        private GroupBox groupBox1;
        private TextBox txtDeleteRegion;
        private Label label3;
        private Button btnDeleteRegion;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
    }
}