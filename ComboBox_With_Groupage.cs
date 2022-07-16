using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dofus_Fm
{
    public partial class ComboBox_With_Groupage : UserControl
    {

        List<string> categories = Runes.getAllCategories();
        List<Runes> runes = Runes.LoadArrayList();
        public Runes rune { get; private set ; }
        public ComboBox_With_Groupage()
        {
            InitializeComponent();
            foreach (var item in categories)
            {
                GroupsAdd(new ListViewGroup(item, HorizontalAlignment.Left));
            }

            for (int i = 0; i < runes.Count; i++)
            {
                for (int y = 0; y < categories.Count; y++)
                {
                    if (runes[i].category == categories[y])
                    {
                          ListViewItem item = new ListViewItem(new string[] { runes[i].label, $" ( {runes[i].weight} puit ) " }, imageList1.Images.IndexOfKey(runes[i].icon));
                          ItemsAdd(item);
                          setItemGroup(i, y);
                    }
                }
            }
            listView1.SmallImageList = imageList1;
        }

        [Description("Drop The list Toward topside or downside"), Category("Misc"),Browsable(true), EditorBrowsable(EditorBrowsableState.Always), Bindable(true),DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool DropToTop { get; set; }

        public void GroupsAdd(ListViewGroup listViewGroup)
        {
            listView1.Groups.Add(listViewGroup);
        }
        public void ItemsAdd(ListViewItem listViewItem)
        {
            listView1.Items.Add(listViewItem);
        }
        public void setItemGroup(int itemIndex, int groupIndex)
        {
            listView1.Items[itemIndex].Group = listView1.Groups[groupIndex];
        }
        private void ComboBox_With_Groupage_Load(object sender, EventArgs e)
        {
            this.Size = this.MinimumSize;
            if (DropToTop)
                txt_box.Dock = DockStyle.Bottom;
            else
                txt_box.Dock = DockStyle.Top;
        }
        private void txt_box_Leave(object sender, EventArgs e)
        {
            this.Size = this.MinimumSize;
            if (DropToTop)
                this.Location = new Point(31, 520);
            SendToBack();
        }

        private void txt_box_TextChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear(); // clear list items before adding 
                                     // filter the items match with search key and add result to list view 
                                     int count = 0;
            for (int i = 0; i < runes.Count; i++)
            {
                if (runes[i].label.ToLower().Contains(txt_box.Text.ToLower()) || string.IsNullOrEmpty(txt_box.Text))
                {
                    ListViewItem item = new ListViewItem(new string[] { runes[i].label, $" (  {runes[i].weight} puit ) " }, imageList1.Images.IndexOfKey(runes[i].icon));
                    ItemsAdd(item);
                    for (int y = 0; y < categories.Count; y++)
                    {
                        if (runes[i].category == categories[y])
                        {
                            
                            setItemGroup(count, y);
                            count++;
                        }
                    }
                }
            }
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                rune = new Runes(selectedItem.Text, selectedItem.Group.ToString(), selectedItem.ImageIndex + "", selectedItem.SubItems[1].Text);
                txt_box.Text = rune.label;
                txt_box.LeadingIcon = imageList1.Images[int.Parse(rune.icon)];
            }
            catch (Exception) { }
        }
        private void txt_box_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                ActiveControl = null;  //this = form
                listView1.Focus();
                txt_box.Text = String.Empty;
                txt_box.LeadingIcon = null;
            }
        }
        private void txt_box_Enter(object sender, EventArgs e)
        {
            txt_box.Text = String.Empty;
            txt_box.LeadingIcon = null;
            listView1.Enabled = true;
            if (DropToTop)
                this.Location = new Point(31, 23);
            this.Size = this.MaximumSize;
            this.BringToFront();
        }

       
    }
}
