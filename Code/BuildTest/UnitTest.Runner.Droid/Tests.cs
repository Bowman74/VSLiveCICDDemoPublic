using System;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Android;

namespace BuildTest.Droid.TestRunner
{
	[TestFixture]
	public class Tests
	{
		AndroidApp app;

		[SetUp]
		public void BeforeEachTest()
		{
			// TODO: If the Android app being tested is included in the solution then open
			// the Unit Tests window, right click Test Apps, select Add App Project
			// and select the app projects that should be tested.
			app = ConfigureApp
				.Android
				// TODO: Update this path to point to your Android app and uncomment the
				// code if the app is not included in the solution.
				//.ApkFile ("../../../Android/bin/Debug/UITestsAndroid.apk")
				.StartApp();
		}

		[Test]
		public void RunUnitTests()
		{
			//app.Repl();
			var appName = GetAppName();

			Console.WriteLine(appName);

			app.Tap(c => c.Id("RunTestsButton"));

			app.WaitFor(() => app.Query(a => a.Id("ResultsResult")).Single().Text != string.Empty);

			var resultLabel = app.Query(a => a.Id("ResultsResult")).Single();

			Console.WriteLine(resultLabel.Text);

			Console.WriteLine(string.Empty);

			Console.WriteLine("Test Results:");

			app.Tap(c => c.Id("TestSuiteListView"));

			app.WaitFor(() => app.Query(a => a.Id("ResultsId")).Count() >= 1 && !app.Query(a => a.Id("ResultsId")).Any(b => b.Text.Contains("appName")));

			Assert.AreEqual("Passed", resultLabel.Text);
		}

		private string GetAppName()
		{
			var cell = app.Query(a => a.Id("ResultsId")).Single();

			var textArray = cell.Text.Split("/".ToCharArray());
			return textArray[textArray.Length - 1];
		}
	}
}