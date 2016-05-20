using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Collections;

namespace fatemeh_HardWare.Data
{
    class Person_Data
    {
        /// <summary>
        /// دیتا مدل
        /// </summary>
        private DataClasses1DataContext db = new DataClasses1DataContext();

        private int _code;
        private string _pass;

        public string Pass
        {
            get 
            {
                var p = db.tblPersons.First(item => item.person_code == this.Code);
                _pass = p.person_password;
                return p.person_password;      
            }

        }

        public int Code
        {
            private set
            { }
            get 
            {
                var c = db.tblPersons.OrderByDescending(u => u.person_code).FirstOrDefault();
                _code = Convert.ToInt32(c.person_code);
                return _code; 
            }
        }
        

        public Person_Data(string name ,  string lastName ,string dakheli ,  int bulding ,string room , int group )
        {
           
            tblPerson tbl = new tblPerson
            {
                person_name = name,
                person_lastName = lastName,
                person_dakheli = dakheli,
                group_code = group ,
                person_fireezing = false
            };
            db.tblPersons.InsertOnSubmit(tbl);
            db.SubmitChanges();

            tblPerson_Room tbl1 = new tblPerson_Room
            {
                room_code = room,
                bulding_code = bulding,
                person_code = tbl.person_code
            };
            db.tblPerson_Rooms.InsertOnSubmit(tbl1);
            db.SubmitChanges();

        }

        public Person_Data( )
        { }

        public bool CheckLogin(int code, string pass)
        {
            bool isUserCorrected = db.tblPersons.Any(item =>
               item.person_code== code
               &&
               item.person_password.ToLower() == pass.ToLower());

            return isUserCorrected;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public bool CheckCode(int code)
        {
            return (db.tblPersons.Any(item => item.person_code == code));

        }

        public ArrayList GetBuildingInfo(int pcode)
        {
            ArrayList a = new ArrayList();
            if (CheckCode(pcode))
            {
                var b = db.tblPerson_Rooms.First(item => item.person_code == pcode);
                a.Add(b.bulding_code);
                a.Add(b.room_code);
                return a;

            }
            else
                throw new Exception("کد اشتباه است");


        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="code"></param>
        /// <param name="name"></param>
        /// <param name="lastName"></param>
        /// <param name="dakheli"></param>
        /// <param name="bulding"></param>
        /// <param name="room"></param>
        /// <param name="group"></param>
        /// <returns></returns>
        public void Update(int code, string name, string lastName, string dakheli, int bulding, string room, int group)
        {

            var p = db.tblPersons.First(item => item.person_code == code);
            p.person_name = name;
            p.person_lastName = lastName;
            p.person_dakheli = dakheli;
            p.group_code = group;
            db.SubmitChanges();

            var b = db.tblPerson_Rooms.First(item => item.person_code == code);
            b.room_code = room;
            b.bulding_code = bulding;
            db.SubmitChanges();
            
           
        }

        public tblPerson SelectPerson(int code)
        {
            var p = db.tblPersons.First(item=>item.person_code==code);
            return p;
        }

        public tblPerson_Room SelectPersonRoom(int code)
        {
            var p = db.tblPerson_Rooms.First(item => item.person_code == code);
            return p;
        }

        public bool Freezed_Data(int code)
        {
            var p = db.tblPersons.First(item=> item.person_code == code);
            return (p.person_fireezing);
        }

        public void Freezing_Data(int code)
        {
            var p = db.tblPersons.First(item => item.person_code == code);
            if (!Freezed_Data(code))
                p.person_fireezing = true;
            db.SubmitChanges();
        }

        public object Search(string type, string value)
        {
            if (type == "نام")
            {
                var p = db.tblPersons.Where(item => item.person_name == value);
                return p;
            }
            else if (type == "نام خانوادگی")
            {
                var p = db.tblPersons.Where(item => item.person_lastName == value);
                return p;
            }
            else if (type == "داخلی")
            {
                var p = db.tblPersons.Where(item => item.person_dakheli == value);
                return p;
            }
            else if (type == "گروه")
            {
                var p = from person in db.tblPersons
                        join g in db.tblGroups on person.group_code equals g.group_code into personGroup
                        from per2 in personGroup
                        where per2.group_name == value
                        select person;
               
                return p;
            }

            else if (type == "ساختمان")
            {
                var p = from person in db.tblPersons
                        join pb in db.tblPerson_Rooms on person.person_code equals pb.person_code
                        join b in db.tblBuildings on pb.bulding_code equals b.building_code into personBuild
                        from per2 in personBuild
                        where per2.building_name == value
                        select person;
                return p;
            }

            else
            {
                throw new Exception("انتخاب شما نادرست است");
            }
            
        }

        public object SelectAll()
        {
            return
               db.tblPersons.Select(item => item);
 
        }

      
    /*************************************/
    }
}
