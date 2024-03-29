namespace MetaForge
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnUrl = new System.Windows.Forms.Button();
            this.tbURLImage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvMetadatos = new System.Windows.Forms.DataGridView();
            this.colMetadata = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lMaps = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMetadatos)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbImage);
            this.groupBox1.Controls.Add(this.btnUrl);
            this.groupBox1.Controls.Add(this.tbURLImage);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 335);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Imagen";
            // 
            // pbImage
            // 
            this.pbImage.BackgroundImage = global::MetaForge.Properties.Resources.Camera_icon;
            this.pbImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.Location = new System.Drawing.Point(9, 58);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(365, 271);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 3;
            this.pbImage.TabStop = false;
            this.pbImage.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.pbImage_LoadCompleted);
            this.pbImage.Validated += new System.EventHandler(this.pbImage_Validated);
            // 
            // btnUrl
            // 
            this.btnUrl.Location = new System.Drawing.Point(338, 30);
            this.btnUrl.Name = "btnUrl";
            this.btnUrl.Size = new System.Drawing.Size(36, 23);
            this.btnUrl.TabIndex = 2;
            this.btnUrl.Text = "...";
            this.btnUrl.UseVisualStyleBackColor = true;
            this.btnUrl.Click += new System.EventHandler(this.btnUrl_Click);
            // 
            // tbURLImage
            // 
            this.tbURLImage.Location = new System.Drawing.Point(9, 32);
            this.tbURLImage.Name = "tbURLImage";
            this.tbURLImage.Size = new System.Drawing.Size(323, 20);
            this.tbURLImage.TabIndex = 1;
            this.tbURLImage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbURLImage_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dirección de la imagen:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvMetadatos);
            this.groupBox2.Location = new System.Drawing.Point(401, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(528, 464);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Metadatos";
            // 
            // dgvMetadatos
            // 
            this.dgvMetadatos.AllowUserToAddRows = false;
            this.dgvMetadatos.AllowUserToDeleteRows = false;
            this.dgvMetadatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMetadatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMetadata,
            this.colValue});
            this.dgvMetadatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMetadatos.Location = new System.Drawing.Point(3, 16);
            this.dgvMetadatos.Name = "dgvMetadatos";
            this.dgvMetadatos.RowHeadersVisible = false;
            this.dgvMetadatos.Size = new System.Drawing.Size(522, 445);
            this.dgvMetadatos.TabIndex = 0;
            // 
            // colMetadata
            // 
            this.colMetadata.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colMetadata.HeaderText = "Metadato";
            this.colMetadata.Name = "colMetadata";
            this.colMetadata.Width = 77;
            // 
            // colValue
            // 
            this.colValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colValue.HeaderText = "Valor";
            this.colValue.Name = "colValue";
            this.colValue.Width = 56;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Imágenes (*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCopy);
            this.groupBox3.Controls.Add(this.lMaps);
            this.groupBox3.Location = new System.Drawing.Point(12, 353);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(383, 123);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Liga de google maps";
            // 
            // lMaps
            // 
            this.lMaps.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lMaps.Location = new System.Drawing.Point(6, 16);
            this.lMaps.Name = "lMaps";
            this.lMaps.Size = new System.Drawing.Size(368, 52);
            this.lMaps.TabIndex = 0;
            this.lMaps.Text = "SIN UBICACION";
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(299, 94);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 1;
            this.btnCopy.Text = "Copiar";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.Active = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 488);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Main";
            this.Text = "VIAR MetaForge";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMetadatos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btnUrl;
        private System.Windows.Forms.TextBox tbURLImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvMetadatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMetadata;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValue;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Label lMaps;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

