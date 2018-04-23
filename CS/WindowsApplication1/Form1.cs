using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Card;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            new DevExpress.XtraGrid.Design.XViewsPrinting(gridControl1);
        }

        private void cardView1_KeyDown(object sender, KeyEventArgs e)
        {
            CardView Cards = sender as CardView;
            if (e.KeyCode == Keys.Insert && !Cards.IsEditing)
            {
                DataView Data = Cards.DataSource as DataView;
                if (Data != null)
                {
                    Data.AddNew();
                    Cards.FocusedColumn = Cards.GetVisibleColumn(0);
                    Cards.ShowEditor();
                    e.Handled = true;
                }
            }
        }

    }   
}