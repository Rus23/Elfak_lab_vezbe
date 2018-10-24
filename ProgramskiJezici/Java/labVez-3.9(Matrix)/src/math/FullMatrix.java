package math;

import java.io.*;

public class FullMatrix implements SquareMatrix {
	
	private int dim;
	private int matrix[][];
	private int m[][];
	
	public FullMatrix()
	{
	}

	public int det(){
		int A[][]=new int [dim][dim];
		int N=dim;
		for(int i=0;i<dim;i++)
			for(int j=0;j<dim;j++)
				A[i][j]=matrix[i][j];
		int rez=determinante(A,N);
		return rez;
	}
	public int determinante(int A[][], int N) {
		int res;

        
        if (N == 1)
            res = A[0][0];
        else if (N == 2)
            res = A[0][0]*A[1][1] - A[1][0]*A[0][1];
        
        else
        {
            res=0;
            for (int j1=0; j1<N; j1++)
            {
                            m = generateSubArray (A, N, j1);
                            res += Math.pow(-1.0, 1.0+j1+1.0) * A[0][j1] * determinante(m, N-1);
            }
        }
        return res;
	}
	
	public int[][] generateSubArray (int A[][], int N, int j1){
        m = new int[N-1][];
        for (int k=0; k<(N-1); k++)
                m[k] = new int[N-1];

        for (int i=1; i<N; i++)
        {
                int j2=0;
                for (int j=0; j<N; j++)
                {
                  if(j == j1)
                          continue;
                  m[i-1][j2] = A[i][j];
                  j2++;
                }
        }
        return m;
    }

	
	public void printMat() {
		
		System.out.println("Matrica: ");
		for (int i = 0; i < dim; i++)
		{
			for	(int j = 0; j< dim; j++)
			{
				System.out.print(matrix[i][j] + " ");
			}
			System.out.println();
		}

	}

	
	public void inputMat() throws Exception {
		try {
		InputStreamReader isr = new InputStreamReader(System.in);
		BufferedReader buff = new BufferedReader (isr);
		System.out.print("Unesite dimenziju matrice: ");
		dim = Integer.parseInt(buff.readLine());
		if (dim < 0)
		{
			buff.close();
			throw new Exception("Kakv si ti tupanj!");
		}
		matrix = new int[dim][dim];
		System.out.println("Unesite elemente matrice: ");
		for (int i = 0; i < dim; i++)
		{
			for	(int j = 0; j< dim; j++)
			{
				System.out.print("Element " + i + " " + j + ": ");
				matrix[i][j] = Integer.parseInt(buff.readLine());
			}
		}
		buff.close();
		} 
		catch (IOException e) {
			e.printStackTrace();
		}
		catch (Exception x)
		{
			System.out.println(x);
		}
		
	}


	public void inputBin(String s) throws Exception {
		
		try
		{
			FileInputStream f = new FileInputStream(s);
			BufferedInputStream b = new BufferedInputStream(f);
			DataInputStream d = new DataInputStream (b);
			dim = d.readInt();
			if ( dim < 0)
			{
				d.close();
				throw new Exception("Em tup, em panj!!");
			}
			matrix = new int[dim][dim];
			for (int i = 0; i < dim; i++)
			{
				for ( int j = 0; j < dim; j++)
				{
					matrix[i][j] = d.readInt();
				}
			}
			d.close();
		}
		catch (IOException x)
		{
			System.out.println(x);
		}
		catch (Exception x)
		{
			System.out.println(x);
		}

	}


	public void outputBin(String s) throws Exception{
		try{
			FileOutputStream f = new FileOutputStream(s);
			BufferedOutputStream b = new BufferedOutputStream(f);
			DataOutputStream d = new DataOutputStream (b);
			d.writeInt(dim);
			for (int i = 0; i < dim; i++)
			{
				for ( int j = 0; j < dim; j++)
				{
					d.writeInt(matrix[i][j]);
				}
			}
			d.close();
			
		}
		catch (IOException x)
		{
			System.out.println(x);
		}
		catch (Exception x)
		{
			System.out.println(x);
		}
		
		
		
	}
	
	public int getDim()
	{
		return dim;
	}
}
