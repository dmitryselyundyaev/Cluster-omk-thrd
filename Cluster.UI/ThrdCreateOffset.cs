using Cluster.BL;
using Cluster.BL.Model.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Cluster.UI
{
    public partial class ThrdCreateOffset<T> : Form
        where T : class
    {
        readonly ClusterDbContext database;
        readonly DbSet<T> set;
        public ThrdCreateOffset(DbSet<T> set, ClusterDbContext db)
        {
            database = new ClusterDbContext();
            InitializeComponent();
            this.database = db;
            this.set = set;
            set.Load();
            database.SaveChanges();
        }

        private void SaveOffsetToDB_Click(object sender, System.EventArgs e)
        {
            set.Load();
            labelIsSaved.Hide();
            if (string.IsNullOrEmpty(comboBoxThreadType.Text) || string.IsNullOrEmpty(comboBoxProductDiameter.Text) || string.IsNullOrEmpty(comboBoxMachineNumber.Text))
            {
                MessageBox.Show("Заполните параметры сортамента", "Ошибка заполнения данных",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (string.IsNullOrEmpty(comboBoxThreadType.Text))
                {
                    comboBoxThreadType.BackColor = Color.Red;
                }
                if (string.IsNullOrEmpty(comboBoxProductDiameter.Text))
                {
                    comboBoxProductDiameter.BackColor = Color.Red;
                }
                if (string.IsNullOrEmpty(comboBoxMachineNumber.Text))
                {
                    comboBoxMachineNumber.BackColor = Color.Red;
                }
            }

            else
            {

                var systemName = Environment.UserName;
                UserData currentUser;
                using (var cont = new ClusterDbContext())
                {
                    if (database.UsersData.Any(u => u.UserName == systemName))
                    {
                        currentUser = database.UsersData.FirstOrDefault(u => u.UserName == systemName);
                    }
                    else
                    {
                        currentUser = new UserData();
                        currentUser.UserName = systemName;
                        database.UsersData.Add(currentUser);
                        database.SaveChanges();
                    }
                }
                #region Getting data from text box.
                var addedCh1 = new ChannelOne();
                addedCh1.X1 = Convert.ToDecimal(maskedTextBoxX1.Text);
                addedCh1.Z1 = Convert.ToDecimal(maskedTextBoxZ1.Text);
                addedCh1.X2 = Convert.ToDecimal(maskedTextBoxX2.Text);
                addedCh1.Z2 = Convert.ToDecimal(maskedTextBoxZ2.Text);
                addedCh1.X3 = Convert.ToDecimal(maskedTextBoxX3.Text);
                addedCh1.Z3 = Convert.ToDecimal(maskedTextBoxZ3.Text);
                addedCh1.X4 = Convert.ToDecimal(maskedTextBoxX4.Text);
                addedCh1.Z4 = Convert.ToDecimal(maskedTextBoxZ4.Text);
                addedCh1.X5 = Convert.ToDecimal(maskedTextBoxX5.Text);
                addedCh1.Z5 = Convert.ToDecimal(maskedTextBoxZ5.Text);
                addedCh1.X6 = Convert.ToDecimal(maskedTextBoxX6.Text);
                addedCh1.Z6 = Convert.ToDecimal(maskedTextBoxZ6.Text);
                addedCh1.X7 = Convert.ToDecimal(maskedTextBoxX7.Text);
                addedCh1.Z7 = Convert.ToDecimal(maskedTextBoxZ7.Text);
                addedCh1.Y1 = Convert.ToDecimal(maskedTextBoxY1.Text);
                addedCh1.Y2 = Convert.ToDecimal(maskedTextBoxY2.Text);
                addedCh1.Y3 = Convert.ToDecimal(maskedTextBoxY3.Text);
                addedCh1.Y4 = Convert.ToDecimal(maskedTextBoxY4.Text);
                var addedCh2 = new ChannelTwo();
                addedCh2.X1 = Convert.ToDecimal(maskedTextBoxCH2X1.Text);
                addedCh2.Z1 = Convert.ToDecimal(maskedTextBoxCH2Z1.Text);
                addedCh2.X2 = Convert.ToDecimal(maskedTextBoxCH2X2.Text);
                addedCh2.Z2 = Convert.ToDecimal(maskedTextBoxCH2Z2.Text);
                addedCh2.X3 = Convert.ToDecimal(maskedTextBoxCH2X3.Text);
                addedCh2.Z3 = Convert.ToDecimal(maskedTextBoxCH2Z3.Text);
                addedCh2.X4 = Convert.ToDecimal(maskedTextBoxCH2X4.Text);
                addedCh2.Z4 = Convert.ToDecimal(maskedTextBoxCH2Z4.Text);
                addedCh2.X5 = Convert.ToDecimal(maskedTextBoxCH2X5.Text);
                addedCh2.Z5 = Convert.ToDecimal(maskedTextBoxCH2Z5.Text);
                addedCh2.X6 = Convert.ToDecimal(maskedTextBoxCH2X6.Text);
                addedCh2.Z6 = Convert.ToDecimal(maskedTextBoxCH2Z6.Text);
                addedCh2.X7 = Convert.ToDecimal(maskedTextBoxCH2X7.Text);
                addedCh2.Z7 = Convert.ToDecimal(maskedTextBoxCH2Z7.Text);
                var addedOffset = new Macro();
                addedOffset.OdSeal = Convert.ToDecimal(maskedTextBoxSealStandoff.Text);
                addedOffset.Standoff = Convert.ToDecimal(maskedTextBoxStandoff.Text);
                if (string.IsNullOrEmpty(maskedTextBoxThrPass.Text) || Convert.ToDouble(maskedTextBoxThrPass.Text) <= 0)
                {
                    addedOffset.ThreadPass = 1;
                }
                else
                {
                    addedOffset.ThreadPass = Convert.ToDecimal(maskedTextBoxThrPass.Text);
                }
                addedOffset.Zajust = Convert.ToDecimal(maskedTextBoxZajust.Text);
                addedOffset.Conicity = Convert.ToDecimal(maskedTextBoxConicity.Text);
                var addedGeometry = new ProductType();
                addedGeometry.Diameter = Convert.ToInt32(comboBoxProductDiameter.Text);
                addedGeometry.ThreadType = comboBoxThreadType.Text;
                database.ProductsTypes.Add(addedGeometry);
                database.ChannelOneDatas.Add(addedCh1);
                database.ChannelTwoDatas.Add(addedCh2);
                database.Macros.Add(addedOffset);
                var offsetAdd = new OffsetData();
                offsetAdd.Channel1 = addedCh1;
                offsetAdd.Channel2 = addedCh2;
                offsetAdd.Macro = addedOffset;
                offsetAdd.Product = addedGeometry;
                offsetAdd.UserId = currentUser.UserId;
                offsetAdd.Machine = comboBoxMachineNumber.Text;
                offsetAdd.Created = DateTime.Now;
                offsetAdd.Comment = textBoxComment.Text;
                var dbCount = database.OffsetDatas.Count();
                database.OffsetDatas.Add(offsetAdd);
                using (var cont = new ClusterDbContext())
                {
                    database.OffsetDatas.Add(offsetAdd);
                    database.SaveChanges();

                }
                #endregion
                
                database.SaveChanges();
                if (database.OffsetDatas.Count() > dbCount)
                {
                    labelIsSaved.Show();
                }
                else
                {
                    labelIsSaved.BackColor = Color.Red;
                    labelIsSaved.Text = "Не выполнено";
                    labelIsSaved.Show();
                }
            }
        }
    }
}
