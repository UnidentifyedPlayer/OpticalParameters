namespace Prototype_1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.data_view = new System.Windows.Forms.DataGridView();
            this.open_file_button = new System.Windows.Forms.Button();
            this.calculate_button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.add_row_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.save_button = new System.Windows.Forms.Button();
            this.CosX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CosY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CosZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.U = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.data_view)).BeginInit();
            this.SuspendLayout();
            // 
            // data_view
            // 
            this.data_view.AllowUserToAddRows = false;
            this.data_view.AllowUserToResizeColumns = false;
            this.data_view.AllowUserToResizeRows = false;
            this.data_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CosX,
            this.CosY,
            this.CosZ,
            this.U});
            this.data_view.Location = new System.Drawing.Point(265, 12);
            this.data_view.Name = "data_view";
            this.data_view.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.data_view.Size = new System.Drawing.Size(443, 537);
            this.data_view.TabIndex = 0;
            // 
            // open_file_button
            // 
            this.open_file_button.Location = new System.Drawing.Point(12, 12);
            this.open_file_button.Name = "open_file_button";
            this.open_file_button.Size = new System.Drawing.Size(75, 23);
            this.open_file_button.TabIndex = 1;
            this.open_file_button.Text = "Open";
            this.open_file_button.UseVisualStyleBackColor = true;
            this.open_file_button.Click += new System.EventHandler(this.open_file_button_Click);
            // 
            // calculate_button
            // 
            this.calculate_button.Location = new System.Drawing.Point(12, 221);
            this.calculate_button.Name = "calculate_button";
            this.calculate_button.Size = new System.Drawing.Size(75, 23);
            this.calculate_button.TabIndex = 2;
            this.calculate_button.Text = "Calculate";
            this.calculate_button.UseVisualStyleBackColor = true;
            this.calculate_button.Click += new System.EventHandler(this.calculate_button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 250);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(247, 166);
            this.textBox1.TabIndex = 3;
            // 
            // add_row_button
            // 
            this.add_row_button.Location = new System.Drawing.Point(184, 41);
            this.add_row_button.Name = "add_row_button";
            this.add_row_button.Size = new System.Drawing.Size(75, 23);
            this.add_row_button.TabIndex = 4;
            this.add_row_button.Text = "Add Row";
            this.add_row_button.UseVisualStyleBackColor = true;
            this.add_row_button.Click += new System.EventHandler(this.add_row_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(12, 41);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(75, 23);
            this.save_button.TabIndex = 6;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // CosX
            // 
            this.CosX.Frozen = true;
            this.CosX.HeaderText = "L";
            this.CosX.Name = "CosX";
            this.CosX.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // CosY
            // 
            this.CosY.Frozen = true;
            this.CosY.HeaderText = "M";
            this.CosY.Name = "CosY";
            this.CosY.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // CosZ
            // 
            this.CosZ.Frozen = true;
            this.CosZ.HeaderText = "N";
            this.CosZ.Name = "CosZ";
            this.CosZ.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // U
            // 
            this.U.Frozen = true;
            this.U.HeaderText = "U";
            this.U.Name = "U";
            this.U.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 561);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add_row_button);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.calculate_button);
            this.Controls.Add(this.open_file_button);
            this.Controls.Add(this.data_view);
            this.Name = "Form1";
            this.Text = "Save";
            ((System.ComponentModel.ISupportInitialize)(this.data_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_view;
        private System.Windows.Forms.Button open_file_button;
        private System.Windows.Forms.Button calculate_button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button add_row_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn CosX;
        private System.Windows.Forms.DataGridViewTextBoxColumn CosY;
        private System.Windows.Forms.DataGridViewTextBoxColumn CosZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn U;
    }
}

