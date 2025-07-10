using Runner.Models;
using Runner.Service.Interfaces;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace LAPSRunner
{
    public partial class Runner : Form
    {
        IGenericService<AppInstance> _service;

        public Runner(IGenericService<AppInstance> service)
        {
            _service = service;

            InitializeComponent();

            populateCache();

            ResizeListViewColumns(lstImmediate);
        }

        private void save_Click(object sender, EventArgs e)
        {
            var result = _service.Add(GetImmediateItems());

            if (!string.IsNullOrEmpty(result))
            {
                MessageBox.Show(result, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            populateCache();
        }

        private List<AppInstance> GetImmediateItems()
        {
            var items = new List<AppInstance>();

            foreach (var item in lstImmediate.Items)
            {
                var lstItem = (ListViewItem)item;
                var appInstance = new AppInstance()
                {
                    Id = Convert.ToInt32(lstItem.SubItems[0].Text),
                    Name = lstItem.SubItems[1].Text,
                    InstanceCount = Convert.ToInt32(lstItem.SubItems[2].Text),
                    Path = lstItem.SubItems[3].Text
                };
                items.Add(appInstance);
            }

            return items;
        }

        private void populateCache()
        {
            var items = _service.GetAll();
            lstCache.Items.Clear();

            lstCache.Items.AddRange(items.Select(i => new ListViewItem(i.SubItem)).ToArray());

            ResizeListViewColumns(lstCache);
        }

        private void lstImmediate_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                e.NewWidth = 0;
                e.Cancel = true;
            }
        }

        private void lstCache_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                e.NewWidth = 0;
                e.Cancel = true;
            }
        }

        private void removeCache_Click(object sender, EventArgs e)
        {
            var idList = new List<int>();

            foreach (var item in lstCache.SelectedItems)
            {
                var lstItem = (ListViewItem)item;
                var itemId = Convert.ToInt32(lstItem.SubItems[0].Text);
                idList.Add(itemId);
            }

            var removeList = _service.Get(x => idList.Contains(x.Id)).ToList();

            _service.RemoveRange(removeList);

            populateCache();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            var items = _service.GetAll();

            RunAppInstances(items);
        }

        private void RunAppInstances(IList<AppInstance> items)
        {
            for (var i = 0; i < items.Count; i++)
            {
                for (var j = 0; j < items[i].InstanceCount; j++)
                {
                    try
                    {
                        System.Diagnostics.Process.Start(items[i].Path);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    Thread.Sleep(1000);
                }
            }
        }

        private void lstCache_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var hitTest = lstCache.HitTest(e.Location);
            if (hitTest.Item != null)
            {
                var itemId = Convert.ToInt32(hitTest.Item.SubItems[0].Text);

                var name = hitTest.Item.SubItems[1].Text;
                var instanceCount = Convert.ToInt32(hitTest.Item.SubItems[2].Text);

                var dialog = new NewItem(name, instanceCount);
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var item = _service.Get(x => x.Id == itemId).FirstOrDefault();
                    if (item != null)
                    {
                        item.Name = dialog.txtName.Text;
                        item.InstanceCount = Convert.ToInt32(dialog.numInstanceCount.Text);
                        _service.Update(item);
                    }
                }
            }

            populateCache();
        }

        private void removeImmediate_Click(object sender, EventArgs e)
        {
            var idList = new List<int>();

            foreach (var item in lstImmediate.SelectedItems)
            {
                var lstItem = (ListViewItem)item;
                lstImmediate.Items.RemoveAt(lstItem.Index);
            }

            ResizeListViewColumns(lstImmediate);
        }

        private void lstImmediate_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var hitTest = lstImmediate.HitTest(e.Location);
            if (hitTest.Item != null)
            {
                var name = hitTest.Item.SubItems[1].Text;
                var instanceCount = Convert.ToInt32(hitTest.Item.SubItems[2].Text);

                var dialog = new NewItem(name, instanceCount);
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    hitTest.Item.SubItems[1].Text = dialog.txtName.Text;
                    hitTest.Item.SubItems[2].Text = dialog.numInstanceCount.Text;
                }
            }
        }

        private void shift_Click(object sender, EventArgs e)
        {
            foreach (var item in lstCache.SelectedItems)
            {
                var lstItem = (ListViewItem)item;
                var clonedItem = (ListViewItem)lstItem.Clone();
                lstImmediate.Items.Add(clonedItem);
            }

            ResizeListViewColumns(lstImmediate);
        }

        private void runnerIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            runnerIcon.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        private void Runner_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                runnerIcon.Visible = true;
                runnerIcon.ShowBalloonTip(1000);
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                runnerIcon.Visible = false;
            }
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void miRestore_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void btnRunImmediate_Click(object sender, EventArgs e)
        {
            var items = GetImmediateItems();
            RunAppInstances(items);
        }

        private void Runner_FormClosing(object sender, FormClosingEventArgs e)
        {
            var confirm = MessageBox.Show("Are you sure you want to exit the app? You'll have to request a password again..", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void ResizeListViewColumns(ListView lv)
        {
            foreach (ColumnHeader column in lv.Columns)
            {
                if (column.Text.ToLower() != "id")
                {
                    column.Width = -2;
                }
            }
        }
    }
}
