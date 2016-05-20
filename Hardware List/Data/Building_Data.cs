using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace fatemeh_HardWare.Data
{
    class Building_Data
    {
        /// <summary>
        /// دیتا مدل
        /// </summary>
        private DataClasses1DataContext db = new DataClasses1DataContext();

        /// <summary>
        /// کد ساختمان
        /// </summary>
        private int _code;

        /// <summary>
        /// نام ساختمان
        /// </summary>
        private string _name;

        /// <summary>
        /// تعداد اتاق های ساختمان
        /// </summary>
        private int _valueRoom;

        /// <summary>
        /// property code
        /// </summary>
        public int Code
        {
            get { return _code; }
            set { _code = value; }
        }

        /// <summary>
        /// property name
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// property value room
        /// </summary>
        public int ValueRoom
        {
            get { return _valueRoom; }
            private set { _valueRoom = value; }
        }

        public Building_Data()
        { }

        public Building_Data(int code)
        {
            var b = db.tblBuildings.First(item => item.building_code == code);
            Name = b.building_name;
            Code = b.building_code;
        }
        /// <summary>
        /// انتخاب همه اطلاعات جدول ساختمان
        /// </summary>
        /// <returns>جدول ساختمان</returns>
        public IEnumerable<Building_Data> SelectAllBulding()
        {
            return
                from a in db.tblBuildings
                select new Building_Data
                {
                    Code = a.building_code,
                    Name = a.building_name,
                };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public bool CheckCode(int code)
        {
            return db.tblBuildings.Any(item => item.building_code == code);
        }

        
        
    }
}
