namespace DisConnectedMode
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
            textBox = new TextBox();
            dataGridView = new DataGridView();
            btn_search = new Button();
            btn_delete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // textBox
            // 
            textBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox.Location = new Point(14, 16);
            textBox.Margin = new Padding(3, 4, 3, 4);
            textBox.Name = "textBox";
            textBox.Size = new Size(593, 47);
            textBox.TabIndex = 0;
            // 
            // dataGridView
            // 
            dataGridView.BackgroundColor = SystemColors.ControlLight;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.GridColor = SystemColors.ControlLight;
            dataGridView.Location = new Point(14, 118);
            dataGridView.Margin = new Padding(3, 4, 3, 4);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(1171, 689);
            dataGridView.TabIndex = 2;
            // 
            // btn_search
            // 
            btn_search.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn_search.Location = new Point(630, 7);
            btn_search.Margin = new Padding(3, 4, 3, 4);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(150, 56);
            btn_search.TabIndex = 3;
            btn_search.Text = "Search";
            btn_search.UseVisualStyleBackColor = true;
            btn_search.Click += btn_select_Click;
            // 
            // btn_delete
            // 
            btn_delete.FlatStyle = FlatStyle.Popup;
            btn_delete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_delete.Location = new Point(786, 7);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(94, 56);
            btn_delete.TabIndex = 4;
            btn_delete.Text = "EXEC";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_exec_click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 823);
            Controls.Add(btn_delete);
            Controls.Add(btn_search);
            Controls.Add(dataGridView);
            Controls.Add(textBox);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox;
        private Button btn_execute;
        private DataGridView dataGridView;
        private Button btn_search;
        private Button btn_delete;
    }
}