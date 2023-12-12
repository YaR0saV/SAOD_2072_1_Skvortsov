namespace MyQueue
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
            CreateQueueButton = new Button();
            pushItemButton = new Button();
            popItemButton = new Button();
            peekItemButton = new Button();
            queueSizeTextBox = new TextBox();
            pushItemTextBox = new TextBox();
            outputListBox = new ListBox();
            popItemListBox = new ListBox();
            peekItemListBox = new ListBox();
            SuspendLayout();
            // 
            // CreateQueueButton
            // 
            CreateQueueButton.Location = new Point(12, 12);
            CreateQueueButton.Name = "CreateQueueButton";
            CreateQueueButton.Size = new Size(117, 23);
            CreateQueueButton.TabIndex = 0;
            CreateQueueButton.Text = "Создать стек";
            CreateQueueButton.UseVisualStyleBackColor = true;
            CreateQueueButton.Click += CreateQueueButton_Click;
            // 
            // pushItemButton
            // 
            pushItemButton.Location = new Point(12, 41);
            pushItemButton.Name = "pushItemButton";
            pushItemButton.Size = new Size(117, 23);
            pushItemButton.TabIndex = 1;
            pushItemButton.Text = "Добавить элемент";
            pushItemButton.UseVisualStyleBackColor = true;
            pushItemButton.Click += pushItemButton_Click;
            // 
            // popItemButton
            // 
            popItemButton.Location = new Point(12, 70);
            popItemButton.Name = "popItemButton";
            popItemButton.Size = new Size(117, 34);
            popItemButton.TabIndex = 2;
            popItemButton.Text = "Изъять элемент";
            popItemButton.UseVisualStyleBackColor = true;
            popItemButton.Click += popItemButton_Click;
            // 
            // peekItemButton
            // 
            peekItemButton.Location = new Point(12, 110);
            peekItemButton.Name = "peekItemButton";
            peekItemButton.Size = new Size(117, 49);
            peekItemButton.TabIndex = 3;
            peekItemButton.Text = "Проверить верхний элемент";
            peekItemButton.UseVisualStyleBackColor = true;
            peekItemButton.Click += peekItemButton_Click;
            // 
            // queueSizeTextBox
            // 
            queueSizeTextBox.Location = new Point(149, 12);
            queueSizeTextBox.Name = "queueSizeTextBox";
            queueSizeTextBox.Size = new Size(106, 23);
            queueSizeTextBox.TabIndex = 4;
            // 
            // pushItemTextBox
            // 
            pushItemTextBox.Location = new Point(149, 41);
            pushItemTextBox.Name = "pushItemTextBox";
            pushItemTextBox.Size = new Size(107, 23);
            pushItemTextBox.TabIndex = 5;
            // 
            // outputListBox
            // 
            outputListBox.FormattingEnabled = true;
            outputListBox.ItemHeight = 15;
            outputListBox.Location = new Point(281, 12);
            outputListBox.Name = "outputListBox";
            outputListBox.Size = new Size(223, 154);
            outputListBox.TabIndex = 8;
            // 
            // popItemListBox
            // 
            popItemListBox.FormattingEnabled = true;
            popItemListBox.ItemHeight = 15;
            popItemListBox.Location = new Point(149, 70);
            popItemListBox.Name = "popItemListBox";
            popItemListBox.Size = new Size(107, 34);
            popItemListBox.TabIndex = 9;
            // 
            // peekItemListBox
            // 
            peekItemListBox.FormattingEnabled = true;
            peekItemListBox.ItemHeight = 15;
            peekItemListBox.Location = new Point(150, 110);
            peekItemListBox.Name = "peekItemListBox";
            peekItemListBox.Size = new Size(106, 49);
            peekItemListBox.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 176);
            Controls.Add(peekItemListBox);
            Controls.Add(popItemListBox);
            Controls.Add(outputListBox);
            Controls.Add(pushItemTextBox);
            Controls.Add(queueSizeTextBox);
            Controls.Add(peekItemButton);
            Controls.Add(popItemButton);
            Controls.Add(pushItemButton);
            Controls.Add(CreateQueueButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CreateQueueButton;
        private Button pushItemButton;
        private Button popItemButton;
        private Button peekItemButton;
        private TextBox queueSizeTextBox;
        private TextBox pushItemTextBox;
        private ListBox outputListBox;
        private ListBox popItemListBox;
        private ListBox peekItemListBox;
    }
}