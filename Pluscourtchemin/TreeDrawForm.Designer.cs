namespace Pluscourtchemin
{
    partial class TreeDrawForm
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
            this.buttonValider = new System.Windows.Forms.Button();
            this.groupBoxConsignes = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // buttonValider
            // 
            this.buttonValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonValider.Location = new System.Drawing.Point(150, 361);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(88, 31);
            this.buttonValider.TabIndex = 0;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            // 
            // groupBoxConsignes
            // 
            this.groupBoxConsignes.Location = new System.Drawing.Point(13, 12);
            this.groupBoxConsignes.Name = "groupBoxConsignes";
            this.groupBoxConsignes.Size = new System.Drawing.Size(363, 100);
            this.groupBoxConsignes.TabIndex = 2;
            this.groupBoxConsignes.TabStop = false;
            this.groupBoxConsignes.Text = "Consignes";
            // 
            // TreeDrawForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(388, 404);
            this.Controls.Add(this.groupBoxConsignes);
            this.Controls.Add(this.buttonValider);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "TreeDrawForm";
            this.Text = "Arbre Dijkstra";
            this.Load += new System.EventHandler(this.DrawForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.GroupBox groupBoxConsignes;
    }
}