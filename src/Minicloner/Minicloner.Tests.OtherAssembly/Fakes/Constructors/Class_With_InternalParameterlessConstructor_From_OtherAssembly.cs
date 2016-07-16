﻿using System;

namespace Minicloner.Tests.OtherAssembly.Fakes.Constructors
{
    public class Class_With_InternalParameterlessConstructor_From_OtherAssembly
    {
        public Int32 Int32Property { get; set; }
        public Int32 PropertyInitializedInConstructor { get; private set; }

        internal Class_With_InternalParameterlessConstructor_From_OtherAssembly()
        {
            PropertyInitializedInConstructor = 1;
        }

        public static Class_With_InternalParameterlessConstructor_From_OtherAssembly Create() => new Class_With_InternalParameterlessConstructor_From_OtherAssembly();
    }
}