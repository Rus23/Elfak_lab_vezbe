using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IksOks.Data
{
	public class Tabla : ICloneable
	{
		int[,] a;
		public int pobedio = 0;
		public Tabla()
		{
			a = new int[3, 3];
			for ( int i = 0; i < 3; i++ )
				for ( int j = 0; j < 3; j++ )
					a[i, j] = 0;
		}

		public Tabla(Tabla t)
		{
			a = new int[3, 3];
			for ( int i = 0; i < 3; i++ )
				for ( int j = 0; j < 3; j++ )
					a[i, j] = t.a[i, j];
		}

		public int Polje(int x, int y)
		{
			if ( x < 0 || x > a.Length )
				return 0;
			if ( y < 0 || y > a.Length )
				return 0;
			if ( a == null )
				return 0;
			return a[x, y];
		}

		public bool Potez(int igrac, int x, int y, out string info)
		{
			if(a[x,y]!=0)
			{
				info = "NEVALIDAN POTEZ!\nPolje je zauzeto!";
				return false;
			}
			info = null;
			a[x, y] = igrac;
			return true;
		}

		public bool DaLiJeKraj( out int pobedio )
		{
			int v,k,d,kd;
			pobedio = 0;
			d = kd = 0x3;

			for ( int i = 0; i < 3; i++ )
			{
				v = a[i, 0] & a[i, 1] & a[i, 2];
				if ( v != 0 )
				{
					pobedio = v;
					return true;
				}
				k = a[0, i] & a[1, i] & a[2, i];
				if ( k != 0 )
				{
					pobedio = k;
					return true;
				}
				d &= a[i, i];
				kd &= a[i, 2-i];
			}
			if ( d != 0 )
			{
				pobedio = d;
				return true;
			}
			if ( kd != 0 )
			{
				pobedio = kd;
				return true;
			}
			return false;
		}

		public object Clone()
		{
			return Dulpicate();
		}

		public Tabla Dulpicate()
		{
			return new Tabla( this );
		}

		internal List<Data.Potez> GetListaPoteza()
		{
			List<Potez> potezi = new List<Potez>();
			if ( DaLiJeKraj( out pobedio ) )
				return potezi;
			for ( int i = 0; i < 3; i++ )
				for ( int j = 0; j < 3; j++ )
					if ( a[i, j] == 0 )
						potezi.Add( new Potez()
							{
								x = i,
								y = j
							} );
			return potezi;
		}

		internal int DoKraja()
		{
			int c = 0;
			for ( int i = 0; i < 3; i++ )
				for ( int j = 0; j < 3; j++ )
					if ( a[i, j] == 0 ) c++;
			return c;
		}
	}
}
