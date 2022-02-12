using Cluster.BL;
using Cluster.BL.Model.Tables;
using System;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace Cluster.UI
{
    public partial class ThrdViewOffset<T> : Form
        where T : class
    {
        readonly ClusterDbContext database;
        readonly DbSet<T> set;
        public ThrdViewOffset(DbSet<T> set, ClusterDbContext db)
        {
            database = new ClusterDbContext();
            InitializeComponent();
            this.database = db;
            this.set = set;
            set.Load();
            database.SaveChanges();
        }

        private void SearchButton_Click(object sender, System.EventArgs e)
        {
            int convertedDiameter = 0;
            if (!string.IsNullOrEmpty(comboBoxProductDiameterView.Text))
            {
                convertedDiameter = Convert.ToInt32(comboBoxProductDiameterView.Text);
            }

            if (checkBoxProductBlank.Checked)
            {

                if (checkBoxPickAllTime.Checked)
                {
                    using (var cont = new ClusterDbContext())
                    {
                        var source = database.OffsetDatas.OrderByDescending(u => u.OffsetDataId).ToList();
                        listBoxViewDataList.DataSource = source;
                    }

                }
                else
                {
                    using (var cont = new ClusterDbContext())
                    {
                        var source = database.OffsetDatas.Where(u => DbFunctions.TruncateTime(u.Created) == dateTimePickerForView.Value.Date).OrderByDescending(u => u.OffsetDataId).ToList();
                        listBoxViewDataList.DataSource = new BindingList<OffsetData>(source);

                    }
                }
            }
            else if (string.IsNullOrEmpty(comboBoxThreadTypeView.Text) && string.IsNullOrEmpty(comboBoxProductDiameterView.Text) && string.IsNullOrEmpty(comboBoxMachineNumberView.Text))
            {
                MessageBox.Show("Заполните параметры сортамента", "Ошибка заполнения данных",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!string.IsNullOrEmpty(comboBoxThreadTypeView.Text) || !string.IsNullOrEmpty(comboBoxProductDiameterView.Text) || !string.IsNullOrEmpty(comboBoxMachineNumberView.Text))
            {
                if (checkBoxPickAllTime.Checked)
                {
                    if (!string.IsNullOrEmpty(comboBoxThreadTypeView.Text) && string.IsNullOrEmpty(comboBoxProductDiameterView.Text) && string.IsNullOrEmpty(comboBoxMachineNumberView.Text))
                    {
                        using (var cont = new ClusterDbContext())
                        {
                            var source = database.OffsetDatas.Where(u => u.Product.ThreadType == comboBoxThreadTypeView.Text).OrderByDescending(u => u.OffsetDataId).ToList();
                            listBoxViewDataList.DataSource = new BindingList<OffsetData>(source);

                        }
                    }
                    else if (string.IsNullOrEmpty(comboBoxThreadTypeView.Text) && !string.IsNullOrEmpty(comboBoxProductDiameterView.Text) && string.IsNullOrEmpty(comboBoxMachineNumberView.Text))
                    {
                        using (var cont = new ClusterDbContext())
                        {
                            var source = database.OffsetDatas.Where(u => u.Product.Diameter == convertedDiameter).OrderByDescending(u => u.OffsetDataId).ToList();
                            listBoxViewDataList.DataSource = new BindingList<OffsetData>(source);
                        }
                    }
                    else if (string.IsNullOrEmpty(comboBoxThreadTypeView.Text) && string.IsNullOrEmpty(comboBoxProductDiameterView.Text) && !string.IsNullOrEmpty(comboBoxMachineNumberView.Text))
                    {
                        using (var cont = new ClusterDbContext())
                        {
                            var source = database.OffsetDatas.Where(u => u.Machine == comboBoxMachineNumberView.Text).OrderByDescending(u => u.OffsetDataId).ToList();
                            listBoxViewDataList.DataSource = new BindingList<OffsetData>(source);

                        }
                    }
                    else if (!string.IsNullOrEmpty(comboBoxThreadTypeView.Text) && !string.IsNullOrEmpty(comboBoxProductDiameterView.Text) && string.IsNullOrEmpty(comboBoxMachineNumberView.Text))
                    {
                        using (var cont = new ClusterDbContext())
                        {
                            var source = database.OffsetDatas.Where(u => u.Product.Diameter == convertedDiameter)
                            .Where(u => u.Product.ThreadType == comboBoxThreadTypeView.Text).OrderByDescending(u => u.OffsetDataId).ToList();
                            listBoxViewDataList.DataSource = new BindingList<OffsetData>(source);
                        }
                    }
                    else if (!string.IsNullOrEmpty(comboBoxThreadTypeView.Text) && string.IsNullOrEmpty(comboBoxProductDiameterView.Text) && !string.IsNullOrEmpty(comboBoxMachineNumberView.Text))
                    {
                        using (var cont = new ClusterDbContext())
                        {
                            var source = database.OffsetDatas
                            .Where(u => u.Machine == comboBoxMachineNumberView.Text)
                            .Where(u => u.Product.ThreadType == comboBoxThreadTypeView.Text).OrderByDescending(u => u.OffsetDataId).ToList();
                            listBoxViewDataList.DataSource = new BindingList<OffsetData>(source);
                        }
                    }
                    else if (string.IsNullOrEmpty(comboBoxThreadTypeView.Text) && !string.IsNullOrEmpty(comboBoxProductDiameterView.Text) && !string.IsNullOrEmpty(comboBoxMachineNumberView.Text))
                    {
                        using (var cont = new ClusterDbContext())
                        {
                            var source = database.OffsetDatas
                            .Where(u => u.Machine == comboBoxMachineNumberView.Text)
                            .Where(u => u.Product.Diameter == convertedDiameter).OrderByDescending(u => u.OffsetDataId).ToList();
                            listBoxViewDataList.DataSource = new BindingList<OffsetData>(source);
                        }
                    }
                    else
                    {
                        using (var cont = new ClusterDbContext())
                        {
                            var source = database.OffsetDatas
                            .Where(u => u.Product.ThreadType == comboBoxThreadTypeView.Text)
                            .Where(u => u.Machine == comboBoxMachineNumberView.Text)
                            .Where(u => u.Product.Diameter == convertedDiameter)
                            .OrderByDescending(u => u.OffsetDataId).ToList();
                            listBoxViewDataList.DataSource = new BindingList<OffsetData>(source);
                        }
                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(comboBoxThreadTypeView.Text) && string.IsNullOrEmpty(comboBoxProductDiameterView.Text) && string.IsNullOrEmpty(comboBoxMachineNumberView.Text))
                    {
                        using (var cont = new ClusterDbContext())
                        {
                            var source = database.OffsetDatas
                            .Where(u => u.Product.ThreadType == comboBoxThreadTypeView.Text)
                            .Where(u => DbFunctions.TruncateTime(u.Created) == dateTimePickerForView.Value.Date)
                            .OrderByDescending(u => u.OffsetDataId).ToList();
                            listBoxViewDataList.DataSource = new BindingList<OffsetData>(source);
                        }
                    }
                    else if (string.IsNullOrEmpty(comboBoxThreadTypeView.Text) && !string.IsNullOrEmpty(comboBoxProductDiameterView.Text) && string.IsNullOrEmpty(comboBoxMachineNumberView.Text))
                    {
                        using (var cont = new ClusterDbContext())
                        {
                            var source = database.OffsetDatas
                            .Where(u => u.Product.Diameter == convertedDiameter)
                            .Where(u => DbFunctions.TruncateTime(u.Created) == dateTimePickerForView.Value.Date)
                            .OrderByDescending(u => u.OffsetDataId).ToList();
                            listBoxViewDataList.DataSource = new BindingList<OffsetData>(source);
                        }
                    }
                    else if (string.IsNullOrEmpty(comboBoxThreadTypeView.Text) && string.IsNullOrEmpty(comboBoxProductDiameterView.Text) && !string.IsNullOrEmpty(comboBoxMachineNumberView.Text))
                    {
                        using (var cont = new ClusterDbContext())
                        {
                            var source = database.OffsetDatas
                            .Where(u => u.Machine == comboBoxMachineNumberView.Text)
                            .Where(u => DbFunctions.TruncateTime(u.Created) == dateTimePickerForView.Value.Date)
                            .OrderByDescending(u => u.OffsetDataId).ToList();
                            listBoxViewDataList.DataSource = new BindingList<OffsetData>(source);
                        }
                    }
                    else if (!string.IsNullOrEmpty(comboBoxThreadTypeView.Text) && !string.IsNullOrEmpty(comboBoxProductDiameterView.Text) && string.IsNullOrEmpty(comboBoxMachineNumberView.Text))
                    {
                        using (var cont = new ClusterDbContext())
                        {
                            var source = database.OffsetDatas.Where(u => u.Product.Diameter == convertedDiameter)
                            .Where(u => u.Product.ThreadType == comboBoxThreadTypeView.Text)
                            .Where(u => DbFunctions.TruncateTime(u.Created) == dateTimePickerForView.Value.Date)
                            .OrderByDescending(u => u.OffsetDataId).ToList();
                            listBoxViewDataList.DataSource = new BindingList<OffsetData>(source);
                        }
                    }
                    else if (!string.IsNullOrEmpty(comboBoxThreadTypeView.Text) && string.IsNullOrEmpty(comboBoxProductDiameterView.Text) && !string.IsNullOrEmpty(comboBoxMachineNumberView.Text))
                    {
                        using (var cont = new ClusterDbContext())
                        {
                            var source = database.OffsetDatas
                            .Where(u => u.Machine == comboBoxMachineNumberView.Text)
                            .Where(u => u.Product.ThreadType == comboBoxThreadTypeView.Text)
                            .Where(u => DbFunctions.TruncateTime(u.Created) == dateTimePickerForView.Value.Date)
                            .OrderByDescending(u => u.OffsetDataId).ToList();
                            listBoxViewDataList.DataSource = new BindingList<OffsetData>(source);
                        }
                    }
                    else if (string.IsNullOrEmpty(comboBoxThreadTypeView.Text) && !string.IsNullOrEmpty(comboBoxProductDiameterView.Text) && !string.IsNullOrEmpty(comboBoxMachineNumberView.Text))
                    {
                        using (var cont = new ClusterDbContext())
                        {
                            var source = database.OffsetDatas
                            .Where(u => u.Machine == comboBoxMachineNumberView.Text)
                            .Where(u => u.Product.Diameter == convertedDiameter)
                            .Where(u => DbFunctions.TruncateTime(u.Created) == dateTimePickerForView.Value.Date)
                            .OrderByDescending(u => u.OffsetDataId).ToList();
                            listBoxViewDataList.DataSource = new BindingList<OffsetData>(source);
                        }
                    }
                    else
                    {
                        using (var cont = new ClusterDbContext())
                        {
                            var source = database.OffsetDatas
                            .Where(u => u.Product.ThreadType == comboBoxThreadTypeView.Text)
                            .Where(u => u.Machine == comboBoxMachineNumberView.Text)
                            .Where(u => u.Product.Diameter == convertedDiameter)
                            .Where(u => DbFunctions.TruncateTime(u.Created) == dateTimePickerForView.Value.Date)
                            .OrderByDescending(u => u.OffsetDataId).ToList();
                        listBoxViewDataList.DataSource = new BindingList<OffsetData>(source);
                        }
                    }
                }
            }
        }

        private void listBoxViewDataList_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxViewDataList.Click += ListBoxViewDataList_Click;
        }

        private void ListBoxViewDataList_Click(object sender, EventArgs e)
        {

            OffsetData selectedOffset = (OffsetData)listBoxViewDataList.SelectedItem;
            textBoxOffsetName.Text = selectedOffset.ToString();
            textBoxCreatedBy.Text = selectedOffset.User.ToString();
            textBoxCreationDate.Text = selectedOffset.Created.ToString();
            textBoxMachineView.Text = selectedOffset.Machine;
            textBoxDiameterView.Text = selectedOffset.Product.Diameter.ToString();
            textBoxThreadTypeView.Text = selectedOffset.Product.ThreadType;
            textBoxStandoff.Text = string.Format("{0:N4}", selectedOffset.Macro.Standoff);
            textBoxStandoffSeal.Text = string.Format("{0:N4}", selectedOffset.Macro.OdSeal);
            textBoxThreadPasses.Text = string.Format("{0:N4}", selectedOffset.Macro.ThreadPass);
            textBoxZajust.Text = string.Format("{0:N4}", selectedOffset.Macro.Zajust);
            textBoxCommentView.Text = selectedOffset.Comment.ToString();
            #region X's and Z's 
            textBoxX1.Text = string.Format("{0:N4}", selectedOffset.Channel1.X1);
            textBoxX2.Text = string.Format("{0:N4}", selectedOffset.Channel1.X2);
            textBoxX3.Text = string.Format("{0:N4}", selectedOffset.Channel1.X3);
            textBoxX4.Text = string.Format("{0:N4}", selectedOffset.Channel1.X4);
            textBoxX5.Text = string.Format("{0:N4}", selectedOffset.Channel1.X5);
            textBoxX6.Text = string.Format("{0:N4}", selectedOffset.Channel1.X6);
            textBoxX7.Text = string.Format("{0:N4}", selectedOffset.Channel1.X7);
            textBoxZ1.Text = string.Format("{0:N4}", selectedOffset.Channel1.Z1);
            textBoxZ2.Text = string.Format("{0:N4}", selectedOffset.Channel1.Z2);
            textBoxZ3.Text = string.Format("{0:N4}", selectedOffset.Channel1.Z3);
            textBoxZ4.Text = string.Format("{0:N4}", selectedOffset.Channel1.Z4);
            textBoxZ5.Text = string.Format("{0:N4}", selectedOffset.Channel1.Z5);
            textBoxZ6.Text = string.Format("{0:N4}", selectedOffset.Channel1.Z6);
            textBoxZ7.Text = string.Format("{0:N4}", selectedOffset.Channel1.Z7);
            textBoxY1.Text = string.Format("{0:N4}", selectedOffset.Channel1.Y1);
            textBoxY2.Text = string.Format("{0:N4}", selectedOffset.Channel1.Y2);
            textBoxY3.Text = string.Format("{0:N4}", selectedOffset.Channel1.Y3);
            textBoxY4.Text = string.Format("{0:N4}", selectedOffset.Channel1.Y4);
            textBoxCannel2X1.Text = string.Format("{0:N4}", selectedOffset.Channel2.X1);
            textBoxCannel2X2.Text = string.Format("{0:N4}", selectedOffset.Channel2.X2);
            textBoxCannel2X3.Text = string.Format("{0:N4}", selectedOffset.Channel2.X3);
            textBoxCannel2X4.Text = string.Format("{0:N4}", selectedOffset.Channel2.X4);
            textBoxCannel2X5.Text = string.Format("{0:N4}", selectedOffset.Channel2.X5);
            textBoxCannel2X6.Text = string.Format("{0:N4}", selectedOffset.Channel2.X6);
            textBoxCannel2X7.Text = string.Format("{0:N4}", selectedOffset.Channel2.X7);
            textBoxCannel2Z1.Text = string.Format("{0:N4}", selectedOffset.Channel2.Z1);
            textBoxCannel2Z2.Text = string.Format("{0:N4}", selectedOffset.Channel2.X2);
            textBoxCannel2Z3.Text = string.Format("{0:N4}", selectedOffset.Channel2.X3);
            textBoxCannel2Z4.Text = string.Format("{0:N4}", selectedOffset.Channel2.X4);
            textBoxCannel2Z5.Text = string.Format("{0:N4}", selectedOffset.Channel2.X5);
            textBoxCannel2Z6.Text = string.Format("{0:N4}", selectedOffset.Channel2.X6);
            textBoxCannel2Z7.Text = string.Format("{0:N4}", selectedOffset.Channel2.X7);
            #endregion
        }
    }
}
