﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeightProgram {
    public partial class WeightInputForm : Form {
        public WeightInputForm() {
            InitializeComponent();
            ResizeBegin += (s, e) => { SuspendLayout(); };
            ResizeEnd += (s, e) => { ResumeLayout(true); };
        }
    }
}
