﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectAPD.Forms {
    public partial class CustomerForm : Form {
        ProjectEntities context = new ProjectEntities();
        public CustomerForm() {
            InitializeComponent();
            customerxBindingSource.DataSource = context.Customerxes.ToList();
        }
    }
}
