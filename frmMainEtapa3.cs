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

        bool Auto = true;
        bool Avion = true;
        bool Barco = true;

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
            objAuto.pctAuto.Location = new Point(100, 50);
            Controls.Add(objAuto.pctAuto);
            Auto = true;
            if(Avion == true)
            {
                objAvion.pctAvion.Dispose();
                Avion = false;
            }
            if(Barco == true)
            {
                objBarco.pctBarco.Dispose();
                Barco = false;
            }
        }

        private void btnAvion_Click(object sender, EventArgs e)
        {
            objAvion.CrearAvion();
            objAvion.pctAvion.Location = new Point(100, 50);
            Controls.Add(objAvion.pctAvion);
            Avion = true;
            if (Auto == true)
            {
                objAvion.pctAvion.Dispose();
                Auto = false;
            }
            if (Barco == true)
            {
                objBarco.pctBarco.Dispose();
                Barco = true;
            }
        }

        private void btnBarco_Click(object sender, EventArgs e)
        {
            objBarco.CrearBarco();
            objBarco.pctBarco.Location = new Point(100, 50);
            Controls.Add(objBarco.pctBarco);
            Barco = true;
            if (Avion == true)
            {
                objAvion.pctAvion.Dispose();
                Avion = false;
            }
            if (Auto == true)
            {
                objAuto.pctAuto.Dispose();
                Auto = false;
            }
        }
    }
}
