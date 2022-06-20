using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCommon.Extensions
{
    public static class Hash
    {
        public static long[] Hash64(this string text, Encoding encoding = null)
        {
            if (string.IsNullOrEmpty(text))
            {
                return null;
            }

            if (encoding == null)
            {
                encoding = Encoding.UTF8;
            }

            var data = encoding.GetBytes(text);
            byte[] hash = new SHA256CryptoServiceProvider().ComputeHash(data);

            return new long[]
            {
                BitConverter.ToInt64(hash, 0),
                BitConverter.ToInt64(hash, 8),
                BitConverter.ToInt64(hash, 16),
                BitConverter.ToInt64(hash, 24)
            };

            
        }
    }
}
