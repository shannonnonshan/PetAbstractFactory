using AbstractFactory.Factory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractFactory
{
    public partial class FWild : Form
    {
        private IAnimalFactory animalFactory;
        public FWild()
        {
            InitializeComponent();
            animalFactory = new SmallWildFactory();
        }

        private void FWild_Load(object sender, EventArgs e)
        {

        }
    }
}
