using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectAPD.Forms {
    public partial class MngProductForm : Form {
        ProjectEntities context = new ProjectEntities();
        List<string> typeNames = new List<string> {
            "ทั้งหมด",
            "ซีพียู คอมพิวเตอร์",
            "เมนบอร์ด",
            "การ์ดแสดงผล",
            "แรมสำหรับคอมพิวเตอร์",
            "เคสและเพาเวอร์ซัพพลาย",
            "เครื่องอ่านและบันทึกแผ่นซีดี",
            "การ์ดเสียง",
            "เครื่องอ่านเม็มโมรี่การ์ด",
            "Single Board Computer",
            "Combo Set",
            "Bundle Pack",
        };
        List<string> typeIds = new List<string> {
            "0","43", "46", "51", "53", "54", "55", "56", "57", "1433", "1617", "1616"
        };
        public MngProductForm() {
            InitializeComponent();
            productxBindingSource.DataSource = context.Productxes.ToList();
            ComboboxAddItem(typeIds, typeNames);
            comboBoxType.SelectedIndex = 0;
        }
        private void ComboboxAddItem(List<string> typeIds, List<string> typeNames) {
            List<ComboboxItem> items = new List<ComboboxItem>();

            for (int i = 0; i < typeIds.Count; i++) {
                items.Add(new ComboboxItem {
                    Text = typeNames[i],
                    Value = typeIds[i]
                });
            }

            foreach (var item in items) {
                comboBoxType.Items.Add(item);
            }
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e) {
            string typeid = ((ComboboxItem)(comboBoxType.SelectedItem)).Value;
            if (!typeid.Equals("0")) {
                productxBindingSource.DataSource = context.Productxes.Where(p => p.TypeId.ToString() == typeid).ToList();
            } else {
                productxBindingSource.DataSource = context.Productxes.ToList();
            }
        }
    }
}
