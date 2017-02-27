namespace VehicleRegistrationPlate
{
    partial class frmVehiclePlateReader
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
            this.grpWorkingArea = new System.Windows.Forms.GroupBox();
            this.grpSelector = new System.Windows.Forms.GroupBox();
            this.txtWorkingArea = new System.Windows.Forms.TextBox();
            this.btnWorkingArea = new System.Windows.Forms.Button();
            this.pictureToScan = new System.Windows.Forms.PictureBox();
            this.lblPatente = new System.Windows.Forms.Label();
            this.lblEmptyMessage = new System.Windows.Forms.Label();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.grpWorkingArea.SuspendLayout();
            this.grpSelector.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureToScan)).BeginInit();
            this.SuspendLayout();
            // 
            // grpWorkingArea
            // 
            this.grpWorkingArea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpWorkingArea.Controls.Add(this.btnWorkingArea);
            this.grpWorkingArea.Controls.Add(this.txtWorkingArea);
            this.grpWorkingArea.Location = new System.Drawing.Point(13, 13);
            this.grpWorkingArea.Name = "grpWorkingArea";
            this.grpWorkingArea.Size = new System.Drawing.Size(742, 65);
            this.grpWorkingArea.TabIndex = 0;
            this.grpWorkingArea.TabStop = false;
            this.grpWorkingArea.Text = "Area de Trabajo";
            // 
            // grpSelector
            // 
            this.grpSelector.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSelector.Controls.Add(this.lblEmptyMessage);
            this.grpSelector.Controls.Add(this.lblPatente);
            this.grpSelector.Controls.Add(this.pictureToScan);
            this.grpSelector.Enabled = false;
            this.grpSelector.Location = new System.Drawing.Point(13, 104);
            this.grpSelector.Name = "grpSelector";
            this.grpSelector.Size = new System.Drawing.Size(742, 377);
            this.grpSelector.TabIndex = 1;
            this.grpSelector.TabStop = false;
            this.grpSelector.Text = "Selector";
            // 
            // txtWorkingArea
            // 
            this.txtWorkingArea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWorkingArea.Enabled = false;
            this.txtWorkingArea.Location = new System.Drawing.Point(16, 33);
            this.txtWorkingArea.Name = "txtWorkingArea";
            this.txtWorkingArea.Size = new System.Drawing.Size(628, 20);
            this.txtWorkingArea.TabIndex = 0;
            // 
            // btnWorkingArea
            // 
            this.btnWorkingArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWorkingArea.Location = new System.Drawing.Point(650, 31);
            this.btnWorkingArea.Name = "btnWorkingArea";
            this.btnWorkingArea.Size = new System.Drawing.Size(75, 23);
            this.btnWorkingArea.TabIndex = 1;
            this.btnWorkingArea.Text = "Establecer";
            this.btnWorkingArea.UseVisualStyleBackColor = true;
            this.btnWorkingArea.Click += new System.EventHandler(this.btnWorkingArea_Click);
            // 
            // pictureToScan
            // 
            this.pictureToScan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureToScan.Location = new System.Drawing.Point(16, 78);
            this.pictureToScan.Name = "pictureToScan";
            this.pictureToScan.Size = new System.Drawing.Size(709, 274);
            this.pictureToScan.TabIndex = 0;
            this.pictureToScan.TabStop = false;
            this.pictureToScan.Click += new System.EventHandler(this.pictureToScan_Click);
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatente.Location = new System.Drawing.Point(16, 42);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(92, 20);
            this.lblPatente.TabIndex = 1;
            this.lblPatente.Text = "Pantente: ";
            // 
            // lblEmptyMessage
            // 
            this.lblEmptyMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEmptyMessage.AutoSize = true;
            this.lblEmptyMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmptyMessage.Location = new System.Drawing.Point(21, 336);
            this.lblEmptyMessage.Name = "lblEmptyMessage";
            this.lblEmptyMessage.Size = new System.Drawing.Size(364, 13);
            this.lblEmptyMessage.TabIndex = 2;
            this.lblEmptyMessage.Text = "Haga click sobre este mensaje para cargar una imagen y obtener la patente";
            this.lblEmptyMessage.Click += new System.EventHandler(this.lblEmptyMessage_Click);
            // 
            // fileDialog
            // 
            this.fileDialog.FileName = "fileDialog";
            // 
            // frmVehiclePlateReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 492);
            this.Controls.Add(this.grpSelector);
            this.Controls.Add(this.grpWorkingArea);
            this.Name = "frmVehiclePlateReader";
            this.Text = "Lector de Pantentes";
            this.grpWorkingArea.ResumeLayout(false);
            this.grpWorkingArea.PerformLayout();
            this.grpSelector.ResumeLayout(false);
            this.grpSelector.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureToScan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpWorkingArea;
        private System.Windows.Forms.Button btnWorkingArea;
        private System.Windows.Forms.TextBox txtWorkingArea;
        private System.Windows.Forms.GroupBox grpSelector;
        private System.Windows.Forms.Label lblEmptyMessage;
        private System.Windows.Forms.Label lblPatente;
        private System.Windows.Forms.PictureBox pictureToScan;
        private System.Windows.Forms.OpenFileDialog fileDialog;
    }
}

