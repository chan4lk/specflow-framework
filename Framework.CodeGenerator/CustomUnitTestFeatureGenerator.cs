using System.CodeDom;
using TechTalk.SpecFlow.Configuration;
using TechTalk.SpecFlow.Generator;
using TechTalk.SpecFlow.Generator.UnitTestConverter;
using TechTalk.SpecFlow.Generator.UnitTestProvider;
using TechTalk.SpecFlow.Parser;
using TechTalk.SpecFlow.Utils;

namespace Framework.CodeGenerator
{
    public class CustomUnitTestFeatureGenerator : UnitTestFeatureGenerator, IFeatureGenerator
    {
        public CustomUnitTestFeatureGenerator(IUnitTestGeneratorProvider testGeneratorProvider, CodeDomHelper codeDomHelper, SpecFlowConfiguration specFlowConfiguration, IDecoratorRegistry decoratorRegistry)
            : base(testGeneratorProvider, codeDomHelper, specFlowConfiguration, decoratorRegistry)
        { }

        public new CodeNamespace GenerateUnitTestFixture(SpecFlowDocument document, string testClassName, string targetNamespace)
        {
            foreach (var scenario in document.SpecFlowFeature.ScenarioDefinitions)
            {
               
            }

            return base.GenerateUnitTestFixture(document, testClassName, targetNamespace);
        }
    }
}
