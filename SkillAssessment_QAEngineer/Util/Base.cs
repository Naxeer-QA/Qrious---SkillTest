using SkillAssessment_QAEngineer.WebPages;
using TechTalk.SpecFlow;

namespace SkillAssessment_QAEngineer.Util
{
    [Binding]
    class Base : Drivers
    {        
        [BeforeScenario]
        public void SetUp()
        {
            Initialize();
        }

        [AfterScenario]
        public void TearDown()
        {
            TerminateBrowser();
        }
    }
}
