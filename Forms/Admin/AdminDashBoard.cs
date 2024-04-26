using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectDB.Forms.Admin
{
    public partial class AdminDashBoard : Form
    {
        private int userId;

        public AdminDashBoard(int userId)
        {
            InitializeComponent();

            this.userId = userId;

        }
    }
}
