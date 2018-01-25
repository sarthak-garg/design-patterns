using Builder.Models;

namespace Builder.PhoneBuilders
{
    class ApplePhoneBuilder: IPhoneBuilder
    {
        public MobilePhone Phone;

        public ApplePhoneBuilder()
        {
            Phone = new MobilePhone();
        }

        public void BuildBattery()
        {
            Phone.PhoneBattery = MobilePhone.Battery.MAH_1500;
        }

        public void BuildCamera()
        {
            Phone.PhoneCamera = MobilePhone.Camera.MP_16;
        }

        public void BuildOS()
        {
            Phone.PhoneOS = MobilePhone.OperatingSystem.IOS;
        }

        public void BuildRam()
        {
            Phone.PhoneRAM = MobilePhone.RAM.GB_4;
        }

        public MobilePhone GetPhone()
        {
            return Phone;
        }
    }
}
