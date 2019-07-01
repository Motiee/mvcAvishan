using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransfer.DAL.Source
{
    class Source_Setting
    {
        private DAO dao;
        private SqlCommand cmd;
        public Target_Setting Get_Setting()
        {

            Target_Setting target_Setting = new Target_Setting();
            dao = new DAO(DBConnection.enConnectionType.SourceConnectionString);
            cmd = new SqlCommand();
            cmd.CommandText = "select [SETTING_ID],[SETTING_NAME_VC],[SETTING_VALUE_VC],[SETTING_DESCRIPTION_VC] FROM[RASBankAccounting].[dbo].[SETTINGS] where[SETTING_ID] in (16,18,19,108)";
            SqlDataReader sqlDataReader = dao.ExeDataReader(cmd);

            while (sqlDataReader.Read())
            {
                Int32 SETTING_ID;
                SETTING_ID = Convert.ToInt32(sqlDataReader["SETTING_ID"]);
                if (SETTING_ID == 16) { target_Setting.RestaurantTitle = Convert.ToString(sqlDataReader["SETTING_VALUE_VC"]); }
                if (SETTING_ID == 18) { target_Setting.RestaurantAddress = Convert.ToString(sqlDataReader["SETTING_VALUE_VC"]); }
                if (SETTING_ID == 19) { target_Setting.Phone = Convert.ToString(sqlDataReader["SETTING_VALUE_VC"]); }
                if (SETTING_ID == 108) {}

              
            }

            return target_Setting;

        }
    }

    [Serializable]
    public class Target_Setting
    {
        public string RestaurantTitle { get; set; }
        public string RestaurantAddress { get; set; }
        public string Phone { get; set; }
    }
}
