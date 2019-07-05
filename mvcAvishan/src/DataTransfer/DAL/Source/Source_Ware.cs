using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransfer.DAL.Source
{
    class Source_Ware
    {
        private DAO dao;
        private SqlCommand cmd;
        public List<Target_Ware> Get_Ware()
        {

            List<Target_Ware> list = new List<Target_Ware>();
            dao = new DAO(DBConnection.enConnectionType.SourceConnectionString);
            cmd = new SqlCommand();
            cmd.CommandText = "SELECT  dbo.WARE.WARE_ID, dbo.WARE.WARE_NAME_VC, dbo.WARE.WARE_PRICE_IN, dbo.WARE_CATEGORY.WARE_CATEGORY_ID, dbo.WARE_CATEGORY.WARE_CATEGOR_NAME_VC, " +
                        " dbo.WARE_CATEGORY.WARE_CATEGORY_TYPE_ID, dbo.WARE_CATEGORY_TYPE.WARE_CATEGORY_TYPE_NAME_VC, dbo.WARE_CATEGORY.WARE_CATEGORY_ACTIVE_BL, " +
                        " dbo.GIVE_FOOD_PLACE.GIVE_FOOD_PLACE_ID, dbo.GIVE_FOOD_PLACE.GIVE_FOOD_PLACE_NAME_VC, count(dbo.FACTURE_CONTAINER.WARE_ID) AS OrderCount " +
"FROM dbo.WARE INNER JOIN " +
                  "       dbo.WARE_CATEGORY ON dbo.WARE.WARE_CATEGORY_ID = dbo.WARE_CATEGORY.WARE_CATEGORY_ID INNER JOIN " +
                   "      dbo.WARE_CATEGORY_TYPE ON dbo.WARE_CATEGORY.WARE_CATEGORY_TYPE_ID = dbo.WARE_CATEGORY_TYPE.WARE_CATEGORY_TYPE_ID INNER JOIN " +
                   "      dbo.GIVE_FOOD_PLACE ON dbo.WARE.GIVE_FOOD_PLACE_ID = dbo.GIVE_FOOD_PLACE.GIVE_FOOD_PLACE_ID INNER JOIN " +
                      "   dbo.FACTURE_CONTAINER ON dbo.WARE.WARE_ID = dbo.FACTURE_CONTAINER.WARE_ID " +
" WHERE(dbo.WARE_CATEGORY_TYPE.WARE_CATEGORY_TYPE_ID <> 3) " +

" group by   dbo.WARE.WARE_ID, dbo.WARE.WARE_NAME_VC, dbo.WARE.WARE_PRICE_IN, dbo.WARE_CATEGORY.WARE_CATEGORY_ID, dbo.WARE_CATEGORY.WARE_CATEGOR_NAME_VC,  " +
                "         dbo.WARE_CATEGORY.WARE_CATEGORY_TYPE_ID, dbo.WARE_CATEGORY_TYPE.WARE_CATEGORY_TYPE_NAME_VC, dbo.WARE_CATEGORY.WARE_CATEGORY_ACTIVE_BL,  " +
                    "     dbo.GIVE_FOOD_PLACE.GIVE_FOOD_PLACE_ID, dbo.GIVE_FOOD_PLACE.GIVE_FOOD_PLACE_NAME_VC; ";
           
                    SqlDataReader sqlDataReader = dao.ExeDataReader(cmd);

            while (sqlDataReader.Read())
            {
                Target_Ware target_Ware = new Target_Ware();

                target_Ware.WareId = Convert.ToInt32(sqlDataReader["WARE_ID"]);
                target_Ware.WareTitle = Convert.ToString(sqlDataReader["WARE_NAME_VC"]);
                target_Ware.WarePrice = Convert.ToDecimal(sqlDataReader["WARE_PRICE_IN"]);
                target_Ware.IsActive = Convert.ToBoolean(sqlDataReader["WARE_PRICE_IN"]);
                target_Ware.WarePlace = Convert.ToInt32(sqlDataReader["GIVE_FOOD_PLACE_ID"]);
                target_Ware.OrderCount = Convert.ToInt32(sqlDataReader["OrderCount"]);

                list.Add(target_Ware);
            }

            return list;

        }
    }

   [Serializable]
   public class Target_Ware
    {
        public  int WareId { get; set; }
        public string WareTitle { get; set; }
        public int WareKind { get; set; }
        public int WarePlace { get; set; }
        public decimal WarePrice { get; set; }
       
        public bool IsActive { get; set; }

        public int OrderCount { get; set; }

    }
}
