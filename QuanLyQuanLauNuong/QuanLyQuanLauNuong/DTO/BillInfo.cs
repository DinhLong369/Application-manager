using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanLauNuong.DTO
{
    public class BillInfo
    {
        private int id;
        private int idBill;
        private int idFood;
        private int count;
        public BillInfo(int id, int idBill, int idFood, int count)
        {
            Id = id;
            IdBill = idBill;
            IdFood = idFood;
            Count = count;
        }

        public BillInfo(DataRow row)
        {
            Id = (int)row["id"];
            IdBill = (int)row["idbill"];
            IdFood =(int)row["idfood"];
            Count = (int)row["count"];
        }

        public int Id { get => id; set => id = value; }
        public int IdBill { get => idBill; set => idBill = value; }
        public int IdFood { get => idFood; set => idFood = value; }
        public int Count { get => count; set => count = value; }
    }
}
