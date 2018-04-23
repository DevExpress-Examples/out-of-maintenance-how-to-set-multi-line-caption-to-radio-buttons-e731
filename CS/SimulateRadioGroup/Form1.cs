using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace SimulateRadioGroup {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        public CheckEdit[] RadioButtons {
            get {
                CheckEdit[] buttons = new CheckEdit[] {CheckEdit1, CheckEdit2, CheckEdit3};
                return buttons;
            }
        }

        public int RadioGroupSelectedIndex {
            get {
                for(int i = 0; i < RadioButtons.Length; i++) {
                    if(RadioButtons[i].Checked)
                        return i;
                }
                return -1;
            }
            set {
                int currentIndex = RadioGroupSelectedIndex;
                if(currentIndex == value) return;
                if(value < -1 || value >= RadioButtons.Length) return;
                if(currentIndex != -1) {
                    RadioButtons[currentIndex].Checked = false;
                }
                if(value != -1) {
                    RadioButtons[value].Checked = true;
                }
            }
        }

        private void  SimpleButton1_Click(object sender, System.EventArgs e) {
            MessageBox.Show(RadioGroupSelectedIndex.ToString());
        }

        private void  SimpleButton2_Click(object sender, System.EventArgs e) {
            RadioGroupSelectedIndex = (int)SpinEdit1.Value;
        }

    }
}