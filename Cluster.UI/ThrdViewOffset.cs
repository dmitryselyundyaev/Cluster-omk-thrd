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
            //database.SaveChanges();
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
                        var source = database.OffsetDatas.Where(u => u.Created.ToString().Substring(0, 10) == dateTimePickerForView.Value.Date.ToString().Substring(0, 10)).OrderByDescending(u => u.OffsetDataId).ToList();
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
                            .Where(u => u.Created.ToString().Substring(0, 10) == dateTimePickerForView.Value.Date.ToString().Substring(0, 10))
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
                            .Where(u => u.Created.ToString().Substring(0, 10) == dateTimePickerForView.Value.Date.ToString().Substring(0, 10))
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
                            .Where(u => u.Created.ToString().Substring(0, 10) == dateTimePickerForView.Value.Date.ToString().Substring(0, 10))
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
                            .Where(u => u.Created.ToString().Substring(0, 10) == dateTimePickerForView.Value.Date.ToString().Substring(0, 10))
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
                            .Where(u => u.Created.ToString().Substring(0, 10) == dateTimePickerForView.Value.Date.ToString().Substring(0, 10))
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
                            .Where(u => u.Created.ToString().Substring(0, 10) == dateTimePickerForView.Value.Date.ToString().Substring(0, 10))
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
                            .Where(u => u.Created.ToString().Substring(0, 10) == dateTimePickerForView.Value.Date.ToString().Substring(0, 10))
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
            if (listBoxViewDataList.SelectedItem != null)
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
                textBoxConicity.Text = string.Format("{0:N4}", selectedOffset.Macro.Conicity);
                textBoxCommentView.Text = selectedOffset.Comment.ToString();
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
                textBoxY5.Text = string.Format("{0:N4}", selectedOffset.Channel1.Y5);
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
            }

            if (textBoxCreatedBy.Text == Environment.UserName)
            {
                buttonChangeData.Visible = true;
            }
            else
            {
                buttonChangeData.Visible = false;
            }
            buttonSaveChanges.Visible = false;
            buttonChangeData.BackColor = default;
            ReadOnlyButtons(true);
        }

        private void buttonDeleteFromDB_Click(object sender, EventArgs e)
        {
            if (listBoxViewDataList.SelectedItem != null && textBoxPassword.Text == "yfkflxbr")
            {
                using (var cont = new ClusterDbContext())
                {
                    OffsetData selectedOffset = (OffsetData)listBoxViewDataList.SelectedItem;

                    database.OffsetDatas.Remove((OffsetData)selectedOffset);
                    database.SaveChanges();
                    SearchButton_Click(sender, e);
                    if (buttonChangeData.BackColor == System.Drawing.Color.Maroon)
                    {
                        buttonSaveChanges.Visible = false;
                        buttonChangeData.Visible = false;
                        buttonChangeData.BackColor = default;
                    }
                }
            }
            else
            {
                MessageBox.Show("Введите пароль", "Неверный пароль", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReadOnlyButtons(bool condition)
        {
            if (condition == true)
            {
                textBoxStandoff.ReadOnly = true;
                textBoxStandoffSeal.ReadOnly = true;
                textBoxThreadPasses.ReadOnly = true;
                textBoxZajust.ReadOnly = true;
                textBoxConicity.ReadOnly = true;
                textBoxCommentView.ReadOnly = true;
                textBoxX1.ReadOnly = true;
                textBoxX2.ReadOnly = true;
                textBoxX3.ReadOnly = true;
                textBoxX4.ReadOnly = true;
                textBoxX5.ReadOnly = true;
                textBoxX6.ReadOnly = true;
                textBoxX7.ReadOnly = true;
                textBoxZ1.ReadOnly = true;
                textBoxZ2.ReadOnly = true;
                textBoxZ3.ReadOnly = true;
                textBoxZ4.ReadOnly = true;
                textBoxZ5.ReadOnly = true;
                textBoxZ6.ReadOnly = true;
                textBoxZ7.ReadOnly = true;
                textBoxY1.ReadOnly = true;
                textBoxY2.ReadOnly = true;
                textBoxY3.ReadOnly = true;
                textBoxY4.ReadOnly = true;
                textBoxY5.ReadOnly = true;
                textBoxCannel2X1.ReadOnly = true;
                textBoxCannel2X2.ReadOnly = true;
                textBoxCannel2X3.ReadOnly = true;
                textBoxCannel2X4.ReadOnly = true;
                textBoxCannel2X5.ReadOnly = true;
                textBoxCannel2X6.ReadOnly = true;
                textBoxCannel2X7.ReadOnly = true;
                textBoxCannel2Z1.ReadOnly = true;
                textBoxCannel2Z2.ReadOnly = true;
                textBoxCannel2Z3.ReadOnly = true;
                textBoxCannel2Z4.ReadOnly = true;
                textBoxCannel2Z5.ReadOnly = true;
                textBoxCannel2Z6.ReadOnly = true;
                textBoxCannel2Z7.ReadOnly = true;
            }
            else
            {
                textBoxStandoff.ReadOnly = false;
                textBoxStandoffSeal.ReadOnly = false;
                textBoxThreadPasses.ReadOnly = false;
                textBoxZajust.ReadOnly = false;
                textBoxConicity.ReadOnly = false;
                textBoxCommentView.ReadOnly = false;
                textBoxX1.ReadOnly = false;
                textBoxX2.ReadOnly = false;
                textBoxX3.ReadOnly = false;
                textBoxX4.ReadOnly = false;
                textBoxX5.ReadOnly = false;
                textBoxX6.ReadOnly = false;
                textBoxX7.ReadOnly = false;
                textBoxZ1.ReadOnly = false;
                textBoxZ2.ReadOnly = false;
                textBoxZ3.ReadOnly = false;
                textBoxZ4.ReadOnly = false;
                textBoxZ5.ReadOnly = false;
                textBoxZ6.ReadOnly = false;
                textBoxZ7.ReadOnly = false;
                textBoxY1.ReadOnly = false;
                textBoxY2.ReadOnly = false;
                textBoxY3.ReadOnly = false;
                textBoxY4.ReadOnly = false;
                textBoxY5.ReadOnly = false;
                textBoxCannel2X1.ReadOnly = false;
                textBoxCannel2X2.ReadOnly = false;
                textBoxCannel2X3.ReadOnly = false;
                textBoxCannel2X4.ReadOnly = false;
                textBoxCannel2X5.ReadOnly = false;
                textBoxCannel2X6.ReadOnly = false;
                textBoxCannel2X7.ReadOnly = false;
                textBoxCannel2Z1.ReadOnly = false;
                textBoxCannel2Z2.ReadOnly = false;
                textBoxCannel2Z3.ReadOnly = false;
                textBoxCannel2Z4.ReadOnly = false;
                textBoxCannel2Z5.ReadOnly = false;
                textBoxCannel2Z6.ReadOnly = false;
                textBoxCannel2Z7.ReadOnly = false;
            }
        }
        private void buttonChangeData_Click(object sender, EventArgs e)
        {
            if (textBoxCreatedBy.Text == Environment.UserName)
            {
                ReadOnlyButtons(false);
                buttonSaveChanges.Visible = true;
                buttonChangeData.BackColor = System.Drawing.Color.Maroon;

            }
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            OffsetData selectedOffset = (OffsetData)listBoxViewDataList.SelectedItem;
            if (selectedOffset != null)
            {
                try
                {
                    selectedOffset.Macro.Standoff = decimal.Parse(textBoxStandoff.Text);
                    selectedOffset.Macro.OdSeal = decimal.Parse(textBoxStandoffSeal.Text);
                    selectedOffset.Macro.ThreadPass = decimal.Parse(textBoxThreadPasses.Text);
                    selectedOffset.Macro.Zajust = decimal.Parse(textBoxZajust.Text);
                    selectedOffset.Macro.Conicity = decimal.Parse(textBoxConicity.Text);
                    selectedOffset.Comment = textBoxCommentView.Text;
                    selectedOffset.Channel1.X1 = decimal.Parse(textBoxX1.Text);
                    selectedOffset.Channel1.X2 = decimal.Parse(textBoxX2.Text);
                    selectedOffset.Channel1.X3 = decimal.Parse(textBoxX3.Text);
                    selectedOffset.Channel1.X4 = decimal.Parse(textBoxX4.Text);
                    selectedOffset.Channel1.X5 = decimal.Parse(textBoxX5.Text);
                    selectedOffset.Channel1.X6 = decimal.Parse(textBoxX6.Text);
                    selectedOffset.Channel1.X7 = decimal.Parse(textBoxX7.Text);
                    selectedOffset.Channel1.Z1 = decimal.Parse(textBoxZ1.Text);
                    selectedOffset.Channel1.Z2 = decimal.Parse(textBoxZ2.Text);
                    selectedOffset.Channel1.Z3 = decimal.Parse(textBoxZ3.Text);
                    selectedOffset.Channel1.Z4 = decimal.Parse(textBoxZ4.Text);
                    selectedOffset.Channel1.Z5 = decimal.Parse(textBoxZ5.Text);
                    selectedOffset.Channel1.Z6 = decimal.Parse(textBoxZ6.Text);
                    selectedOffset.Channel1.Z7 = decimal.Parse(textBoxZ7.Text);
                    selectedOffset.Channel1.Y1 = decimal.Parse(textBoxY1.Text);
                    selectedOffset.Channel1.Y2 = decimal.Parse(textBoxY2.Text);
                    selectedOffset.Channel1.Y3 = decimal.Parse(textBoxY3.Text);
                    selectedOffset.Channel1.Y4 = decimal.Parse(textBoxY4.Text);
                    selectedOffset.Channel1.Y5 = decimal.Parse(textBoxY5.Text);
                    selectedOffset.Channel2.X1 = decimal.Parse(textBoxCannel2X1.Text);
                    selectedOffset.Channel2.X2 = decimal.Parse(textBoxCannel2X2.Text);
                    selectedOffset.Channel2.X3 = decimal.Parse(textBoxCannel2X3.Text);
                    selectedOffset.Channel2.X4 = decimal.Parse(textBoxCannel2X4.Text);
                    selectedOffset.Channel2.X5 = decimal.Parse(textBoxCannel2X5.Text);
                    selectedOffset.Channel2.X6 = decimal.Parse(textBoxCannel2X6.Text);
                    selectedOffset.Channel2.X7 = decimal.Parse(textBoxCannel2X7.Text);
                    selectedOffset.Channel2.Z1 = decimal.Parse(textBoxCannel2Z1.Text);
                    selectedOffset.Channel2.X2 = decimal.Parse(textBoxCannel2Z2.Text);
                    selectedOffset.Channel2.X3 = decimal.Parse(textBoxCannel2Z3.Text);
                    selectedOffset.Channel2.X4 = decimal.Parse(textBoxCannel2Z4.Text);
                    selectedOffset.Channel2.X5 = decimal.Parse(textBoxCannel2Z5.Text);
                    selectedOffset.Channel2.X6 = decimal.Parse(textBoxCannel2Z6.Text);
                    selectedOffset.Channel2.X7 = decimal.Parse(textBoxCannel2Z7.Text);
                    MessageBox.Show("Сохранено", "Данные обновлены", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    database.SaveChanges();
                    ReadOnlyButtons(true);
                    buttonSaveChanges.Visible = false;
                    buttonChangeData.BackColor = default;

                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("NullReferenceException", "Ошибка сохранения",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show("Проверьте корректность введенных данных", "Ошибка сохранения",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                buttonSaveChanges.Visible = false;
                buttonChangeData.BackColor = default;
            }

        }
    }
}
