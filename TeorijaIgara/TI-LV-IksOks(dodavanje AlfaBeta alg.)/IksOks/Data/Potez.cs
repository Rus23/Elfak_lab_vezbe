using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IksOks.Data
{
	public class Potez
	{
		public int x;
		public int y;
		public ContextIksOks PrethodnoStanje { get; set; }
		public ContextIksOks NarednoStanje { get; set; }

		public int Value { get; set; }
	}
}
