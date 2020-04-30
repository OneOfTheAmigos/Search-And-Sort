namespace SearchandSort
{
    partial class Form1
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblPresortedNumbers = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSortedNumbers = new System.Windows.Forms.Label();
            this.btnSelectionSort = new System.Windows.Forms.Button();
            this.btnInsertSort = new System.Windows.Forms.Button();
            this.btnMerge = new System.Windows.Forms.Button();
            this.txtSearchInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSearchPosition = new System.Windows.Forms.Label();
            this.lblSteps = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(528, 40);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(123, 52);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search ";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblPresortedNumbers
            // 
            this.lblPresortedNumbers.AutoSize = true;
            this.lblPresortedNumbers.Location = new System.Drawing.Point(194, 157);
            this.lblPresortedNumbers.Name = "lblPresortedNumbers";
            this.lblPresortedNumbers.Size = new System.Drawing.Size(32, 17);
            this.lblPresortedNumbers.TabIndex = 1;
            this.lblPresortedNumbers.Text = "___";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pre-Sorted Numbers:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sorted Numbers:";
            // 
            // lblSortedNumbers
            // 
            this.lblSortedNumbers.AutoSize = true;
            this.lblSortedNumbers.Location = new System.Drawing.Point(197, 212);
            this.lblSortedNumbers.Name = "lblSortedNumbers";
            this.lblSortedNumbers.Size = new System.Drawing.Size(32, 17);
            this.lblSortedNumbers.TabIndex = 4;
            this.lblSortedNumbers.Text = "___";
            // 
            // btnSelectionSort
            // 
            this.btnSelectionSort.Location = new System.Drawing.Point(38, 40);
            this.btnSelectionSort.Name = "btnSelectionSort";
            this.btnSelectionSort.Size = new System.Drawing.Size(123, 52);
            this.btnSelectionSort.TabIndex = 5;
            this.btnSelectionSort.Text = "Selection Sort";
            this.btnSelectionSort.UseVisualStyleBackColor = true;
            this.btnSelectionSort.Click += new System.EventHandler(this.btnSelectionSort_Click);
            // 
            // btnInsertSort
            // 
            this.btnInsertSort.Location = new System.Drawing.Point(167, 40);
            this.btnInsertSort.Name = "btnInsertSort";
            this.btnInsertSort.Size = new System.Drawing.Size(123, 52);
            this.btnInsertSort.TabIndex = 6;
            this.btnInsertSort.Text = "Insertion Sort";
            this.btnInsertSort.UseVisualStyleBackColor = true;
            this.btnInsertSort.Click += new System.EventHandler(this.btnInsertSort_Click);
            // 
            // btnMerge
            // 
            this.btnMerge.Location = new System.Drawing.Point(296, 40);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(123, 52);
            this.btnMerge.TabIndex = 8;
            this.btnMerge.Text = "Merge Sort";
            this.btnMerge.UseVisualStyleBackColor = true;
            this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
            // 
            // txtSearchInput
            // 
            this.txtSearchInput.Location = new System.Drawing.Point(628, 114);
            this.txtSearchInput.Name = "txtSearchInput";
            this.txtSearchInput.Size = new System.Drawing.Size(100, 22);
            this.txtSearchInput.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(525, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Search Value:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(528, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Position:";
            // 
            // lblSearchPosition
            // 
            this.lblSearchPosition.AutoSize = true;
            this.lblSearchPosition.Location = new System.Drawing.Point(628, 157);
            this.lblSearchPosition.Name = "lblSearchPosition";
            this.lblSearchPosition.Size = new System.Drawing.Size(0, 17);
            this.lblSearchPosition.TabIndex = 12;
            // 
            // lblSteps
            // 
            this.lblSteps.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSteps.Location = new System.Drawing.Point(38, 293);
            this.lblSteps.Name = "lblSteps";
            this.lblSteps.Size = new System.Drawing.Size(395, 207);
            this.lblSteps.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Steps:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 509);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblSteps);
            this.Controls.Add(this.lblSearchPosition);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSearchInput);
            this.Controls.Add(this.btnMerge);
            this.Controls.Add(this.btnInsertSort);
            this.Controls.Add(this.btnSelectionSort);
            this.Controls.Add(this.lblSortedNumbers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPresortedNumbers);
            this.Controls.Add(this.btnSearch);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblPresortedNumbers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSortedNumbers;
        private System.Windows.Forms.Button btnSelectionSort;
        private System.Windows.Forms.Button btnInsertSort;
        private System.Windows.Forms.Button btnMerge;
        private System.Windows.Forms.TextBox txtSearchInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSearchPosition;
        private System.Windows.Forms.Label lblSteps;
        private System.Windows.Forms.Label label5;
    }
}

