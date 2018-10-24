import java.util.*;

public class KvadratniTrinom extends Funkcija {

	private double a,b,c;

	public KvadratniTrinom()
	{
		Scanner tast = new Scanner(System.in);
		a= tast.nextDouble();
		b= tast.nextDouble();
		c= tast.nextDouble();
	}
	public double getA() {
		return a;
	}
	public double getB() {
		return b;
	}
	public double getC() {
		return c;
	}
	public KvadratniTrinom(double aa, double bb, double cc)
	{
		a = aa; b = bb; c = cc;
	}
	
	public double vrednostF(double x) {
		return x = this.a*Math.pow(x, 2) + this.b*x + this.c;
	}
	

}
