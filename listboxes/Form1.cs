using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listboxes
{
    public partial class Form1 : Form
    {
        private ListBox draggedFrom;

        public Form1()
        {
            InitializeComponent();
            ListBoxLeft.Items.Add("Понедельник");
            ListBoxLeft.Items.Add("Вторник");
            ListBoxLeft.Items.Add("Среда");
            ListBoxLeft.Items.Add("Четверг");
            ListBoxLeft.Items.Add("Пятница");
        }

        private void ToRightAll_Click(object sender, EventArgs e)
        {
            var elementCount = ListBoxLeft.Items.Count;
            for (var i = 0; i < elementCount; i++)
            {
                ListBoxRight.Items.Add(ListBoxLeft.Items[0]);
                ListBoxLeft.Items.Remove(ListBoxLeft.Items[0]);
            }
            DataChange();
        }

        private void ToLeftAll_Click(object sender, EventArgs e)
        {
            var elementCount = ListBoxRight.Items.Count;
            for (var i = 0; i < elementCount; i++)
            {
                ListBoxLeft.Items.Add(ListBoxRight.Items[0]);
                ListBoxRight.Items.Remove(ListBoxRight.Items[0]);
            }
            DataChange();
        }

        private void ToRight_Click(object sender, EventArgs e)
        {
            var elementCount = ListBoxLeft.SelectedItems.Count;
            for (var i = 0; i < elementCount; i++)
            {
                ListBoxRight.Items.Add(ListBoxLeft.SelectedItems[0]);
                ListBoxLeft.Items.Remove(ListBoxLeft.SelectedItems[0]);
            }
            DataChange();
        }

        private void ToLeft_Click(object sender, EventArgs e)
        {
            var elementCount = ListBoxRight.SelectedItems.Count;
            for (var i = 0; i < elementCount; i++)
            {
                ListBoxLeft.Items.Add(ListBoxRight.SelectedItems[0]);
                ListBoxRight.Items.Remove(ListBoxRight.SelectedItems[0]);
            }
            DataChange();
        }

        private void ListBoxLeft_MouseDown(object sender, MouseEventArgs e)
        {
            if (sender is ListBox list)
            {
                draggedFrom = list;
                list.DoDragDrop(list.SelectedItems, DragDropEffects.Copy);
            }
        }

        private void ListBoxLeft_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void ListBoxLeft_DragDrop(object sender, DragEventArgs e)
        {
            if (sender is ListBox list && list != draggedFrom)
            {
                var dragged = e.Data!.GetData(typeof(ListBox.SelectedObjectCollection)) as ListBox.SelectedObjectCollection;
                list.Items.Add(dragged[0]);
                draggedFrom!.Items.Remove(dragged[0]);
            }
        }

        private void ListBoxLeft_MouseEnter(object sender, EventArgs e)
        {
            DataChange();
        }

        private void ListBoxRight_MouseEnter(object sender, EventArgs e)
        {
            DataChange();
        }
        private void DataChange()
        {
            ToRightAll.Enabled = ListBoxLeft.Items.Count > 0;
            ToLeftAll.Enabled = ListBoxRight.Items.Count > 0;
            ToRight.Enabled = ListBoxLeft.SelectedItems.Count > 0;
            ToLeft.Enabled = ListBoxRight.SelectedItems.Count > 0;
        }
    }
}
