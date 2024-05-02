using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySosaEtapa3
{
    public partial class frmMainEtapa3 : Form
    {
        public frmMainEtapa3()
        {
            InitializeComponent();
        }

        clsVehiculo objAuto;
        clsVehiculo objAvion;
        clsVehiculo objBarco;

        bool Auto = false;
        bool Avion = false;
        bool Barco = false;

        private void frmMainEtapa3_Load(object sender, EventArgs e)
        {
            objAuto = new clsVehiculo();
            objAvion = new clsVehiculo();
            objBarco = new clsVehiculo();

            objAuto.CrearAuto();
            objAvion.CrearAvion();
            objBarco.CrearBarco();
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            objAuto.CrearAuto();
            objAuto.pctAuto.Location = new Point(-20, 300);
            Controls.Add(objAuto.pctAuto);
            lblAuto.Text = objAuto.tipoVehiculo;
            Auto = true;
            if(Avion == true)
            {
                objAvion.pctAvion.Dispose();
                Avion = false;
                lblAvion.Text = "";
            }
            if(Barco == true)
            {
                objBarco.pctBarco.Dispose();
                Barco = false;
                lblBarco.Text = "";
            }
        }

        private void btnAvion_Click(object sender, EventArgs e)
        {
            objAvion.CrearAvion();
            objAvion.pctAvion.Location = new Point(350, 50);
            Controls.Add(objAvion.pctAvion);
            lblAvion.Text = objAvion.tipoVehiculo;
            Avion = true;
            if (Auto == true)
            {
                objAuto.pctAuto.Dispose();
                Auto = false;
                lblAuto.Text = "";
            }
            if (Barco == true)
            {
                objBarco.pctBarco.Dispose();
                Barco = true;
                lblBarco.Text = "";
            }
        }

        private void btnBarco_Click(object sender, EventArgs e)
        {
            objBarco.CrearBarco();
            objBarco.pctBarco.Location = new Point(600, 50);
            Controls.Add(objBarco.pctBarco);
            lblBarco.Text = objBarco.tipoVehiculo;
            Barco = true;
            if (Avion == true)
            {
                objAvion.pctAvion.Dispose();
                Avion = false;
                lblAvion.Text = "";
            }
            if (Auto == true)
            {
                objAuto.pctAuto.Dispose();
                Auto = false;
                lblAuto.Text = "";
            }
        }
    }
}
