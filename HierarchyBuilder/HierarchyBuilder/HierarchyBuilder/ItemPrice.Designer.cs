namespace HierarchyBuilder
{
    partial class ItemPrice
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
            this.dataGridViewTable = new System.Windows.Forms.DataGridView();
            this.listBoxCriteria = new System.Windows.Forms.ListBox();
            this.buttonSaveCalculations = new System.Windows.Forms.Button();
            this.buttonSolve = new System.Windows.Forms.Button();
            this.buttonChoice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTable
            // 
            this.dataGridViewTable.AllowUserToAddRows = false;
            this.dataGridViewTable.AllowUserToDeleteRows = false;
            this.dataGridViewTable.AllowUserToResizeColumns = false;
            this.dataGridViewTable.AllowUserToResizeRows = false;
            this.dataGridViewTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTable.EnableHeadersVisualStyles = false;
            this.dataGridViewTable.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewTable.MultiSelect = false;
            this.dataGridViewTable.Name = "dataGridViewTable";
            this.dataGridViewTable.RowHeadersVisible = false;
            this.dataGridViewTable.RowHeadersWidth = 30;
            this.dataGridViewTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewTable.Size = new System.Drawing.Size(378, 274);
            this.dataGridViewTable.StandardTab = true;
            this.dataGridViewTable.TabIndex = 3;
            this.dataGridViewTable.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridViewTable_CellBeginEdit);
            this.dataGridViewTable.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTable_CellEndEdit);
            // 
            // listBoxCriteria
            // 
            this.listBoxCriteria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxCriteria.FormattingEnabled = true;
            this.listBoxCriteria.Location = new System.Drawing.Point(396, 12);
            this.listBoxCriteria.Name = "listBoxCriteria";
            this.listBoxCriteria.Size = new System.Drawing.Size(176, 303);
            this.listBoxCriteria.TabIndex = 7;
            this.listBoxCriteria.DoubleClick += new System.EventHandler(this.listBoxCriteria_DoubleClick);
            // 
            // buttonSaveCalculations
            // 
            this.buttonSaveCalculations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSaveCalculations.Location = new System.Drawing.Point(306, 292);
            this.buttonSaveCalculations.Name = "buttonSaveCalculations";
            this.buttonSaveCalculations.Size = new System.Drawing.Size(84, 23);
            this.buttonSaveCalculations.TabIndex = 10;
            this.buttonSaveCalculations.Text = "Сохранить веса";
            this.buttonSaveCalculations.UseVisualStyleBackColor = true;
            this.buttonSaveCalculations.Click += new System.EventHandler(this.buttonSaveCalculations_Click);
            // 
            // buttonSolve
            // 
            this.buttonSolve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSolve.Location = new System.Drawing.Point(12, 292);
            this.buttonSolve.Name = "buttonSolve";
            this.buttonSolve.Size = new System.Drawing.Size(84, 23);
            this.buttonSolve.TabIndex = 9;
            this.buttonSolve.Text = "Рассчитать";
            this.buttonSolve.UseVisualStyleBackColor = true;
            this.buttonSolve.Click += new System.EventHandler(this.buttonSolve_Click);
            // 
            // buttonChoice
            // 
            this.buttonChoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChoice.Location = new System.Drawing.Point(396, 326);
            this.buttonChoice.Name = "buttonChoice";
            this.buttonChoice.Size = new System.Drawing.Size(175, 23);
            this.buttonChoice.TabIndex = 8;
            this.buttonChoice.Text = "Выбрать";
            this.buttonChoice.UseVisualStyleBackColor = true;
            this.buttonChoice.Click += new System.EventHandler(this.buttonChoice_Click);
            // 
            // ItemPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.buttonSaveCalculations);
            this.Controls.Add(this.buttonSolve);
            this.Controls.Add(this.buttonChoice);
            this.Controls.Add(this.listBoxCriteria);
            this.Controls.Add(this.dataGridViewTable);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "ItemPrice";
            this.Text = "ItemPrice";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTable;
        private System.Windows.Forms.ListBox listBoxCriteria;
        private System.Windows.Forms.Button buttonSaveCalculations;
        private System.Windows.Forms.Button buttonSolve;
        private System.Windows.Forms.Button buttonChoice;
    }
}