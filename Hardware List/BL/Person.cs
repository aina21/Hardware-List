using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using fatemeh_HardWare.Data;

namespace fatemeh_HardWare.BL
{
    class Person
    {
        /*************فیلد کلاس *************/
        private string _message;
        private string _name;
        private string _lastName;
        private string _password;
        private string _dakheli;
        private string _room;
        private int _code;
        private int _bulding;
        private int _group;
        private bool _manager;

        /**********************************/

        /*************propertis*************/

        /// <summary>
        /// کد پرسنل
        /// </summary>
        public int Code
        {
            get { return _code; }
            set
            {
                Person_Data p = new Person_Data();
                if (p.CheckCode(value))
                    _code = value;
                else
                    throw new HardWareExeption("شماره پرسنل اشتباه است");
            }
        }
        /// <summary>
        /// پیام عملیات
        /// </summary>
        public string Message
        {
            get { return _message; }
        }

        /// <summary>
        /// نام پرسنل
        /// </summary>
        public string Name
        {
            //تابع get
            get { return _name; }
            //تابع set
            private set
            {

                foreach (char c in value)
                {
                    //اگر عدد داخل اسم بود درست نیست 
                    if (char.IsDigit(c))
                    { throw new HardWareExeption("شما نمیتوانید عدد برای اسم وارد کنید"); }
                    //در غیر این صورت مقدار اسم صحیح است
                    else
                    {
                        _name = value;
                    }
                }

            }
        }
        
        /// <summary>
        /// نام خانوادگی پرسنل
        /// </summary>
        public string LastName
        {
            //تابع get
            get { return _lastName; }
            //تابع set
            set
            {
                foreach (char c in value)
                {
                    //اگر عدد داخل اسم بود درست نیست 
                    if (char.IsDigit(c))
                    { throw new HardWareExeption("شما نمیتوانید عدد برای نام خانوادگی وارد کنید"); }
                    //در غیر این صورت مقدار اسم صحیح است
                    else
                    {
                        _lastName = value;
                    }
                
                }
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string Password
        {
            get 
            { 
                return _password; 
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string Dakheli
        {
            get { return _dakheli; }
            set 
            {
                foreach (char c in value)
                {
                    //اگر حرف داخل شماره بود بود درست نیست 
                    if (!char.IsDigit(c))
                    { throw new HardWareExeption("شما نمیتوانید غیر از عدد برای داخلی وارد کنید"); }
                    //در غیر این صورت مقدار اسم صحیح است
                    else
                    {
                        _dakheli= value;
                    }
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public int Bulding
        {
            get { return _bulding; }
            set 
            {
                Building_Data b = new Building_Data();
                if (b.CheckCode(value))
                    _bulding = value;
                else
                    throw new HardWareExeption("شماره پرسنل اشتباه است");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public int Group
        {
            get { return _group; }
            set 
            {
                Group_Data g = new Group_Data();
                if (g.CheckCode(value))
                    _group = value;
                else
                    throw new HardWareExeption("شماره گروه اشتباه است");
            }
        }
      
        /// <summary>
        /// 
        /// </summary>
        public string Room
        {
            get { return _room; }
            set { _room = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Manager
        {
            get { return _manager; }
            set { _manager = value; }
        }
        /**********************************/

        /*************سازنده *************/
        //public Person(string name, string lastName, string dakheli, int bulding, string room, int group)
        //{
        //    Add(name, lastName, dakheli, bulding, room, group);
        //}

        /// <summary>
        /// سازنده
        /// </summary>
        /// <param name="code">کد پرسنل</param>
        public Person(int code)
        {
            try
            {
                Code = code;
                Person_Data person = new Person_Data();
                if (!this.Freezed(code))
                {
                    var p = person.SelectPerson(code);
                    var pr = person.SelectPersonRoom(code);

                    Name = p.person_name;
                    LastName = p.person_lastName;
                    Dakheli = p.person_dakheli.ToString();
                    Group = Convert.ToInt32(p.group_code);
                    Bulding = pr.bulding_code;
                    Room = pr.room_code;
                }
            }
            catch (HardWareExeption ex)
            {
                this._message = ex.Message;
                return;
            }
            catch (Exception ex)
            {
                this._message = ex.Message;
                return;
            }

        }

        /// <summary>
        /// سازنده - بدون پارامتر
        /// </summary>
        public Person() { }
        /*********************************/

        /*************متدهای کلاس *************/
        /// <summary>
        /// اضافه کردن 
        /// </summary>
        /// <param name="name">اسم </param>
        /// <param name="lastName">نام خانوادگی</param>
        /// <param name="dakheli">داخلی</param>
        /// <param name="bulding">شماره ساختمان</param>
        /// <param name="room">شماره اتاق</param>
        /// <param name="group">شماره گروه</param>
        /// <returns>اگر درست بود وارد لیست کنه </returns>
        public bool Add(string name, string lastName, string dakheli, int bulding, string room, int group)
        {
            try
            {
                Name = name;
                LastName = name;
                Dakheli = dakheli;
                Bulding = bulding;
                Room = room;
                Group = group;
                Person_Data obj = new Person_Data(Name, LastName, Dakheli, Bulding, Room, Group);
                this._password = obj.Pass;
                this._message = null;
                return true;
            }
            catch (HardWareExeption ex)
            {
                this._message = ex.Message;
                return false;
            }
            catch (Exception ex)
            {
                this._message = ex.Message;
                return false;
            }
        }

        /// <summary>
        /// چک میکنه کاربر کد و پسوردش وجود داره یا نه
        /// </summary>
        /// <param name="user">کد پرسنل </param>
        /// <param name="pass">پسورد</param>
        /// <returns>اگر موجود بود مقدار صحیح</returns>
        public bool CheckLogin(int user,string pass)
        {
                Person_Data obj = new Person_Data();
                return obj.CheckLogin(user, pass);
        }

        /// <summary>
        /// اخرین کد پرسنل را برمیگرداند
        /// </summary>
        /// <returns>اخرین کد پرسنل</returns>
        public int GetLastCode()
        {
            Person_Data obj = new Person_Data();
            return obj.Code;
        }

        public string GetBuildingName(int code)
        {
            Building_Data obj = new Building_Data(code);
            Bulding = code;
            return obj.Name;
           
        }

        public string GetGroupName(int code)
        {
            Group_Data obj = new Group_Data(code);
            Group = code;
            return obj.Name;

        }
        /// <summary>
        /// کد پرسنل صحیح است یا نه
        /// </summary>
        /// <param name="code">کد</param>
        /// <returns>کد پرسنل موجود باشد مقدار صحیح</returns>
        public bool CheckCode(int code)
        {
            Person_Data obj = new Person_Data();
            if (obj.CheckCode(code))
                return true;
            else
            {
                throw new HardWareExeption("کد اشتباه وارد شده است");
            }
        }

        public bool Update(int code, string name, string lastName, string dakheli, int bulding, string room, int group)
        {
            Person_Data myPerson = new Person_Data();
            Building_Data myBuild = new Building_Data();
            
            try
            {
                Name = name;
                LastName = lastName;
                Dakheli = dakheli;
                Bulding = bulding;
                Room = room;
                Group = group;

                if (!myPerson.Freezed_Data(code))
                {
                    if (myPerson.CheckCode(code))
                    {
                        if (myBuild.CheckCode(bulding))
                        {
                            myPerson.Update(Code, Name, LastName, Dakheli, Bulding, Room, Group);
                            this._password = myPerson.Pass;
                            this._message = null;
                        }
                    }
                }

                return true;
            }
            catch (HardWareExeption ex)
            {
                this._message = ex.Message;
                return false;
            }
            catch (Exception ex)
            {
                this._message = ex.Message;
                return false;
            }
        }

        public bool Freezed(int code)
        {
            Person_Data p = new Person_Data();
            if (p.Freezed_Data(code))
                throw new HardWareExeption("این پرسنل در حالت فریز می باشد");
            else
                return false;
        }

        public bool Freezing(int code)
        {
            Person_Data p = new Person_Data();
            try
            {
                if (!this.Freezed(code))
                {
                    p.Freezing_Data(code);
                    return true;
                }
            }
            catch (HardWareExeption ex)
            {
                this._message = ex.Message;
                return false;
            }
            catch (Exception ex)
            {
                this._message = ex.Message;
                return false;
            }
            return false;

        }

        public bool Search(string type, string value)
        {
            Person_Data myPerson = new Person_Data();
            Building_Data myBuild = new Building_Data();

            try
            {
                if (type == "")
                    throw new HardWareExeption("نوع سرچ را انتخاب کنید");
                else if (value == "")
                    throw new HardWareExeption("مقدار را وارد کنید");
                else
                {
                    PersonSearch = myPerson.Search(type, value);
                    this._message = "";
                    return true;
                }
            }
            catch (HardWareExeption ex)
            {
                this._message = ex.Message;
                return false;
            }
            catch (Exception ex)
            {
                this._message = ex.Message;
                return false;
            }
        }

        public object SelectAll()
        {
            Person_Data person = new Person_Data();
           var p = person.SelectAll();
           return p;
           
        }

        public IEnumerable<Building_Data> SelectAllBuldings()
        {
            Building_Data b = new Building_Data();
            return b.SelectAllBulding();
        }

        public IEnumerable<Group_Data> SelectAllGroups()
        {
            Group_Data g = new Group_Data();
            return g.SelectAll();
        }
        /*************************************/

        public object PersonSearch { get; private set; }
    }
}
