namespace Calculator
{
    partial class CalculatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorForm));
            this.fourButton = new System.Windows.Forms.Button();
            this.fiveButton = new System.Windows.Forms.Button();
            this.sixButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.oneButton = new System.Windows.Forms.Button();
            this.twoButton = new System.Windows.Forms.Button();
            this.threeButton = new System.Windows.Forms.Button();
            this.equalButton = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.dividetButton = new System.Windows.Forms.Button();
            this.seventButton = new System.Windows.Forms.Button();
            this.deleteCurrentNumberButton = new System.Windows.Forms.Button();
            this.eightButton = new System.Windows.Forms.Button();
            this.deleteOneNumberButton = new System.Windows.Forms.Button();
            this.nineButton = new System.Windows.Forms.Button();
            this.timesButton = new System.Windows.Forms.Button();
            this.resultsPanel = new System.Windows.Forms.Panel();
            this.preivousNumberLabel = new System.Windows.Forms.Label();
            this.resultLabelValue = new System.Windows.Forms.Label();
            this.zeroButton = new System.Windows.Forms.Button();
            this.dotButton = new System.Windows.Forms.Button();
            this.deleteAllButton = new System.Windows.Forms.Button();
            this.negateButton = new System.Windows.Forms.Button();
            this.resultsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // fourButton
            // 
            this.fourButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.fourButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.fourButton.FlatAppearance.BorderSize = 2;
            this.fourButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.fourButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fourButton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourButton.Location = new System.Drawing.Point(12, 307);
            this.fourButton.Name = "fourButton";
            this.fourButton.Size = new System.Drawing.Size(80, 80);
            this.fourButton.TabIndex = 9;
            this.fourButton.Text = "4";
            this.fourButton.UseVisualStyleBackColor = false;
            this.fourButton.Click += new System.EventHandler(this.AddToResultButtons_Click);
            this.fourButton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            this.fourButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyDownPress);
            // 
            // fiveButton
            // 
            this.fiveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.fiveButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.fiveButton.FlatAppearance.BorderSize = 2;
            this.fiveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.fiveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fiveButton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fiveButton.Location = new System.Drawing.Point(98, 307);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(80, 80);
            this.fiveButton.TabIndex = 10;
            this.fiveButton.Text = "5";
            this.fiveButton.UseVisualStyleBackColor = false;
            this.fiveButton.Click += new System.EventHandler(this.AddToResultButtons_Click);
            this.fiveButton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            this.fiveButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyDownPress);
            // 
            // sixButton
            // 
            this.sixButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sixButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.sixButton.FlatAppearance.BorderSize = 2;
            this.sixButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.sixButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sixButton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sixButton.Location = new System.Drawing.Point(184, 307);
            this.sixButton.Name = "sixButton";
            this.sixButton.Size = new System.Drawing.Size(80, 80);
            this.sixButton.TabIndex = 11;
            this.sixButton.Text = "6";
            this.sixButton.UseVisualStyleBackColor = false;
            this.sixButton.Click += new System.EventHandler(this.AddToResultButtons_Click);
            this.sixButton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            this.sixButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyDownPress);
            // 
            // minusButton
            // 
            this.minusButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.minusButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.minusButton.FlatAppearance.BorderSize = 2;
            this.minusButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.minusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minusButton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusButton.Location = new System.Drawing.Point(270, 307);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(80, 80);
            this.minusButton.TabIndex = 12;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = false;
            this.minusButton.Click += new System.EventHandler(this.AddCalculationButtons_Click);
            this.minusButton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            this.minusButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyDownPress);
            // 
            // oneButton
            // 
            this.oneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.oneButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.oneButton.FlatAppearance.BorderSize = 2;
            this.oneButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.oneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oneButton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneButton.Location = new System.Drawing.Point(12, 393);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(80, 80);
            this.oneButton.TabIndex = 13;
            this.oneButton.Text = "1";
            this.oneButton.UseVisualStyleBackColor = false;
            this.oneButton.Click += new System.EventHandler(this.AddToResultButtons_Click);
            this.oneButton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            this.oneButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyDownPress);
            // 
            // twoButton
            // 
            this.twoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.twoButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.twoButton.FlatAppearance.BorderSize = 2;
            this.twoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.twoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.twoButton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twoButton.Location = new System.Drawing.Point(98, 393);
            this.twoButton.Name = "twoButton";
            this.twoButton.Size = new System.Drawing.Size(80, 80);
            this.twoButton.TabIndex = 14;
            this.twoButton.Text = "2";
            this.twoButton.UseVisualStyleBackColor = false;
            this.twoButton.Click += new System.EventHandler(this.AddToResultButtons_Click);
            this.twoButton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            this.twoButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyDownPress);
            // 
            // threeButton
            // 
            this.threeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.threeButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.threeButton.FlatAppearance.BorderSize = 2;
            this.threeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.threeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.threeButton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threeButton.Location = new System.Drawing.Point(184, 393);
            this.threeButton.Name = "threeButton";
            this.threeButton.Size = new System.Drawing.Size(80, 80);
            this.threeButton.TabIndex = 15;
            this.threeButton.Text = "3";
            this.threeButton.UseVisualStyleBackColor = false;
            this.threeButton.Click += new System.EventHandler(this.AddToResultButtons_Click);
            this.threeButton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            this.threeButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyDownPress);
            // 
            // equalButton
            // 
            this.equalButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.equalButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.equalButton.FlatAppearance.BorderSize = 2;
            this.equalButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.equalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.equalButton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalButton.Location = new System.Drawing.Point(270, 479);
            this.equalButton.Name = "equalButton";
            this.equalButton.Size = new System.Drawing.Size(80, 80);
            this.equalButton.TabIndex = 20;
            this.equalButton.Text = "=";
            this.equalButton.UseVisualStyleBackColor = false;
            this.equalButton.Click += new System.EventHandler(this.equalButton_Click);
            this.equalButton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            this.equalButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyDownPress);
            // 
            // plusButton
            // 
            this.plusButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.plusButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.plusButton.FlatAppearance.BorderSize = 2;
            this.plusButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.plusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plusButton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusButton.Location = new System.Drawing.Point(270, 393);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(80, 80);
            this.plusButton.TabIndex = 16;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = false;
            this.plusButton.Click += new System.EventHandler(this.AddCalculationButtons_Click);
            this.plusButton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            this.plusButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyDownPress);
            // 
            // dividetButton
            // 
            this.dividetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dividetButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.dividetButton.FlatAppearance.BorderSize = 2;
            this.dividetButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.dividetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dividetButton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividetButton.Location = new System.Drawing.Point(270, 135);
            this.dividetButton.Name = "dividetButton";
            this.dividetButton.Size = new System.Drawing.Size(80, 80);
            this.dividetButton.TabIndex = 4;
            this.dividetButton.Text = "/";
            this.dividetButton.UseVisualStyleBackColor = false;
            this.dividetButton.Click += new System.EventHandler(this.AddCalculationButtons_Click);
            this.dividetButton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            this.dividetButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyDownPress);
            // 
            // seventButton
            // 
            this.seventButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.seventButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.seventButton.FlatAppearance.BorderSize = 2;
            this.seventButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.seventButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seventButton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seventButton.Location = new System.Drawing.Point(12, 221);
            this.seventButton.Name = "seventButton";
            this.seventButton.Size = new System.Drawing.Size(80, 80);
            this.seventButton.TabIndex = 5;
            this.seventButton.Text = "7";
            this.seventButton.UseVisualStyleBackColor = false;
            this.seventButton.Click += new System.EventHandler(this.AddToResultButtons_Click);
            this.seventButton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            this.seventButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyDownPress);
            // 
            // deleteCurrentNumberButton
            // 
            this.deleteCurrentNumberButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.deleteCurrentNumberButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.deleteCurrentNumberButton.FlatAppearance.BorderSize = 2;
            this.deleteCurrentNumberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.deleteCurrentNumberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteCurrentNumberButton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCurrentNumberButton.Location = new System.Drawing.Point(98, 135);
            this.deleteCurrentNumberButton.Name = "deleteCurrentNumberButton";
            this.deleteCurrentNumberButton.Size = new System.Drawing.Size(80, 80);
            this.deleteCurrentNumberButton.TabIndex = 2;
            this.deleteCurrentNumberButton.Text = "C";
            this.deleteCurrentNumberButton.UseVisualStyleBackColor = false;
            this.deleteCurrentNumberButton.Click += new System.EventHandler(this.deleteCurrentNumberButton_Click);
            this.deleteCurrentNumberButton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            this.deleteCurrentNumberButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyDownPress);
            // 
            // eightButton
            // 
            this.eightButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.eightButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.eightButton.FlatAppearance.BorderSize = 2;
            this.eightButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.eightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eightButton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eightButton.Location = new System.Drawing.Point(98, 221);
            this.eightButton.Name = "eightButton";
            this.eightButton.Size = new System.Drawing.Size(80, 80);
            this.eightButton.TabIndex = 6;
            this.eightButton.Text = "8";
            this.eightButton.UseVisualStyleBackColor = false;
            this.eightButton.Click += new System.EventHandler(this.AddToResultButtons_Click);
            this.eightButton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            this.eightButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyDownPress);
            // 
            // deleteOneNumberButton
            // 
            this.deleteOneNumberButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.deleteOneNumberButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.deleteOneNumberButton.FlatAppearance.BorderSize = 2;
            this.deleteOneNumberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.deleteOneNumberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteOneNumberButton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteOneNumberButton.Location = new System.Drawing.Point(184, 135);
            this.deleteOneNumberButton.Name = "deleteOneNumberButton";
            this.deleteOneNumberButton.Size = new System.Drawing.Size(80, 80);
            this.deleteOneNumberButton.TabIndex = 3;
            this.deleteOneNumberButton.Text = "<=";
            this.deleteOneNumberButton.UseVisualStyleBackColor = false;
            this.deleteOneNumberButton.Click += new System.EventHandler(this.deleteOneNumberButton_Click);
            this.deleteOneNumberButton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            this.deleteOneNumberButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyDownPress);
            // 
            // nineButton
            // 
            this.nineButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.nineButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.nineButton.FlatAppearance.BorderSize = 2;
            this.nineButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.nineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nineButton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nineButton.Location = new System.Drawing.Point(184, 221);
            this.nineButton.Name = "nineButton";
            this.nineButton.Size = new System.Drawing.Size(80, 80);
            this.nineButton.TabIndex = 7;
            this.nineButton.Text = "9";
            this.nineButton.UseVisualStyleBackColor = false;
            this.nineButton.Click += new System.EventHandler(this.AddToResultButtons_Click);
            this.nineButton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            this.nineButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyDownPress);
            // 
            // timesButton
            // 
            this.timesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.timesButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.timesButton.FlatAppearance.BorderSize = 2;
            this.timesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.timesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timesButton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timesButton.Location = new System.Drawing.Point(270, 221);
            this.timesButton.Name = "timesButton";
            this.timesButton.Size = new System.Drawing.Size(80, 80);
            this.timesButton.TabIndex = 8;
            this.timesButton.Text = "*";
            this.timesButton.UseVisualStyleBackColor = false;
            this.timesButton.Click += new System.EventHandler(this.AddCalculationButtons_Click);
            this.timesButton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            this.timesButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyDownPress);
            // 
            // resultsPanel
            // 
            this.resultsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultsPanel.Controls.Add(this.preivousNumberLabel);
            this.resultsPanel.Controls.Add(this.resultLabelValue);
            this.resultsPanel.Location = new System.Drawing.Point(12, 12);
            this.resultsPanel.Name = "resultsPanel";
            this.resultsPanel.Size = new System.Drawing.Size(338, 98);
            this.resultsPanel.TabIndex = 0;
            // 
            // preivousNumberLabel
            // 
            this.preivousNumberLabel.AutoSize = true;
            this.preivousNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preivousNumberLabel.Location = new System.Drawing.Point(302, 0);
            this.preivousNumberLabel.Name = "preivousNumberLabel";
            this.preivousNumberLabel.Size = new System.Drawing.Size(31, 33);
            this.preivousNumberLabel.TabIndex = 0;
            this.preivousNumberLabel.Text = "0";
            // 
            // resultLabelValue
            // 
            this.resultLabelValue.AutoSize = true;
            this.resultLabelValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabelValue.Location = new System.Drawing.Point(294, 54);
            this.resultLabelValue.Name = "resultLabelValue";
            this.resultLabelValue.Size = new System.Drawing.Size(39, 42);
            this.resultLabelValue.TabIndex = 1;
            this.resultLabelValue.Text = "0";
            // 
            // zeroButton
            // 
            this.zeroButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.zeroButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.zeroButton.FlatAppearance.BorderSize = 2;
            this.zeroButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.zeroButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zeroButton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zeroButton.Location = new System.Drawing.Point(98, 479);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(80, 80);
            this.zeroButton.TabIndex = 18;
            this.zeroButton.Text = "0";
            this.zeroButton.UseVisualStyleBackColor = false;
            this.zeroButton.Click += new System.EventHandler(this.AddToResultButtons_Click);
            this.zeroButton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            this.zeroButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyDownPress);
            // 
            // dotButton
            // 
            this.dotButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dotButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.dotButton.FlatAppearance.BorderSize = 2;
            this.dotButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.dotButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dotButton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dotButton.Location = new System.Drawing.Point(184, 479);
            this.dotButton.Name = "dotButton";
            this.dotButton.Size = new System.Drawing.Size(80, 80);
            this.dotButton.TabIndex = 19;
            this.dotButton.Text = ".";
            this.dotButton.UseVisualStyleBackColor = false;
            this.dotButton.Click += new System.EventHandler(this.AddToResultButtons_Click);
            this.dotButton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            this.dotButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyDownPress);
            // 
            // deleteAllButton
            // 
            this.deleteAllButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.deleteAllButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.deleteAllButton.FlatAppearance.BorderSize = 2;
            this.deleteAllButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.deleteAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteAllButton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteAllButton.Location = new System.Drawing.Point(12, 135);
            this.deleteAllButton.Name = "deleteAllButton";
            this.deleteAllButton.Size = new System.Drawing.Size(80, 80);
            this.deleteAllButton.TabIndex = 1;
            this.deleteAllButton.Text = "CE";
            this.deleteAllButton.UseVisualStyleBackColor = false;
            this.deleteAllButton.Click += new System.EventHandler(this.deleteAllButton_Click);
            this.deleteAllButton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            this.deleteAllButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyDownPress);
            // 
            // negateButton
            // 
            this.negateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.negateButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.negateButton.FlatAppearance.BorderSize = 2;
            this.negateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.negateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.negateButton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.negateButton.Location = new System.Drawing.Point(12, 479);
            this.negateButton.Name = "negateButton";
            this.negateButton.Size = new System.Drawing.Size(80, 80);
            this.negateButton.TabIndex = 17;
            this.negateButton.Text = "+/-";
            this.negateButton.UseVisualStyleBackColor = false;
            this.negateButton.Click += new System.EventHandler(this.negateButton_Click);
            this.negateButton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            this.negateButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyDownPress);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(373, 576);
            this.Controls.Add(this.resultsPanel);
            this.Controls.Add(this.timesButton);
            this.Controls.Add(this.nineButton);
            this.Controls.Add(this.equalButton);
            this.Controls.Add(this.deleteOneNumberButton);
            this.Controls.Add(this.dotButton);
            this.Controls.Add(this.threeButton);
            this.Controls.Add(this.eightButton);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.zeroButton);
            this.Controls.Add(this.deleteAllButton);
            this.Controls.Add(this.deleteCurrentNumberButton);
            this.Controls.Add(this.twoButton);
            this.Controls.Add(this.seventButton);
            this.Controls.Add(this.sixButton);
            this.Controls.Add(this.dividetButton);
            this.Controls.Add(this.oneButton);
            this.Controls.Add(this.negateButton);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.fiveButton);
            this.Controls.Add(this.fourButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CalculatorForm";
            this.Text = "Calculator";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownPress);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            this.resultsPanel.ResumeLayout(false);
            this.resultsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button fourButton;
        private System.Windows.Forms.Button fiveButton;
        private System.Windows.Forms.Button sixButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button oneButton;
        private System.Windows.Forms.Button twoButton;
        private System.Windows.Forms.Button threeButton;
        private System.Windows.Forms.Button equalButton;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button dividetButton;
        private System.Windows.Forms.Button seventButton;
        private System.Windows.Forms.Button deleteCurrentNumberButton;
        private System.Windows.Forms.Button eightButton;
        private System.Windows.Forms.Button deleteOneNumberButton;
        private System.Windows.Forms.Button nineButton;
        private System.Windows.Forms.Button timesButton;
        private System.Windows.Forms.Panel resultsPanel;
        private System.Windows.Forms.Label resultLabelValue;
        private System.Windows.Forms.Button zeroButton;
        private System.Windows.Forms.Button dotButton;
        private System.Windows.Forms.Button deleteAllButton;
        private System.Windows.Forms.Label preivousNumberLabel;
        private System.Windows.Forms.Button negateButton;
    }
}

