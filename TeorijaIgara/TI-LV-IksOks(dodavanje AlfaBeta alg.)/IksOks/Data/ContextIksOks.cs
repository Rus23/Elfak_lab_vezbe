using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IksOks.Data
{
	public class ContextIksOks
	{
		public int NaPotezu { get; set; }
		public Tabla TrenutnoStanje { get; protected set;}

		public int Value{get;set;}

		public ContextIksOks(Tabla t, int igrac)
		{
			NaPotezu = igrac;
			TrenutnoStanje = t;
			Value = 0;
		}

		public virtual int Evaluate()
		{
			switch(TrenutnoStanje.pobedio)
			{
				case 0:
					return 0;
				case 1:
                    return 10;/*(NaPotezu==1)?10:-10;*/
				case 2:
                    return -10;/*( NaPotezu == 2 ) ? 10 : -10;*/
			}
			return 0;
		}

		internal void Sledeci()
		{
			NaPotezu = NaPotezu^3;
		}

		public List<Potez> GetListaMogucihPoteza()
		{
			List<Potez> potezi = TrenutnoStanje.GetListaPoteza();
			potezi.ForEach(x=>
			{
				string info;
				x.PrethodnoStanje = this;
				x.NarednoStanje = new ContextIksOks(new Tabla(TrenutnoStanje), NaPotezu);
				x.NarednoStanje.TrenutnoStanje.Potez(NaPotezu,x.x,x.y,out info);
				x.NarednoStanje.Sledeci();
			});
			return potezi;
		}
        public static Potez AlfaBeta(int alfa, int beta, ContextIksOks c, int depth)
        {
            List<Potez> sviMoguciPotezi = c.GetListaMogucihPoteza();
            Potez najPotez = new Potez();

            int najPotezVrednost = int.MinValue;

            if (c.NaPotezu == 2)
                najPotezVrednost = int.MaxValue;
                        
            if (depth == 0 || c.GetListaMogucihPoteza().Count == 0)
            {
                c.Value = c.Evaluate();
                return null;
            }

            foreach (Potez potez in sviMoguciPotezi)
            {
                MinMax(potez.NarednoStanje, depth - 1);
                int trenutniNajPotez = potez.NarednoStanje.Value;
                if (c.NaPotezu == 1)
                {                    
                    if (najPotezVrednost < trenutniNajPotez)
                    {
                        najPotezVrednost = trenutniNajPotez;
                        najPotez = potez;
                    }
                    alfa = Math.Max(alfa, najPotezVrednost);
                    if (beta <= alfa)
                        break;
                }
                else
                {                    
                    trenutniNajPotez = potez.NarednoStanje.Value;
                    if (najPotezVrednost > trenutniNajPotez)
                    {
                        najPotezVrednost = trenutniNajPotez;
                        najPotez = potez;
                    }
                    beta = Math.Min(beta, najPotezVrednost);
                    if (beta <= alfa)
                        break;
                }
            }
            c.Value = najPotezVrednost;
            return najPotez;
        }
		public static Potez MinMax(ContextIksOks c, int depth)
		{
            int alfa = int.MinValue;
            int beta = int.MaxValue;

            return AlfaBeta(alfa, beta, c, depth);            
		}
	}
}
