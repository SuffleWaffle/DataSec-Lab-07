namespace DataSec_Lab_07_PRJ
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripItemAboutProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonSaveFile = new System.Windows.Forms.Button();
            this.textBoxSaveFile = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelFileOutputEntropy = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxOpenFile = new System.Windows.Forms.TextBox();
            this.labelFileInputEntropy = new System.Windows.Forms.Label();
            this.sizeStLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxGenerateVector = new System.Windows.Forms.CheckBox();
            this.textBoxVector = new System.Windows.Forms.TextBox();
            this.buttonGenerateVector = new System.Windows.Forms.Button();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.buttonGenerateKey = new System.Windows.Forms.Button();
            this.buttonSaveSettings = new System.Windows.Forms.Button();
            this.buttonOpenSettings = new System.Windows.Forms.Button();
            this.comboBoxKeyLength = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radioButtonRC2 = new System.Windows.Forms.RadioButton();
            this.radioButtonTripleDES = new System.Windows.Forms.RadioButton();
            this.radioButtonDES = new System.Windows.Forms.RadioButton();
            this.radioButtonRijndael = new System.Windows.Forms.RadioButton();
            this.radioButtonAES = new System.Windows.Forms.RadioButton();
            this.buttonCipher = new System.Windows.Forms.Button();
            this.buttonDecipher = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.labelCalculationTime = new System.Windows.Forms.Label();
            this.labelElapsedTime = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.helpToolStripMenuItem });
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(704, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.toolStripItemAboutProgram });
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // toolStripItemAboutProgram
            // 
            this.toolStripItemAboutProgram.Name = "toolStripItemAboutProgram";
            this.toolStripItemAboutProgram.Size = new System.Drawing.Size(156, 22);
            this.toolStripItemAboutProgram.Text = "About Program";
            this.toolStripItemAboutProgram.Click += new System.EventHandler(this.toolStripItemAboutProgram_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(680, 160);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.buttonSaveFile);
            this.groupBox4.Controls.Add(this.textBoxSaveFile);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.labelFileOutputEntropy);
            this.groupBox4.Location = new System.Drawing.Point(6, 87);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(668, 66);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Output";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Output file:";
            // 
            // buttonSaveFile
            // 
            this.buttonSaveFile.Location = new System.Drawing.Point(620, 19);
            this.buttonSaveFile.Name = "buttonSaveFile";
            this.buttonSaveFile.Size = new System.Drawing.Size(42, 23);
            this.buttonSaveFile.TabIndex = 14;
            this.buttonSaveFile.Text = "...";
            this.toolTip1.SetToolTip(this.buttonSaveFile, "Choose output file");
            this.buttonSaveFile.UseVisualStyleBackColor = true;
            this.buttonSaveFile.Click += new System.EventHandler(this.buttonSaveFile_Click);
            // 
            // textBoxSaveFile
            // 
            this.textBoxSaveFile.Location = new System.Drawing.Point(69, 19);
            this.textBoxSaveFile.Name = "textBoxSaveFile";
            this.textBoxSaveFile.Size = new System.Drawing.Size(541, 20);
            this.textBoxSaveFile.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Entropy";
            // 
            // labelFileOutputEntropy
            // 
            this.labelFileOutputEntropy.AutoSize = true;
            this.labelFileOutputEntropy.Location = new System.Drawing.Point(55, 46);
            this.labelFileOutputEntropy.Name = "labelFileOutputEntropy";
            this.labelFileOutputEntropy.Size = new System.Drawing.Size(25, 13);
            this.labelFileOutputEntropy.TabIndex = 12;
            this.labelFileOutputEntropy.Text = "???";
            this.toolTip1.SetToolTip(this.labelFileOutputEntropy, "Copy entropy value to Clipboard");
            this.labelFileOutputEntropy.Click += new System.EventHandler(this.labelFileOutputEntropy_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonOpenFile);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.textBoxOpenFile);
            this.groupBox3.Controls.Add(this.labelFileInputEntropy);
            this.groupBox3.Controls.Add(this.sizeStLabel);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(6, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(668, 66);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Input";
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(620, 19);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(42, 23);
            this.buttonOpenFile.TabIndex = 11;
            this.buttonOpenFile.Text = "...";
            this.toolTip1.SetToolTip(this.buttonOpenFile, "Choose input file");
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Input file:";
            // 
            // textBoxOpenFile
            // 
            this.textBoxOpenFile.Location = new System.Drawing.Point(69, 19);
            this.textBoxOpenFile.Name = "textBoxOpenFile";
            this.textBoxOpenFile.Size = new System.Drawing.Size(541, 20);
            this.textBoxOpenFile.TabIndex = 11;
            // 
            // labelFileInputEntropy
            // 
            this.labelFileInputEntropy.AutoSize = true;
            this.labelFileInputEntropy.Location = new System.Drawing.Point(55, 46);
            this.labelFileInputEntropy.Name = "labelFileInputEntropy";
            this.labelFileInputEntropy.Size = new System.Drawing.Size(25, 13);
            this.labelFileInputEntropy.TabIndex = 11;
            this.labelFileInputEntropy.Text = "???";
            this.toolTip1.SetToolTip(this.labelFileInputEntropy, "Copy entropy value to Clipboard");
            this.labelFileInputEntropy.Click += new System.EventHandler(this.labelFileInputEntropy_Click);
            // 
            // sizeStLabel
            // 
            this.sizeStLabel.AutoSize = true;
            this.sizeStLabel.Location = new System.Drawing.Point(386, 46);
            this.sizeStLabel.Name = "sizeStLabel";
            this.sizeStLabel.Size = new System.Drawing.Size(25, 13);
            this.sizeStLabel.TabIndex = 10;
            this.sizeStLabel.Text = "???";
            this.toolTip1.SetToolTip(this.sizeStLabel, "Input file size");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(353, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Entropy";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxGenerateVector);
            this.groupBox2.Controls.Add(this.textBoxVector);
            this.groupBox2.Controls.Add(this.buttonGenerateVector);
            this.groupBox2.Controls.Add(this.textBoxKey);
            this.groupBox2.Controls.Add(this.buttonGenerateKey);
            this.groupBox2.Controls.Add(this.buttonSaveSettings);
            this.groupBox2.Controls.Add(this.buttonOpenSettings);
            this.groupBox2.Controls.Add(this.comboBoxKeyLength);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Location = new System.Drawing.Point(12, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(680, 175);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parameters";
            // 
            // checkBoxGenerateVector
            // 
            this.checkBoxGenerateVector.AutoSize = true;
            this.checkBoxGenerateVector.Checked = true;
            this.checkBoxGenerateVector.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxGenerateVector.Location = new System.Drawing.Point(425, 89);
            this.checkBoxGenerateVector.Name = "checkBoxGenerateVector";
            this.checkBoxGenerateVector.Size = new System.Drawing.Size(54, 17);
            this.checkBoxGenerateVector.TabIndex = 19;
            this.checkBoxGenerateVector.Text = "BI = 0";
            this.toolTip1.SetToolTip(this.checkBoxGenerateVector, "Init vector fill with zeros");
            this.checkBoxGenerateVector.UseVisualStyleBackColor = true;
            this.checkBoxGenerateVector.CheckedChanged += new System.EventHandler(this.checkBoxGenerateVector_CheckedChanged);
            // 
            // textBoxVector
            // 
            this.textBoxVector.Enabled = false;
            this.textBoxVector.Location = new System.Drawing.Point(15, 87);
            this.textBoxVector.Name = "textBoxVector";
            this.textBoxVector.Size = new System.Drawing.Size(330, 20);
            this.textBoxVector.TabIndex = 18;
            this.textBoxVector.Text = "00-00-00-00-00-00-00-00";
            this.textBoxVector.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVector_KeyPress);
            // 
            // buttonGenerateVector
            // 
            this.buttonGenerateVector.BackgroundImage = global::DataSec_Lab_07_PRJ.Properties.Resources.encryption_true;
            this.buttonGenerateVector.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonGenerateVector.Enabled = false;
            this.buttonGenerateVector.Location = new System.Drawing.Point(359, 79);
            this.buttonGenerateVector.Name = "buttonGenerateVector";
            this.buttonGenerateVector.Size = new System.Drawing.Size(40, 35);
            this.buttonGenerateVector.TabIndex = 17;
            this.toolTip1.SetToolTip(this.buttonGenerateVector, "Generate new init vector");
            this.buttonGenerateVector.UseVisualStyleBackColor = true;
            this.buttonGenerateVector.Click += new System.EventHandler(this.buttonGenerateVector_Click);
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(15, 46);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(330, 20);
            this.textBoxKey.TabIndex = 16;
            this.textBoxKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxKey_KeyPress);
            // 
            // buttonGenerateKey
            // 
            this.buttonGenerateKey.BackgroundImage = global::DataSec_Lab_07_PRJ.Properties.Resources.key21;
            this.buttonGenerateKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonGenerateKey.Location = new System.Drawing.Point(359, 40);
            this.buttonGenerateKey.Name = "buttonGenerateKey";
            this.buttonGenerateKey.Size = new System.Drawing.Size(40, 35);
            this.buttonGenerateKey.TabIndex = 13;
            this.toolTip1.SetToolTip(this.buttonGenerateKey, "Generate new key");
            this.buttonGenerateKey.UseVisualStyleBackColor = true;
            this.buttonGenerateKey.Click += new System.EventHandler(this.buttonGenerateKey_Click);
            // 
            // buttonSaveSettings
            // 
            this.buttonSaveSettings.BackgroundImage = global::DataSec_Lab_07_PRJ.Properties.Resources.save__1_;
            this.buttonSaveSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSaveSettings.Location = new System.Drawing.Point(501, 25);
            this.buttonSaveSettings.Name = "buttonSaveSettings";
            this.buttonSaveSettings.Size = new System.Drawing.Size(60, 60);
            this.buttonSaveSettings.TabIndex = 12;
            this.toolTip1.SetToolTip(this.buttonSaveSettings, "Save settings");
            this.buttonSaveSettings.UseVisualStyleBackColor = true;
            this.buttonSaveSettings.Click += new System.EventHandler(this.buttonSaveSettings_Click);
            // 
            // buttonOpenSettings
            // 
            this.buttonOpenSettings.BackgroundImage = global::DataSec_Lab_07_PRJ.Properties.Resources.folder_management;
            this.buttonOpenSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonOpenSettings.Location = new System.Drawing.Point(567, 25);
            this.buttonOpenSettings.Name = "buttonOpenSettings";
            this.buttonOpenSettings.Size = new System.Drawing.Size(60, 60);
            this.buttonOpenSettings.TabIndex = 11;
            this.toolTip1.SetToolTip(this.buttonOpenSettings, "Load settings file");
            this.buttonOpenSettings.UseVisualStyleBackColor = true;
            this.buttonOpenSettings.Click += new System.EventHandler(this.buttonOpenSettings_Click);
            // 
            // comboBoxKeyLength
            // 
            this.comboBoxKeyLength.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKeyLength.FormattingEnabled = true;
            this.comboBoxKeyLength.Items.AddRange(new object[] { "128", "192", "256" });
            this.comboBoxKeyLength.Location = new System.Drawing.Point(105, 18);
            this.comboBoxKeyLength.Name = "comboBoxKeyLength";
            this.comboBoxKeyLength.Size = new System.Drawing.Size(60, 21);
            this.comboBoxKeyLength.TabIndex = 10;
            this.toolTip1.SetToolTip(this.comboBoxKeyLength, "Change encoding Key Length");
            this.comboBoxKeyLength.SelectedIndexChanged += new System.EventHandler(this.comboBoxKeyLength_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Key Length (bit):";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radioButtonRC2);
            this.groupBox5.Controls.Add(this.radioButtonTripleDES);
            this.groupBox5.Controls.Add(this.radioButtonDES);
            this.groupBox5.Controls.Add(this.radioButtonRijndael);
            this.groupBox5.Controls.Add(this.radioButtonAES);
            this.groupBox5.Location = new System.Drawing.Point(6, 113);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(668, 55);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Encryption";
            // 
            // radioButtonRC2
            // 
            this.radioButtonRC2.AutoSize = true;
            this.radioButtonRC2.Location = new System.Drawing.Point(262, 19);
            this.radioButtonRC2.Name = "radioButtonRC2";
            this.radioButtonRC2.Size = new System.Drawing.Size(46, 17);
            this.radioButtonRC2.TabIndex = 4;
            this.radioButtonRC2.Text = "RC2";
            this.radioButtonRC2.UseVisualStyleBackColor = true;
            this.radioButtonRC2.CheckedChanged += new System.EventHandler(this.radioButtonRC2_CheckedChanged);
            // 
            // radioButtonTripleDES
            // 
            this.radioButtonTripleDES.AutoSize = true;
            this.radioButtonTripleDES.Location = new System.Drawing.Point(183, 19);
            this.radioButtonTripleDES.Name = "radioButtonTripleDES";
            this.radioButtonTripleDES.Size = new System.Drawing.Size(73, 17);
            this.radioButtonTripleDES.TabIndex = 3;
            this.radioButtonTripleDES.Text = "TripleDES";
            this.radioButtonTripleDES.UseVisualStyleBackColor = true;
            this.radioButtonTripleDES.CheckedChanged += new System.EventHandler(this.radioButtonTripleDES_CheckedChanged);
            // 
            // radioButtonDES
            // 
            this.radioButtonDES.AutoSize = true;
            this.radioButtonDES.Location = new System.Drawing.Point(130, 19);
            this.radioButtonDES.Name = "radioButtonDES";
            this.radioButtonDES.Size = new System.Drawing.Size(47, 17);
            this.radioButtonDES.TabIndex = 2;
            this.radioButtonDES.Text = "DES";
            this.radioButtonDES.UseVisualStyleBackColor = true;
            this.radioButtonDES.CheckedChanged += new System.EventHandler(this.radioButtonDES_CheckedChanged);
            // 
            // radioButtonRijndael
            // 
            this.radioButtonRijndael.AutoSize = true;
            this.radioButtonRijndael.Location = new System.Drawing.Point(61, 19);
            this.radioButtonRijndael.Name = "radioButtonRijndael";
            this.radioButtonRijndael.Size = new System.Drawing.Size(63, 17);
            this.radioButtonRijndael.TabIndex = 1;
            this.radioButtonRijndael.Text = "Rijndael";
            this.radioButtonRijndael.UseVisualStyleBackColor = true;
            this.radioButtonRijndael.CheckedChanged += new System.EventHandler(this.radioButtonRijndael_CheckedChanged);
            // 
            // radioButtonAES
            // 
            this.radioButtonAES.AutoSize = true;
            this.radioButtonAES.Checked = true;
            this.radioButtonAES.Location = new System.Drawing.Point(9, 20);
            this.radioButtonAES.Name = "radioButtonAES";
            this.radioButtonAES.Size = new System.Drawing.Size(46, 17);
            this.radioButtonAES.TabIndex = 0;
            this.radioButtonAES.TabStop = true;
            this.radioButtonAES.Text = "AES";
            this.radioButtonAES.UseVisualStyleBackColor = true;
            this.radioButtonAES.CheckedChanged += new System.EventHandler(this.radioButtonAES_CheckedChanged);
            // 
            // buttonCipher
            // 
            this.buttonCipher.Location = new System.Drawing.Point(18, 375);
            this.buttonCipher.Name = "buttonCipher";
            this.buttonCipher.Size = new System.Drawing.Size(75, 23);
            this.buttonCipher.TabIndex = 4;
            this.buttonCipher.Text = "Cipher";
            this.toolTip1.SetToolTip(this.buttonCipher, "Start encoding");
            this.buttonCipher.UseVisualStyleBackColor = true;
            this.buttonCipher.Click += new System.EventHandler(this.buttonCipher_Click);
            // 
            // buttonDecipher
            // 
            this.buttonDecipher.Location = new System.Drawing.Point(18, 406);
            this.buttonDecipher.Name = "buttonDecipher";
            this.buttonDecipher.Size = new System.Drawing.Size(75, 23);
            this.buttonDecipher.TabIndex = 5;
            this.buttonDecipher.Text = "Decipher";
            this.toolTip1.SetToolTip(this.buttonDecipher, "Start decoding");
            this.buttonDecipher.UseVisualStyleBackColor = true;
            this.buttonDecipher.Click += new System.EventHandler(this.buttonDecipher_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Enabled = false;
            this.buttonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStop.Location = new System.Drawing.Point(114, 375);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 54);
            this.buttonStop.TabIndex = 6;
            this.buttonStop.Text = "Stop";
            this.toolTip1.SetToolTip(this.buttonStop, "Stop encoding/decoding");
            this.buttonStop.UseVisualStyleBackColor = true;
            // 
            // labelCalculationTime
            // 
            this.labelCalculationTime.AutoSize = true;
            this.labelCalculationTime.Location = new System.Drawing.Point(216, 385);
            this.labelCalculationTime.Name = "labelCalculationTime";
            this.labelCalculationTime.Size = new System.Drawing.Size(141, 13);
            this.labelCalculationTime.TabIndex = 7;
            this.labelCalculationTime.Text = "Calculation time (hh/mm/ss):";
            // 
            // labelElapsedTime
            // 
            this.labelElapsedTime.AutoSize = true;
            this.labelElapsedTime.Location = new System.Drawing.Point(231, 406);
            this.labelElapsedTime.Name = "labelElapsedTime";
            this.labelElapsedTime.Size = new System.Drawing.Size(70, 13);
            this.labelElapsedTime.TabIndex = 8;
            this.labelElapsedTime.Text = "00:00:00.000";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(704, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.labelElapsedTime);
            this.Controls.Add(this.labelCalculationTime);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonDecipher);
            this.Controls.Add(this.buttonCipher);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Lab07 - Block Ciphers";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.Label label1;

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripItemAboutProgram;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonCipher;
        private System.Windows.Forms.Button buttonDecipher;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label labelCalculationTime;
        private System.Windows.Forms.Label labelElapsedTime;
        private System.Windows.Forms.Label labelFileInputEntropy;
        private System.Windows.Forms.Label sizeStLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelFileOutputEntropy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxKeyLength;
        private System.Windows.Forms.Button buttonSaveFile;
        private System.Windows.Forms.TextBox textBoxSaveFile;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.TextBox textBoxOpenFile;
        private System.Windows.Forms.Button buttonSaveSettings;
        private System.Windows.Forms.Button buttonOpenSettings;
        private System.Windows.Forms.CheckBox checkBoxGenerateVector;
        private System.Windows.Forms.TextBox textBoxVector;
        private System.Windows.Forms.Button buttonGenerateVector;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.Button buttonGenerateKey;
        private System.Windows.Forms.RadioButton radioButtonRC2;
        private System.Windows.Forms.RadioButton radioButtonTripleDES;
        private System.Windows.Forms.RadioButton radioButtonDES;
        private System.Windows.Forms.RadioButton radioButtonRijndael;
        private System.Windows.Forms.RadioButton radioButtonAES;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

