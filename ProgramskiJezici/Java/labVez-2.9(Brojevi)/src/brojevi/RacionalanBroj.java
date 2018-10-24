package brojevi;

import ti_nisi_covek.TiSiGreska;
import java.io.*;

public class RacionalanBroj {
	
	private int brojilac;
	private int imenilac;
	
	public RacionalanBroj() 
	{
		InputStreamReader tast = new InputStreamReader(System.in);
		BufferedReader br = new BufferedReader(tast);
		try {
			brojilac = Integer.parseInt(br.readLine());
			imenilac = Integer.parseInt(br.readLine());
		} catch (NumberFormatException e) {
			e.printStackTrace();
		} catch (IOException e) {
			e.printStackTrace();
		}
	}
	public RacionalanBroj(int broj, int imen){
			try {
				if(imen==0)
					throw new TiSiGreska("Doci ce zuti ljudi i pice vodu sa Morave!");
			} catch (TiSiGreska tg) {
				tg.printStackTrace();
				//System.out.print(tg);
				imen=1;
			}
		this.brojilac = broj; this.imenilac = imen;}
	public RacionalanBroj( RacionalanBroj rb)
	{
		this.brojilac = rb.brojilac;
		this.imenilac = rb.imenilac;
	}
	public void setBrojilac(int brojilac) {
		this.brojilac = brojilac;
	}
	public void setImenilac(int imenilac) {
		this.imenilac = imenilac;
	}
	public String toString()
	{
		if(imenilac < 0){
			imenilac*=-1;
			brojilac*=-1;
			return brojilac+"/"+imenilac;
		}
		else if(brojilac <0)
			return brojilac + "/" + imenilac;
		else if(brojilac <0 && imenilac <0){
			brojilac *= imenilac *= -1;
			return "+"+brojilac + "/"+imenilac;
		}
		return "+"+brojilac + "/"+imenilac;
	}
public int getBrojilac() {
	return brojilac;
}
public int getImenilac() {
	return imenilac;
}
	
	
}
