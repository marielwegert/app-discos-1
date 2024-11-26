using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using dominio;
using negocio;
using System.Deployment.Internal;

namespace winform_app
{
    public partial class frmDisco : Form
    {
        //ATRIBUTO
        private List<Disco> listaDisco;
        private Disco seleccionado;

        //CONSTRUCTOR
        public frmDisco()
        {
            InitializeComponent();
        }

        //EVENTO DE CARGA DE FORMULARIO
        private void frmDiscos_Load(object sender, EventArgs e)
        {
            cargar();
            cboCampo.Items.Add("Título");
            cboCampo.Items.Add("Fecha de lanzamiento");
            cboCampo.Items.Add("Cantidad de canciones");

            //if(cboCampo.Items.Contains("Título"))
            //{
            //    txtFiltroAvanzado.Visible = true;
            //    dtpFechaLanzamiento.Visible = false;
            //}
            //if (cboCampo.Items.Contains("Fecha de lanzamiento"))
            //{
            //    dtpFechaLanzamiento.Visible = true;
            //    txtFiltroAvanzado.Visible = false;
            //}
            //else if(cboCampo.Items.Contains("Cantidad de canciones"))
            //{
            //    txtFiltroAvanzado.Visible = true;
            //    dtpFechaLanzamiento.Visible = false;
            //}
        }

        //EVENTO para cuando cambio la selección de la grilla,
        //cambia lo que cargo en la imagen
        private void dgvDiscos_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvDiscos.CurrentRow != null)
            {
                seleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.UrlImagenTapa);
            }
        }

        //METODO para invocar la lectura a DB y cargar la lista
        private void cargar()
        {
            //Invoco la lectura de la DB
            DiscoNegocio negocio = new DiscoNegocio();
            try
            {
                listaDisco = negocio.listar();
                dgvDiscos.DataSource = listaDisco;
                ocultarColumnas();
                cargarImagen(listaDisco[0].UrlImagenTapa);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //METODO para ocultar columnas, las q no quiero q aparezcan en la tabla ppal.
        private void ocultarColumnas()
        {
            dgvDiscos.Columns["Id"].Visible = false;
            dgvDiscos.Columns["UrlImagenTapa"].Visible = false;
        }

        //METODO //Si falla el try xq no hay imagen
        //entonces va al catch y muestra la imagen por defecto.
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxDisco.Load(imagen);
            }
            catch (Exception)
            {
                pbxDisco.Load("https://t3.ftcdn.net/jpg/02/48/42/64/360_F_248426448_NVKLywWqArG2ADUxDq6QprtIzsF82dMF.jpg");
            }
        }

        //EVENTO del botón Agregar
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaDisco alta = new frmAltaDisco();
            alta.ShowDialog();
            cargar();
        }

        //EVENTO del botón Modificar
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDiscos.CurrentRow == null)
                {
                    MessageBox.Show("Seleccionar un Disco para modificar");
                }
                else
                {
                    seleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem;

                    frmAltaDisco modificar = new frmAltaDisco(seleccionado);
                    modificar.ShowDialog();
                    cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //EVENTO del botón Eliminar (elimina de la DB)
        private void btnEliminarFisico_Click(object sender, EventArgs e)
        {
            DiscoNegocio negocio = new DiscoNegocio();
            try
            {
                if (dgvDiscos.CurrentRow == null)
                {
                    MessageBox.Show("Seleccionar un Disco para eliminar");
                }
                else
                {
                    DialogResult respuesta = MessageBox.Show("¿Estás seguro que queres eliminar el Disco?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if(respuesta == DialogResult.Yes)
                    {
                        seleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem;
                        negocio.eliminar(seleccionado.Id);
                        cargar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //METODO para validar filtro de busqueda avanzado
        private bool validarFiltro()
        {
            if (cboCampo.SelectedIndex < 0)
            {
                //cboCampo.BackColor = Color.Red;
                lblErrorCampo.Text = "Seleccione el campo a filtrar";
                //MessageBox.Show("Seleccione el campo a filtrar");
                return true;
            }
            else
            {
                lblErrorCampo.Text = "";
            }

            if (cboCriterio.SelectedIndex < 0)
            {
                //cboCriterio.BackColor = Color.Red;
                lblErrorCriterio.Text = "Seleccione el criterio a filtrar";
                //MessageBox.Show("Seleccione el criterio a filtrar");
                return true;
            }
            else
            {
                lblErrorCriterio.Text = "";
            }
            
            if (cboCampo.SelectedItem.ToString() == "Cantidad de canciones")
            {
                if (!(soloNumeros(txtFiltroAvanzado.Text)) || string.IsNullOrWhiteSpace(txtFiltroAvanzado.Text))
                {
                    MessageBox.Show("El campo acepta solo números para filtrar");
                    return true;
                }
            }
            if (cboCampo.SelectedItem.ToString() == "Fecha de lanzamiento")
            {
                if (string.IsNullOrWhiteSpace(txtFiltroAvanzado.Text))
                {
                    MessageBox.Show("El campo acepta solo fechas completas o un año para filtrar");
                    return true;
                }
                if (!(soloNumeros(txtFiltroAvanzado.Text)))
                {
                    MessageBox.Show("El campo acepta solo fechas completas o un año para filtrar");
                    return true;
                }
            }
            return false;
        }

        ////METODO para que una caja de texto reciba solo números
        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }

        //EVENTO para buscar CON FILTRO RAPIDO
        private void txtFiltroRapido_TextChanged(object sender, EventArgs e)
        {
            List<Disco> listaFiltrada;
            string filtro = txtFiltroRapido.Text;

            if (filtro.Length >= 2)
            {
                listaFiltrada = listaDisco.FindAll(x => x.Titulo.ToLower().Contains(filtro.ToLower()));
                //|| x.CantidadCanciones == filtro -> no me deja poner asi al final de lo de arriba
                //para buscar un disco por la cantidad de canciones
            }
            else
            {
                listaFiltrada = listaDisco;
            }

            dgvDiscos.DataSource = null;
            dgvDiscos.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        //EVENTO para buscar CON FILTRO AVANZADO
        private void btnFiltro_Click(object sender, EventArgs e)
        {
            DiscoNegocio negocio = new DiscoNegocio();
            try
            {
                if (validarFiltro())
                    return;

                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtFiltroAvanzado.Text;
                dgvDiscos.DataSource = negocio.filtrar(campo, criterio, filtro);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //EVENTO del desplegable del "Campo"
        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();

            if (opcion == "Título")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene");
            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Menor a");
                cboCriterio.Items.Add("Igual a");
            }
        }
    }
}
