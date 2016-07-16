using System;

namespace Minicloner.Tests.Fakes.Fields
{
    public class Class_With_ProtectedField
    {
        protected readonly Int32 ProtectedField;

        public Class_With_ProtectedField(int parameter)
        {
            ProtectedField = parameter;
        }

        public Int32 Get_ProtectedField() => ProtectedField;
    }
}