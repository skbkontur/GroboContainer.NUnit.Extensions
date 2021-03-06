using NUnit.Framework;

namespace GroboContainer.NUnitExtensions.Tests.ExecutionOrder
{
    [GroboTestSuite("InheritanceHierarchyForSetUpMethod")]
    public class DerivedTestClass_WithSetUpMethodInBase_Test : TestBaseWithSetUpMethod
    {
        [Test]
        public void Test()
        {
            GroboTestMachineryTrace.Log("Test()");
            Assert.That(GroboTestContext.Current.SuiteName(), Is.EqualTo("InheritanceHierarchyForSetUpMethod"));
            AssertTestMachineryTrace(new[]
                {
                    $"SuiteWrapper.SetUp() for {GroboTestContext.Current.SuiteName()}",
                    $"MethodWrapper.SetUp() for {GroboTestContext.Current.SuiteName()}::{GroboTestContext.Current.TestName()}",
                    "TestBase_SetUp()",
                    "Test()",
                });
        }
    }
}