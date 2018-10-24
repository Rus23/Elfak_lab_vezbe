
public abstract class Funkcija {
	

	public abstract double vrednostF(double xm);
	
	protected double imaNulu(double a, double b)
	{
		double xl=a,xr=b;
		double xm = (xl+xr)/2;
		if(xl == xr && vrednostF(xl) != 0){
			System.out.println("Funkcija nema nulu!");
			return 0.0;
			
		}
			if ( vrednostF(xm)== 0)
			{
				System.out.println("Nula funkcije je x="+xm);
				return xm;
			}
			else if(vrednostF(xm) < 0){
				xl = xm;
				return imaNulu(xl,xr);
			}
			else{
				xr = xm;
				return imaNulu(xl,xr);
			}
			
	}
	
}
