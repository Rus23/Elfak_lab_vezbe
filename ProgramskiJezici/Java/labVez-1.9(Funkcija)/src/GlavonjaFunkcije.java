

public class GlavonjaFunkcije {

	public static void main(String[] args)
	{
		
		KvadratniTrinom kt = new KvadratniTrinom(2.0,1.0,-3.0);
		kt.imaNulu(-(kt.getB()/kt.getA()), -(kt.getB()/2*kt.getA()));
		kt.imaNulu(-1, 2);
	}
	
}
