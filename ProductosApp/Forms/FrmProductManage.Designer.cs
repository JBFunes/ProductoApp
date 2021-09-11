namespace ProductosApp.Forms
{
    partial class FrmProductManage
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbFinder = new System.Windows.Forms.ComboBox();
            this.pnlId = new System.Windows.Forms.Panel();
            this.txtId = new System.Windows.Forms.TextBox();
            this.pnlMeasureUnit = new System.Windows.Forms.Panel();
            this.cmbMeasureUnit = new System.Windows.Forms.ComboBox();
            this.pnlPriceRange = new System.Windows.Forms.Panel();
            this.nudToPrice = new System.Windows.Forms.NumericUpDown();
            this.nudFromPrice = new System.Windows.Forms.NumericUpDown();
            this.pnlCaducity = new System.Windows.Forms.Panel();
            this.dtpCaducity = new System.Windows.Forms.DateTimePicker();
            this.rtbProductView = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlId.SuspendLayout();
            this.pnlMeasureUnit.SuspendLayout();
            this.pnlPriceRange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudToPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFromPrice)).BeginInit();
            this.pnlCaducity.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnUpdate);
            this.flowLayoutPanel1.Controls.Add(this.btnNew);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 371);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(615, 30);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(538, 2);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 24);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Modificar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(459, 2);
            this.btnNew.Margin = new System.Windows.Forms.Padding(2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 24);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "Nuevo";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(380, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 24);
            this.button1.TabIndex = 3;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbFinder
            // 
            this.cmbFinder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFinder.FormattingEnabled = true;
            this.cmbFinder.Items.AddRange(new object[] {
            "Id",
            "Unidad de Medida",
            "Rango de Precio",
            "Fecha de Vencimiento"});
            this.cmbFinder.Location = new System.Drawing.Point(9, 9);
            this.cmbFinder.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFinder.Name = "cmbFinder";
            this.cmbFinder.Size = new System.Drawing.Size(150, 21);
            this.cmbFinder.TabIndex = 1;
            this.cmbFinder.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // pnlId
            // 
            this.pnlId.Controls.Add(this.txtId);
            this.pnlId.Location = new System.Drawing.Point(188, 1);
            this.pnlId.Margin = new System.Windows.Forms.Padding(2);
            this.pnlId.Name = "pnlId";
            this.pnlId.Size = new System.Drawing.Size(267, 29);
            this.pnlId.TabIndex = 2;
            this.pnlId.Visible = false;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(2, 3);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(254, 20);
            this.txtId.TabIndex = 3;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // pnlMeasureUnit
            // 
            this.pnlMeasureUnit.Controls.Add(this.cmbMeasureUnit);
            this.pnlMeasureUnit.Location = new System.Drawing.Point(181, 2);
            this.pnlMeasureUnit.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMeasureUnit.Name = "pnlMeasureUnit";
            this.pnlMeasureUnit.Size = new System.Drawing.Size(299, 28);
            this.pnlMeasureUnit.TabIndex = 3;
            this.pnlMeasureUnit.Visible = false;
            // 
            // cmbMeasureUnit
            // 
            this.cmbMeasureUnit.FormattingEnabled = true;
            this.cmbMeasureUnit.Location = new System.Drawing.Point(6, 2);
            this.cmbMeasureUnit.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMeasureUnit.Name = "cmbMeasureUnit";
            this.cmbMeasureUnit.Size = new System.Drawing.Size(254, 21);
            this.cmbMeasureUnit.TabIndex = 4;
            this.cmbMeasureUnit.SelectedIndexChanged += new System.EventHandler(this.cmbMeasureUnit_SelectedIndexChanged);
            // 
            // pnlPriceRange
            // 
            this.pnlPriceRange.Controls.Add(this.nudFromPrice);
            this.pnlPriceRange.Controls.Add(this.nudToPrice);
            this.pnlPriceRange.Location = new System.Drawing.Point(163, 4);
            this.pnlPriceRange.Margin = new System.Windows.Forms.Padding(2);
            this.pnlPriceRange.Name = "pnlPriceRange";
            this.pnlPriceRange.Size = new System.Drawing.Size(319, 26);
            this.pnlPriceRange.TabIndex = 3;
            this.pnlPriceRange.Visible = false;
            // 
            // nudToPrice
            // 
            this.nudToPrice.Location = new System.Drawing.Point(143, 2);
            this.nudToPrice.Margin = new System.Windows.Forms.Padding(2);
            this.nudToPrice.Name = "nudToPrice";
            this.nudToPrice.Size = new System.Drawing.Size(122, 20);
            this.nudToPrice.TabIndex = 4;
            this.nudToPrice.ValueChanged += new System.EventHandler(this.nudToPrice_ValueChanged);
            // 
            // nudFromPrice
            // 
            this.nudFromPrice.Location = new System.Drawing.Point(7, 2);
            this.nudFromPrice.Margin = new System.Windows.Forms.Padding(2);
            this.nudFromPrice.Name = "nudFromPrice";
            this.nudFromPrice.Size = new System.Drawing.Size(122, 20);
            this.nudFromPrice.TabIndex = 4;
            this.nudFromPrice.ValueChanged += new System.EventHandler(this.nudFromPrice_ValueChanged);
            // 
            // pnlCaducity
            // 
            this.pnlCaducity.Controls.Add(this.dtpCaducity);
            this.pnlCaducity.Location = new System.Drawing.Point(181, 3);
            this.pnlCaducity.Margin = new System.Windows.Forms.Padding(2);
            this.pnlCaducity.Name = "pnlCaducity";
            this.pnlCaducity.Size = new System.Drawing.Size(280, 27);
            this.pnlCaducity.TabIndex = 4;
            this.pnlCaducity.Visible = false;
            // 
            // dtpCaducity
            // 
            this.dtpCaducity.Location = new System.Drawing.Point(2, 2);
            this.dtpCaducity.Margin = new System.Windows.Forms.Padding(2);
            this.dtpCaducity.Name = "dtpCaducity";
            this.dtpCaducity.Size = new System.Drawing.Size(235, 20);
            this.dtpCaducity.TabIndex = 5;
            this.dtpCaducity.ValueChanged += new System.EventHandler(this.dtpCaducity_ValueChanged);
            // 
            // rtbProductView
            // 
            this.rtbProductView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbProductView.Location = new System.Drawing.Point(15, 34);
            this.rtbProductView.Margin = new System.Windows.Forms.Padding(2);
            this.rtbProductView.Name = "rtbProductView";
            this.rtbProductView.ReadOnly = true;
            this.rtbProductView.Size = new System.Drawing.Size(598, 323);
            this.rtbProductView.TabIndex = 5;
            this.rtbProductView.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(515, 4);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 24);
            this.button2.TabIndex = 4;
            this.button2.Text = "Mostrar Todos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmProductManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 401);
            this.Controls.Add(this.pnlCaducity);
            this.Controls.Add(this.pnlPriceRange);
            this.Controls.Add(this.pnlMeasureUnit);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pnlId);
            this.Controls.Add(this.cmbFinder);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.rtbProductView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmProductManage";
            this.Text = "Gestion de productos";
            this.Load += new System.EventHandler(this.FrmProductManage_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnlId.ResumeLayout(false);
            this.pnlId.PerformLayout();
            this.pnlMeasureUnit.ResumeLayout(false);
            this.pnlPriceRange.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudToPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFromPrice)).EndInit();
            this.pnlCaducity.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.ComboBox cmbFinder;
        private System.Windows.Forms.Panel pnlId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Panel pnlMeasureUnit;
        private System.Windows.Forms.ComboBox cmbMeasureUnit;
        private System.Windows.Forms.Panel pnlPriceRange;
        private System.Windows.Forms.NumericUpDown nudToPrice;
        private System.Windows.Forms.NumericUpDown nudFromPrice;
        private System.Windows.Forms.Panel pnlCaducity;
        private System.Windows.Forms.DateTimePicker dtpCaducity;
        private System.Windows.Forms.RichTextBox rtbProductView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}