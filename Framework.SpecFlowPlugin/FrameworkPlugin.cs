using Framework.Common;
using Framework.HTTP;
using Framework.SpecFlowPlugin;
using TechTalk.SpecFlow.Generator.Plugins;
using TechTalk.SpecFlow.Infrastructure;
using TechTalk.SpecFlow.Plugins;
using TechTalk.SpecFlow.Tracing;

[assembly: GeneratorPlugin(typeof(FrameworkPlugin))]
[assembly: RuntimePlugin(typeof(FrameworkPlugin))]

namespace Framework.SpecFlowPlugin
{
    
    public class FrameworkPlugin : IRuntimePlugin, IGeneratorPlugin
    {
        public void Initialize(GeneratorPluginEvents generatorPluginEvents, GeneratorPluginParameters generatorPluginParameters)
        {
            generatorPluginEvents.CustomizeDependencies += GeneratorPluginEvents_CustomizeDependencies;
        }

        private void GeneratorPluginEvents_CustomizeDependencies(object sender, CustomizeDependenciesEventArgs e)
        {
            e.ObjectContainer.RegisterTypeAs<Response, IResponse>();
            e.ObjectContainer.RegisterTypeAs<Request, IRequest>();
            e.ObjectContainer.RegisterTypeAs<BaseContext, IBaseContext>();
        }

        public void Initialize(RuntimePluginEvents runtimePluginEvents, RuntimePluginParameters runtimePluginParameters)
        {
            runtimePluginEvents.CustomizeTestThreadDependencies += RuntimePluginEvents_CustomizeTestThreadDependencies;
            runtimePluginEvents.CustomizeScenarioDependencies += RuntimePluginEvents_CustomizeScenarioDependencies;
        }

        private void RuntimePluginEvents_CustomizeTestThreadDependencies(object sender, CustomizeTestThreadDependenciesEventArgs e)
        {
            e.ObjectContainer.RegisterTypeAs<ThreadSafeTraceListener, IThreadSafeTraceListener>();
            e.ObjectContainer.RegisterTypeAs<ThreadSafeTraceListener, ITraceListener>();
        }

        private void RuntimePluginEvents_CustomizeScenarioDependencies(object sender, CustomizeScenarioDependenciesEventArgs e)
        {
            e.ObjectContainer.RegisterTypeAs<Response, IResponse>();
            e.ObjectContainer.RegisterTypeAs<Request, IRequest>();
            e.ObjectContainer.RegisterTypeAs<BaseContext, IBaseContext>();
        }

        
    }
}
