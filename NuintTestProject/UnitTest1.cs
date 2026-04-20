namespace NuintTestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            TestContext.Progress.WriteLine("Set-up method execution");
        }

        [Test]
        public void Test1()
        {
            TestContext.Progress.WriteLine("This is test 1");
        }

        [Test]
        public void Test2()
        {
            TestContext.Progress.WriteLine("This is test 2");
        }


        [TearDown]
        public void CloseBrowser()
        {
            TestContext.Progress.WriteLine("This is tear down method");
        }
    }
}