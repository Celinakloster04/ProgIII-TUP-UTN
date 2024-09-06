namespace PaginaPrincipal
{
    partial class Ejercicio1
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
            this.lblIngreseNombre = new System.Windows.Forms.Label();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lbIzq = new System.Windows.Forms.ListBox();
            this.lbDer = new System.Windows.Forms.ListBox();
            this.btnPasarUnItem = new System.Windows.Forms.Button();
            this.btnPasarItems = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIngreseNombre
            // 
            this.lblIngreseNombre.AutoSize = true;
            this.lblIngreseNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngreseNombre.Location = new System.Drawing.Point(138, 95);
            this.lblIngreseNombre.Name = "lblIngreseNombre";
            this.lblIngreseNombre.Size = new System.Drawing.Size(153, 18);
            this.lblIngreseNombre.TabIndex = 0;
            this.lblIngreseNombre.Text = "Ingrese un nombre:";
            // 
            // tbxNombre
            // 
            this.tbxNombre.Location = new System.Drawing.Point(315, 94);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(271, 22);
            this.tbxNombre.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(616, 84);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(85, 32);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lbIzq
            // 
            this.lbIzq.FormattingEnabled = true;
            this.lbIzq.ItemHeight = 16;
            this.lbIzq.Location = new System.Drawing.Point(127, 188);
            this.lbIzq.Name = "lbIzq";
            this.lbIzq.Size = new System.Drawing.Size(188, 244);
            this.lbIzq.TabIndex = 3;
            // 
            // lbDer
            // 
            this.lbDer.FormattingEnabled = true;
            this.lbDer.ItemHeight = 16;
            this.lbDer.Location = new System.Drawing.Point(538, 188);
            this.lbDer.Name = "lbDer";
            this.lbDer.Size = new System.Drawing.Size(188, 244);
            this.lbDer.TabIndex = 4;
            // 
            // btnPasarUnItem
            // 
            this.btnPasarUnItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasarUnItem.Location = new System.Drawing.Point(386, 246);
            this.btnPasarUnItem.Name = "btnPasarUnItem";
            this.btnPasarUnItem.Size = new System.Drawing.Size(75, 33);
            this.btnPasarUnItem.TabIndex = 5;
            this.btnPasarUnItem.Text = ">";
            this.btnPasarUnItem.UseVisualStyleBackColor = true;
            this.btnPasarUnItem.Click += new System.EventHandler(this.btnPasarUnItem_Click);
            // 
            // btnPasarItems
            // 
            this.btnPasarItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasarItems.Location = new System.Drawing.Point(386, 334);
            this.btnPasarItems.Name = "btnPasarItems";
            this.btnPasarItems.Size = new System.Drawing.Size(75, 33);
            this.btnPasarItems.TabIndex = 6;
            this.btnPasarItems.Text = ">>";
            this.btnPasarItems.UseVisualStyleBackColor = true;
            this.btnPasarItems.Click += new System.EventHandler(this.btnPasarItems_Click);
            // 
            // Ejercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 531);
            this.Controls.Add(this.btnPasarItems);
            this.Controls.Add(this.btnPasarUnItem);
            this.Controls.Add(this.lbDer);
            this.Controls.Add(this.lbIzq);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.tbxNombre);
            this.Controls.Add(this.lblIngreseNombre);
            this.Name = "Ejercicio1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIngreseNombre;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox lbIzq;
        private System.Windows.Forms.ListBox lbDer;
        private System.Windows.Forms.Button btnPasarUnItem;
        private System.Windows.Forms.Button btnPasarItems;
    }
}