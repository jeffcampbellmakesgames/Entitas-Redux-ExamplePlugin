using System.Linq;
using EntitasRedux.Core.Plugins;
using Genesis.Plugin;

namespace ExamplePlugin
{
    public class ExampleERCodeGeneratorPlugin : ICodeGenerator
    {
        /// <inheritdoc />
        public string Name => nameof(ExampleERCodeGeneratorPlugin);

        /// <inheritdoc />
        public int Priority => 0;

        /// <inheritdoc />
        public bool RunInDryMode => false;

        /// <inheritdoc />
        public CodeGenFile[] Generate(CodeGeneratorData[] data)
        {
            // Get all component data instances
            var componentData = data.OfType<ComponentData>();

            // Get all context data instances
            var contextData = data.OfType<ContextData>();

            // TODO Do something to generate additional
            return new CodeGenFile[0];
        }
    }
}
