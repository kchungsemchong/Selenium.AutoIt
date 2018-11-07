using AutoItX3Lib;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Selenium.AutoIt
{
	class Program
	{
		[STAThread]
		static void Main(string[] args)
		{
			var driver = new ChromeDriver(@"Dependencies");
			driver.Navigate().GoToUrl("https://www.google.mu/imghp?hl=en&tab=wi");
			var camera = driver.FindElement(By.Id("qbi"));
			camera.Click();
			var uploadImage = driver.FindElement(By.XPath("//a[@class='qbtbha qbtbtxt qbclr']"));
			uploadImage.Click();
			var chooseFile = driver.FindElement(By.Id("qbfile"));
			chooseFile.Click();
			AutoItX3 auto = new AutoItX3();
			auto.WinWaitActive("Open");
			auto.Send(@"YOUR URL");
			auto.Send("{ENTER}");
		}
	}
}
