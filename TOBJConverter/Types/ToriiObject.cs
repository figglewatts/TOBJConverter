using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOBJConverter.Types
{
	public class ToriiObject
	{
		public string ObjectFile;
		public string ObjectTexture;
		public int NumberOfObjects = 0;

		public ToriiObject(string objectFile, string objectTexture)
		{
			ObjectFile = objectFile;
		}
	}
}
