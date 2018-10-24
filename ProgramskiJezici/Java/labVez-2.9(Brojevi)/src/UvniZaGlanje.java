import kolekcija.Red;
import ti_nisi_covek.TiSiGreska;
import brojevi.RacionalanBroj;
//shift + alt + j
/**
 * @author Pavle
 *
 */
public class UvniZaGlanje 
{

	
public static void main(String[] args) throws Exception
{
	Red redInt = new Red(5);
	
	for(int i=0,br=0;!(redInt.isFull());i++,br=i*i){
		redInt.addEl(new Integer(i));
	}
		
	
	System.out.print("Svi clanovi reda"+"("+redInt.getBrEl()+"):\n");
	for(int i=0;i<redInt.getBrEl();i++) 
		System.out.print(" "+redInt.getRed(i));
	
	redInt.deleteEl();
	redInt.deleteEl();
	redInt.deleteEl();
	System.out.print("\n"+"Presotali clanovi reda"+"("+redInt.getBrEl()+"):\n");
	for(int i=0;i<redInt.getBrEl();i++)
		System.out.print(" "+redInt.getRed(i));
	System.out.print("\n");

		Red redRB = new Red(3); // 5

		for(int i=0,br=0;i<redRB.getDim();i++,br=i*i)
			redRB.addEl(new RacionalanBroj(i,-br));
		
		System.out.print("\n"+"Svi clanovi reda Racionalnih Brojeva"+
		"("+redRB.getBrEl()+"):\n");
		for(int i=0;i<redRB.getBrEl();i++) 
			System.out.print(" "+redRB.getRed(i));
		redRB.writeInFile("ZastoNeces.txt");
		//System.out.print("\n");
		
		
		redRB.deleteEl();
		//redRB.deleteEl();
		//redRB.deleteEl();
		//redRB.deleteEl();
		//redRB.deleteEl();
		//redRB.deleteEl();
		System.out.print("\n"+"Presotali clanovi reda"+"("+redRB.getBrEl()+"):\n");
		for(int i=0;i<redRB.getBrEl();i++)
			System.out.print(" "+redRB.getRed(i));
	
	
	
}
}
