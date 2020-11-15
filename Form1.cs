using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaABB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdbHombre.Checked = true;
            rdbPreOrden.Checked = true;
            campo1 = "Nombre";
            campo2 = "Numero de identificacion";
            campo3 = "Sueldo al año";
            campo4 = "Inicial del empleado";
            campo5 = "Fecha de ingreso";
            campo6 = "Puesto que elabora";
            campo7 = "¿Tiene seguro?";
            campo8 = "Sexo del empleado/a";
            rdbC1 = "Masculino";
            rdbC2 = "Femenino";
            {
                lblC1.Text = campo1;
                lblC2.Text = campo2;
                lblC3.Text = campo3;
                lblC4.Text = campo4;
                lblC5.Text = campo5;
                lblC6.Text = campo6;
                lblC7.Text = campo7;
                lblC8.Text = campo8;
                rdbHombre.Text = rdbC1;
                rdbMujer.Text = rdbC2;
                TCampo1.HeaderText = campo1;//0
                TCampo2.HeaderText = campo2;
                TCampo3.HeaderText = campo3;
                TCampo4.HeaderText = campo4;
                TCampo5.HeaderText = campo5;
                TCampo6.HeaderText = campo6;
                TCampo7.HeaderText = campo7;
                TCampo8.HeaderText = campo8;//7
            }
        }
        
        EmpresaCurtidoraPieles empresa;
        ClaseABB<EmpresaCurtidoraPieles> arbol = new ClaseABB<EmpresaCurtidoraPieles>();
        string PathDireccion = @"C:\Users\jacco\source\repos\PruebaABB\Draw\Perfil.png";
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                var x = ObtenerObjeto("Agregar");
                arbol.AgregarNodo(x);
                AgregarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private new void Click(object sender, EventArgs e)
        {
            string strNombreArchivo = CargarImagen();
            if (strNombreArchivo != null)
                MostrarImagenPerfil(strNombreArchivo);
        }
        private string CargarImagen()
        {
            string strNombreArchivo = null;
            // Declaración de variable para seleccionar el archivo

            OpenFileDialog miArchivoFoto = new OpenFileDialog();
            miArchivoFoto.Title = "Seleccione la imagen que desea cargar";
            miArchivoFoto.Filter = "Archivos JPEG (*.jpg) | *.jpg";
            miArchivoFoto.InitialDirectory = "Mis documentos";
            if (miArchivoFoto.ShowDialog() == DialogResult.OK)
            {
                strNombreArchivo = miArchivoFoto.FileName;
                PathDireccion = strNombreArchivo;
                return (strNombreArchivo);
            }
            else return (null);
        }
        private void MostrarImagenPerfil(string strNombreArchivo)
        {
            Bitmap miImagen = new Bitmap(strNombreArchivo);
            pcbImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbImagen.Image = (Image)miImagen;
            pcbImagen.Refresh();
        }
        string campo1, campo2, campo3, campo4, campo5, campo6, campo7, campo8, rdbC1, rdbC2;

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            if (!arbol.Vacio) // Si no está vacío ..
                DibujarFigura(); // Invoca el método para dibujar la figura
            else
                MessageBox.Show("Árbol Binario de Búsqueda vacío", "E R R O R",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        

        private void rdbPostOrden_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rdbInOrden_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rdbPreOrden_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnFacil_Click_1(object sender, EventArgs e)
        {
            txtCampo1.Text = "Mauricio";
            txtCampo2.Text = "1";
            txtCampo3.Text = "1000";
            txtCampo4.Text = "M";
            cmbCampo6.Text = "Maquiladora";
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            try
            {
                var x = ObtenerObjeto("Agregar");
                arbol.AgregarNodo(x);
                AgregarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void btnDibujar_Click_1(object sender, EventArgs e)
        {
            if (!arbol.Vacio) // Si no está vacío ..
                DibujarFigura(); // Invoca el método para dibujar la figura
            else
                MessageBox.Show("Árbol Binario de Búsqueda vacío", "E R R O R",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pcbImagen_Click(object sender, EventArgs e)
        {
            string strNombreArchivo = CargarImagen();
            if (strNombreArchivo != null)
                MostrarImagenPerfil(strNombreArchivo);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                var x = ObtenerObjeto("Buscar");
                MessageBox.Show("El objeto que busca es \n"+x.ToStringAll());
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
                throw;
            }
        }

        private void clickdata(object sender, EventArgs e)
        {
            if (chbBuscar.Checked)
            { 
                try
                {
                    var x = ObtenerObjeto("Tabla");
                    MessageBox.Show("El objeto que busca es\n " + x.ToStringAll());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                var random = new Random();

                for (int i = 0; i < 10; i++)
                {
                    var value = random.Next(1, 200);
                    var opc = random.Next(1, 4);
                    EmpresaCurtidoraPieles Aux = new EmpresaCurtidoraPieles();
                    Aux.Nombre = RandomString(4);
                    Aux.ID = value;
                    Aux.Sueldo = value;
                    Aux.Fecha = DateTime.Now;
                    Aux.Inicial = char.Parse(RandomString(1));
                    Aux.Puesto = "Empreado";
                    Aux.Seguro = false;
                    Aux.Genero = "Masculino";
                    Aux.Direccion = PathDireccion;
                    arbol.AgregarNodo(Aux);
                    AgregarTabla();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex}");
            }
        }
        string RandomString(int lengt)
        {
            var random = new Random();

            string cadena = "";

            for (int i = 0; i < lengt; i++)
            {
                var value = random.Next(1, 26);
                cadena += $"{NextLetra(value)}";
            }
            return cadena;

        }
        string NextLetra(int letra)
        {
            switch (letra)
            {
                case 1:
                    return "a";
                case 2:
                    return "b";
                case 3:
                    return "c";
                case 4:
                    return "d";
                case 5:
                    return "e";
                case 6:
                    return "f";
                case 7:
                    return "g";
                case 8:
                    return "h";
                case 9:
                    return "i";
                case 10:
                    return "j";
                case 11:
                    return "k";
                case 12:
                    return "l";
                case 13:
                    return "m";
                case 14:
                    return "n";
                case 15:
                    return "o";
                case 16:
                    return "p";
                case 17:
                    return "q";
                case 18:
                    return "r";
                case 19:
                    return "s";
                case 20:
                    return "t";
                case 21:
                    return "u";
                case 22:
                    return "v";
                case 23:
                    return "w";
                case 24:
                    return "x";
                case 25:
                    return "y";
                case 26:
                    return "z";
                default:
                    throw new Exception("Fuera del rango");
            }
        }

        private void btnVaciar_Click(object sender, EventArgs e)
        {
            DialogResult comprobar = MessageBox.Show("¿Desea borrar todos los datos?", "Borrar Datos", MessageBoxButtons.YesNoCancel);
            switch (comprobar)
            {
                case DialogResult.Yes:
                    try
                    { 
                        arbol.Vaciar();
                        arbol.Vaciar1();
                        AgregarTabla();
                    }catch(Exception ex)
                    {
                        MessageBox.Show("Error: " + ex);
                    }
                    break;
                case DialogResult.No:
                    break;
                default:
                    break;
            }
        }

        private void btnRecorrer_Click(object sender, EventArgs e)
        {
            try
            {
                string x = AgregarTabla();
                MessageBox.Show(AgregarTabla(), "Lista de identificaciones");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult comprobar = MessageBox.Show("¿Desea borrar el dato seleccionado?", "Borrar Datos", MessageBoxButtons.YesNoCancel);
            switch (comprobar)
            {
                case DialogResult.Yes:
                    try
                    {
                        var x = ObtenerObjeto("Buscar");
                        var y = arbol.EliminarNodo(x);
                        AgregarTabla();
                        MessageBox.Show("Se borro: \n" + y.ToStringAll());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex);
                    }
                    break;
                case DialogResult.No:
                    break;
                default:
                    break;
            }
        }

        private void btnFacil_Click(object sender, EventArgs e)
        {
            txtCampo1.Text = "Mauricio";
            txtCampo2.Text = "1";
            txtCampo3.Text = "1000";
            txtCampo4.Text = "M";
            cmbCampo6.Text = "Maquiladora";

        }

        
        private EmpresaCurtidoraPieles ObtenerObjeto(string Tipo)
        {
            if (Tipo == "Agregar")
            {
                try
                {
                    empresa = new EmpresaCurtidoraPieles();
                    empresa.Nombre = txtCampo1.Text;
                    empresa.ID = int.Parse(txtCampo2.Text);
                    empresa.Sueldo = int.Parse(txtCampo3.Text);
                    empresa.Inicial = char.Parse(txtCampo4.Text);
                    empresa.Fecha = (DateTime)dtpFecha.Value;
                    empresa.Puesto = cmbCampo6.Text;
                    if (cbxSeguro.Checked)
                    {
                        empresa.Seguro = true;
                    }
                    else
                    {
                        empresa.Seguro = false;
                    }
                    if (rdbHombre.Checked)
                    {
                        empresa.Genero = "Masculino";
                    }
                    else
                    {
                        empresa.Genero = "Femenino";
                    }
                    empresa.Direccion = PathDireccion;
                    return empresa;

                }
                catch (Exception ex)
                {
                    throw new Exception("" + ex);
                }
            }
            DataGridViewRow row = Tabla.CurrentRow;
            if (Tipo == "Tabla" && row != null)//Para cuando hago click en la tabla
            {
                try
                {
                    empresa = new EmpresaCurtidoraPieles();
                    empresa.Nombre = Tabla.CurrentRow.Cells[0].Value.ToString();
                    empresa.ID = int.Parse(Tabla.CurrentRow.Cells[1].Value.ToString());
                    empresa.Sueldo = int.Parse(Tabla.CurrentRow.Cells[2].Value.ToString());
                    empresa.Inicial = char.Parse(Tabla.CurrentRow.Cells[3].Value.ToString());
                    empresa.Fecha = (DateTime)Tabla.CurrentRow.Cells[4].Value;
                    empresa.Puesto = Tabla.CurrentRow.Cells[5].Value.ToString();
                    string x = Tabla.CurrentRow.Cells[6].Value.ToString();
                    if (x == "Si")
                    {
                        empresa.Seguro = true;
                    }
                    else
                    {
                        empresa.Seguro = false;
                    }
                    empresa.Genero = Tabla.CurrentRow.Cells[7].Value.ToString();
                    empresa.Direccion = Tabla.CurrentRow.Cells[8].Value.ToString();
                    return empresa;
                }catch(NullReferenceException exx)
                {
                    throw new Exception(""+exx);
                }
                catch (Exception ex)
                {
                    throw new Exception("" + ex);
                }
            }
            if (Tipo == "Buscar" && row != null)//Para el boton buscar
            {
                try
                {
                    EmpresaCurtidoraPieles Aux = new EmpresaCurtidoraPieles();
                    txtCampo1.Text = Tabla.CurrentRow.Cells[0].Value.ToString();
                    txtCampo2.Text = Tabla.CurrentRow.Cells[1].Value.ToString();
                    txtCampo3.Text = Tabla.CurrentRow.Cells[2].Value.ToString();
                    txtCampo4.Text = Tabla.CurrentRow.Cells[3].Value.ToString();
                    dtpFecha.Value = (DateTime)Tabla.CurrentRow.Cells[4].Value;
                    cmbCampo6.Text = Tabla.CurrentRow.Cells[5].Value.ToString();
                    if (Tabla.CurrentRow.Cells[6].Value.ToString() == "Si")
                    {
                        Aux.Seguro = true;
                        cbxSeguro.Checked = true;
                    }
                    else
                    {
                        Aux.Seguro = false;
                        cbxSeguro.Checked = false;
                    }
                    Aux.Genero = $"{Tabla.CurrentRow.Cells[7].Value}";
                    if (Aux.Genero == "Masculino")
                    {
                        rdbHombre.Checked = true;
                    }
                    else
                    {
                        rdbMujer.Checked = true;
                    }
                    MostrarImagenPerfil(Tabla.CurrentRow.Cells[8].Value.ToString());
                    return (ObtenerObjeto("Agregar"));
                }
                catch (Exception)
                {
                    throw new Exception("Error");
                }
            }

            if (row == null)
            {
                throw new Exception("Seleccione un renglon de la tabla");
            }
            throw new Exception("El metodo no encontro la palabra " + Tipo);
        }
        private string AgregarTabla()
        {
            string resultado = "ID: ";
            {
                if (rdbPreOrden.Checked)
                {

                    Tabla.Rows.Clear();
                    foreach (EmpresaCurtidoraPieles Empresa in arbol.RecorrerPreOrden())
                    {
                        IntroducirTabla(Empresa.Nombre, Empresa.ID, Empresa.Genero, Empresa.Sueldo, Empresa.Inicial, Empresa.Fecha, Empresa.Puesto, Empresa.Seguro, Empresa.Direccion);
                        resultado += $"{Empresa.ID}, ";
                    }
                    return resultado;
                }
                if (rdbInOrden.Checked)
                {
                    Tabla.Rows.Clear();
                    foreach (EmpresaCurtidoraPieles Empresa in arbol.RecorrerInOrden())
                    {
                        IntroducirTabla(Empresa.Nombre, Empresa.ID, Empresa.Genero, Empresa.Sueldo, Empresa.Inicial, Empresa.Fecha, Empresa.Puesto, Empresa.Seguro, Empresa.Direccion);
                        resultado += $"{Empresa.ID}, ";
                    }
                    return resultado;
                }
                if (rdbPostOrden.Checked)
                {
                    Tabla.Rows.Clear();
                    foreach (EmpresaCurtidoraPieles Empresa in arbol.RecorrerPostOrden())
                    {
                        IntroducirTabla(Empresa.Nombre, Empresa.ID, Empresa.Genero, Empresa.Sueldo, Empresa.Inicial, Empresa.Fecha, Empresa.Puesto, Empresa.Seguro, Empresa.Direccion);
                        resultado += $"{Empresa.ID}, ";
                    }
                    return resultado;
                }
                throw new Exception("Ocurrio un error inesperado");
            }
        }
        private void AgregarTabla(string x)
        {

        }
        public void IntroducirTabla(string Name, int id, string genero, double doble, char clar, DateTime fecha, string puesto, bool seguro, string direccion)
        {
            string s;
            if (seguro)
            {
                s = "Si";
            }
            else
            {
                s = "No";
            }
            Tabla.Rows.Add(Name, id, doble, clar, fecha, puesto, s, genero, direccion);
        }
    
    private void DibujarFigura()
        {
            try
            {
                string Resultado = CrearArchivoDot();
                InvocaDibujar();
                MessageBox.Show("Código para generar el archivo FIGURA.jpg con la imagen:\n\n" + Resultado + "\n\nEjecutar mediante: DOT - TJPG - O \\Figura", "CREACIÓN DEL ARCHIVO EN LENGUAJE DOT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PonerDibujo();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inseperado: Pulsa de nuevo el boton \n\n\n{ex}","Error inesperado: Pulse de nuevo");
            }
        }

        private void PonerDibujo()
        {
            //pcbGrafico.Image = "";
            System.IO.FileStream AliasFigura; // Declaración del alias del archivo Figura.jpg
            
            try        // Intenta abrir el archivo
            {
                AliasFigura = new System.IO.FileStream("C:\\Users\\jacco\\source\\repos\\PruebaABB\\bin\\Debug\\Figura.jpg",
               System.IO.FileMode.Open, System.IO.FileAccess.Read);
            }
            catch (Exception x)
            {
                throw new Exception("" + x);
            }
            try // Intenta cargar la imagen en el pictureBox
            {
                pcbGrafico.Image = System.Drawing.Bitmap.FromStream(AliasFigura);
            }//error
            catch (Exception) // En caso de error ...
            {
                MessageBox.Show("No se pudo cargar la imagen del archivo c:\\Datos\\FIGURA.jpg",
               "E R R O R", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AliasFigura.Close(); // Cierra el archivo ArbolBinarioBusqueda.jpg
                return;
            }
            AliasFigura.Close();
            pcbGrafico.Refresh();
        }

        private void InvocaDibujar()
        {
            // El archivo por lotes DIBUJAR.bat contiene el siguiente código:
            // @echo off
            // del \Figura.jpg
            // \"Archivos de programa\Graphviz 2.28"\bin\DOT -Tjpg -O \Figura
            //"Archivos de programa\Graphviz 2.44.1"\bin\DOT -Tjpg -O \Figura
            // Ejecuta DIBUJAR.bat ubicado en la carpeta raíz de la unidad de disco
            
            try
            {
                System.Diagnostics.Process.Start("C:\\Users\\jacco\\source\\repos\\PruebaABB\\bin\\Debug\\DIBUJAR.bat");
                
            }
            catch (Exception)
            {

                MessageBox.Show("Error");
                throw new Exception("Error al cargar el proceso");
            }
            

        }
        
        private string CrearArchivoDot()
        {
            string Resultado = "";
            arbol.CrearArchivoDot(ref  Resultado);
            
            try
            {
                System.IO.StreamWriter AliasArchivo = new System.IO.StreamWriter(@"C:\\Users\\jacco\\source\\repos\\PruebaABB\\bin\\Debug\\Figura");
                AliasArchivo.WriteLine(Resultado);
                AliasArchivo.Close();
                return (Resultado);
            }
            catch (Exception x)
            {
                MessageBox.Show("Error");
                throw new Exception("" + x);
            }
        }
    }
}
