using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DashSub;

namespace ArmEditor.UI
{
    public partial class DashboardEditor : Form
    {
        private ArmDashboardTemplate template;

        public DashboardEditor()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    File.WriteAllText(dialog.FileName, DashReplace.ParameteriseText(this.template.ToString()));
                }
            }
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            this.template = ArmDashboardTemplate.FromNew();
            this.Rebuild();
        }

        private void Rebuild()
        {
            this.treeView1.Nodes.Clear();
            foreach (var component in this.template.Children)
            {
                this.treeView1.Nodes.Add(new TreeNode(component.Title));
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            using (var form = new AddDashboardComponent())
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    this.template.AddDashboardComponent(form.Component);
                    this.Rebuild();
                }
            }            
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    this.template = ArmDashboardTemplate.FromFile(dialog.FileName);
                    this.Rebuild();
                }
            }
        }

        private void toolStripButtonSaveParameters_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    File.WriteAllText(dialog.FileName, ParamReplace.GetParameters(Path.GetFileNameWithoutExtension(dialog.FileName)));
                }
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    File.WriteAllText(dialog.FileName, DashReplace.ParameteriseText(this.template.ToString()));
                }
            }
        }
    }
}
