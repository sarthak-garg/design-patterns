
namespace Builder.Models
{
    class MobilePhone
    {
        #region HelperEnums

        public enum Battery
        {
            MAH_1000,
            MAH_1500,
            MAH_2000
        };

        public enum OperatingSystem
        {
            ANDROID,
            WINDOWS,
            IOS
        };

        public enum RAM
        {
            GB_6,
            GB_4,
            GB_2
        };

        public enum Camera
        {
            MP_16,
            MP_12,
            MP_8
        }

        #endregion

        #region Properties  

        public Battery PhoneBattery { get; set; }

        public OperatingSystem PhoneOS { get; set; }

        public RAM PhoneRAM { get; set; }

        public Camera PhoneCamera { get; set; }

        #endregion

        public override string ToString()
        {
            return string.Format("Battery: {0}\nOperating System: {1}\nRAM: {2}\nCamera: {3}\n", 
                PhoneBattery, PhoneOS, PhoneRAM, PhoneCamera);
        }
    }
}
