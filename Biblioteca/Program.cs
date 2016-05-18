using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static String name = " ";
    static int numFac = 0001;
    static int selec = 0;
    static long telef = 0;
    static int cantidad = 0;
    static int sino = 0;
    static int monto = 0;
    class Libro
    {
        public float precio;
        public String Titulo;
        float desc;
        public Libro(float precio, String titulo, float desc)
        {
            this.precio = precio;
            this.Titulo = titulo;
            this.desc = desc;
        }

        public float getPrecio()
        { return this.precio; }

        public void setPrecio(float precio)
        { this.precio = precio; }

        public String getTitulo()
        { return this.Titulo; }

        public void setTitulo(string titulo)
        { this.Titulo = titulo; }

        public float getDescuento()
        { return this.desc; }

        public void setDescuento(float desc)
        { this.desc = desc; }

    }
    static void Main(string[] args)
    {
        int[] Libro = new int[10];
        Libro[] biblioteca = new Libro[10];
        Libro Libro1 = new Libro(1980, "El Señor de los Anillos, Las Dos Torres", 0.15f);
        Libro Libro2 = new Libro(5275, "Alicia en el Pais de las Maravillas", 0.05f);
        Libro Libro3 = new Libro(5440, "Cementerio de Mascotas", 0.10f);
        Libro Libro4 = new Libro(6460, "Quiero Aprender", 0.20f);
        Libro Libro5 = new Libro(8145, "El Poder del Pensamiento Positivo", 0.25f);
        Libro Libro6 = new Libro(8460, "Mi primer libro de Matematicas", 0.20f);
        Libro Libro7 = new Libro(10000, "Las Aventuras de Tom Sawyer", 0.05f);
        Libro Libro8 = new Libro(3160, "El Mago de Oz", 0.15f);
        Libro Libro9 = new Libro(8590, "La zona muerta", 0.10f);
        Libro Libro10 = new Libro(6500, "Viaje al Centro de la Tierra", 0.25f);
        biblioteca[0] = Libro1;
        biblioteca[1] = Libro2;
        biblioteca[2] = Libro3;
        biblioteca[3] = Libro4;
        biblioteca[4] = Libro5;
        biblioteca[5] = Libro6;
        biblioteca[6] = Libro7;
        biblioteca[7] = Libro8;
        biblioteca[8] = Libro9;
        biblioteca[9] = Libro10;
        float[] subtotales = new float[10];
        for (int i = 0; i < 10; i++) {
            subtotales[i] = 0;
        }
        bool continuar = true;
        Console.WriteLine("Buenas Tardes");
        Console.WriteLine("Ingrese su nombre  a aplicar a la factura:");
        name = Console.ReadLine();
        Console.WriteLine("Ingrese su numero de Telefono:");
        telef = int.Parse(Console.ReadLine());
        while (continuar)
        {
            float total = 0;
            Console.WriteLine("Digite el numero del libro que desee");
            Console.WriteLine("1-El Señor de los Anillos, Las Dos Torres\n 2-Alicia en el Pais de las Maravillas\n 3-Cementerio de Mascotas\n 4-Quiero Aprender\n 5-El poder del pensamiento Positivo\n 6-Mi primer libro de Matematicas\n 7- Las Aventuras de Tom Sawyer\n 8-El Mago de Oz\n 9-La zona Muerta\n 10-Viaje al Centro de la Tierra");
            selec = int.Parse(Console.ReadLine());
            Console.WriteLine("Cuantas Unidades desea?");
            cantidad = int.Parse(Console.ReadLine());
            subtotales[selec - 1] = subtotales[selec - 1] + ((biblioteca[selec - 1].getPrecio() - biblioteca[selec - 1].getPrecio() * biblioteca[selec - 1].getDescuento()) * cantidad);
            //precio = (precio - precio * 0.020)
            Console.WriteLine("Desea agregar otro libro?: \n0-No \n1-Si");
            sino= int.Parse(Console.ReadLine());
            if (sino == 1) {
                continuar = true;
            }
            else if (sino == 0) { continuar = false; }
            else {
                Console.WriteLine("Valor ingresado no valido");
            }

        }
        Console.WriteLine("Digite el monto con el que desea pagar:");
        monto = int.Parse(Console.ReadLine());


            Console.WriteLine("==============================================================");
            Console.Write("*-*               "); Console.Write("Libreria el Buen Lector"); Console.WriteLine("                  *-*");
            Console.WriteLine("==============================================================");
            Console.Write("Factura Proforma               "); Console.WriteLine("                          Nº:" + numFac);
            Console.WriteLine("Cliente: " + name);
            Console.WriteLine("Telefono: " + telef);
            Console.WriteLine("______________________________________________________________");
            Console.Write("Item                                 "); Console.Write("Precio     "); Console.Write("Ctd    "); Console.WriteLine("SubTotal");
        for (int i = 0; i < 10; i++)
        {
            if (subtotales[i] > 0)
                Console.WriteLine(biblioteca[i].getTitulo() + "   " + biblioteca[i].getPrecio() + "       " + subtotales[i] / (biblioteca[i].getPrecio()- biblioteca[i].getPrecio()*biblioteca[i].getDescuento()) + "     " + subtotales[i]);
        }
        
        Console.WriteLine("_______________________________________________________________");
        Console.WriteLine("Total de la Orden:                                        "+ (subtotales[selec-1]+subtotales[selec-1]));
        Console.WriteLine("Descuento:                                                "+ biblioteca[selec-1].getDescuento());
        Console.WriteLine("Impuesto de Venta:                                          13%");
        Console.WriteLine("Impuesto Total:                                           "+biblioteca[selec-1].getPrecio()*0.13);
        Console.WriteLine("Precio Neto:                                            {0}", (biblioteca[selec-1].getPrecio()+biblioteca[selec-1].getDescuento()));
        Console.WriteLine("_______________________________________________________________");
        Console.WriteLine("Monto Recibido:                                           "+monto);
        Console.WriteLine("Monto De Cambio:                                          {0}", monto- subtotales[selec - 1]);
        Console.WriteLine("===============================================================");
        Console.WriteLine("Gracias Por su Compra...");
        Console.ReadKey();

        }

    }


