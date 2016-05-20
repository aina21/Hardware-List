using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fatemeh_HardWare.Data
{
    class Group_Data
    {
        /// <summary>
        /// دیتا مدل
        /// </summary>
        private DataClasses1DataContext db = new DataClasses1DataContext();

        /// <summary>
        /// کد گروه
        /// </summary>
        private int _code;

        /// <summary>
        /// نام گروه
        /// </summary>
        private string _name;

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

        public Group_Data()
        { }

        public Group_Data(int code)
        {
            var g = db.tblGroups.First(item => item.group_code == code);
            Name = g.group_name;
            Code = g.group_code;
        }
        /// <summary>
        /// انتخاب همه اطلاعات جدول گروه
        /// </summary>
        /// <returns>جدول گروه</returns>
        public IEnumerable<Group_Data> SelectAll()
        {
            return
                from a in db.tblGroups
                select new Group_Data
                {
                    Code = a.group_code,
                    Name = a.group_name,
                };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public bool CheckCode(int code)
        {
            return db.tblGroups.Any(item => item.group_code == code);


        }

        public string GetName(int code)
        {
            var g = db.tblGroups.First(item => item.group_code == code);
            return g.group_name;
        }

    }
}
