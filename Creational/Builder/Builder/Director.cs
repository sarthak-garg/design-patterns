using Builder.PhoneBuilders;

namespace Builder
{
    class Director
    {
        public void Construct(IPhoneBuilder builder)
        {
            builder.BuildBattery();
            builder.BuildCamera();
            builder.BuildOS();
            builder.BuildRam();
        }
    }
}
