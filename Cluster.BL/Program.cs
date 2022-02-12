using Cluster.BL.Model.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cluster.BL
{
    class Program
    {
        static void Main(string[] args)
        {
            UserData vvv= new UserData();
            vvv.UserName = "Johun";
            UserData vv1 = new UserData();
            vv1.UserName = "Johu2n";
            UserData vv3 = new UserData();
            vv3.UserName = "Joh3un";

            var cont = new ClusterDbContext();
            cont.UsersData.Add(vvv);
            cont.UsersData.Add(vv1);
            cont.UsersData.Add(vv3);
            cont.SaveChanges();
            var addedCh1 = new ChannelOne();
            addedCh1.X1 = Convert.ToDecimal(4);
            addedCh1.Z1 = Convert.ToDecimal(4);
            addedCh1.X2 = Convert.ToDecimal(4);
            addedCh1.Z2 = Convert.ToDecimal(4);
            addedCh1.X3 = Convert.ToDecimal(4);
            addedCh1.Z3 = Convert.ToDecimal(2);

            var addedCh2 = new ChannelTwo();
            addedCh2.X1 = Convert.ToDecimal(12);
            addedCh2.Z1 = Convert.ToDecimal(213);

            var addedOffset = new Macro();
            addedOffset.OdSeal = Convert.ToDecimal(4);
            addedOffset.ThreadPass = 1;
            addedOffset.Standoff = Convert.ToDecimal(2);

            addedOffset.Zajust = Convert.ToDecimal(87);
            addedOffset.Conicity = Convert.ToDecimal(3456);
            var addedGeometry = new ProductType();
            addedGeometry.Diameter = Convert.ToInt32(222);
            addedGeometry.ThreadType = "dsadas";
            cont.ProductsTypes.Add(addedGeometry);
            cont.ChannelOneDatas.Add(addedCh1);
            cont.ChannelTwoDatas.Add(addedCh2);
            cont.Macros.Add(addedOffset);
            var offsetAdd = new OffsetData();
            offsetAdd.Channel1 = addedCh1;
            offsetAdd.Channel2 = addedCh2;
            offsetAdd.Macro = addedOffset;
            offsetAdd.Product = addedGeometry;
            offsetAdd.UserId = 3;
            offsetAdd.Machine = "HYC";
            offsetAdd.Created = DateTime.Now;
            offsetAdd.Comment = "dsaasd";
            cont.OffsetDatas.Add(offsetAdd);
            var ooo = 0;
            cont.SaveChanges();
            Console.WriteLine(cont.UsersData.Where(u=>u.UserId == 1).ToString());
            Console.WriteLine(System.Net.CredentialCache.DefaultCredentials.ToString());
            Console.ReadKey();

        }
    }
}
