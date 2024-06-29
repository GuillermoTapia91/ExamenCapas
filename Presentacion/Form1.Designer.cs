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
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegion)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListarRegion
            // 
            this.btnListarRegion.Location = new System.Drawing.Point(46, 152);
            this.btnListarRegion.Name = "btnListarRegion";
            this.btnListarRegion.Size = new System.Drawing.Size(106, 29);
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
            this.dgvRegion.Location = new System.Drawing.Point(182, 152);
            this.dgvRegion.Name = "dgvRegion";
            this.dgvRegion.RowHeadersWidth = 51;
            this.dgvRegion.RowTemplate.Height = 29;
            this.dgvRegion.Size = new System.Drawing.Size(541, 188);
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
            this.txtRegionName.Location = new System.Drawing.Point(250, 63);
            this.txtRegionName.Name = "txtRegionName";
            this.txtRegionName.Size = new System.Drawing.Size(189, 27);
            this.txtRegionName.TabIndex = 2;
            // 
            // btnInsertRegion
            // 
            this.btnInsertRegion.Location = new System.Drawing.Point(445, 62);
            this.btnInsertRegion.Name = "btnInsertRegion";
            this.btnInsertRegion.Size = new System.Drawing.Size(138, 29);
            this.btnInsertRegion.TabIndex = 3;
            this.btnInsertRegion.Text = "Crear Región";
            this.btnInsertRegion.UseVisualStyleBackColor = true;
            this.btnInsertRegion.Click += new System.EventHandler(this.btnInsertRegion_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(29, 63);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(215, 20);
            this.label.TabIndex = 4;
            this.label.Text = "Nombre de la Region a Crear:";
            this.label.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.label);
            this.Controls.Add(this.btnInsertRegion);
            this.Controls.Add(this.txtRegionName);
            this.Controls.Add(this.dgvRegion);
            this.Controls.Add(this.btnListarRegion);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}