using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fatemeh_HardWare.Data
{
    class Equipment_Data
    {
        /// <summary>
        /// دیتا مدل
        /// </summary>
        private DataClasses1DataContext db = new DataClasses1DataContext();

        private int _code;

        public int Code
        {
            private set
            { }
            get
            {
                var c = db.tblEquipments.OrderByDescending(u => u.equipment_code).FirstOrDefault();
                _code = Convert.ToInt32(c.equipment_code);
                return _code;
            }
        }

        public Equipment_Data(int hardware,string model ,string warranty ,  string warBegin , string warEnd , int state,int person)
        {
            tblWarranty tblw = new tblWarranty
            {
                warranty_name = warranty,
                warranty_start = warBegin ,
                warranty_end = warEnd
            };
            db.tblWarranties.InsertOnSubmit(tblw);
            db.SubmitChanges();
           
            tblEquipment tble = new tblEquipment
            {
               hardware_code = hardware ,
               equipment_model = model ,
               warranty_code = tblw.warranty_code ,
               state_code = state ,
               equipment_freez = false
            };
            db.tblEquipments.InsertOnSubmit(tble);
            db.SubmitChanges();

            tblReport tblr = new tblReport
            {
                Equimpment_code = tble.equipment_code,
                Person_code = person,
                Data = DateTime.Now.ToShortDateString()
            };
            db.tblReports.InsertOnSubmit(tblr);
            db.SubmitChanges();
          
        }

        public Equipment_Data()
        { }

        public int GetPersonCode(int p)
        {
            return db.tblPersons.First(item => item.person_code == p).person_code;
        }

        internal bool CheckCode(int code)
        {
            return (db.tblEquipments.Any(item => item.equipment_code == code));
        }

        internal bool CheckCodeState(int value)
        {
            return db.tblStates.Any(item => item.state_code == value);
        }

        internal tblEquipment SelectEquipment(int code)
        {
            var e = db.tblEquipments.First(item => item.equipment_code == code);
            return e;
        }

        internal tblWarranty SelectWarranty(int code)
        {
            var w = db.tblWarranties.First(item => item.warranty_code == code);
            return w;
        }

        internal tblState SelectState(int code)
        {
            var s = db.tblStates.First(item => item.state_code == code);
            return s;
        }

        internal bool CheckCodeHardWare(int value)
        {
            return db.tblHardwares.Any(item => item.hardware_code == value);
        }

        internal tblHardware SelectHardware(int code)
        {
            var h = db.tblHardwares.First(item => item.hardware_code == code);
            return h;
        }

        internal bool Freezed_Data(int code)
        {
            var e = db.tblEquipments.First(item => item.equipment_code == code);
            return (e.equipment_freez);
        }

        internal void Freezing_Data(int code)
        {
            var e = db.tblEquipments.First(item => item.equipment_code == code);
            if (!Freezed_Data(code))
                e.equipment_freez = true;
            db.SubmitChanges();
        }

        internal IEnumerable<Equipment_Data> SelectAllState()
        {
            return from a in db.tblStates
                   where a.state_code == 1 || a.state_code == 2 
                select new Equipment_Data
                {
                    CodeState= a.state_code,
                    NameState = a.state_name,
                };
        }

        internal IEnumerable<Equipment_Data> SelectAllHardwares()
        {
            return from a in db.tblHardwares
                   select new Equipment_Data
                   {
                       CodeHardware = a.hardware_code,
                       NameHardware = a.hardware_name,
                   };
        }

        internal IEnumerable<Equipment_Data> SelectAllPersons()
        {
            return from a in db.tblPersons
                   where a.person_fireezing == false
                   select new Equipment_Data
                   {
                       CodePerson = a.person_code
                   };
        }

        public int CodeHardware { get; set; }

        public string NameHardware { get; set; }

        public int CodeState { get; set; }

        public string NameState { get; set; }



        public int CodePerson { get; set; }

        internal string GetStateCode(int p)
        {
            return db.tblStates.First(item => item.state_code == p).state_name;
        }

        internal string GetHardwareCode(int p)
        {
            return db.tblHardwares.First(item => item.hardware_code == p).hardware_name;
        }

        internal void Update(int code, int hardware, string model, string warranty, string warBegin, string warEnd, int state)
        {
            var e = db.tblEquipments.First(item => item.equipment_code == code);
            e.hardware_code = hardware;
            e.equipment_model = model;
            e.state_code = state;
            db.SubmitChanges();

            var w = db.tblWarranties.First(item => item.warranty_code == e.warranty_code);
            w.warranty_name=warranty;
            w.warranty_start = warBegin;
            w.warranty_end = warEnd;
            db.SubmitChanges();
        }

        internal object Search(string type, string value)
        {
            if (type == "نوع")
            {
                var e = from equipment in db.tblEquipments
                        join h in db.tblHardwares on equipment.hardware_code equals h.hardware_code into equipmentGroup
                        from per2 in equipmentGroup
                        where per2.hardware_name == value
                        select equipment ;
                return e;
            }
            else if (type == "مدل")
            {
                var e = db.tblEquipments.Where(item => item.equipment_model == value);
                return e;
            }
            else if (type == "گارانتی")
            {
                var e = from equipment in db.tblEquipments
                        join w in db.tblWarranties on equipment.warranty_code equals w.warranty_code into equipmentGroup
                        from per2 in equipmentGroup
                        where per2.warranty_name == value
                        select equipment;
                return e;
            }
          
            else
            {
                throw new Exception("انتخاب شما نادرست است");
            }
        }

        internal IEnumerable<Equipment_Data> SelectAllEquipmentOfPerson(int perCod)
        {
            return
                from r in db.tblReports
                join p in db.tblPersons on r.Person_code equals p.person_code 
                join e in db.tblEquipments on r.Equimpment_code equals e.equipment_code
                join h in db.tblHardwares on e.hardware_code equals h.hardware_code
                where p.person_code== perCod && e.equipment_freez== false
                select new Equipment_Data
                {
                    CodeEquipment = e.equipment_code,
                    NameEquipment = e.equipment_model,
                    NameHardware = h.hardware_name ,
                    CodeHardware = h.hardware_code 
                };
        }

        public int CodeEquipment { get; set; }

        public string NameEquipment { get; set; }



        internal void ChangeStatus(int code, int personCode , string tozih)
        {
            var r = db.tblReports.First(item => item.Equimpment_code == code && item.Person_code == personCode);
            r.Tozihat = tozih;
            r.Data = DateTime.Now.ToString();
            db.SubmitChanges();
            var e = db.tblEquipments.First(item => item.equipment_code == code);
            e.equipment_freez = true;
            db.SubmitChanges();

        }

        internal string SelectAllEquipmentOfDate(int equCod,string date)
        {

            //var a =
            //    from r in db.tblReports
            //    join e in db.tblEquipments on r.Equimpment_code equals e.equipment_code
            //    where r.Data == date && r.Equimpment_code == equCod
            //    select  r.Tozihat;

            var a = db.tblReports.First(item => item.Equimpment_code == equCod && item.Data == date);

            return a.Tozihat;
        }

        public int CodePersonE { get; set; }

        public string NamePersonE { get; set; }

        public string Tozih { get; set; }
    }
}
