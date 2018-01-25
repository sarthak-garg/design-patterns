using Builder.Models;

namespace Builder.PhoneBuilders
{
    class AndroidPhoneBuilder : IPhoneBuilder
    {
        public MobilePhone Phone;

        public AndroidPhoneBuilder()
        {
            Phone = new MobilePhone();
        }

        public void BuildBattery()
        {
            Phone.PhoneBattery = MobilePhone.Battery.MAH_2000;
        }

        public void BuildCamera()
        {
            Phone.PhoneCamera = MobilePhone.Camera.MP_12;
        }

        public void BuildOS()
        {
            Phone.PhoneOS = MobilePhone.OperatingSystem.ANDROID;
        }

        public void BuildRam()
        {
            Phone.PhoneRAM = MobilePhone.RAM.GB_6;
        }

        public MobilePhone GetPhone()
        {
            return Phone;
        }
    }
}
