using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOBJConverter.Types;

namespace TOBJConverter.IO
{
	public static class ToriiObjectWriter
	{
		private static char[] SIGNATURE = { 'T', 'O', 'R', 'I', 'I', 'O', 'B', 'J' };

		public static void Write(string location, ToriiObject toriiObject)
		{
			using (BinaryWriter writer = new BinaryWriter(File.Open(location, FileMode.Create)))
			{
				// FILE HEADER
				writer.Write(SIGNATURE);
				writer.Write(0x01); // version

				// FILE CONTENT
				writer.Write(toriiObject.ObjectFile);
				writer.Write(toriiObject.ObjectTexture);
				writer.Write(toriiObject.NumberOfObjects);
				writer.Write(0); // max animation ID
				writer.Write(0); // number of animations
			}
		}
	}

}
