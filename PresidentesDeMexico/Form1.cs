using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PresidentesDeMexico
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        List<Gobernante> listaDeGobernantes = new List<Gobernante>();
        string ruta;
        int inicio;
        int gobernanteEncontrado = 0;
        List<Gobernante> GobernantesEncontrados;
        Gobernante gobernanteInterino;

        private void Form1_Load(object sender, EventArgs e)
        {
            nudInicioGobierno.Minimum = 1233;
            nudInicioGobierno.Maximum = DateTime.Now.Year;
            nudFinGobierno.Minimum = nudInicioGobierno.Minimum+1;
            nudFinGobierno.Maximum = DateTime.Now.Year+6;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ruta = txtRuta.Text;
            listaDeGobernantes = Gobernantes.Cargar(ruta);
            dgvGobernantes.DataSource = listaDeGobernantes;
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            txtRuta.Enabled = false;
            OpenFileDialog archivo = new OpenFileDialog();
            archivo.Title = "Seleccione el Archivo Xml";
            archivo.Filter = "Archivo Xml(*.xml)|*.xml";
            archivo.ShowDialog();
            txtRuta.Text = archivo.FileName;
        }

        private void btnGobernantes_Click(object sender, EventArgs e)
        {
            gobernanteEncontrado = 0;
            switch (cboTiposBusqueda.SelectedIndex)
            {
                case 0://Año Unitario            
                    //Reiniciar la Lista de Gobernantes Encontrados
                    GobernantesEncontrados = new List<Gobernante>();

                    int año = int.Parse(cboAño.Text);                    
                    gobernanteInterino = new Gobernante();

                    //Saber cuantos gobernantes encontro

                    for (int casillero = 0; casillero <= listaDeGobernantes.Count - 1; casillero++)
                    {
                        if (listaDeGobernantes[casillero].Inicio == año || listaDeGobernantes[casillero].Fin == año || listaDeGobernantes[casillero].Inicio <= año && listaDeGobernantes[casillero].Fin >= año)
                        {
                            Buscar(casillero);
                        }
                    }
                    Mostrar();
                    
                    break;
                case 1://Intervalo de Años
                    GobernantesEncontrados = new List<Gobernante>();
                    int añoInicio = int.Parse(cboAño.Text);
                    int añoFin = int.Parse(cboFin.Text);
                    gobernanteInterino = new Gobernante();
                    //Saber cuantos gobernantes encontro

                    for (int casillero = 0; casillero <= listaDeGobernantes.Count - 1; casillero++)
                    {
                        if (listaDeGobernantes[casillero].Fin <= añoFin && listaDeGobernantes[casillero].Inicio>=añoInicio
                            || listaDeGobernantes[casillero].Fin >= añoInicio && listaDeGobernantes[casillero].Fin<=añoFin
                            || listaDeGobernantes[casillero].Fin >= añoFin && listaDeGobernantes[casillero].Inicio <= añoFin)
                        {
                            Buscar(casillero);
                        }
                    }
                    Mostrar();
                    break;
                case 2://Periodo Historico
                    //Reiniciar la Lista de Gobernantes Encontrados
                    GobernantesEncontrados = new List<Gobernante>();
                    string periodoHistorico = cboTiposGobernantes.Text;

                     gobernanteInterino= new Gobernante();

                    //Saber cuantos gobernantes encontro

                    for (int casillero = 0; casillero <= listaDeGobernantes.Count - 1; casillero++)
                    {
                        if (listaDeGobernantes[casillero].PeriodoHistorico == periodoHistorico)
                        {
                            Buscar(casillero);
                        }
                    }
                    Mostrar();
                    break;
                case 3://Tipo de Gobernante
                    //Reiniciar la Lista de Gobernantes Encontrados
                    GobernantesEncontrados = new List<Gobernante>();
                    string tipoGobernante = cboTiposGobernantes.Text;

                    gobernanteInterino = new Gobernante();

                    //Saber cuantos gobernantes encontro
                    for (int casillero = 0; casillero <= listaDeGobernantes.Count - 1; casillero++)
                    {
                        if (listaDeGobernantes[casillero].Titulo == tipoGobernante)
                        {
                            Buscar(casillero);
                        }
                    }
                    Mostrar();
                    break;
                case 4://Nombre
                    //Reiniciar la Lista de Gobernantes Encontrados
                    GobernantesEncontrados = new List<Gobernante>();
                    string nombre = txtNombreBuscar.Text;

                    gobernanteInterino = new Gobernante();

                    //Saber cuantos gobernantes encontro
                    for (int casillero = 0; casillero <= listaDeGobernantes.Count - 1; casillero++)
                    {
                        if (listaDeGobernantes[casillero].Nombre.Contains(nombre)==true)
                        {
                            Buscar(casillero);
                        }
                    }
                    Mostrar();
                    break;
                default:
                    break;
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            int largo = Form1.ActiveForm.Width - 95;
            pnBuscar.Width = largo;
            dgvGobernantesAño.Width = largo;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Gobernante nuevoGobernante = new Gobernante();

            ruta = txtRuta.Text;
            List<Gobernante> listaNuevaDeGobernantes = new List<Gobernante>();
            listaNuevaDeGobernantes = listaDeGobernantes;
            listaNuevaDeGobernantes.Capacity = listaNuevaDeGobernantes.Count + 1;
            listaNuevaDeGobernantes.Add(nuevoGobernante);

            //Agregar dato por dato
            listaNuevaDeGobernantes[listaNuevaDeGobernantes.Count - 1].Inicio = int.Parse(nudInicioGobierno.Value.ToString());
            listaNuevaDeGobernantes[listaNuevaDeGobernantes.Count - 1].Fin = int.Parse(nudFinGobierno.Value.ToString());
            listaNuevaDeGobernantes[listaNuevaDeGobernantes.Count - 1].Nombre = txtNombre.Text;
            listaNuevaDeGobernantes[listaNuevaDeGobernantes.Count - 1].PeriodoHistorico = cboPeriodoHistorico.Text;
            listaNuevaDeGobernantes[listaNuevaDeGobernantes.Count - 1].Significado = txtSignificado.Text;
            listaNuevaDeGobernantes[listaNuevaDeGobernantes.Count - 1].Titulo = cboTitulo.Text;

            //Guardar todo            
            Gobernantes nuevosGobernantes = new Gobernantes();
            nuevosGobernantes.Guardar(ruta, listaNuevaDeGobernantes);

            //Actualizar Cuadricula
            dgvGobernantes.DataSource = Gobernantes.Cargar(ruta);
        }



        private void cboTiposBusquedas_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboTiposBusqueda.SelectedIndex)
            {
                case 0://Año Unitario
                    //Activar cosas
                    cboAño.Visible = true;
                    lblAño.Visible = true;
                    btnGobernantes.Visible = true;

                    //Llenar los Combos
                    Llenar();

                    //Desactivar lo que no se usara
                    cboTiposGobernantes.Visible = false;
                    lblTipoGobernante.Visible = false;
                    cboFin.Visible = false;
                    lblFin.Visible = false;
                    lblNombreBuscar.Visible = false;
                    txtNombreBuscar.Visible = false;
                    lblLeyenda.Visible = false;
                    lblResultados.Visible = false;                    
                    txtResultados.Visible = false;
                    dgvGobernantesAño.Visible = false;

                    //Activar el foco en el principal
                    cboAño.Focus();
                    break;
                case 1://Intervalo de Años
                    //Activar cosas
                    lblAño.Text = "Inicio";
                    lblAño.Visible = true;
                    lblFin.Visible = true;                    

                    cboAño.Visible = true;
                    cboFin.Visible = true;
                    btnGobernantes.Visible = true;

                    //Llenar los Combos
                    Llenar();

                    inicio = 1233;
                    for (int año = inicio; año <= DateTime.Now.Year; año++)
                    {
                        cboFin.Items.Add(año.ToString());
                    }

                    //Desactivar lo que no se usara
                    cboTiposGobernantes.Visible = false;
                    lblTipoGobernante.Visible = false;                    
                    lblNombreBuscar.Visible = false;
                    txtNombreBuscar.Visible = false;
                    lblLeyenda.Visible = false;
                    lblResultados.Visible = false;                    
                    txtResultados.Visible = false;
                    dgvGobernantesAño.Visible = false;                    

                    //Activar el foco en el principal
                    cboAño.Focus();
                    break;
                case 2://Periodo Historico
                    //Activar cosas
                    lblTipoGobernante.Text = "Periodo Historico";
                    lblTipoGobernante.Visible = true;
                    cboTiposGobernantes.Visible = true;
                    btnGobernantes.Visible = true;

                    //Llenar Combo
                    cboTiposGobernantes.Items.Clear();
                    cboTiposGobernantes.Items.Add("Mñxico Prehispanico");
                    cboTiposGobernantes.Items.Add("Conquista de Mñxico");
                    cboTiposGobernantes.Items.Add("Mñxico Colonial");
                    cboTiposGobernantes.Items.Add("Guerra de Independencia");
                    cboTiposGobernantes.Items.Add("Primer Imperio Mexicano");
                    cboTiposGobernantes.Items.Add("Mñxico Independiente (Republica Federal)");
                    cboTiposGobernantes.Items.Add("Separacion de Texas");
                    cboTiposGobernantes.Items.Add("Primera Intervencion Francesa");
                    cboTiposGobernantes.Items.Add("Mñxico Independiente (Republica Central)");
                    cboTiposGobernantes.Items.Add("Anexion de Texas a Estados Unidos de Norteamerica");
                    cboTiposGobernantes.Items.Add("Intervencion Norteamericana");
                    cboTiposGobernantes.Items.Add("Revolucion de Ayutla");
                    cboTiposGobernantes.Items.Add("Segunda Intervencion Francesa");
                    cboTiposGobernantes.Items.Add("Segundo Imperio Mexicano");
                    cboTiposGobernantes.Items.Add("Restauracion de la Republica");
                    cboTiposGobernantes.Items.Add("Porfiriato");
                    cboTiposGobernantes.Items.Add("Revolucion Mexicana");
                    cboTiposGobernantes.Items.Add("México Post-Revolucionario");
                    cboTiposGobernantes.Items.Add("Los Sexenios (México Contemporaneo)");                   
                    
                    //Desactivar lo que no se usara
                    cboAño.Visible = false;
                    lblAño.Visible = false;
                    cboFin.Visible = false;
                    lblFin.Visible = false;
                    lblNombreBuscar.Visible = false;
                    txtNombreBuscar.Visible = false;
                    lblLeyenda.Visible = false;
                    lblResultados.Visible = false;
                    txtResultados.Visible = false;
                    dgvGobernantesAño.Visible = false;                    


                    //Activar el foco en el principal
                    cboTiposGobernantes.Focus();
                    break;
                case 3://Tipo de Gobernante
                    //Activar cosas
                    lblTipoGobernante.Text = "Tipo de Gobernante";
                    lblTipoGobernante.Visible = true;
                    cboTiposGobernantes.Visible = true;
                    btnGobernantes.Visible = true;

                    //Llenar Combo
                    cboTiposGobernantes.Items.Clear();
                    for (int elemento = 0; elemento <= cboTitulo.Items.Count - 1; elemento++)
                    {
                        cboTitulo.SelectedIndex = elemento;
                        cboTiposGobernantes.Items.Add(cboTitulo.Text);
                    }                   

                    //Desactivar lo que no se usara
                    cboAño.Visible = false;
                    lblAño.Visible = false;
                    cboFin.Visible = false;
                    lblFin.Visible = false;
                    lblNombreBuscar.Visible = false;
                    txtNombreBuscar.Visible = false;
                    lblLeyenda.Visible = false;
                    lblResultados.Visible = false;
                    txtResultados.Visible = false;
                    dgvGobernantesAño.Visible = false;                    


                    //Activar el foco en el principal
                    cboTiposGobernantes.Focus();
                    break;
                case 4://Nombre
                    //Activar cosas                    
                    lblNombreBuscar.Visible = true;
                    txtNombreBuscar.Visible = true;
                    btnGobernantes.Visible = true;

                    //Desactivar lo que no se usara
                    cboAño.Visible = false;
                    lblAño.Visible = false;
                    cboTiposGobernantes.Visible = false;
                    lblTipoGobernante.Visible = false;
                    cboFin.Visible = false;
                    lblFin.Visible = false;
                    lblLeyenda.Visible = false;
                    lblResultados.Visible = false;
                    txtResultados.Visible = false;
                    dgvGobernantesAño.Visible = false;                    

                    //Activar el foco en el principal
                    txtNombreBuscar.Focus();
                    break;
                default:
                    break;
            }
        }

        //Metodos
        public void Llenar()
        {
            //Llenar Combo
            for (int año = 1233; año <= DateTime.Now.Year; año++)
            {
                cboAño.Items.Add(año.ToString());
            }
        }

        public void Buscar(int casillero)
        {
            GobernantesEncontrados.Add(gobernanteInterino);

            //Guardarlos en una Lista Generica        
            GobernantesEncontrados[gobernanteEncontrado].Inicio = listaDeGobernantes[casillero].Inicio;
            GobernantesEncontrados[gobernanteEncontrado].Fin = listaDeGobernantes[casillero].Fin;
            GobernantesEncontrados[gobernanteEncontrado].Nombre = listaDeGobernantes[casillero].Nombre;
            GobernantesEncontrados[gobernanteEncontrado].PeriodoHistorico = listaDeGobernantes[casillero].PeriodoHistorico;
            GobernantesEncontrados[gobernanteEncontrado].Significado = listaDeGobernantes[casillero].Significado;
            GobernantesEncontrados[gobernanteEncontrado].Titulo = listaDeGobernantes[casillero].Titulo;

            gobernanteEncontrado++;
            gobernanteInterino = new Gobernante();
        }

        public void Mostrar()
        {
            GobernantesEncontrados.Capacity = gobernanteEncontrado;
            dgvGobernantesAño.DataSource = GobernantesEncontrados;

            //Mostrar numero de Resultados
            lblLeyenda.Visible = true;
            lblResultados.Visible = true;
            txtResultados.Text = gobernanteEncontrado.ToString();
            txtResultados.Visible = true;

            //Mostrar Cuadricula
            dgvGobernantesAño.Visible = true;
        }

        private void cboAño_SelectedIndexChanged(object sender, EventArgs e)
        {
                       
        }

        private void cboFin_TextChanged(object sender, EventArgs e)
        {
            
            }

        private void cboAño_TextChanged(object sender, EventArgs e)
        {
            switch (cboTiposBusqueda.SelectedIndex)
            {
                case 1://Intervalo de Años
                    inicio = int.Parse(cboAño.Text);
                    cboFin.Items.Clear();
                    for (int año = inicio + 1; año <= DateTime.Now.Year; año++)
                    {
                        cboFin.Items.Add(año.ToString());
                    }

                    break;
                default:
                    break;
            }
        }

        private void tbpAgregar_Click(object sender, EventArgs e)
        {

        }

        private void nudInicioGobierno_ValueChanged(object sender, EventArgs e)
        {
            nudFinGobierno.Minimum = nudInicioGobierno.Value;            
        }

        private void cboTitulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboPeriodoHistorico.Items.Clear();
            cboPeriodoHistorico.Enabled = true;
            switch (cboTitulo.SelectedIndex)
            {
                case 0://Emperador Azteca                    
                    cboPeriodoHistorico.Items.Add("Mñxico Prehispanico");
                    cboPeriodoHistorico.Items.Add("Conquista de Mñxico");
                    break;
                case 1://Rey de España
                    cboPeriodoHistorico.Items.Add("Mñxico Colonial");
                    cboPeriodoHistorico.Items.Add("Guerra de Independencia");
                    break;
                case 2://Gobernante de la Nueva España
                    cboPeriodoHistorico.Items.Add("Mñxico Colonial");                    
                    break;
                case 3://Virrey de la Nueva España
                    cboPeriodoHistorico.Items.Add("Mñxico Colonial");
                    cboPeriodoHistorico.Items.Add("Guerra de Independencia");
                    break;
                case 4://Emperador de Mexico
                    cboPeriodoHistorico.Items.Add("Primer Imperio Mexicano");
                    cboPeriodoHistorico.Items.Add("Segundo Imperio Mexicano");
                    break;
                case 5://Presidente de Mexico
                    cboPeriodoHistorico.Items.Add("Restauracion de la Republica");
                    cboPeriodoHistorico.Items.Add("Porfiriato");
                    cboPeriodoHistorico.Items.Add("Revolucion Mexicana");
                    cboPeriodoHistorico.Items.Add("Mexico Post-Revolucionario");
                    cboPeriodoHistorico.Items.Add("Los Sexenios (Mexico Moderno)");
                    cboPeriodoHistorico.Items.Add("Los Sexenios (Mexico Contemporaneo)");
                    break;
                case 6://Presidente de Mexico (Liberal)
                    cboPeriodoHistorico.Items.Add("Mñxico Independiente (Republica Federal)");
                    cboPeriodoHistorico.Items.Add("Separacion de Texas");
                    cboPeriodoHistorico.Items.Add("Primera Intervencion Francesa");
                    break;
                case 7://Presidente de Mexico (Conservador)
                    cboPeriodoHistorico.Items.Add("Mñxico Independiente (Republica Central)");
                    cboPeriodoHistorico.Items.Add("Anexion de Texas a Estados Unidos de Norteamerica");
                    cboPeriodoHistorico.Items.Add("Intervencion Norteamericana");
                    cboPeriodoHistorico.Items.Add("Revolucion de Ayutla");
                    cboPeriodoHistorico.Items.Add("Segunda Intervencion Francesa");
                    break;
                default:
                    break;
            }
            
           
        }

        private void cboPeriodoHistorico_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboTitulo.SelectedIndex==0 && cboPeriodoHistorico.SelectedIndex==0)
                //Emperador Azteca del Periodo Prehispanico
            {
                nudInicioGobierno.Minimum = 1233;
                nudInicioGobierno.Maximum = 1520;
                nudFinGobierno.Maximum = nudInicioGobierno.Maximum;
            }

            if (cboTitulo.SelectedIndex == 0 && cboPeriodoHistorico.SelectedIndex == 1)
            //Emperador Azteca de la Conquista de Mexico
            {
                nudInicioGobierno.Minimum = 1520;
                nudInicioGobierno.Maximum = 1521;
                nudFinGobierno.Maximum = nudInicioGobierno.Maximum;
            }
        }

        private void nudFinGobierno_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}