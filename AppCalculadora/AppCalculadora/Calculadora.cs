using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCalculadora
{
    class Calculadora
    {
        double numero1, numero2;

        public Calculadora()
        {
        }
    public Calculadora (double numero1, double numero2)
        {
    this.numero1=numero1;
    this.numero2=numero2;
        }

    public double Numero1
        {
    get {return numero1;}
    set{ numero1 = value; }
        }
    public double Numero2
    {
        get { return numero2; }
        set { numero2 = value; }
    }

    public double Sumar (double mumero1, double mumero2)
     {
         return mumero1 + mumero2;
     }

    public double Restar(double mumero1, double mumero2)
    {
        return mumero1 - mumero2;
    }
    public double Multiplicar(double mumero1, double mumero2)
    {
        return mumero1 * mumero2;

    }
    public double Dividir(double mumero1, double mumero2)
    {
        return mumero1 / mumero2;
    }
    
        
        
     
 }
    
   }

