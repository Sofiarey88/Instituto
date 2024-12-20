﻿namespace InstitutoDesktop
{
    partial class MenuPrincipalView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            menuPrincipal = new FontAwesome.Sharp.IconMenuItem();
            subMenuCiclosLectivos = new FontAwesome.Sharp.IconMenuItem();
            subMenuAulas = new FontAwesome.Sharp.IconMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            subMenuAlumnos = new FontAwesome.Sharp.IconMenuItem();
            subMenuDocentes = new FontAwesome.Sharp.IconMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            subMenuCarreras = new FontAwesome.Sharp.IconMenuItem();
            subMenuAñosCarreras = new FontAwesome.Sharp.IconMenuItem();
            subMenuMaterias = new FontAwesome.Sharp.IconMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            subMenuUsuarios = new FontAwesome.Sharp.IconMenuItem();
            menuHorarios = new FontAwesome.Sharp.IconMenuItem();
            subMenuHoras = new FontAwesome.Sharp.IconMenuItem();
            subMenuPeriodosHorarios = new FontAwesome.Sharp.IconMenuItem();
            subMenuHorarios = new FontAwesome.Sharp.IconMenuItem();
            menuMesasExamenes = new FontAwesome.Sharp.IconMenuItem();
            subMenuTurnosExámenes = new FontAwesome.Sharp.IconMenuItem();
            subMenuConformacionMesasExamenes = new FontAwesome.Sharp.IconMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            subMenuPeriodosInscripciones = new FontAwesome.Sharp.IconMenuItem();
            subMenuInscripciones = new FontAwesome.Sharp.IconMenuItem();
            menuInformes = new FontAwesome.Sharp.IconMenuItem();
            subMenuInformeDocentes = new FontAwesome.Sharp.IconMenuItem();
            menuSalir = new FontAwesome.Sharp.IconMenuItem();
            subMenuSalirDelSistema = new FontAwesome.Sharp.IconMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuPrincipal, menuHorarios, menuMesasExamenes, menuInformes, menuSalir });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 2, 0, 2);
            menuStrip1.Size = new Size(1364, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuPrincipal
            // 
            menuPrincipal.DropDownItems.AddRange(new ToolStripItem[] { subMenuCiclosLectivos, subMenuAulas, toolStripSeparator1, subMenuAlumnos, subMenuDocentes, toolStripSeparator2, subMenuCarreras, subMenuAñosCarreras, subMenuMaterias, toolStripSeparator4, subMenuUsuarios });
            menuPrincipal.IconChar = FontAwesome.Sharp.IconChar.House;
            menuPrincipal.IconColor = Color.Black;
            menuPrincipal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuPrincipal.IconSize = 40;
            menuPrincipal.Name = "menuPrincipal";
            menuPrincipal.Size = new Size(118, 29);
            menuPrincipal.Text = "Principal";
            // 
            // subMenuCiclosLectivos
            // 
            subMenuCiclosLectivos.IconChar = FontAwesome.Sharp.IconChar.Hourglass2;
            subMenuCiclosLectivos.IconColor = Color.Black;
            subMenuCiclosLectivos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            subMenuCiclosLectivos.Name = "subMenuCiclosLectivos";
            subMenuCiclosLectivos.Size = new Size(272, 34);
            subMenuCiclosLectivos.Text = "Ciclos Lectivos";
            subMenuCiclosLectivos.Click += subMenuCiclosLectivos_Click;
            // 
            // subMenuAulas
            // 
            subMenuAulas.IconChar = FontAwesome.Sharp.IconChar.ShopLock;
            subMenuAulas.IconColor = Color.Black;
            subMenuAulas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            subMenuAulas.Name = "subMenuAulas";
            subMenuAulas.Size = new Size(272, 34);
            subMenuAulas.Text = "Aulas";
            subMenuAulas.Click += subMenuAulas_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(269, 6);
            // 
            // subMenuAlumnos
            // 
            subMenuAlumnos.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            subMenuAlumnos.IconColor = Color.Black;
            subMenuAlumnos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            subMenuAlumnos.Name = "subMenuAlumnos";
            subMenuAlumnos.Size = new Size(272, 34);
            subMenuAlumnos.Text = "Alumnos";
            subMenuAlumnos.Click += subMenuAlumnos_Click;
            // 
            // subMenuDocentes
            // 
            subMenuDocentes.IconChar = FontAwesome.Sharp.IconChar.User;
            subMenuDocentes.IconColor = Color.Pink;
            subMenuDocentes.IconFont = FontAwesome.Sharp.IconFont.Solid;
            subMenuDocentes.Name = "subMenuDocentes";
            subMenuDocentes.Size = new Size(272, 34);
            subMenuDocentes.Text = "Docentes";
            subMenuDocentes.Click += subMenuDocentes_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(269, 6);
            // 
            // subMenuCarreras
            // 
            subMenuCarreras.IconChar = FontAwesome.Sharp.IconChar.MortarBoard;
            subMenuCarreras.IconColor = Color.Black;
            subMenuCarreras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            subMenuCarreras.Name = "subMenuCarreras";
            subMenuCarreras.Size = new Size(272, 34);
            subMenuCarreras.Text = "Carreras";
            subMenuCarreras.Click += subMenuCarreras_Click;
            // 
            // subMenuAñosCarreras
            // 
            subMenuAñosCarreras.IconChar = FontAwesome.Sharp.IconChar.Table;
            subMenuAñosCarreras.IconColor = Color.Black;
            subMenuAñosCarreras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            subMenuAñosCarreras.Name = "subMenuAñosCarreras";
            subMenuAñosCarreras.Size = new Size(272, 34);
            subMenuAñosCarreras.Text = "Años de las carreras";
            subMenuAñosCarreras.Click += subMenuAñosCarreras_Click;
            // 
            // subMenuMaterias
            // 
            subMenuMaterias.IconChar = FontAwesome.Sharp.IconChar.Readme;
            subMenuMaterias.IconColor = Color.Black;
            subMenuMaterias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            subMenuMaterias.Name = "subMenuMaterias";
            subMenuMaterias.Size = new Size(272, 34);
            subMenuMaterias.Text = "Materias";
            subMenuMaterias.Click += subMenuMaterias_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(269, 6);
            // 
            // subMenuUsuarios
            // 
            subMenuUsuarios.IconChar = FontAwesome.Sharp.IconChar.PeopleArrowsLeftRight;
            subMenuUsuarios.IconColor = Color.Black;
            subMenuUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            subMenuUsuarios.Name = "subMenuUsuarios";
            subMenuUsuarios.Size = new Size(272, 34);
            subMenuUsuarios.Text = "Usuarios";
            // 
            // menuHorarios
            // 
            menuHorarios.DropDownItems.AddRange(new ToolStripItem[] { subMenuHoras, subMenuPeriodosHorarios, subMenuHorarios });
            menuHorarios.IconChar = FontAwesome.Sharp.IconChar.ClockRotateLeft;
            menuHorarios.IconColor = Color.Black;
            menuHorarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuHorarios.Name = "menuHorarios";
            menuHorarios.Size = new Size(120, 29);
            menuHorarios.Text = "Horarios";
            // 
            // subMenuHoras
            // 
            subMenuHoras.IconChar = FontAwesome.Sharp.IconChar.ClockFour;
            subMenuHoras.IconColor = Color.Black;
            subMenuHoras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            subMenuHoras.Name = "subMenuHoras";
            subMenuHoras.Size = new Size(278, 34);
            subMenuHoras.Text = "Horas";
            subMenuHoras.Click += subMenuHoras_Click;
            // 
            // subMenuPeriodosHorarios
            // 
            subMenuPeriodosHorarios.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            subMenuPeriodosHorarios.IconColor = Color.Black;
            subMenuPeriodosHorarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            subMenuPeriodosHorarios.Name = "subMenuPeriodosHorarios";
            subMenuPeriodosHorarios.Size = new Size(278, 34);
            subMenuPeriodosHorarios.Text = "Periodos de horarios";
            subMenuPeriodosHorarios.Click += subMenuPeriodosHorarios_Click;
            // 
            // subMenuHorarios
            // 
            subMenuHorarios.IconChar = FontAwesome.Sharp.IconChar.PersonChalkboard;
            subMenuHorarios.IconColor = Color.Black;
            subMenuHorarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            subMenuHorarios.Name = "subMenuHorarios";
            subMenuHorarios.Size = new Size(278, 34);
            subMenuHorarios.Text = "Horarios";
            subMenuHorarios.Click += subMenuHorarios_Click;
            // 
            // menuMesasExamenes
            // 
            menuMesasExamenes.DropDownItems.AddRange(new ToolStripItem[] { subMenuTurnosExámenes, subMenuConformacionMesasExamenes, toolStripSeparator3, subMenuPeriodosInscripciones, subMenuInscripciones });
            menuMesasExamenes.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            menuMesasExamenes.IconColor = Color.Black;
            menuMesasExamenes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuMesasExamenes.Name = "menuMesasExamenes";
            menuMesasExamenes.Size = new Size(210, 29);
            menuMesasExamenes.Text = "Mesas de exámenes";
            // 
            // subMenuTurnosExámenes
            // 
            subMenuTurnosExámenes.IconChar = FontAwesome.Sharp.IconChar.CalendarDays;
            subMenuTurnosExámenes.IconColor = Color.Black;
            subMenuTurnosExámenes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            subMenuTurnosExámenes.Name = "subMenuTurnosExámenes";
            subMenuTurnosExámenes.Size = new Size(415, 34);
            subMenuTurnosExámenes.Text = "Turnos de exámenes";
            subMenuTurnosExámenes.Click += subMenuTurnosExámenes_Click;
            // 
            // subMenuConformacionMesasExamenes
            // 
            subMenuConformacionMesasExamenes.IconChar = FontAwesome.Sharp.IconChar.CaretSquareRight;
            subMenuConformacionMesasExamenes.IconColor = Color.Black;
            subMenuConformacionMesasExamenes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            subMenuConformacionMesasExamenes.Name = "subMenuConformacionMesasExamenes";
            subMenuConformacionMesasExamenes.Size = new Size(415, 34);
            subMenuConformacionMesasExamenes.Text = "Conformación de Mesas de exámenes";
            subMenuConformacionMesasExamenes.Click += subMenuConformacionMesasExamenes_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(412, 6);
            // 
            // subMenuPeriodosInscripciones
            // 
            subMenuPeriodosInscripciones.IconChar = FontAwesome.Sharp.IconChar.CheckSquare;
            subMenuPeriodosInscripciones.IconColor = Color.Black;
            subMenuPeriodosInscripciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            subMenuPeriodosInscripciones.Name = "subMenuPeriodosInscripciones";
            subMenuPeriodosInscripciones.Size = new Size(415, 34);
            subMenuPeriodosInscripciones.Text = "Períodos de inscripciones";
            subMenuPeriodosInscripciones.Click += subMenuPeriodosInscripciones_Click;
            // 
            // subMenuInscripciones
            // 
            subMenuInscripciones.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            subMenuInscripciones.IconColor = Color.Black;
            subMenuInscripciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            subMenuInscripciones.Name = "subMenuInscripciones";
            subMenuInscripciones.Size = new Size(415, 34);
            subMenuInscripciones.Text = "Inscripciones de alumnos";
            // 
            // menuInformes
            // 
            menuInformes.DropDownItems.AddRange(new ToolStripItem[] { subMenuInformeDocentes });
            menuInformes.IconChar = FontAwesome.Sharp.IconChar.Print;
            menuInformes.IconColor = Color.Black;
            menuInformes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuInformes.Name = "menuInformes";
            menuInformes.Size = new Size(123, 29);
            menuInformes.Text = "Informes";
            // 
            // subMenuInformeDocentes
            // 
            subMenuInformeDocentes.IconChar = FontAwesome.Sharp.IconChar.User;
            subMenuInformeDocentes.IconColor = Color.Pink;
            subMenuInformeDocentes.IconFont = FontAwesome.Sharp.IconFont.Solid;
            subMenuInformeDocentes.Name = "subMenuInformeDocentes";
            subMenuInformeDocentes.Size = new Size(188, 34);
            subMenuInformeDocentes.Text = "Docentes";
            subMenuInformeDocentes.Click += mnuDocentes_Click;
            // 
            // menuSalir
            // 
            menuSalir.DropDownItems.AddRange(new ToolStripItem[] { subMenuSalirDelSistema });
            menuSalir.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            menuSalir.IconColor = Color.Black;
            menuSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuSalir.Name = "menuSalir";
            menuSalir.Size = new Size(85, 29);
            menuSalir.Text = "Salir";
            // 
            // subMenuSalirDelSistema
            // 
            subMenuSalirDelSistema.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            subMenuSalirDelSistema.IconColor = Color.Black;
            subMenuSalirDelSistema.IconFont = FontAwesome.Sharp.IconFont.Auto;
            subMenuSalirDelSistema.Name = "subMenuSalirDelSistema";
            subMenuSalirDelSistema.Size = new Size(241, 34);
            subMenuSalirDelSistema.Text = "Salir del sistema";
            subMenuSalirDelSistema.Click += iconMenuItem4_Click;
            // 
            // MenuPrincipalView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1364, 828);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
            Name = "MenuPrincipalView";
            Text = "Instituto Superior de Profesorado Nº20";
            WindowState = FormWindowState.Maximized;
            Activated += MenuPrincipalView_Activated;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem menuPrincipal;
        private FontAwesome.Sharp.IconMenuItem subMenuConformacionMesasExamenes;
        private FontAwesome.Sharp.IconMenuItem menuSalir;
        private FontAwesome.Sharp.IconMenuItem subMenuSalirDelSistema;


        private FontAwesome.Sharp.IconMenuItem menuInformes;
        private FontAwesome.Sharp.IconMenuItem subMenuInformeDocentes;
        private FontAwesome.Sharp.IconMenuItem menuHorarios;
        private FontAwesome.Sharp.IconMenuItem subMenuHoras;
        private FontAwesome.Sharp.IconMenuItem subMenuHorarios;
        private FontAwesome.Sharp.IconMenuItem menuMesasExamenes;
        private FontAwesome.Sharp.IconMenuItem subMenuPeriodosHorarios;
        private FontAwesome.Sharp.IconMenuItem subMenuCiclosLectivos;
        private FontAwesome.Sharp.IconMenuItem subMenuAlumnos;
        private FontAwesome.Sharp.IconMenuItem subMenuAulas;
        private ToolStripSeparator toolStripSeparator1;
        private FontAwesome.Sharp.IconMenuItem subMenuDocentes;
        private ToolStripSeparator toolStripSeparator2;
        private FontAwesome.Sharp.IconMenuItem subMenuMaterias;
        private FontAwesome.Sharp.IconMenuItem subMenuCarreras;
        private FontAwesome.Sharp.IconMenuItem subMenuAñosCarreras;
        private FontAwesome.Sharp.IconMenuItem subMenuTurnosExámenes;
        private FontAwesome.Sharp.IconMenuItem subMenuPeriodosInscripciones;
        private ToolStripSeparator toolStripSeparator3;
        private FontAwesome.Sharp.IconMenuItem subMenuInscripciones;
        private ToolStripSeparator toolStripSeparator4;
        private FontAwesome.Sharp.IconMenuItem subMenuUsuarios;
    }
}
