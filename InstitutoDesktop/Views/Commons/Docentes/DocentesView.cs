﻿using InstitutoDesktop.ExtensionMethods;
using InstitutoDesktop.Services;
using InstitutoDesktop.Util;
using InstitutoDesktop.Views.Commons.Aulas;
using InstitutoServices.Interfaces;
using InstitutoServices.Models.Commons;
using InstitutoServices.Services.Commons;
using Microsoft.Extensions.DependencyInjection;

namespace InstitutoDesktop.Views.Commons
{
    public partial class DocentesView : Form
    {
        BindingSource BindingDocente = new BindingSource();
        List<Docente> listDocente = new List<Docente>();
        private readonly MemoryCacheServiceWinForms _memoryCache;
        private readonly IServiceProvider _serviceProvider;

        public DocentesView(MemoryCacheServiceWinForms memoryCacheService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _memoryCache = memoryCacheService;
            _serviceProvider = serviceProvider;
            dataGridDocentes.DataSource = BindingDocente;
            CargarGrilla();

        }

        private async Task CargarGrilla()
        {
            listDocente = await _memoryCache.GetAllCacheAsync<Docente>("Docentes");
            dataGridDocentes.OcultarColumnas(new string[] { "Eliminado" });
            BindingDocente.DataSource = listDocente;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarEditarDocenteView agregarEditarDocenteView = ActivatorUtilities.CreateInstance<AgregarEditarDocenteView>(_serviceProvider);
            agregarEditarDocenteView.ShowDialog();
            CargarGrilla();
        }

        private async void iconButton1_Click(object sender, EventArgs e)
        {
            var docente = (Docente)BindingDocente.Current;
            AgregarEditarDocenteView agregarEditarDocenteView = ActivatorUtilities.CreateInstance<AgregarEditarDocenteView>(_serviceProvider, docente);
            agregarEditarDocenteView.ShowDialog();
            await CargarGrilla();
        }

        private async void iconButton2_Click(object sender, EventArgs e)
        {
            var docente = (Docente)BindingDocente.Current;
            var respuesta = MessageBox.Show($"¿Está seguro que quiere borrar el docente {docente.Nombre}", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                await _memoryCache.DeleteCacheAsync<Docente>(docente.Id, "Docentes");
                //await docenteService.DeleteAsync(docente.Id);
                await CargarGrilla();
                dataGridDocentes.SeleccionarFilaNuevaOEditada(docente.Id);
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            BindingDocente.DataSource = listDocente.Where(x => x.Nombre.ToUpper().Contains(txtFiltro.Text.ToUpper())).ToList();

        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            BtnBuscar.PerformClick();
        }
    }
}
