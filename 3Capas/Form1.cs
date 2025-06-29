using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatoss;
using LogicaNegocio;
using Entidadd;

namespace _3Capas
{
    public partial class Form1: Form
    {
        private readonly Class1 _service;
        public Form1()
        {
            InitializeComponent();
            var repo = new InMemoryContactRepository();
            _service = new ContactService(repo);
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            var datos = _service.ListarContactos()
                                .Select(c => new {

                                    c.Id,

                                    c.Name,

                                    c.Email,

                                    c.Phone

                                })
                                .ToList();
            dataGridView1.DataSource = datos;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var nuevo = new Contact
            {
                Name = txtName.Text,
                Email = txtEmail.Text,
                Phone = txtPhone.Text
            };
            try
            {
                _service.AddContact(nuevo);
                CargarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnEdi_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            int id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
            _service.DeleteContact(id);
            CargarGrilla();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            var c = new Contact
            {
                Id = (int)dataGridView1.CurrentRow.Cells["Id"].Value,
                Name = txtName.Text,
                Email = txtEmail.Text,
                Phone = txtPhone.Text
            };
            _service.UpdateContact(c);
            CargarGrilla();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}

