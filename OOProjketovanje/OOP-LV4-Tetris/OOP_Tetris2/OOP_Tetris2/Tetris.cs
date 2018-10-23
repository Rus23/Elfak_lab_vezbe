using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOP_Tetris2.Podaci;

namespace OOP_Tetris2
{
    public partial class Tetris : UserControl
    {
        private Model mod;

        public Model Mod
        {
            get
            {
                return mod;
            }

            set
            {
                mod = value;
            }
        }

        public Tetris()
        {
            InitializeComponent();
            Init();
        }
        private void Init()
        {
            int j = 5;
            int k = 5;
            

            Mod = new Model(j, k);
            Mod.MojPanel = panelTetris;
            Mod.LogickiPanel = panelLogicki;
            Mod.crtajPanel();

            this.Height = Mod.MojPanel.Height + Mod.LogickiPanel.Height + 10;
            this.Width = Mod.MojPanel.Width + Mod.LogickiPanel.Width + 30;

            panelTetris.Height = Mod.MojPanel.Height;
            panelTetris.Width = Mod.MojPanel.Width;
        }
        public Tetris(int n,int m)
        {
            InitializeComponent();

            Mod = new Model(n, m);
            Mod.MojPanel = panelTetris;
            Mod.LogickiPanel = panelLogicki;
            Mod.crtajPanel();

            this.Height = Mod.MojPanel.Height + Mod.LogickiPanel.Height + 10;
            this.Width = Mod.MojPanel.Width + Mod.LogickiPanel.Width + 30;

            panelTetris.Height = Mod.MojPanel.Height;
            panelTetris.Width = Mod.MojPanel.Width;

            panelLogicki.Height = Mod.LogickiPanel.Height;
            panelLogicki.Width = Mod.LogickiPanel.Width;
        }
    }
}
