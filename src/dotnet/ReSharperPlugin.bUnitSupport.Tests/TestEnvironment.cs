using System.Threading;
using JetBrains.Application.BuildScript.Application.Zones;
using JetBrains.ReSharper.Feature.Services;
using JetBrains.ReSharper.Psi.CSharp;
using JetBrains.ReSharper.TestFramework;
using JetBrains.TestFramework;
using JetBrains.TestFramework.Application.Zones;
using NUnit.Framework;

[assembly: Apartment(ApartmentState.STA)]

namespace ReSharperPlugin.bUnitSupport.Tests
{
    [ZoneDefinition]
    public class bUnitSupportTestEnvironmentZone : ITestsEnvZone, IRequire<PsiFeatureTestZone>, IRequire<IbUnitSupportZone> { }

    [ZoneMarker]
    public class ZoneMarker : IRequire<ICodeEditingZone>, IRequire<ILanguageCSharpZone>, IRequire<bUnitSupportTestEnvironmentZone> { }

    [SetUpFixture]
    public class bUnitSupportTestsAssembly : ExtensionTestEnvironmentAssembly<bUnitSupportTestEnvironmentZone> { }
}
