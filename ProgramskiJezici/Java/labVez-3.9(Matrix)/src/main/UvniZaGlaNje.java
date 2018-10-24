package main;

import math.*;

public class UvniZaGlaNje {

	public static void main(String[] args) throws Exception {
		
		SquareMatrix km = new FullMatrix();
		
		km.inputMat();
		km.printMat();
		km.outputBin("Matrix1.bin");
		km.inputBin("Matrix1.bin");
		km.printMat();
		int k = km.det();
		System.out.println("Determinanta: " + k);

	}

}
