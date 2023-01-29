using System;
using System.Collections.Generic;
using System.Text;

namespace PresidentesDeMexico
{
    public class Gobernante
    {
        //Atributos
        private int inicio;
        private int fin;
        private string nombre;
        private string significado;
        private string titulo;
        private string periodoHistorico;


        //Propiedades
        public int Inicio
        {
            get { return inicio; }
            set { inicio = value; }
        }        

        public int Fin
        {
            get { return fin; }
            set { fin = value; }
        }        

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }        

        public string Significado
        {
            get { return significado; }
            set { significado = value; }
        }        

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public string PeriodoHistorico
        {
            get {return periodoHistorico;}
            set {periodoHistorico=value;}
        }
    }
}
