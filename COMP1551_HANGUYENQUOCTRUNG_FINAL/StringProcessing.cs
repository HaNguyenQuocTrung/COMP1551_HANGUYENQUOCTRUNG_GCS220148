using System;
using System.Security.Cryptography;
using System.Text;

namespace COMP1551_HANGUYENQUOCTRUNG_FINAL
{
    public class StringProcessing
    {
        private string _inputString;
        private int _n;

        public string InputString
        {
            get => _inputString;
            set
            {
                if (value.Length > 40 || !IsValidInput(value))
                {
                    throw new ArgumentException("Input must be 40 characters or less and contain only capital letters (A-Z).");
                }
                _inputString = value;
            }
        }

        public int N
        {
            get => _n;
            set
            {
                if (value < -25 || value > 25)
                {
                    throw new ArgumentException("N must be between -25 and 25.");
                }
                _n = value;
            }
        }

        public string Encode()
        {
            char[] output = new char[_inputString.Length];

            for (int i = 0; i < _inputString.Length; i++)
            {
                char newChar = (char)(((_inputString[i] - 'A' + N + 26) % 26) + 'A');
                output[i] = newChar;
            }

            return new string(output);
        }

        public int[] InputCode()
        {
            return Array.ConvertAll(_inputString.ToCharArray(), c => (int)c);
        }

        public int[] OutputCode()
        {
            return Array.ConvertAll(Encode().ToCharArray(), c => (int)c);
        }

        public string Sort()
        {
            char[] sortedArray = _inputString.ToCharArray();
            Array.Sort(sortedArray);
            return new string(sortedArray);
        }

        private bool IsValidInput(string input)
        {
            foreach (char c in input)
            {
                if (c < 'A' || c > 'Z') return false;
            }
            return true;
        }

        // New method: Compute SHA-256 hash of any string
        public string ComputeHash(string text)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(text));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public string Print()
        {
            return Encode();
        }
    }
}
