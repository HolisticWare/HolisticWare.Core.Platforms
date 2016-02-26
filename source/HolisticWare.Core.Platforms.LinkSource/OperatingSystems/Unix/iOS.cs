using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Platforms.OperatingSystems.Unix
{
	public partial class iOS : Darwin
	{
		public bool IsUnified 
		{
			get; 
		}

		public string Architecture
		{
			get
			{
				return this.Architecture();
			}
		}

		public string Architecture()
		{
			string architecture = null;

			if (IntPtr.Size == 4)
			{
				architecture = "32-bit";
			}
			else if (IntPtr.Size == 8)
			{
				architecture = "64-bit";
			}

			return architecture;
		}
	}
}
