using IksOks.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IksOks
{
	public partial class Form1 : Form
	{
		Button[,] buttons;
		int igrac = 0;
		ContextIksOks context;
		public Form1()
		{
			InitializeComponent();
		}

		private void NovaIgra( object sender, EventArgs e )
		{
			Button sb = sender as Button;
			if ( sb == null )
				return;
			if(sb.Name.Contains("X"))
			{
				igrac = 1;
			}
			else
			{
				igrac = 2;
			}

			buttons = new Button[3, 3];

			for(int i=0;i<3;i++)
				for(int j=0;j<3;j++)
				{
					Button b = new Button()
					{
						BackColor = Color.White,
						Dock = System.Windows.Forms.DockStyle.Fill,
						Font = new System.Drawing.Font( "Stencil", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) ),
						Location = new System.Drawing.Point( 3, 3 ),
						Name = "button"+i.ToString()+j.ToString(),
						Size = new System.Drawing.Size( 93, 93 ),
						TabIndex = 0,
						Text = "",
						Tag = i*10+j,
					};
					b.Click += b_Click;
					tlpGame.Controls.Add( b, j, i );
					buttons[i, j] = b;
				}
			pnlHeader.Visible = false;
			pnlGameInfo.Visible = true;

			context = new ContextIksOks( new Tabla(), igrac );
		}

		void b_Click( object sender, EventArgs e )
		{
			Button b = sender as Button;
			if ( b == null )
				return;
			int x = (int)b.Tag;
			int y = x % 10;
			x = x / 10;

			UradiPotez( new Potez()
			{
				x = x,
				y = y,
			} );

			if ( context.NaPotezu != igrac )
			{
				try
				{
					this.Enabled = false;
					if ( context.TrenutnoStanje.DoKraja() == 0 )
					{
						MessageBox.Show( "Nerešeno" );
						return;
					}
					Potez p = ContextIksOks.MinMax( context, 8 );
					UradiPotez( p );
				}
				finally
				{
					this.Enabled = true;
				}
			}
		}

		protected virtual void UradiPotez(Potez p)
		{
			string info;
			if ( context.TrenutnoStanje.Potez( context.NaPotezu, p.x, p.y, out info ) )
			{
				OsveziPrikaz();
				int igrac;
				if ( context.TrenutnoStanje.DaLiJeKraj( out igrac ) )
				{
					if ( igrac == 1 )
						MessageBox.Show( "Pobedio X" );
					else
						MessageBox.Show( "Pobedio O" );
					return;
				}
				context.Sledeci();
				if ( context.NaPotezu == 1 )
					lblIgrac.Text = btnX.Text;
				else
					lblIgrac.Text = btnO.Text;
			}
			else
			{
				MessageBox.Show( info );
			}
		}

		protected virtual void OsveziPrikaz()
		{
			for ( int i = 0; i < 3; i++ )
				for ( int j = 0; j < 3; j++ )
				{
					var p = context.TrenutnoStanje.Polje( i, j );
					switch ( p )
					{
						case 1:
							buttons[i, j].Text = btnX.Text;
							buttons[i, j].ForeColor = btnX.ForeColor;
							break;
						case 2:
							buttons[i, j].Text = btnO.Text;
							buttons[i, j].ForeColor = btnO.ForeColor;
							break;
						default:
							buttons[i, j].Text = "";
							break;
					}
				}
		}

		private void btnNewGame_Click( object sender, EventArgs e )
		{
			pnlGameInfo.Visible = false;
			pnlHeader.Visible = true;
			tlpGame.Controls.Clear();
			buttons = null;
		}
	}
}
