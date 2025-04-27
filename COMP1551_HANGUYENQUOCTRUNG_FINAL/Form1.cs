using COMP1551_HANGUYENQUOCTRUNG_FINAL;
using System;
using System.Windows.Forms;

namespace COMP1551_HANGUYENQUOCTRUNG_FINAL
{
    public partial class Form1 : Form
    {
        private StringProcessing sp = new StringProcessing();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            try
            {
                // Get input from TextBoxes
                sp.InputString = txtInputString.Text; // Input string
                sp.N = int.Parse(txtN.Text);          // Integer N

                // Encode the input string
                string encodedString = sp.Encode();
                lblEncodedString.Text = $"Encoded String: {encodedString}";

                // Display ASCII codes
                lblInputCodes.Text = $"ASCII Codes of Input: {string.Join(", ", sp.InputCode())}";
                lblOutputCodes.Text = $"ASCII Codes of Output: {string.Join(", ", sp.OutputCode())}";

                // Display sorted input
                lblSortedInput.Text = $"Sorted Input: {sp.Sort()}";

                // Display hashes
                lblInputHash.Text = $"Input Hash: {sp.ComputeHash(txtInputString.Text)}";
                lblEncodedHash.Text = $"Encoded Hash: {sp.ComputeHash(encodedString)}";

                // Test decoding (reverse encoding)
                string originalInput = txtInputString.Text; // Backup original input
                int originalN = sp.N;                       // Backup N

                sp.InputString = encodedString; // Set output as input
                sp.N = -originalN;              // Reverse N

                string decodedString = sp.Encode(); // Decode
                MessageBox.Show($"Decoded String: {decodedString}", "Decoded Result"); // Should match original input

                // Restore original input and N (optional)
                sp.InputString = originalInput;
                sp.N = originalN;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
