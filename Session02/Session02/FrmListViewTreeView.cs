using Session02.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session02
{
    public partial class FrmListViewTreeView : Form
    {
        List<Classes> list = new List<Classes>()
        {
            new Classes {ClassId=1,ClassName ="C1610M" },
            new Classes {ClassId=2,ClassName ="C1608H" },
            new Classes {ClassId=3,ClassName ="C1608I" }
        };
        List<Student> liststudent = new List<Student>()
        {
            new Student {Id="B001",Name="Nguyễn Thu Thủy 1", Birthday="1/1/1990",Address="Hà Nội",ClassId=1,Gender=true},
            new Student {Id="B002",Name="Nguyễn Thu Thủy 2" , Birthday="1/1/1990",Address="Hà Nội",ClassId=1,Gender=true},
            new Student {Id="B003",Name="Nguyễn Thu Thủy 3", Birthday="1/1/1990",Address="Hà Nội",ClassId=2,Gender=false},
            new Student {Id="B004",Name="Nguyễn Thu Thủy 4", Birthday="1/1/1990",Address="Hà Nội",ClassId=2,Gender=true},
            new Student {Id="B005",Name="Nguyễn Thu Thủy 5", Birthday="1/1/1990",Address="Hà Nội",ClassId=2,Gender=false},
            new Student {Id="B006",Name="Nguyễn Thu Thủy 6", Birthday="1/1/1990",Address="Hà Nội",ClassId=3,Gender=true},
            new Student {Id="B007",Name="Nguyễn Thu Thủy 7", Birthday="1/1/1990",Address="Hà Nội",ClassId=1,Gender=false},
        };
        public FrmListViewTreeView()
        {
            InitializeComponent();
        }

        private void FrmListViewTreeView_Load(object sender, EventArgs e)
        {
            LoadClass();
        }

        private void LoadClass()
        {
            trvClass.Nodes.Clear();
            //Tạo nút gốc
            TreeNode root = new TreeNode("Danh mục lớp học", 0, 0);
            //Load dữ liệu lên nút gốc
            foreach (var c in list)
            {
                TreeNode child = new TreeNode(c.ClassName, 1, 1);
                child.Tag = c.ClassId;
                root.Nodes.Add(child);
            }
            //đưa nút gốc lên cây
            trvClass.Nodes.Add(root);
            trvClass.ExpandAll();
        }

        private void trvClass_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = e.Node;
            if (node.Tag != null)
                // MessageBox.Show("Bạn chọn lớp:" + node.Text);
                LoadStudent();
        }
        private void LoadStudent()
        {
            lstStudent.Items.Clear();
            TreeNode node = trvClass.SelectedNode;
            int classid = (int)node.Tag;
            var students = liststudent.Where(x => x.ClassId == classid);
            foreach (var s in students)
            {
                ListViewItem item = new ListViewItem();
                item.Text = s.Id;
                item.SubItems.Add(s.Name);
                item.SubItems.Add(s.Birthday);
                item.SubItems.Add(s.Address);
                item.ImageIndex = s.Gender ? 2 : 3;
                lstStudent.Items.Add(item);
            }
        }

        private void lstStudent_Click(object sender, EventArgs e)
        {
            if(lstStudent.SelectedItems.Count>0)
            {
                ListViewItem item = lstStudent.SelectedItems[0];
                MessageBox.Show(item.Text+":"+item.SubItems[1].Text);
            }
        }

        private void rdoLarge_Click(object sender, EventArgs e)
        {
            lstStudent.View = View.LargeIcon;
        }

        private void rdoDetail_Click(object sender, EventArgs e)
        {
            lstStudent.View = View.Details;
        }

        private void rdoList_Click(object sender, EventArgs e)
        {
            lstStudent.View = View.List;
        }

        private void rdoSmall_Click(object sender, EventArgs e)
        {
            lstStudent.View = View.SmallIcon;
        }

        private void rdoTile_Click(object sender, EventArgs e)
        {
            lstStudent.View = View.Tile;
        }
    }
}
