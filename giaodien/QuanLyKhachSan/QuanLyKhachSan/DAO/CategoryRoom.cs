using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    internal class CategoryRoom
    {
        public CategoryRoom GetCategoryRoomById(int id)
        {
            CategoryRoom category = null;

            string q = "Select  * from DANHMUCPHONG where MAPHONG = " + id;

            DataTable dt = DataProvider.Instance.ExecuteQuery(q);

            foreach (DataRow dr in dt.Rows)
            {
                category = new CategoryRoom();
                return category;
            }
            return category;
        }
    }
}
