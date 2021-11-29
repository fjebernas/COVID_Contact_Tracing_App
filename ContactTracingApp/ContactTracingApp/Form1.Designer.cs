
namespace ContactTracingApp
{
    partial class ContactTracer
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
            this.labelMainTitle = new System.Windows.Forms.Label();
            this.txtBxFN = new System.Windows.Forms.TextBox();
            this.txtBxMN = new System.Windows.Forms.TextBox();
            this.txtBxLN = new System.Windows.Forms.TextBox();
            this.txtBxAge = new System.Windows.Forms.TextBox();
            this.labelFN = new System.Windows.Forms.Label();
            this.labelMN = new System.Windows.Forms.Label();
            this.labelLN = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.rdoBtnMale = new System.Windows.Forms.RadioButton();
            this.rdoBtnFemale = new System.Windows.Forms.RadioButton();
            this.txtBxAddress = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.rdoBtnIPNTS = new System.Windows.Forms.RadioButton();
            this.labelQuesOne = new System.Windows.Forms.Label();
            this.labelQuesTwoPt1 = new System.Windows.Forms.Label();
            this.labelQuesTwoPt2 = new System.Windows.Forms.Label();
            this.labelQuesThreePt1 = new System.Windows.Forms.Label();
            this.labelQuesThreePt2 = new System.Windows.Forms.Label();
            this.chkBxQuesOneFever = new System.Windows.Forms.CheckBox();
            this.chkBxQuesOneCough = new System.Windows.Forms.CheckBox();
            this.chkBxQuesOneBD = new System.Windows.Forms.CheckBox();
            this.labelPN = new System.Windows.Forms.Label();
            this.txtBxPN = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.groupBoxQuesTwo = new System.Windows.Forms.GroupBox();
            this.rdoBtnQuesTwoNS = new System.Windows.Forms.RadioButton();
            this.rdoBtnQuesTwoNo = new System.Windows.Forms.RadioButton();
            this.rdoBtnQuesTwoYes = new System.Windows.Forms.RadioButton();
            this.groupBoxQuesOne = new System.Windows.Forms.GroupBox();
            this.rdoBtnQuesOneNS = new System.Windows.Forms.RadioButton();
            this.rdoBtnQuesOneNo = new System.Windows.Forms.RadioButton();
            this.rdoBtnQuesOneYes = new System.Windows.Forms.RadioButton();
            this.groupBoxQuesTwo.SuspendLayout();
            this.groupBoxQuesOne.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMainTitle
            // 
            this.labelMainTitle.AutoSize = true;
            this.labelMainTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelMainTitle.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainTitle.Location = new System.Drawing.Point(167, 23);
            this.labelMainTitle.Name = "labelMainTitle";
            this.labelMainTitle.Size = new System.Drawing.Size(253, 39);
            this.labelMainTitle.TabIndex = 0;
            this.labelMainTitle.Text = "Contact Tracer";
            this.labelMainTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtBxFN
            // 
            this.txtBxFN.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxFN.Location = new System.Drawing.Point(16, 118);
            this.txtBxFN.Name = "txtBxFN";
            this.txtBxFN.Size = new System.Drawing.Size(183, 27);
            this.txtBxFN.TabIndex = 1;
            this.txtBxFN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxChar_KeyPress);
            // 
            // txtBxMN
            // 
            this.txtBxMN.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxMN.Location = new System.Drawing.Point(205, 118);
            this.txtBxMN.Name = "txtBxMN";
            this.txtBxMN.Size = new System.Drawing.Size(183, 27);
            this.txtBxMN.TabIndex = 1;
            this.txtBxMN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxChar_KeyPress);
            // 
            // txtBxLN
            // 
            this.txtBxLN.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxLN.Location = new System.Drawing.Point(394, 118);
            this.txtBxLN.Name = "txtBxLN";
            this.txtBxLN.Size = new System.Drawing.Size(183, 27);
            this.txtBxLN.TabIndex = 1;
            this.txtBxLN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxChar_KeyPress);
            // 
            // txtBxAge
            // 
            this.txtBxAge.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxAge.Location = new System.Drawing.Point(16, 173);
            this.txtBxAge.Name = "txtBxAge";
            this.txtBxAge.Size = new System.Drawing.Size(89, 27);
            this.txtBxAge.TabIndex = 1;
            this.txtBxAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxNum_KeyPress);
            // 
            // labelFN
            // 
            this.labelFN.AutoSize = true;
            this.labelFN.BackColor = System.Drawing.Color.Transparent;
            this.labelFN.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFN.Location = new System.Drawing.Point(16, 95);
            this.labelFN.Name = "labelFN";
            this.labelFN.Size = new System.Drawing.Size(87, 20);
            this.labelFN.TabIndex = 0;
            this.labelFN.Text = "First Name:";
            this.labelFN.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelMN
            // 
            this.labelMN.AutoSize = true;
            this.labelMN.BackColor = System.Drawing.Color.Transparent;
            this.labelMN.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMN.Location = new System.Drawing.Point(201, 95);
            this.labelMN.Name = "labelMN";
            this.labelMN.Size = new System.Drawing.Size(112, 20);
            this.labelMN.TabIndex = 0;
            this.labelMN.Text = "Middle Name:";
            this.labelMN.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelLN
            // 
            this.labelLN.AutoSize = true;
            this.labelLN.BackColor = System.Drawing.Color.Transparent;
            this.labelLN.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLN.Location = new System.Drawing.Point(394, 95);
            this.labelLN.Name = "labelLN";
            this.labelLN.Size = new System.Drawing.Size(89, 20);
            this.labelLN.TabIndex = 0;
            this.labelLN.Text = "Last Name:";
            this.labelLN.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.BackColor = System.Drawing.Color.Transparent;
            this.labelAge.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAge.Location = new System.Drawing.Point(16, 150);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(44, 20);
            this.labelAge.TabIndex = 0;
            this.labelAge.Text = "Age:";
            this.labelAge.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.BackColor = System.Drawing.Color.Transparent;
            this.labelGender.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.Location = new System.Drawing.Point(201, 152);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(70, 20);
            this.labelGender.TabIndex = 0;
            this.labelGender.Text = "Gender:";
            this.labelGender.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rdoBtnMale
            // 
            this.rdoBtnMale.AutoSize = true;
            this.rdoBtnMale.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBtnMale.Location = new System.Drawing.Point(217, 179);
            this.rdoBtnMale.Name = "rdoBtnMale";
            this.rdoBtnMale.Size = new System.Drawing.Size(56, 21);
            this.rdoBtnMale.TabIndex = 2;
            this.rdoBtnMale.TabStop = true;
            this.rdoBtnMale.Text = "Male";
            this.rdoBtnMale.UseVisualStyleBackColor = true;
            // 
            // rdoBtnFemale
            // 
            this.rdoBtnFemale.AutoSize = true;
            this.rdoBtnFemale.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBtnFemale.Location = new System.Drawing.Point(289, 179);
            this.rdoBtnFemale.Name = "rdoBtnFemale";
            this.rdoBtnFemale.Size = new System.Drawing.Size(70, 21);
            this.rdoBtnFemale.TabIndex = 3;
            this.rdoBtnFemale.TabStop = true;
            this.rdoBtnFemale.Text = "Female";
            this.rdoBtnFemale.UseVisualStyleBackColor = true;
            // 
            // txtBxAddress
            // 
            this.txtBxAddress.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxAddress.Location = new System.Drawing.Point(20, 606);
            this.txtBxAddress.Name = "txtBxAddress";
            this.txtBxAddress.Size = new System.Drawing.Size(561, 27);
            this.txtBxAddress.TabIndex = 1;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.BackColor = System.Drawing.Color.Transparent;
            this.labelAddress.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.Location = new System.Drawing.Point(20, 583);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(71, 20);
            this.labelAddress.TabIndex = 0;
            this.labelAddress.Text = "Address:";
            this.labelAddress.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rdoBtnIPNTS
            // 
            this.rdoBtnIPNTS.AutoSize = true;
            this.rdoBtnIPNTS.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBtnIPNTS.Location = new System.Drawing.Point(377, 179);
            this.rdoBtnIPNTS.Name = "rdoBtnIPNTS";
            this.rdoBtnIPNTS.Size = new System.Drawing.Size(129, 21);
            this.rdoBtnIPNTS.TabIndex = 3;
            this.rdoBtnIPNTS.TabStop = true;
            this.rdoBtnIPNTS.Text = "I prefer not to say";
            this.rdoBtnIPNTS.UseVisualStyleBackColor = true;
            // 
            // labelQuesOne
            // 
            this.labelQuesOne.AutoSize = true;
            this.labelQuesOne.BackColor = System.Drawing.Color.Transparent;
            this.labelQuesOne.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuesOne.Location = new System.Drawing.Point(20, 215);
            this.labelQuesOne.Name = "labelQuesOne";
            this.labelQuesOne.Size = new System.Drawing.Size(548, 20);
            this.labelQuesOne.TabIndex = 0;
            this.labelQuesOne.Text = "Have you traveled outside the country anytime from last month until now?";
            this.labelQuesOne.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelQuesTwoPt1
            // 
            this.labelQuesTwoPt1.AutoSize = true;
            this.labelQuesTwoPt1.BackColor = System.Drawing.Color.Transparent;
            this.labelQuesTwoPt1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuesTwoPt1.Location = new System.Drawing.Point(20, 294);
            this.labelQuesTwoPt1.Name = "labelQuesTwoPt1";
            this.labelQuesTwoPt1.Size = new System.Drawing.Size(546, 20);
            this.labelQuesTwoPt1.TabIndex = 0;
            this.labelQuesTwoPt1.Text = "Have you come into contact with anyone who has traveled outside your ";
            this.labelQuesTwoPt1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelQuesTwoPt2
            // 
            this.labelQuesTwoPt2.AutoSize = true;
            this.labelQuesTwoPt2.BackColor = System.Drawing.Color.Transparent;
            this.labelQuesTwoPt2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuesTwoPt2.Location = new System.Drawing.Point(20, 314);
            this.labelQuesTwoPt2.Name = "labelQuesTwoPt2";
            this.labelQuesTwoPt2.Size = new System.Drawing.Size(393, 20);
            this.labelQuesTwoPt2.TabIndex = 0;
            this.labelQuesTwoPt2.Text = "country between the period of last month until now?";
            this.labelQuesTwoPt2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelQuesThreePt1
            // 
            this.labelQuesThreePt1.AutoSize = true;
            this.labelQuesThreePt1.BackColor = System.Drawing.Color.Transparent;
            this.labelQuesThreePt1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuesThreePt1.Location = new System.Drawing.Point(20, 394);
            this.labelQuesThreePt1.Name = "labelQuesThreePt1";
            this.labelQuesThreePt1.Size = new System.Drawing.Size(521, 20);
            this.labelQuesThreePt1.TabIndex = 0;
            this.labelQuesThreePt1.Text = "Do you currently have any of the following conditions during this time?";
            this.labelQuesThreePt1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelQuesThreePt2
            // 
            this.labelQuesThreePt2.AutoSize = true;
            this.labelQuesThreePt2.BackColor = System.Drawing.Color.Transparent;
            this.labelQuesThreePt2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuesThreePt2.Location = new System.Drawing.Point(20, 414);
            this.labelQuesThreePt2.Name = "labelQuesThreePt2";
            this.labelQuesThreePt2.Size = new System.Drawing.Size(170, 20);
            this.labelQuesThreePt2.TabIndex = 0;
            this.labelQuesThreePt2.Text = "(Check all that apply):";
            this.labelQuesThreePt2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // chkBxQuesOneFever
            // 
            this.chkBxQuesOneFever.AutoSize = true;
            this.chkBxQuesOneFever.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBxQuesOneFever.Location = new System.Drawing.Point(24, 447);
            this.chkBxQuesOneFever.Name = "chkBxQuesOneFever";
            this.chkBxQuesOneFever.Size = new System.Drawing.Size(61, 21);
            this.chkBxQuesOneFever.TabIndex = 4;
            this.chkBxQuesOneFever.Text = "Fever";
            this.chkBxQuesOneFever.UseVisualStyleBackColor = true;
            // 
            // chkBxQuesOneCough
            // 
            this.chkBxQuesOneCough.AutoSize = true;
            this.chkBxQuesOneCough.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBxQuesOneCough.Location = new System.Drawing.Point(24, 470);
            this.chkBxQuesOneCough.Name = "chkBxQuesOneCough";
            this.chkBxQuesOneCough.Size = new System.Drawing.Size(66, 21);
            this.chkBxQuesOneCough.TabIndex = 4;
            this.chkBxQuesOneCough.Text = "Cough";
            this.chkBxQuesOneCough.UseVisualStyleBackColor = true;
            // 
            // chkBxQuesOneBD
            // 
            this.chkBxQuesOneBD.AutoSize = true;
            this.chkBxQuesOneBD.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBxQuesOneBD.Location = new System.Drawing.Point(24, 493);
            this.chkBxQuesOneBD.Name = "chkBxQuesOneBD";
            this.chkBxQuesOneBD.Size = new System.Drawing.Size(139, 21);
            this.chkBxQuesOneBD.TabIndex = 4;
            this.chkBxQuesOneBD.Text = "Breathing Difficulty";
            this.chkBxQuesOneBD.UseVisualStyleBackColor = true;
            // 
            // labelPN
            // 
            this.labelPN.AutoSize = true;
            this.labelPN.BackColor = System.Drawing.Color.Transparent;
            this.labelPN.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPN.Location = new System.Drawing.Point(20, 527);
            this.labelPN.Name = "labelPN";
            this.labelPN.Size = new System.Drawing.Size(120, 20);
            this.labelPN.TabIndex = 0;
            this.labelPN.Text = "Phone number:";
            this.labelPN.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtBxPN
            // 
            this.txtBxPN.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxPN.Location = new System.Drawing.Point(20, 550);
            this.txtBxPN.Name = "txtBxPN";
            this.txtBxPN.Size = new System.Drawing.Size(129, 27);
            this.txtBxPN.TabIndex = 1;
            this.txtBxPN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxNum_KeyPress);
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.Color.LightSalmon;
            this.SubmitButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.Location = new System.Drawing.Point(244, 658);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(100, 47);
            this.SubmitButton.TabIndex = 5;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // groupBoxQuesTwo
            // 
            this.groupBoxQuesTwo.Controls.Add(this.rdoBtnQuesTwoNS);
            this.groupBoxQuesTwo.Controls.Add(this.rdoBtnQuesTwoNo);
            this.groupBoxQuesTwo.Controls.Add(this.rdoBtnQuesTwoYes);
            this.groupBoxQuesTwo.Location = new System.Drawing.Point(-6, 332);
            this.groupBoxQuesTwo.Margin = new System.Windows.Forms.Padding(1);
            this.groupBoxQuesTwo.Name = "groupBoxQuesTwo";
            this.groupBoxQuesTwo.Padding = new System.Windows.Forms.Padding(0);
            this.groupBoxQuesTwo.Size = new System.Drawing.Size(237, 58);
            this.groupBoxQuesTwo.TabIndex = 6;
            this.groupBoxQuesTwo.TabStop = false;
            // 
            // rdoBtnQuesTwoNS
            // 
            this.rdoBtnQuesTwoNS.AutoSize = true;
            this.rdoBtnQuesTwoNS.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBtnQuesTwoNS.Location = new System.Drawing.Point(149, 22);
            this.rdoBtnQuesTwoNS.Name = "rdoBtnQuesTwoNS";
            this.rdoBtnQuesTwoNS.Size = new System.Drawing.Size(75, 21);
            this.rdoBtnQuesTwoNS.TabIndex = 3;
            this.rdoBtnQuesTwoNS.TabStop = true;
            this.rdoBtnQuesTwoNS.Text = "Not sure";
            this.rdoBtnQuesTwoNS.UseVisualStyleBackColor = true;
            // 
            // rdoBtnQuesTwoNo
            // 
            this.rdoBtnQuesTwoNo.AutoSize = true;
            this.rdoBtnQuesTwoNo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBtnQuesTwoNo.Location = new System.Drawing.Point(89, 22);
            this.rdoBtnQuesTwoNo.Name = "rdoBtnQuesTwoNo";
            this.rdoBtnQuesTwoNo.Size = new System.Drawing.Size(43, 21);
            this.rdoBtnQuesTwoNo.TabIndex = 4;
            this.rdoBtnQuesTwoNo.TabStop = true;
            this.rdoBtnQuesTwoNo.Text = "No";
            this.rdoBtnQuesTwoNo.UseVisualStyleBackColor = true;
            // 
            // rdoBtnQuesTwoYes
            // 
            this.rdoBtnQuesTwoYes.AutoSize = true;
            this.rdoBtnQuesTwoYes.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBtnQuesTwoYes.Location = new System.Drawing.Point(29, 22);
            this.rdoBtnQuesTwoYes.Name = "rdoBtnQuesTwoYes";
            this.rdoBtnQuesTwoYes.Size = new System.Drawing.Size(46, 21);
            this.rdoBtnQuesTwoYes.TabIndex = 5;
            this.rdoBtnQuesTwoYes.TabStop = true;
            this.rdoBtnQuesTwoYes.Text = "Yes";
            this.rdoBtnQuesTwoYes.UseVisualStyleBackColor = true;
            // 
            // groupBoxQuesOne
            // 
            this.groupBoxQuesOne.Controls.Add(this.rdoBtnQuesOneNS);
            this.groupBoxQuesOne.Controls.Add(this.rdoBtnQuesOneNo);
            this.groupBoxQuesOne.Controls.Add(this.rdoBtnQuesOneYes);
            this.groupBoxQuesOne.Location = new System.Drawing.Point(-6, 233);
            this.groupBoxQuesOne.Margin = new System.Windows.Forms.Padding(1);
            this.groupBoxQuesOne.Name = "groupBoxQuesOne";
            this.groupBoxQuesOne.Padding = new System.Windows.Forms.Padding(0);
            this.groupBoxQuesOne.Size = new System.Drawing.Size(237, 58);
            this.groupBoxQuesOne.TabIndex = 7;
            this.groupBoxQuesOne.TabStop = false;
            // 
            // rdoBtnQuesOneNS
            // 
            this.rdoBtnQuesOneNS.AutoSize = true;
            this.rdoBtnQuesOneNS.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBtnQuesOneNS.Location = new System.Drawing.Point(149, 22);
            this.rdoBtnQuesOneNS.Name = "rdoBtnQuesOneNS";
            this.rdoBtnQuesOneNS.Size = new System.Drawing.Size(75, 21);
            this.rdoBtnQuesOneNS.TabIndex = 3;
            this.rdoBtnQuesOneNS.TabStop = true;
            this.rdoBtnQuesOneNS.Text = "Not sure";
            this.rdoBtnQuesOneNS.UseVisualStyleBackColor = true;
            // 
            // rdoBtnQuesOneNo
            // 
            this.rdoBtnQuesOneNo.AutoSize = true;
            this.rdoBtnQuesOneNo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBtnQuesOneNo.Location = new System.Drawing.Point(89, 22);
            this.rdoBtnQuesOneNo.Name = "rdoBtnQuesOneNo";
            this.rdoBtnQuesOneNo.Size = new System.Drawing.Size(43, 21);
            this.rdoBtnQuesOneNo.TabIndex = 4;
            this.rdoBtnQuesOneNo.TabStop = true;
            this.rdoBtnQuesOneNo.Text = "No";
            this.rdoBtnQuesOneNo.UseVisualStyleBackColor = true;
            // 
            // rdoBtnQuesOneYes
            // 
            this.rdoBtnQuesOneYes.AutoSize = true;
            this.rdoBtnQuesOneYes.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBtnQuesOneYes.Location = new System.Drawing.Point(29, 22);
            this.rdoBtnQuesOneYes.Name = "rdoBtnQuesOneYes";
            this.rdoBtnQuesOneYes.Size = new System.Drawing.Size(46, 21);
            this.rdoBtnQuesOneYes.TabIndex = 5;
            this.rdoBtnQuesOneYes.TabStop = true;
            this.rdoBtnQuesOneYes.Text = "Yes";
            this.rdoBtnQuesOneYes.UseVisualStyleBackColor = true;
            // 
            // ContactTracer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(587, 731);
            this.Controls.Add(this.groupBoxQuesOne);
            this.Controls.Add(this.groupBoxQuesTwo);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.chkBxQuesOneBD);
            this.Controls.Add(this.chkBxQuesOneCough);
            this.Controls.Add(this.chkBxQuesOneFever);
            this.Controls.Add(this.rdoBtnIPNTS);
            this.Controls.Add(this.rdoBtnFemale);
            this.Controls.Add(this.rdoBtnMale);
            this.Controls.Add(this.txtBxLN);
            this.Controls.Add(this.txtBxMN);
            this.Controls.Add(this.txtBxAge);
            this.Controls.Add(this.txtBxPN);
            this.Controls.Add(this.txtBxAddress);
            this.Controls.Add(this.txtBxFN);
            this.Controls.Add(this.labelLN);
            this.Controls.Add(this.labelMN);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelQuesTwoPt2);
            this.Controls.Add(this.labelQuesThreePt2);
            this.Controls.Add(this.labelQuesThreePt1);
            this.Controls.Add(this.labelQuesTwoPt1);
            this.Controls.Add(this.labelQuesOne);
            this.Controls.Add(this.labelPN);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelFN);
            this.Controls.Add(this.labelMainTitle);
            this.Name = "ContactTracer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Tracing App";
            this.groupBoxQuesTwo.ResumeLayout(false);
            this.groupBoxQuesTwo.PerformLayout();
            this.groupBoxQuesOne.ResumeLayout(false);
            this.groupBoxQuesOne.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMainTitle;
        private System.Windows.Forms.TextBox txtBxFN;
        private System.Windows.Forms.TextBox txtBxMN;
        private System.Windows.Forms.TextBox txtBxLN;
        private System.Windows.Forms.TextBox txtBxAge;
        private System.Windows.Forms.Label labelFN;
        private System.Windows.Forms.Label labelMN;
        private System.Windows.Forms.Label labelLN;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.RadioButton rdoBtnMale;
        private System.Windows.Forms.RadioButton rdoBtnFemale;
        private System.Windows.Forms.TextBox txtBxAddress;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.RadioButton rdoBtnIPNTS;
        private System.Windows.Forms.Label labelQuesOne;
        private System.Windows.Forms.Label labelQuesTwoPt1;
        private System.Windows.Forms.Label labelQuesTwoPt2;
        private System.Windows.Forms.Label labelQuesThreePt1;
        private System.Windows.Forms.Label labelQuesThreePt2;
        private System.Windows.Forms.CheckBox chkBxQuesOneFever;
        private System.Windows.Forms.CheckBox chkBxQuesOneCough;
        private System.Windows.Forms.CheckBox chkBxQuesOneBD;
        private System.Windows.Forms.Label labelPN;
        private System.Windows.Forms.TextBox txtBxPN;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.GroupBox groupBoxQuesTwo;
        private System.Windows.Forms.RadioButton rdoBtnQuesTwoNS;
        private System.Windows.Forms.RadioButton rdoBtnQuesTwoNo;
        private System.Windows.Forms.RadioButton rdoBtnQuesTwoYes;
        private System.Windows.Forms.GroupBox groupBoxQuesOne;
        private System.Windows.Forms.RadioButton rdoBtnQuesOneNS;
        private System.Windows.Forms.RadioButton rdoBtnQuesOneNo;
        private System.Windows.Forms.RadioButton rdoBtnQuesOneYes;
    }
}

