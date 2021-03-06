using System;

namespace Entitas.CodeGeneration.Attributes {

    [AttributeUsage(AttributeTargets.Interface | AttributeTargets.Class | AttributeTargets.Struct)]
    public class CustomPrefixAttribute : Attribute {

        public readonly string prefix;

        public CustomPrefixAttribute(string prefix) {
            this.prefix = prefix;
        }
    }
}
