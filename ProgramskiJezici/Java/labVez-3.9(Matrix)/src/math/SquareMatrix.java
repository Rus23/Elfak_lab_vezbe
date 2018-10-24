package math;

public interface SquareMatrix {

	public int determinante(int A[][], int N);
	public void printMat();
	public void inputMat() throws Exception;
	public void inputBin(String s)throws Exception;
	public void outputBin(String s)throws Exception;
	public int getDim();
	public int det();
}
