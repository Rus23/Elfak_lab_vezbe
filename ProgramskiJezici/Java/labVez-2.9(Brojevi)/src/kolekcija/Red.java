package kolekcija;
import java.io.*;
import java.util.Scanner;

import brojevi.RacionalanBroj;
import ti_nisi_covek.TiSiGreska;

public class Red
{

	private int dim;
	private int brEl=0;
	private Object[] red;  
	
	public Red()
	{dim = brEl =0;}
	 public Red(int d)
	 {
		 dim = d; brEl=0;
		 red = new Object[dim];
	 }
	 public boolean isFull(){ return dim == brEl;}
	 public void addEl(Object obj)
	 {
			try {
				if(isFull())
					throw new TiSiGreska("Nije crnja Tesla toliko brojeva da zapamti!");
			} catch (TiSiGreska e) {
				e.printStackTrace();
				return;
			}
		red[brEl++]=obj;
	 }
	 public void deleteEl() //(1st in/1st out)
	 {
		 try{
			 if(isEmpty())
				// throw new TiSiGreska("Maa ti si ; ");
				 throw new Exception("Ma ti si ;");
		 }
		 catch (TiSiGreska tg){
			 tg.printStackTrace();
			 return;
		 }
		 catch(Exception e)
		 {
			 e.printStackTrace();
			 return;
		 }
		
		 for(int i=0;i<brEl-1;i++)
			 red[i]=red[i+1];
		brEl--;
	 }
	 public void deleteThisEl(Object br) throws Exception
	 {
		 int i;
		 for( i =0;i<brEl && red[i]!=br;i++);
		 if(red[i]!=br)
			 throw new Exception("Ne nadjo ga!");
		 for(int j=i+1; j<brEl-1;j++)
			 red[i]=red[j];
		brEl--;
	 }
	 public void addEl(int br)
	 {
			try {
				if(isFull())
					throw new TiSiGreska("Nije crnja Tesla toliko brojeva da zapamti!");
			} catch (TiSiGreska e) {
				e.printStackTrace();
				return;
			}
		 Integer tmp = new Integer(br);
		 red[brEl++]=tmp;
	 }
	 public void readFromFile(String ime)
	 {
		 try {
			FileReader f = new FileReader(ime);
			BufferedReader br = new BufferedReader(f);
			for(int i=0;i<this.brEl;i++){
				if(red[i] instanceof Integer)
				{
					String pom;
				
				}
			}
			
		} catch (FileNotFoundException e) {
			e.printStackTrace();
		}
		 
		 
	 }
	 public void writeInFile(String ime)
	 {
		 
		 try {
			FileWriter f = new FileWriter(ime);
			BufferedWriter bw = new BufferedWriter(f);
			for(int i=0;i<this.brEl;i++)
			{
				if(red[i] instanceof Integer){
					bw.write( red[i].toString() );
					System.out.print("\nUnosInt:"+i);}
				else{
					Integer pBr= new Integer(5);//((RacionalanBroj)red[i]).getBrojilac()
					Integer pIm= new Integer(13);//((RacionalanBroj)red[i]).getImenilac()
					bw.write((new Integer(5)).toString());
					bw.newLine();
					bw.write((new Integer(13).toString()));
					bw.newLine();
					System.out.print("\nUnos:"+i);
				}	
			}
			bw.close();
			
		} catch (IOException e) {
			e.printStackTrace();
		}
		 
	 }
	 
	 public boolean isEmpty(){return brEl == 0;}
	 public Object getRed(int i) {
		return red[i];
	}
	 public int getBrEl() {
		return brEl;
	}
	 public int getDim() {
		return dim;
	}
	 public void setEl(int m, Object el){ red[m]=el;}
	
}
