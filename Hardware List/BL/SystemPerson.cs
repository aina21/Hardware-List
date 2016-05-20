using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using fatemeh_HardWare.Data;
using System.Collections;

namespace fatemeh_HardWare.BL
{
    class SystemPerson
    {

        /*************فیلد کلاس *************/
        private int _systemCode;
        private int _equipmentCode;

        /**********************************/

        /*************propertis*************/
        public int SystemCode
        {
            get { return _systemCode; }
            set
            {
                _systemCode = value;
            }
        }

        public int EquipmentCode
        {
            get { return _equipmentCode; }
            set
            {
                System_Data e = new System_Data();
                if (e.CheckCode(value))
                    _equipmentCode = value;
                else
                    throw new HardWareExeption("شماره قطعه اشتباه است");
            }
        }
        /**********************************/
       
        /*************سازنده *************/
        public SystemPerson()
        { }

        public SystemPerson(string code)
        {
            try
            {
                
                try
                {
                    SystemCode = Convert.ToInt32(code);
                }
                catch
                {
                    this.Message = "کد اشتباه است";
                    return ;
                }
                
                

                this.Message = null;
            }
            catch (HardWareExeption ex)
            {
                this.Message = ex.Message;
                return;
            }
            catch (Exception ex)
            {
                this.Message = ex.Message;
                return;
            }
        }

        /*********************************/

        /*************متدهای کلاس *************/
        internal IEnumerable<System_Data> SelectAllCPU()
        {
            System_Data system = new System_Data();
            return system.SelectAllCPU();
        }

        internal IEnumerable<System_Data> SelectAllVGA()
        {
            System_Data system = new System_Data();
            return system.SelectAllVGA();
        }

        internal IEnumerable<System_Data> SelectAllODD()
        {
            System_Data system = new System_Data();
            return system.SelectAllODD();
        }

        internal IEnumerable<System_Data> SelectAllHDD()
        {
            System_Data system = new System_Data();
            return system.SelectAllHDD();
        }

        internal IEnumerable<System_Data> SelectAllRAM()
        {
            System_Data system = new System_Data();
            return system.SelectAllRAM();
        }

        internal IEnumerable<System_Data> SelectAllPCI()
        {
            System_Data system = new System_Data();
            return system.SelectAllPCI();
        }

        internal IEnumerable<System_Data> SelectAllMain()
        {
            System_Data system = new System_Data();
            return system.SelectAllMain();
        }

        internal IEnumerable<System_Data> SelectAllDisplay()
        {
            System_Data system = new System_Data();
            return system.SelectAllDisplay();
        }

        internal IEnumerable<System_Data> SelectAllMouse()
        {
            System_Data system = new System_Data();
            return system.SelectAllMouse();
        }

        internal IEnumerable<System_Data> SelectAllKeyboard()
        {
            System_Data system = new System_Data();
            return system.SelectAllKeyboard();
        }

        internal IEnumerable<System_Data> SelectAllCase()
        {
            System_Data system = new System_Data();
            return system.SelectAllCase();
        }

        internal IEnumerable<System_Data> SelectAllPrinter()
        {
            System_Data system = new System_Data();
            return system.SelectAllPrinter();
        }
        /*************************************/




        internal bool Add(string code, int cpu, int ca, int display, int hdd, int keyboad, int main, int mouse, int odd, int pci, int printer, int ram, int vga)
        {
            try
            {
                try
                {
                    System_Data s = new System_Data();
                    SystemCode = Convert.ToInt32(code);
                    if (s.CheckCode(SystemCode))
                        throw new HardWareExeption("شماره قطعه موجود است است");
                }
                catch
                {
                    this.Message = "کد اشتباه است";
                    return false;
                }

                ArrayList obj = new ArrayList();
                obj.Add(new System_Data(SystemCode, cpu));
                obj.Add(new System_Data(SystemCode, display));
                obj.Add(new System_Data(SystemCode, hdd));
                obj.Add( new System_Data(SystemCode, keyboad));
                obj.Add(new System_Data(SystemCode, main));
                obj.Add( new System_Data(SystemCode, mouse));
                obj.Add(new System_Data(SystemCode, odd));
                obj.Add( new System_Data(SystemCode, pci));
                obj.Add(new System_Data(SystemCode, printer));
                obj.Add( new System_Data(SystemCode, ram));
                obj.Add(new System_Data(SystemCode, vga));

                this.Message = null;
                return true;
            }
            catch (HardWareExeption ex)
            {
                this.Message = ex.Message;
                return false;
            }
            catch (Exception ex)
            {
                this.Message = ex.Message;
                return false;
            }
        }

        public int GetSystemOfEquipment(int code)
        {
            System_Data system = new System_Data();
            return system.GetSystemOfEquipment(code);
        }
        public string Message { get; set; }
  
    }
}
