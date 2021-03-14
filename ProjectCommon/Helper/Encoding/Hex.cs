using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ProjectCommon.Helper.Encoding
{
    /// <summary>
    /// Hexadecimal encoding
    /// </summary>
    public class Hex
    {
        /// <summary>
        /// Unhexifies
        /// </summary>
        public static byte[] HexToBytes(string hex)
        {
            byte[] bin = new byte[hex.Length / 2];
            for (int i = 0; i < bin.Length; i++)
            {
                string byteValue = hex.Substring(i * 2, 2);
                bin[i] = byte.Parse(byteValue, NumberStyles.HexNumber, CultureInfo.InvariantCulture);
            }
            return bin;
        }

        /// <summary>
        /// Convert bytearray to hex
        /// </summary>
        public static string BytesToHex(byte[] bin)
        {
            return BitConverter.ToString(bin).Replace("-", "");
        }
    }
}
