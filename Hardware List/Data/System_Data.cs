using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fatemeh_HardWare.Data
{
    class System_Data
    {
        private DataClasses1DataContext db = new DataClasses1DataContext();

        public System_Data()
        { }

        public System_Data(int code, int equipment)
        {
            if (equipment == 0)
                return;
            tblSystem tbls = new tblSystem
            {
                equipment_code=equipment,
                system_code = code
            };
            db.tblSystems.InsertOnSubmit(tbls);
            db.SubmitChanges();
           
        }

        internal bool CheckCode(int value)
        {
            return db.tblSystems.Any(item => item.equipment_code == value);
        }

        internal bool CheckCodeSystem(int value)
        {
            return db.tblSystems.Any(item => item.system_code == value);
        }

        internal IEnumerable<System_Data> SelectAllCPU()
        {
            
            return from a in db.tblHardwares
                   join e in db.tblEquipments on a.hardware_code equals e.hardware_code into HardwareGroup
                   from per2 in HardwareGroup
                   where a.hardware_code == 1 && per2.equipment_freez == false 
                   select new System_Data
                   {
                            
                       CodeCPU = per2.equipment_code,
                       NameCPU = per2.equipment_model
                   };
        }

        internal IEnumerable<System_Data> SelectAllVGA()
        {
            return from a in db.tblHardwares
                   join e in db.tblEquipments on a.hardware_code equals e.hardware_code into HardwareGroup
                   from per2 in HardwareGroup
                   where a.hardware_code == 2 && per2.equipment_freez == false
                   select new System_Data
                   {
                       CodeVGA = per2.equipment_code,
                       NameVGA = per2.equipment_model
                   };
        }

        internal IEnumerable<System_Data> SelectAllODD()
        {
            return from a in db.tblHardwares
                   join e in db.tblEquipments on a.hardware_code equals e.hardware_code into HardwareGroup
                   from per2 in HardwareGroup
                   where a.hardware_code == 3 && per2.equipment_freez == false
                   select new System_Data
                   {
                       CodeODD = per2.equipment_code,
                       NameODD = per2.equipment_model
                   };
        }

        internal IEnumerable<System_Data> SelectAllHDD()
        {
            return from a in db.tblHardwares
                   join e in db.tblEquipments on a.hardware_code equals e.hardware_code into HardwareGroup
                   from per2 in HardwareGroup
                   where a.hardware_code == 4 && per2.equipment_freez == false
                   select new System_Data
                   {
                       CodeHDD = per2.equipment_code,
                       NameHDD = per2.equipment_model
                   };
        }

        internal IEnumerable<System_Data> SelectAllRAM()
        {
            return from a in db.tblHardwares
                   join e in db.tblEquipments on a.hardware_code equals e.hardware_code into HardwareGroup
                   from per2 in HardwareGroup
                   where a.hardware_code == 5 && per2.equipment_freez == false
                   select new System_Data
                   {
                       CodeRAM = per2.equipment_code,
                       NameRAM = per2.equipment_model
                   };
        }

        internal IEnumerable<System_Data> SelectAllPCI()
        {
            return from a in db.tblHardwares
                   join e in db.tblEquipments on a.hardware_code equals e.hardware_code into HardwareGroup
                   from per2 in HardwareGroup
                   where a.hardware_code == 6 && per2.equipment_freez == false
                   select new System_Data
                   {
                       CodePCI = per2.equipment_code,
                       NamePCI = per2.equipment_model
                   };
        }

        internal IEnumerable<System_Data> SelectAllMain()
        {
            return from a in db.tblHardwares
                   join e in db.tblEquipments on a.hardware_code equals e.hardware_code into HardwareGroup
                   from per2 in HardwareGroup
                   where a.hardware_code == 7 && per2.equipment_freez == false
                   select new System_Data
                   {
                       CodeMain = per2.equipment_code,
                       NameMain = per2.equipment_model
                   };
        }

        internal IEnumerable<System_Data> SelectAllDisplay()
        {
            return from a in db.tblHardwares
                   join e in db.tblEquipments on a.hardware_code equals e.hardware_code into HardwareGroup
                   from per2 in HardwareGroup
                   where a.hardware_code == 8 && per2.equipment_freez == false
                   select new System_Data
                   {
                       CodeDisplay = per2.equipment_code,
                       NameDisplay = per2.equipment_model
                   };
        }

        internal IEnumerable<System_Data> SelectAllMouse()
        {
            return from a in db.tblHardwares
                   join e in db.tblEquipments on a.hardware_code equals e.hardware_code into HardwareGroup
                   from per2 in HardwareGroup
                   where a.hardware_code == 9 && per2.equipment_freez == false
                   select new System_Data
                   {
                       CodeMouse = per2.equipment_code,
                       NameMouse= per2.equipment_model
                   };
        }

        internal IEnumerable<System_Data> SelectAllKeyboard()
        {
            return from a in db.tblHardwares
                   join e in db.tblEquipments on a.hardware_code equals e.hardware_code into HardwareGroup
                   from per2 in HardwareGroup
                   where a.hardware_code == 10 && per2.equipment_freez == false
                   select new System_Data
                   {
                       CodeKeyboard = per2.equipment_code,
                       NameKeyboard = per2.equipment_model
                   };
        }

        internal IEnumerable<System_Data> SelectAllCase()
        {
            return from a in db.tblHardwares
                   join e in db.tblEquipments on a.hardware_code equals e.hardware_code into HardwareGroup
                   from per2 in HardwareGroup
                   where a.hardware_code == 11 && per2.equipment_freez == false
                   select new System_Data
                   {
                       CodeCase = per2.equipment_code,
                       NameCase = per2.equipment_model
                   };
        }

        internal IEnumerable<System_Data> SelectAllPrinter()
        {
            return from a in db.tblHardwares
                   join e in db.tblEquipments on a.hardware_code equals e.hardware_code into HardwareGroup
                   from per2 in HardwareGroup
                   where a.hardware_code == 12 && per2.equipment_freez == false
                   select new System_Data
                   {
                       CodePrinter = per2.equipment_code,
                       NamePrinter = per2.equipment_model
                   };
        }



        public int CodeCPU { get; set; }

        public string NameCPU { get; set; }

        public int CodeVGA { get; set; }

        public string NameVGA { get; set; }

        public int CodeODD { get; set; }

        public string NameODD { get; set; }

        public string NameHDD { get; set; }

        public int CodeHDD { get; set; }

        public int CodeRAM { get; set; }

        public string NameRAM { get; set; }

        public int CodePCI { get; set; }

        public string NamePCI { get; set; }

        public int CodeMain { get; set; }

        public string NameMain { get; set; }

        public int CodeDisplay { get; set; }

        public string NameDisplay { get; set; }

        public int CodeMouse { get; set; }

        public string NameMouse { get; set; }

        public int CodeKeyboard { get; set; }

        public string NameKeyboard { get; set; }

        public int CodeCase { get; set; }

        public string NameCase { get; set; }

        public string NamePrinter { get; set; }

        public int CodePrinter { get; set; }



        internal string GetEquimpnentModel(int p)
        {
            return db.tblEquipments.First(item => item.equipment_code == p).equipment_model;
        }

        internal object GetEquimpnets(int system)
        {
            var e = from equipment in db.tblSystems
                    where equipment.system_code == system
                    select equipment;
            return e;


        }

        internal int GetSystemOfEquipment(int code)
        {
            var s = db.tblSystems.First(item => item.equipment_code==code);
            return s.system_code;
        }
    }
}
