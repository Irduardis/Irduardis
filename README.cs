using System;
public class Program
{
    public static void Main(string[] args)
    {
		//Eduardo Salvador Segovia Tzompa
		//2922573
		//Examen final
        double[] x = { 1, 2, 3, 4, 5};//meses
        double[] y = { 571, 142, 428, 1714, 3142};//scrap
        double[,] matriz = new double[5,6];
        double pivote, factor;
        double x_0 = 6;//Valor que se quiere encontrar
        double y_0 = 0;

        for (int i = 0; i < 5; i = i + 1)
        {
            for (int j = 0; j < 5; j = j + 1)
            {
                matriz[i, j] = Math.Pow(x[i],j);
            }
        }
        for (int i = 0; i < 5; i = i + 1)
        {
            matriz[i, 5] = y[i];
        }       
        //Eliminación Gaussiana
        //------------------------------
        for (int reng = 0; reng < 5; reng = reng + 1)
        {
            pivote = matriz[reng, reng];
            for (int colu = 0; colu < 6; colu = colu + 1)
            {
                matriz[reng, colu] = matriz[reng, colu] / pivote;
            }
            for (int reng_elimi = 0; reng_elimi < 5; reng_elimi = reng_elimi + 1)
            {
                if (reng_elimi != reng)
                {
                    factor = matriz[reng_elimi, reng];
                    for (int colu_elimi = 0; colu_elimi < 6; colu_elimi = colu_elimi + 1)
                    {
                        matriz[reng_elimi, colu_elimi] = matriz[reng_elimi, colu_elimi]
                            - factor * matriz[reng, colu_elimi];
                    }
                }
            }
        }
        //------------------------------        
        for (int i = 0; i < 5; i = i + 1)
        {
            y_0 = y_0 + matriz[i, 5]*Math.Pow(x_0,i);
        }
        Console.WriteLine("El valor del scrap en el mes de junio será: " + x_0 + " es " + y_0);
        Console.ReadLine();
    }
}
