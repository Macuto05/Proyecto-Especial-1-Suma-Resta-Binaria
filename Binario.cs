using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Proyecto_Especial_1
{
    internal class Binario
    {
        #region atributos
        private int Numero1 { get; set; }
        private int Numero2 { get; set;}
        #endregion

        #region constructores
        public Binario(int num1, int num2)
        {
            Numero1 = num1;
            Numero2 = num2;
        }
        #endregion 

        #region metodos
        private string ConvertirBinario(int num)
        {
            string numBinario = "";
            do
            {
                numBinario = num % 2 + numBinario;
                num = num / 2;
            }while (num > 0);

            return numBinario;
                    
        }

        public void mostrarBinario()
        {
            Console.WriteLine("El primer numero en binario es: " + ConvertirBinario(Numero1));
            Console.WriteLine("El segundo numero en binario es: " + ConvertirBinario(Numero2));
            Console.WriteLine();
        }

        private string SumarBinario()
        {
            string BinarioSumado = "";
            int suma = Numero1 + Numero2;
            int acarreo = 0;
            int bin1, bin2;
            int sumaBin;

            do
            {
                bin1 = Numero1 % 2;
                bin2 = Numero2 % 2;
                sumaBin = bin1 + bin2 + acarreo;

                BinarioSumado = (sumaBin % 2) + BinarioSumado;

                acarreo = sumaBin / 2;

                suma = suma / 2;
                Numero1 = Numero1 / 2;
                Numero2 = Numero2 / 2;

            } while (acarreo > 0 || suma > 0);

            return BinarioSumado;
        }
        public void mostrarSumaBinaria()
        {
            Console.WriteLine("La suma de los numeros en binario seria: ");

            Console.WriteLine();

            Console.WriteLine(ConvertirBinario(Numero1) + "+");
            Console.WriteLine(ConvertirBinario(Numero2));
            Console.WriteLine("----------");
            Console.WriteLine(SumarBinario());
            Console.WriteLine();
        }

        private string RestarBinario()
        {
            string BinarioRestado = "";
            int aux, i, acarreo, bit, bit1, bit2;
            string bin1, bin2;

            //Validar quien es mayor

            if (Numero1 < Numero2)
            {
                aux = Numero1;
                Numero1 = Numero2;
                Numero2 = aux;
            }

             bin1 = ConvertirBinario(Numero1);
             bin2 = ConvertirBinario(Numero2);

            int longMax = Math.Max(bin1.Length, bin2.Length);

            //Validar que los 2 números tengan la misma longitud

            bin1 = bin1.PadLeft(longMax, '0');
            bin2 = bin2.PadLeft(longMax, '0');

            // Complemento a dos de Número2

            string complementoNumero2 = "";

            for (i = 0; i < bin2.Length; i++)
            {
                if (bin2[i] == '0')
                    complementoNumero2 += '1';
                else
                    complementoNumero2 += '0';
            }

            //Sumar 1 al complemento de Número2

            acarreo = 1;
            char[] complementoArray = complementoNumero2.ToCharArray();

            for (i = complementoArray.Length - 1; i >= 0; i--)
            {
                bit = complementoArray[i] - '0';

                int sumaCom = bit + acarreo;
                complementoArray[i] = (sumaCom % 2).ToString()[0];
                acarreo = sumaCom / 2;
            }

            //Sumar Número1 mas el complemento a dos de Número2

            acarreo = 0;

            for (i = longMax - 1; i >= 0; i--)
            {
                bit1 = bin1[i] - '0';
                bit2 = complementoArray[i] - '0';

                int suma = bit1 + bit2 + acarreo;
                BinarioRestado = (suma % 2).ToString()[0] + BinarioRestado;
                acarreo = suma / 2;
            }

            //Eliminar ceros sin valor del resultado

            BinarioRestado = BinarioRestado.TrimStart('0');

            if (BinarioRestado.Length > 0)
            {
                return BinarioRestado;
            }
            else
            {
                return "0";
            }
        }
        public void mostrarRestaBinaria()
        {
            Console.WriteLine("La resta de los numeros en binario seria: ");

            Console.WriteLine();

            Console.WriteLine(ConvertirBinario(Numero1) + "-");
            Console.WriteLine(ConvertirBinario(Numero2));
            Console.WriteLine("----------");
            Console.WriteLine(RestarBinario());
            Console.WriteLine();
        }  

        #endregion
    }
}
