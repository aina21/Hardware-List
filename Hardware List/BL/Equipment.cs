using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using fatemeh_HardWare.Data;

namespace fatemeh_HardWare.BL
{
    class Equipment
    {
        /*************فیلد کلاس *************/
        private string _message;
        private string _model;
        private string _warranty;
        private string _warBegin;
        private string _warEnd;
        private int _code;
        private int _state;
        private int _personCode;
        private int _hardware;

        /**********************************/

        /*************propertis*************/

        public string Message
        {
            get { return _message; }
            private set { _message = value; }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public string Warranty
        {
            get { return _warranty; }
            set { _warranty = value; }
        }

        public string WarBegin
        {
            get { return _warBegin; }
            set { _warBegin = value; }
        }

        public string WarEnd
        {
            get { return _warEnd; }
            set { _warEnd = value; }
        }

        public int State
        {
            get { return _state; }
            set
            {
                Equipment_Data e = new Equipment_Data();
                if (e.CheckCodeState(value))
                    _state = value;
                else
                    throw new HardWareExeption("شماره وضعیت اشتباه است");
            }
        }

        public int PersonCode
        {
            get { return _personCode; }
            set
            {
                Person_Data p = new Person_Data();
                if (p.CheckCode(value))
                    _personCode= value;
                else
                    throw new HardWareExeption("شماره پرسنل اشتباه است");
            }
        }

        public int Hardware
        {
            get { return _hardware; }
            set
            {
                Equipment_Data p = new Equipment_Data();
                if (p.CheckCodeHardWare(value))
                    _hardware = value;
                else
                    throw new HardWareExeption("شماره پرسنل اشتباه است");
            }
        }

        public int Code
        {
            get { return _code; }
            set
            {
                Equipment_Data e = new Equipment_Data();
                if (e.CheckCode(value))
                    _code = value;
                else
                    throw new HardWareExeption("شماره قطعه اشتباه است");
            }
        }
        /**********************************/

        /*************سازنده *************/

        //public Equipment(int hardware, string model, string warranty, string warBegin, string warEnd, int state, int personCode)
        //{
        //    if(Add(hardware,model,warranty,warBegin,warEnd,state,personCode))

        //}
        public Equipment(int code)
        {
            try
            {
                Code = code;
                Equipment_Data equipment = new Equipment_Data();
                if (!this.Freezed(code))
                {
                    var e = equipment.SelectEquipment(code);
                    var w = equipment.SelectWarranty(Convert.ToInt32(e.warranty_code));
                    var s = equipment.SelectState(Convert.ToInt32(e.state_code));
                    var h = equipment.SelectHardware(Convert.ToInt32(e.hardware_code));

                    Model = e.equipment_model;
                    Warranty = w.warranty_name;
                    WarBegin = w.warranty_start;
                    WarEnd = w.warranty_end;
                    State = s.state_code;
                    Hardware = h.hardware_code;
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

        public Equipment()
        { }
       
        /*********************************/

        /*************متدهای کلاس *************/
        private bool Freezed(int code)
        {
            Equipment_Data e = new Equipment_Data();
            if (e.Freezed_Data(code))
                throw new HardWareExeption("این قطعه در حالت فریز می باشد");
            else
                return false;
        }

        public bool Add(int hardware, string model, string warranty, string warBegin, string warEnd, int state,int person)
        {
            try
            {
                Model = model;
                Warranty = warranty;
                WarBegin = warBegin;
                WarEnd = warEnd;
                State = state;
                Hardware = hardware;
                PersonCode = person;
                Equipment_Data obj = new Equipment_Data(hardware, model, warranty, warBegin, warEnd, state,person);
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

        internal int GetLastCode()
        {
            Equipment_Data obj = new Equipment_Data();
            return obj.Code;
        }
 




        internal IEnumerable<Equipment_Data> SelectAllStates()
        {
            Equipment_Data e = new Equipment_Data();
            return e.SelectAllState();
        }

        internal IEnumerable<Equipment_Data> SelectAllHardwares()
        {
            Equipment_Data e = new Equipment_Data();
            return e.SelectAllHardwares();
        }

        internal IEnumerable<Equipment_Data> SelectAllPersons()
        {
            Equipment_Data e = new Equipment_Data();
            return e.SelectAllPersons();
        }

        internal IEnumerable<Equipment_Data> SelectAllEquipmentOfPerson(string perCode)
        {
            Equipment_Data e = new Equipment_Data();
            PersonCode = Convert.ToInt32(perCode);
            return e.SelectAllEquipmentOfPerson(PersonCode);
            
        }

        internal int GetPersonCode(int p)
        {
            Equipment_Data obj = new Equipment_Data();
            PersonCode = p;
            return obj.GetPersonCode(p);
        }

        internal string GetStateCode(int p)
        {
            Equipment_Data obj = new Equipment_Data();
            State = p;
            return obj.GetStateCode(p);
        }

        internal string GetHardwareCode(int p)
        {
            Equipment_Data obj = new Equipment_Data();
            Hardware = p;
            return obj.GetHardwareCode(p);
        }

        internal bool Update(int code,int hardware, string model, string warranty, string warBegin, string warEnd, int state)
        {
            Equipment_Data myEquipment = new Equipment_Data();

            try
            {
                Code = code;
                Model = model;
                Warranty = warranty;
                WarBegin = warBegin;
                WarEnd = warEnd;
                State = state;
                Hardware = hardware;

                if (!myEquipment.Freezed_Data(Code))
                {
                    if (myEquipment.CheckCode(Code))
                    {
                        if (myEquipment.CheckCodeHardWare(Hardware))
                        {
                            if (myEquipment.CheckCodeState(State))
                            {
                                myEquipment.Update(Code, Hardware, Model, Warranty, WarBegin, WarEnd, State);
                                this._message = null;
                            }
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

        internal bool Freezing(int code)
        {
            Equipment_Data e = new Equipment_Data();
            try
            {
                if (!this.Freezed(code))
                {
                    e.Freezing_Data(code);
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

        public object SearchEquipment { get; private set; }

        internal bool Search(string type , string value)
        {
            Equipment_Data myEquipment = new Equipment_Data();

            try
            {
                if (type == "")
                    throw new HardWareExeption("نوع سرچ را انتخاب کنید");
                else if (value == "")
                    throw new HardWareExeption("مقدار را وارد کنید");
                else
                {
                    SearchEquipment = myEquipment.Search(type, value);
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

        
        /*************************************/

        internal bool ChangeStatus(int equipment, string person, string tozih)
        {
            Equipment_Data e = new Equipment_Data();
            try
            {
                Code = equipment;
                PersonCode = Convert.ToInt32(person);
                e.ChangeStatus(Code,PersonCode,tozih);
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

        public string SelectAllEquipmentOfDate(int code, string date)
        {
            Equipment_Data e = new Equipment_Data();
            return e.SelectAllEquipmentOfDate(code,date);
        }
    }
}
