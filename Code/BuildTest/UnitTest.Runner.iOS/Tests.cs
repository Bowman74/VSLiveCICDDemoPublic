using System;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.iOS;

namespace BuildTest.Ios.TestRunner
{
	[TestFixture]
	public class Tests
	{
		iOSApp app;

		[SetUp]
		public void BeforeEachTest()
		{
			// TODO: If the iOS app being tested is included in the solution then open
			// the Unit Tests window, right click Test Apps, select Add App Project
			// and select the app projects that should be tested.
			//
			// The iOS project should have the Xamarin.TestCloud.Agent NuGet package
			// installed. To start the Test Cloud Agent the following code should be
			// added to the FinishedLaunching method of the AppDelegate:
			//
			//    #if ENABLE_TEST_CLOUD
			//    Xamarin.Calabash.Start();
			//    #endif
			app = ConfigureApp
				.iOS
				// TODO: Update this path to point to your iOS app and uncomment the
				// code if the app is not included in the solution.
				//.AppBundle ("../../../iOS/bin/iPhoneSimulator/Debug/BuildTest.Ios.TestRunner.iOS.app")
				.StartApp();
		}

		[Test]
		public void RunUnitTests()
		{


			//app.Repl();

			var appName = GetAppName();
			Console.WriteLine(appName);

			app.Tap(c => c.Marked("Run Everything"));

			app.WaitFor(() => app.Query(a => a.Class("UITableViewLabel")).SingleOrDefault(c => c.Label.Contains(" test cases, Runnable")) == null);

			var labels = app.Query(c => c.Class("UITableViewLabel"));


			var resultLabel = labels.SingleOrDefault(l => l.Label.Contains("Success!"));


			Console.WriteLine(string.Empty);

			Console.WriteLine("Test Results:");

			app.Tap(c => c.Marked(appName));

			app.WaitForNoElement(a => a.Class("UITableViewLabel").Marked("Options"));

			Assert.IsNotNull(resultLabel);
		}

		private string GetAppName()
		{
			var cells = app.Query(a => a.Class("UITableViewCell"));

			return cells.Single(c => c.Text != "Credits" && c.Text != "Options" && c.Text != "Run Everything").Text;
		}

	}
}