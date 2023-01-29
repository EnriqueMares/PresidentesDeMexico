using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace PresidentesDeMexico
{
    public class Gobernantes
    {
        //Atributos
        private List<Gobernante> lista = new List<Gobernante>();



        //Propiedades
        public List<Gobernante> Lista
        {
            get { return lista; }
            set { lista = value; }
        }


        //Metodos
        public void Guardar(string ruta, List<Gobernante> lista)
        {
            List<Gobernante> listaDeGobernantes = lista;
            try
            {
                //Guardar
                FileStream fs = new FileStream(ruta, FileMode.Create);
                //XmlTextWriter escritor=new XmlTextWriter(ruta, Encoding.UTF8);

                //escritor.Formatting=Formatting.Indented;                

                XmlSerializer serializador = new XmlSerializer(typeof(List<Gobernante>));


                /*    Gobernantes gobernanteInterino = new Gobernante();
                    gobernanteInterino.Inicio = listaDeGobernantes[0].Inicio;
                    gobernanteInterino.Fin = listaDeGobernantes[0].Fin;
                    gobernanteInterino.Nombre = listaDeGobernantes[0].Nombre;
                    gobernanteInterino.PeriodoHistorico = listaDeGobernantes[0].PeriodoHistorico;
                    gobernanteInterino.Significado = listaDeGobernantes[0].Significado;
                    gobernanteInterino.Titulo = listaDeGobernantes[0].Titulo;*/

                serializador.Serialize(fs, lista);
                //escritor.Close();
                fs.Close();
            }
            catch (Exception e)
            {

            }
        }

        public static List<Gobernante> Cargar(string ruta)
        {
            List<Gobernante> listaDeGobernantes;
            XmlTextReader lector = new XmlTextReader(ruta);
            XmlSerializer serializador = new XmlSerializer(typeof(List<Gobernante>));
            listaDeGobernantes = (List<Gobernante>)serializador.Deserialize(lector);
            lector.Close();

            //Para asegurar que nunca falle, por si no existe el gobernante
            if (listaDeGobernantes == null)
            {
                //  listaDeGobernantes=new List<Gobernante>;
            }
            return listaDeGobernantes;
        }
    }
}
