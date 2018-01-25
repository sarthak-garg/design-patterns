using Builder.Models;

namespace Builder.PhoneBuilders
{
    interface IPhoneBuilder
    {
        void BuildBattery();
        void BuildOS();
        void BuildRam();
        void BuildCamera();
        MobilePhone GetPhone();
    }
}
