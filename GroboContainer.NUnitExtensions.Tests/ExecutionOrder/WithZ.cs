using System.Reflection;

using GroboContainer.NUnitExtensions.Impl.TestContext;

namespace GroboContainer.NUnitExtensions.Tests.ExecutionOrder
{
    [WithY("2")]
    public class WithZ : EdiTestSuiteWrapperAttribute
    {
        public WithZ(string r)
        {
            this.r = r;
        }

        public override void SetUp(string suiteName, Assembly testAssembly, IEditableEdiTestContext suiteContext)
        {
            EdiTestMachineryTrace.Log(string.Format("WithZ(r={0}).SetUp()", r), suiteContext);
        }

        public override void TearDown(string suiteName, Assembly testAssembly, IEditableEdiTestContext suiteContext)
        {
            EdiTestMachineryTrace.Log(string.Format("WithZ(r={0}).TearDown()", r), suiteContext);
        }

        protected override string TryGetIdentity()
        {
            return r;
        }

        private readonly string r;
    }
}