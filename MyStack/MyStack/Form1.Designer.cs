namespace MyStack
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
            createStackButton = new Button();
            pushItemButton = new Button();
            popItemButton = new Button();
            peekItemButton = new Button();
            stackListBox = new ListBox();
            sizeTextBox = new TextBox();
            itemTextBox = new TextBox();
            popTextBox = new TextBox();
            peekTextBox = new TextBox();
            SuspendLayout();
            // 
            // createStackButton
            // 
            createStackButton.Location = new Point(13, 17);
            createStackButton.Name = "createStackButton";
            createStackButton.Size = new Size(99, 32);
            createStackButton.TabIndex = 0;
            createStackButton.Text = "Создать";
            createStackButton.UseVisualStyleBackColor = true;
            createStackButton.Click += createStackButton_Click;
            // 
            // pushItemButton
            // 
            pushItemButton.Location = new Point(13, 55);
            pushItemButton.Name = "pushItemButton";
            pushItemButton.Size = new Size(99, 58);
            pushItemButton.TabIndex = 1;
            pushItemButton.Text = "добавить эелемент";
            pushItemButton.UseVisualStyleBackColor = true;
            pushItemButton.Click += pushItemButton_Click;
            // 
            // popItemButton
            // 
            popItemButton.Location = new Point(13, 119);
            popItemButton.Name = "popItemButton";
            popItemButton.Size = new Size(99, 63);
            popItemButton.TabIndex = 2;
            popItemButton.Text = "Вывести последний элемент";
            popItemButton.UseVisualStyleBackColor = true;
            popItemButton.Click += popItemButton_Click;
            // 
            // peekItemButton
            // 
            peekItemButton.Location = new Point(13, 188);
            peekItemButton.Name = "peekItemButton";
            peekItemButton.Size = new Size(99, 55);
            peekItemButton.TabIndex = 3;
            peekItemButton.Text = "Показать последний элемент";
            peekItemButton.UseVisualStyleBackColor = true;
            peekItemButton.Click += peekItemButton_Click;
            // 
            // stackListBox
            // 
            stackListBox.FormattingEnabled = true;
            stackListBox.ItemHeight = 15;
            stackListBox.Location = new Point(254, 18);
            stackListBox.Name = "stackListBox";
            stackListBox.Size = new Size(120, 94);
            stackListBox.TabIndex = 4;
            // 
            // sizeTextBox
            // 
            sizeTextBox.Location = new Point(123, 20);
            sizeTextBox.Name = "sizeTextBox";
            sizeTextBox.Size = new Size(43, 23);
            sizeTextBox.TabIndex = 5;
            // 
            // itemTextBox
            // 
            itemTextBox.Location = new Point(124, 71);
            itemTextBox.Name = "itemTextBox";
            itemTextBox.Size = new Size(45, 23);
            itemTextBox.TabIndex = 6;
            // 
            // popTextBox
            // 
            popTextBox.Location = new Point(126, 134);
            popTextBox.Name = "popTextBox";
            popTextBox.Size = new Size(47, 23);
            popTextBox.TabIndex = 7;
            // 
            // peekTextBox
            // 
            peekTextBox.Location = new Point(128, 203);
            peekTextBox.Name = "peekTextBox";
            peekTextBox.Size = new Size(45, 23);
            peekTextBox.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 267);
            Controls.Add(peekTextBox);
            Controls.Add(popTextBox);
            Controls.Add(itemTextBox);
            Controls.Add(sizeTextBox);
            Controls.Add(stackListBox);
            Controls.Add(peekItemButton);
            Controls.Add(popItemButton);
            Controls.Add(pushItemButton);
            Controls.Add(createStackButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button createStackButton;
        private Button pushItemButton;
        private Button popItemButton;
        private Button peekItemButton;
        private ListBox stackListBox;
        private TextBox sizeTextBox;
        private TextBox itemTextBox;
        private TextBox popTextBox;
        private TextBox peekTextBox;
    }
}