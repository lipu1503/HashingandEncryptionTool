using SmartCommon.Security;

namespace HashingAndEncryption
{
    public partial class HashingAndEncryption : Form
    {
        IAES aesEncryption;
        SmartEncryptionSuit smartEncryptionSuit;
        IRijndael rijndaelEncryption;


        public HashingAndEncryption()
        {
            InitializeComponent();
            aesEncryption = new AES();
            smartEncryptionSuit = new SmartEncryptionSuit();
            rijndaelEncryption = new Rijndael();
        }

        private void HashingAndEncryption_Load(object sender, EventArgs e)
        {

        }

        

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbtnAES.Checked)
                {
                    txtOutput.Text = aesEncryption.Decrypt(txtInput.Text.Trim(), textBoxKey.Text);
                }
                else if (rbtnSmart.Checked)
                {
                    txtOutput.Text = SmartEncryptionSuit.Decrypt(txtInput.Text.Trim());
                }
                else if (rbtnRijManaged.Checked)
                {
                    txtOutput.Text = rijndaelEncryption.Decrypt(txtInput.Text.Trim());
                }
            }
            finally
            {

            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbtnAES.Checked)
                {
                    txtOutput.Text = aesEncryption.Encrypt(txtInput.Text.Trim(), textBoxKey.Text);
                }
                else if (rbtnSmart.Checked)
                {
                    txtOutput.Text = SmartEncryptionSuit.Encrypt(txtInput.Text.Trim());
                }
                else if (rbtnRijManaged.Checked)
                {
                    txtOutput.Text = rijndaelEncryption.Encrypt(txtInput.Text.Trim());
                }
            }
            finally
            {

            }

        }
    }
}
