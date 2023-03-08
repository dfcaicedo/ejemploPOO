using System;
using System.Collections.Generic;
using System.Text;

namespace ejemplo
{
    class persona
    {
        int edad,  peso;
        string nombre; //Atributos
        int cant_calorias;
        bool despierto;
        public persona(string nombre, int edad, int peso) // Constructor -> Metodo
        {
            this.nombre = nombre;
            this.edad = edad;
            this.peso = peso;
            despierto = false;
            cant_calorias = 0;
        }
        public void despertar()
        {
            despierto = true;
        }
        public void dormir()
        {
            despierto = false;
        }

        public void AdicionarComida(int calorias)
        {
            if (despierto)
                cant_calorias += calorias;
        }
        public void consumircalorias(int calorias)
        {
            if (despierto)
                cant_calorias -= calorias;
        }
        public void MontarBici(int kms)
        {
            consumircalorias(20 * kms);
        }
        public void Caminar(int kms)
        {
            consumircalorias(50 * kms);
        }
        public void comer(int calorias)
        {
            this.AdicionarComida(calorias);
        }
        public void finalizardia()
        {
            this.peso += (cant_calorias) / 500;
            cant_calorias = 0;
        }
        public int getPeso()
        {
            return this.peso;
        }
        


    }
}
