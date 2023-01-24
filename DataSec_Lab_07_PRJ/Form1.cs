using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Collections;

namespace DataSec_Lab_07_PRJ
{
    public partial class Form1 : Form
    {
        byte[] arrayFile = new byte[0];
        byte[] arrayResult = new byte[0];
        byte[] key = new byte[0];
        byte[] IV = new byte[0];

        RadioButton radioButtonLast = null;
        RadioButton radioButtonCurrent = null;
        string stringFile = "";

        public Form1()
        {
            InitializeComponent();
            comboBoxKeyLength.SelectedIndex = 0;
            textBoxVector.Text = "00-00-00-00-00-00-00-00";
        }

        private void toolStripItemAboutProgram_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yevdokimov Danil/r/nCiphering program", "About program", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void labelFileInputEntropy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(labelFileInputEntropy.Text);
        }

        private void labelFileOutputEntropy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(labelFileOutputEntropy.Text);
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            OpenFileDialog dialogOpenFile = new OpenFileDialog();
            dialogOpenFile.Filter = "All files (*.*)|*.*|Text files (*.txt)|*.txt";
            dialogOpenFile.FilterIndex = 2;
            dialogOpenFile.RestoreDirectory = true;

            if (dialogOpenFile.ShowDialog() == DialogResult.OK)
            {
                string pathFile = dialogOpenFile.FileName;

                if (pathFile == "")
                {
                    MessageBox.Show("This file is empty or damaged!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    buttonOpenFile.Focus();
                    this.Cursor = Cursors.Default;
                    return;
                }
                if (!File.Exists(pathFile))
                {
                    MessageBox.Show("This file does not exist!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    buttonOpenFile.Focus();
                    this.Cursor = Cursors.Default;
                    return;
                }
                textBoxOpenFile.Text = pathFile;
                this.arrayFile = File.ReadAllBytes(pathFile);
                this.stringFile = File.ReadAllText(pathFile);
                labelFileInputEntropy.Text = String.Format("{0:0.000}", CalculateEntropy(this.arrayFile));
                sizeStLabel.Text = String.Format("- {0:0.000} Mb ({1} bytes)", (double)this.arrayFile.Length / (1024.0 * 1024.0), arrayFile.Length);
            }
            this.Cursor = Cursors.Default;
        }

        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialogSaveFile = new SaveFileDialog();
            dialogSaveFile.Filter = "All files (*.*)|*.*|Text files (*.txt)|*.txt";
            dialogSaveFile.FilterIndex = 2;
            dialogSaveFile.CreatePrompt = true;
            dialogSaveFile.OverwritePrompt = true;
            dialogSaveFile.RestoreDirectory = true;

            if (dialogSaveFile.ShowDialog() == DialogResult.OK)
            {
                string pathFile = dialogSaveFile.FileName;

                if (pathFile == "")
                {
                    MessageBox.Show("The path to file is empty!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    buttonSaveFile.Focus();
                    return;
                }
                textBoxSaveFile.Text = pathFile;
            }
        }

        private void buttonSaveSettings_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialogSaveFile = new SaveFileDialog();
            dialogSaveFile.Filter = "All files (*.*)|*.*|Text files (*.txt)|*.txt";
            dialogSaveFile.FilterIndex = 2;
            dialogSaveFile.CreatePrompt = true;
            dialogSaveFile.OverwritePrompt = true;
            dialogSaveFile.RestoreDirectory = true;

            if (dialogSaveFile.ShowDialog() == DialogResult.OK)
            {
                string pathFile = dialogSaveFile.FileName;

                if (pathFile == "")
                {
                    MessageBox.Show("The path to file is empty!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    buttonSaveSettings.Focus();
                    return;
                }

                this.Cursor = Cursors.WaitCursor;
                Application.DoEvents();

                string stringSettings = "";

                if (radioButtonAES.Checked)
                    stringSettings += "AES+";

                if (radioButtonRijndael.Checked)
                    stringSettings += "Rjndael+";

                if (radioButtonDES.Checked)
                    stringSettings += "DES+";

                if (radioButtonTripleDES.Checked)
                    stringSettings += "TripleDES+";

                if (radioButtonRC2.Checked)
                    stringSettings += "RC2+";

                if (checkBoxGenerateVector.Checked)
                    stringSettings += "true+";
                else
                    stringSettings += "false+";

                stringSettings += comboBoxKeyLength.Text + "+";
                stringSettings += textBoxKey.Text + "+";
                stringSettings += textBoxVector.Text;

                File.WriteAllText(pathFile, stringSettings);
            }
            this.Cursor = Cursors.Default;
        }

        private void buttonOpenSettings_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            OpenFileDialog dialogOpenFile = new OpenFileDialog();
            dialogOpenFile.Filter = "All files (*.*)|*.*|Text files (*.txt)|*.txt";
            dialogOpenFile.FilterIndex = 2;
            dialogOpenFile.RestoreDirectory = true;

            if (dialogOpenFile.ShowDialog() == DialogResult.OK)
            {
                string pathFile = dialogOpenFile.FileName;

                if (pathFile == "")
                {
                    MessageBox.Show("The path to file is empty!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    buttonOpenSettings.Focus();
                    this.Cursor = Cursors.Default;
                    return;
                }

                if (!File.Exists(pathFile))
                {
                    MessageBox.Show("This file does not exist!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    buttonOpenSettings.Focus();
                    this.Cursor = Cursors.Default;
                    return;
                }

                string[] stringsSettings = File.ReadAllText(pathFile).Split('+');

                switch (stringsSettings[0])
                {
                    case "AES":
                        radioButtonAES.Checked = true;
                        break;
                    case "Rijndael":
                        radioButtonRijndael.Checked = true;
                        break;
                    case "DES":
                        radioButtonDES.Checked = true;
                        break;
                    case "TripleDES":
                        radioButtonTripleDES.Checked = true;
                        break;
                    case "RC2":
                        radioButtonRC2.Checked = true;
                        break;
                    default:
                        radioButtonAES.Checked = true;
                        break;
                }

                if (stringsSettings[1] == "true")
                    checkBoxGenerateVector.Checked = true;

                if (stringsSettings[1] == "false")
                {
                    checkBoxGenerateVector.Checked = false;
                    textBoxVector.Text = stringsSettings[4];
                    this.IV = StringToByteArray(stringsSettings[4]);
                }

                comboBoxKeyLength.SelectedItem = stringsSettings[2];
                textBoxKey.Text = stringsSettings[3];

                this.key = StringToByteArray(stringsSettings[3]);
            }
            this.Cursor = Cursors.Default;
        }

        private void buttonGenerateKey_Click(object sender, EventArgs e)
        {
            this.key = GenerateKey();
            textBoxKey.Text = HexToString(this.key);
        }

        private void buttonGenerateVector_Click(object sender, EventArgs e)
        {
            this.IV = GenerateIV();
            textBoxVector.Text = HexToString(this.IV);
        }

        private void checkBoxGenerateVector_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGenerateVector.Checked)
            {
                textBoxVector.Text = "00-00-00-00-00-00-00-00";
                textBoxVector.Enabled = false;
                buttonGenerateVector.Enabled = false;
            }
            else
            {
                textBoxVector.Enabled = true;
                textBoxVector.Text = HexToString(IV);
                buttonGenerateVector.Enabled = true;
            }
        }

        private void buttonCipher_Click(object sender, EventArgs e)
        {
            string pathFile = textBoxSaveFile.Text;
            DateTime timeStart;
            DateTime timeFinish;
            TimeSpan timeAll;
            labelElapsedTime.Text = "0:00:00:00.000";

            if (pathFile == "")
            {
                MessageBox.Show("The path to file is empty!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxSaveFile.Focus();
                return;
            }

            this.Cursor = Cursors.WaitCursor;
            Application.DoEvents();
            timeStart = DateTime.Now;

            this.arrayResult = MyCiphering(stringFile);
            File.WriteAllBytes(pathFile, this.arrayResult);

            timeFinish = DateTime.Now;
            timeAll = timeFinish - timeStart;

            labelElapsedTime.Text = timeAll.ToString(@"d\:hh\:mm\:ss\.ffffff");
            labelFileOutputEntropy.Text = String.Format("{0:0.000}", CalculateEntropy(this.arrayResult));

            this.Cursor = Cursors.Default;
        }

        private void buttonDecipher_Click(object sender, EventArgs e)
        {
            string pathFile = textBoxSaveFile.Text;
            DateTime timeStart;
            DateTime timeFinish;
            TimeSpan timeAll;
            labelElapsedTime.Text = "0:00:00:00.000";

            if (pathFile == "")
            {
                MessageBox.Show("The path to file is empty!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxSaveFile.Focus();
                return;
            }

            this.Cursor = Cursors.WaitCursor;
            Application.DoEvents();
            timeStart = DateTime.Now;
            try
            {
                this.arrayResult = Encoding.ASCII.GetBytes(MyDeciphering(this.arrayFile));
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong key or vector!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                buttonOpenSettings.Focus();
                this.Cursor = Cursors.Default;
                return;
            }
            File.WriteAllBytes(pathFile, this.arrayResult);
            timeFinish = DateTime.Now;
            timeAll = timeFinish - timeStart;
            labelElapsedTime.Text = timeAll.ToString(@"d\:hh\:mm\:ss\.ffffff");

            this.Cursor = Cursors.Default;
        }

        private void radioButtonAES_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonAES.Checked)
            {
                radioButtonCurrent = radioButtonAES;
                comboBoxKeyLength.Items.Clear();
                comboBoxKeyLength.Items.AddRange(new string[] { "128", "192", "256" });
                comboBoxKeyLength.Enabled = true;
                comboBoxKeyLength.SelectedIndex = 0;

                this.key = GenerateKey();
                this.IV = GenerateIV();

                textBoxKey.Text = HexToString(this.key);
                if(textBoxVector.Enabled) textBoxVector.Text = HexToString(this.IV);
            }
        }

        private void radioButtonRijndael_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonRijndael.Checked)
            {
                radioButtonCurrent = radioButtonRijndael;
                comboBoxKeyLength.Items.Clear();
                comboBoxKeyLength.Items.AddRange(new string[] { "128", "192", "256" });
                comboBoxKeyLength.Enabled = true;
                comboBoxKeyLength.SelectedIndex = 0;

                this.key = GenerateKey();
                this.IV = GenerateIV();

                textBoxKey.Text = HexToString(this.key);
                if (textBoxVector.Enabled) textBoxVector.Text = HexToString(this.IV);
            }
        }

        private void radioButtonDES_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonDES.Checked)
            {
                radioButtonCurrent = radioButtonDES;
                comboBoxKeyLength.Items.Clear();
                comboBoxKeyLength.Items.Add("64");
                comboBoxKeyLength.Enabled = false;
                comboBoxKeyLength.SelectedIndex = 0;

                this.key = GenerateKey();
                this.IV = GenerateIV();

                textBoxKey.Text = HexToString(this.key);
                if (textBoxVector.Enabled) textBoxVector.Text = HexToString(this.IV);
            }
        }

        private void radioButtonTripleDES_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonTripleDES.Checked)
            {
                radioButtonCurrent = radioButtonTripleDES;
                comboBoxKeyLength.Items.Clear();
                comboBoxKeyLength.Items.AddRange(new string[] { "128", "192" });
                comboBoxKeyLength.Enabled = true;
                comboBoxKeyLength.SelectedIndex = 0;

                this.key = GenerateKey();
                this.IV = GenerateIV();
                textBoxKey.Text = HexToString(this.key);
                if (textBoxVector.Enabled) textBoxVector.Text = HexToString(this.IV);
            }
        }

        private void radioButtonRC2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonRC2.Checked)
            {
                radioButtonCurrent = radioButtonRC2;
                comboBoxKeyLength.Items.Clear();
                comboBoxKeyLength.Items.AddRange(new string[] { "40", "48", "56", "64", "72", "80", "88", "96", "104", "112", "120", "128" });
                comboBoxKeyLength.Enabled = true;
                comboBoxKeyLength.SelectedIndex = 0;

                this.key = GenerateKey();
                this.IV = GenerateIV();
                textBoxKey.Text = HexToString(this.key);
                if (textBoxVector.Enabled) textBoxVector.Text = HexToString(this.IV);
            }
        }

        private byte[] MyCiphering(string stringInput)
        {
            byte[] result = { 0 };
            if (radioButtonAES.Checked == true)
            {
                using (Aes aes = Aes.Create())
                {
                    aes.Key = this.key;
                    if (checkBoxGenerateVector.Checked)
                    {
                        try
                        {
                            aes.IV = this.key;
                        }
                        catch (Exception)
                        {
                            aes.IV = (byte[])this.key.Take(this.key.Length / 2);
                        }
                    }
                    else
                    {
                        aes.IV = this.IV;
                    }
                    result = Encryption.encryptAes(stringInput, aes.Key, aes.IV);
                }
            }
            if (radioButtonRijndael.Checked == true)
            {
                using (Rijndael rijndael = Rijndael.Create())
                {
                    rijndael.Key = this.key;
                    if (checkBoxGenerateVector.Checked)
                    {
                        rijndael.IV = this.key;
                    }
                    else
                    {
                        rijndael.IV = this.IV;
                    }
                    result = Encryption.encryptRijndael(stringInput, rijndael.Key, rijndael.IV);
                }
            }
            if (radioButtonDES.Checked == true)
            {
                using (DES des = DES.Create())
                {
                    des.Key = this.key;
                    if (checkBoxGenerateVector.Checked)
                    {
                        des.IV = this.key;
                    }
                    else
                    {
                        des.IV = this.IV;
                    }
                    result = Encryption.encryptDES(stringInput, des.Key, des.IV);
                }
            }
            if (radioButtonTripleDES.Checked == true)
            {
                using (TripleDES trDES = TripleDES.Create())
                {
                    trDES.Key = this.key;
                    if (checkBoxGenerateVector.Checked)
                    {
                        try
                        {
                            trDES.IV = this.key;
                        }
                        catch (Exception)
                        {
                            trDES.IV = this.key.Take(this.key.Length / 2).ToArray();
                        }
                    }
                    else
                    {
                        trDES.IV = this.IV;
                    }
                    result = Encryption.encryptTripleDES(stringInput, trDES.Key, trDES.IV);
                }
            }
            if (radioButtonRC2.Checked == true)
            {
                using (RC2 rc2 = RC2.Create())
                {
                    rc2.Key = this.key;
                    if (checkBoxGenerateVector.Checked)
                    {
                        try
                        {
                            rc2.IV = this.key;
                        }
                        catch (Exception)
                        {
                            rc2.IV = this.key.Take(5).Union(this.key.Take(3)).ToArray();
                        }
                    }
                    else
                    {
                        rc2.IV = this.IV;
                    }
                    result = Encryption.encryptRC2(stringInput, rc2.Key, rc2.IV);
                }
            }
            return result;
        }

        private string MyDeciphering(byte[] arrayInput)
        {
            string result = "";
            if (radioButtonAES.Checked == true)
            {
                using (Aes aes = Aes.Create())
                {
                    aes.Key = this.key;
                    if (checkBoxGenerateVector.Checked)
                    {
                        aes.IV = this.key;
                    }
                    else
                    {
                        aes.IV = this.IV;
                    }

                    result = Encryption.decryptAes(arrayInput, aes.Key, aes.IV);
                }
            }
            if (radioButtonRijndael.Checked == true)
            {
                using (Rijndael rijndael = Rijndael.Create())
                {
                    rijndael.Key = this.key;
                    if (checkBoxGenerateVector.Checked)
                    {
                        rijndael.IV = this.key;
                    }
                    else
                    {
                        rijndael.IV = this.IV;
                    }

                    result = Encryption.decryptRijndael(arrayInput, rijndael.Key, rijndael.IV);
                }
            }
            if (radioButtonTripleDES.Checked == true)
            {
                using (DES des = DES.Create())
                {
                    des.Key = this.key;
                    if (checkBoxGenerateVector.Checked)
                    {
                        des.IV = this.key;
                    }
                    else
                    {
                        des.IV = this.IV;
                    }

                    result = Encryption.decryptDES(arrayInput, des.Key, des.IV);
                }
            }
            if (radioButtonTripleDES.Checked == true)
            {
                using (TripleDES trDES = TripleDES.Create())
                {
                    trDES.Key = this.key;
                    if (checkBoxGenerateVector.Checked)
                    {
                        trDES.IV = this.key;
                    }
                    else
                    {
                        trDES.IV = this.IV;
                    }

                    result = Encryption.decryptTripleDES(arrayInput, trDES.Key, trDES.IV);
                }
            }
            if (radioButtonRC2.Checked == true)
            {
                using (RC2 rc2 = RC2.Create())
                {
                    rc2.Key = this.key;
                    if (checkBoxGenerateVector.Checked)
                    {
                        rc2.IV = this.key;
                    }
                    else
                    {
                        rc2.IV = this.IV;
                    }

                    result = Encryption.decryptRC2(arrayInput, rc2.Key, rc2.IV);
                }
            }
            return result;
        }

        string HexToString(byte[] arrayInput)
        {
            return BitConverter.ToString(arrayInput);
        }

        byte[] GenerateKey()
        {
            if (radioButtonAES.Checked)
            {
                AesCryptoServiceProvider provider = new AesCryptoServiceProvider();
                provider.KeySize = Int32.Parse(comboBoxKeyLength.Text);
                provider.GenerateKey();
                return provider.Key;
            }
            if (radioButtonRijndael.Checked)
            {
                RijndaelManaged provider = new RijndaelManaged();
                provider.KeySize = Int32.Parse(comboBoxKeyLength.Text);
                provider.GenerateKey();
                return provider.Key;
            }
            if (radioButtonDES.Checked)
            {
                DESCryptoServiceProvider provider = new DESCryptoServiceProvider();
                provider.KeySize = Int32.Parse(comboBoxKeyLength.Text);
                provider.GenerateKey();
                return provider.Key;
            }
            if (radioButtonTripleDES.Checked)
            {
                TripleDESCryptoServiceProvider provider = new TripleDESCryptoServiceProvider();
                provider.KeySize = Int32.Parse(comboBoxKeyLength.Text);
                provider.GenerateKey();
                return provider.Key;
            }
            if (radioButtonRC2.Checked)
            {
                RC2CryptoServiceProvider provider = new RC2CryptoServiceProvider();
                provider.KeySize = Int32.Parse(comboBoxKeyLength.Text);
                provider.GenerateKey();
                return provider.Key;
            }
            return new byte[0];
        }

        byte[] GenerateIV()
        {
            if (radioButtonAES.Checked)
            {
                AesCryptoServiceProvider provider = new AesCryptoServiceProvider();
                provider.KeySize = Int32.Parse(comboBoxKeyLength.Text);
                provider.GenerateIV();
                return provider.IV;
            }
            if (radioButtonRijndael.Checked)
            {
                RijndaelManaged provider = new RijndaelManaged();
                provider.KeySize = Int32.Parse(comboBoxKeyLength.Text);
                provider.GenerateIV();
                return provider.IV;
            }
            if (radioButtonDES.Checked)
            {
                DESCryptoServiceProvider provider = new DESCryptoServiceProvider();
                provider.KeySize = Int32.Parse(comboBoxKeyLength.Text);
                provider.GenerateIV();
                return provider.IV;
            }
            if (radioButtonTripleDES.Checked)
            {
                TripleDESCryptoServiceProvider provider = new TripleDESCryptoServiceProvider();
                provider.KeySize = Int32.Parse(comboBoxKeyLength.Text);
                provider.GenerateIV();
                return provider.IV;
            }
            if (radioButtonRC2.Checked)
            {
                RC2CryptoServiceProvider provider = new RC2CryptoServiceProvider();
                provider.KeySize = Int32.Parse(comboBoxKeyLength.Text);
                provider.GenerateIV();
                return provider.IV;
            }
            return new byte[0];
        }

        private void comboBoxKeyLength_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioButtonLast != radioButtonCurrent)
            {
                radioButtonLast = radioButtonCurrent;
                return;
            }

            this.key = GenerateKey();
            this.IV = GenerateIV();

            textBoxKey.Text = HexToString(this.key);
            textBoxVector.Text = HexToString(this.IV);
        }

        private double CalculateEntropy(byte[] array)
        {
            double entropy = 0.0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != 0)
                {
                    entropy += -((double)array[i] / (double)array.Length) * Math.Log((double)array[i] / (double)array.Length, 2.0);
                }
            }
            return entropy;
        }

        byte[] StringToByteArray(string hex)
        {
            string tmp = hex.Replace("-", "");
            int length = tmp.Length;
            if (length % 2 == 1)
            {
                tmp = "0" + tmp;
                length++;
            }

            int halfLength = length / 2;
            byte[] bs = new byte[halfLength];

            for (int i = 0; i != halfLength; i++)
            {
                bs[i] = (byte)Int32.Parse(tmp.Substring(i * 2, 2), System.Globalization.NumberStyles.HexNumber);
            }
            return bs;
        }

        private void textBoxKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            char[] ch = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            if (!ch.Contains(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '-')
            {
                if (ch.Contains(e.KeyChar.ToString().ToUpper().ToCharArray()[0]))
                {
                    e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];

                    string result = "";
                    string[] strings = textBoxKey.Text.Split('-');

                    for(int i = 0; i < strings.Length; i++)
                    {
                        if (strings[i].Length == 2)
                        {
                            result += strings[i];
                        }
                    }

                    this.key = StringToByteArray(result);

                    return;
                }

                e.Handled = true;
                return;
            }
            else
            {
                string result = "";
                string[] strings = textBoxKey.Text.Split('-');

                for (int i = 0; i < strings.Length; i++)
                {
                    if (strings[i].Length == 2)
                    {
                        result += strings[i];
                    }
                }

                this.key = StringToByteArray(result);

            }

        }

        private void textBoxVector_KeyPress(object sender, KeyPressEventArgs e)
        {
            char[] ch = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            if (!ch.Contains(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '-')
            {
                if (ch.Contains(e.KeyChar.ToString().ToUpper().ToCharArray()[0]))
                {
                    e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
                    string result = "";
                    string[] strings = textBoxVector.Text.Split('-');

                    for (int i = 0; i < strings.Length; i++)
                    {
                        if (strings[i].Length == 2)
                        {
                            result += strings[i];
                        }
                    }

                    this.IV = StringToByteArray(result);

                    return;
                }
                e.Handled = true;
                return;
            }
            else
            {
                string result = "";
                string[] strings = textBoxVector.Text.Split('-');

                for (int i = 0; i < strings.Length; i++)
                {
                    if (strings[i].Length == 2)
                    {
                        result += strings[i];
                    }
                }

                this.IV = StringToByteArray(result);
            }
        }

    }
}
