using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WFA
{
    public partial class Form20 : Form
    {
        public Form20()
        {
            InitializeComponent();
        }

        private void btnWarrior_Click(object sender, EventArgs e)
        {
            Attack("sword",200);
        }

        private void btnArcher_Click(object sender, EventArgs e)
        {
            Attack("arch",300);
        }

        private void btnWizard_Click(object sender, EventArgs e)
        {
            Attack("magic",400);
        }

        private void btnBomb_Click(object sender, EventArgs e)
        {
            Attack("bomb");
        }

        public void Attack(string attackStyle ,int damage = 200)
        {
            MessageBox.Show($"You attacked enemy with {attackStyle} and gave {damage} damage.");
        }
       
        /// sadece NPC ler kullaniyor
        public void Attack()
        {
            MessageBox.Show($"You attacked enemy and gave 100 damage.");
        }
        private void btnNpc_Click(object sender, EventArgs e)
        {
            Attack(); //metotlarin adi ayni ama birinin ici bos digeri dolu burda bos biraktik diye bos olani kullandi 
        }
    }
}
