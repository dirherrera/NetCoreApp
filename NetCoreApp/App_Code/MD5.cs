using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreApp.App_Code
{
	public class MD5
	{
		public static string Encrypt(string value)
		{
			string hash = "";
			using (var md5 = System.Security.Cryptography.MD5.Create()) {
				hash = BitConverter.ToString(
					md5.ComputeHash(Encoding.ASCII.GetBytes(value)))
					.Replace("-", string.Empty);
			}
			return hash;
		}
	}
}
