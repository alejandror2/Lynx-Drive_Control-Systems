/*
 * Created by Ranorex
 * User: NSN
 * Date: 3/5/2024
 * Time: 6:34 AM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using LynxDrive_ControlSystems_001.Code_Modules;


namespace LynxDrive_ControlSystems_001.Code_Modules
{
    /// <summary>
    /// Description of StationLevelTest.
    /// </summary>
    [TestModule("0AD50007-6E74-4240-8565-3DCA589C69BC", ModuleType.UserCode, 1)]
    public class StationLevelTest : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public StationLevelTest()
        {
            // Do not delete - a parameterless constructor is required!
        }
        
#region Code Module Variables to access cells and repository
        //----------------------------- Code Module(cm) Variables -------------------------------------------------------------//
		string _cmStationRowName = "";
		[TestVariable("86112241-6a71-4977-b908-866cae2f1245")]
		public string cmStationRowName
		{
			get { return _cmStationRowName; }
			set { _cmStationRowName = value; }
		}
		
		
		string _cmStationAccessRow = "";
		[TestVariable("6cda3231-272f-40ac-8988-b936c336175f")]
		public string cmStationAccessRow
		{
			get { return _cmStationAccessRow; }
			set { _cmStationAccessRow = value; }
		}
		
		
		string _cmNameRow = "";
		[TestVariable("8b18c1e6-d9c6-4f7a-86a6-1c953678c6de")]
		public string cmNameRow
		{
			get { return _cmNameRow; }
			set { _cmNameRow = value; }
		}
		
		
		string _cmAreaRowName = "";
		[TestVariable("cc940f3e-4442-48fd-9286-e485d989735d")]
		public string cmAreaRowName
		{
			get { return _cmAreaRowName; }
			set { _cmAreaRowName = value; }
		}
		
		
		string _cmHoleRowName = "";
		[TestVariable("424d2843-d78c-4d19-8bdd-aae84bc6bd15")]
		public string cmHoleRowName
		{
			get { return _cmHoleRowName; }
			set { _cmHoleRowName = value; }
		}
		
		
		string _cmTagRowName = "";
		[TestVariable("4e85e87d-b494-4629-85c0-23e292a2fe06")]
		public string cmTagRowName
		{
			get { return _cmTagRowName; }
			set { _cmTagRowName = value; }
		}
		
		
		string _cmNOSRowName = "";
		[TestVariable("b58d6952-3fae-481c-a6da-a8824f230fa1")]
		public string cmNOSRowName
		{
			get { return _cmNOSRowName; }
			set { _cmNOSRowName = value; }
		}
		
		
		string _cmAddRowName = "";
		[TestVariable("8fe83040-3b68-4286-936c-2c9db5e8cf29")]
		public string cmAddRowName
		{
			get { return _cmAddRowName; }
			set { _cmAddRowName = value; }
		}
		
		
		string _cmOffsetRowName = "";
		[TestVariable("7ae669b9-b0ae-45ca-9095-996a61d21c7d")]
		public string cmOffsetRowName
		{
			get { return _cmOffsetRowName; }
			set { _cmOffsetRowName = value; }
		}
		
		
		string _cmWPRowName = "";
		[TestVariable("b23d9c29-3cfd-4781-8ecc-1e112f014a60")]
		public string cmWPRowName
		{
			get { return _cmWPRowName; }
			set { _cmWPRowName = value; }
		}
		
#endregion
#region CodeModule Variables to input values
		
		string _cmStationVal = "";
		[TestVariable("b8ddab5d-b18a-4882-a7cc-b02d02000d89")]
		public string cmStationVal
		{
			get { return _cmStationVal; }
			set { _cmStationVal = value; }
		}
		
		string _cmNameVal = "";
		[TestVariable("1681069f-c0b1-48f0-9227-3fdcf82e711e")]
		public string cmNameVal
		{
			get { return _cmNameVal; }
			set { _cmNameVal = value; }
		}
		
		string _cmAreaVal = "";
		[TestVariable("be5e16a2-d64d-4d78-9064-727f7170466b")]
		public string cmAreaVal
		{
			get { return _cmAreaVal; }
			set { _cmAreaVal = value; }
		}
		
		
		string _cmHoelVal = "";
		[TestVariable("6e1d3c99-01bc-4b20-a0ac-d7e35f455bf0")]
		public string cmHoelVal
		{
			get { return _cmHoelVal; }
			set { _cmHoelVal = value; }
		}
		
		//add Tag in the future
		
		string _cmNOSVal = "";
		[TestVariable("8afc53b0-1296-4793-bc73-83efcc12092b")]
		public string cmNOSVal
		{
			get { return _cmNOSVal; }
			set { _cmNOSVal = value; }
		}
		
		
		string _cmAddVal = "";
		[TestVariable("2b94bd55-d32b-4f66-9078-22791ced85d1")]
		public string cmAddVal
		{
			get { return _cmAddVal; }
			set { _cmAddVal = value; }
		}
		
		
		string _cmOffsetVal = "";
		[TestVariable("c504da5b-4add-42e2-a8e7-ca148c73773b")]
		public string cmOffsetVal
		{
			get { return _cmOffsetVal; }
			set { _cmOffsetVal = value; }
		}
		
		
		string _cmWPValue = "";
		[TestVariable("36d4f8cf-b617-4382-a9b9-88b91308c1b7")]
		public string cmWPValue
		{
			get { return _cmWPValue; }
			set { _cmWPValue = value; }
		}
			
#endregion
		
        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
            
            //mouse keys
            const string retKey = "{Return}";
        	const string downKey = "{Down}";
            
            // intantiate the ripository
            var repo = LynxDrive_ControlSystems_001Repository.Instance;

            //Row Access Variable set
            //var currentRow = repo.CS_StaLevel.rStationRow
            
            //station variables binded row and value from CSV
            repo.StationAccessRow = cmStationAccessRow;
            repo.StationRowName = cmStationRowName;
            repo.StationValue = cmStationVal;
            
            //repository variables binded from CSV and cm variables
            repo.NameRow = cmNameRow;
            repo.AreaRowName = cmAreaRowName;
            repo.HoleRowName = cmHoleRowName;
            repo.TagRowName = cmTagRowName;
            repo.NOSRowName = cmNOSRowName;
            repo.AddRowName = cmAddRowName;
            repo.OffsetRowName = cmOffsetRowName;
            repo.WPRowName = cmWPRowName;
            
            var currentStation = repo.MainForm.CS_StaLevel.rStationRow;
            var currentName = repo.MainForm.CS_StaLevel.rNameRow;
            var currentArea = repo.MainForm.CS_StaLevel.rAreaRow;
            var currentHole = repo.MainForm.CS_StaLevel.rHoleRow;
            var currentTag = repo.MainForm.CS_StaLevel.rTagRow;
            var currentNOS = repo.MainForm.CS_StaLevel.rNOSRow;
            var currentAdd = repo.MainForm.CS_StaLevel.rLSMAddressRow;
            var currentOfsset = repo.MainForm.CS_StaLevel.rLSMOffsetRow;
            var currentWP = repo.MainForm.CS_StaLevel.rWirePathRow;
            
            //check if station number is correct example: 1-1-1 for station 1. This is initial check to make sure the test can even run (temporary check??)
            if(currentStation.Visible != true)
            {
            	Ranorex.Report.Log(ReportLevel.Failure, "Station "+cmStationVal+" NOT FOUND!");
            	throw new RanorexException("TEST ABORTED, CELL NOT FOUND");
            }
            else
            {
            	Ranorex.Report.Log(ReportLevel.Success, "Station "+cmStationVal+" Found INIT TEST");
            }
            
			//input Name (name column)
			Delay.Ms(500);
	       	currentName.Click();
            Delay.Ms(500);
	        currentName.PressKeys(cmNameVal + retKey);
            Delay.Ms(3000);

			//input area
			currentArea.Click();
			Delay.Ms(500);
			currentArea.PressKeys(cmAreaVal + retKey);
			Delay.Ms(3000);

			//input hole -- add later

			//input tag -- add later

			//input Number Of Sprinlklers (NOS)
			Delay.Ms(500);
			currentNOS.Click();
			Delay.Ms(500);
			currentNOS.PressKeys(cmNOSVal + retKey);
			Delay.Ms(3000);			

			//input decoder address
			Delay.Ms(500);
			currentAdd.Click();
			Delay.Ms(500);
			currentAdd.PressKeys(cmAddVal + retKey);
			Delay.Ms(3000);

			//input offset
			Delay.Ms(500);
			currentOfsset.Click();
			Delay.Ms(500);
			currentOfsset.PressKeys(cmOffsetVal + retKey);
			Delay.Ms(3000);

			//input Wire Path
			Delay.Ms(500);
			currentWP.Click();
			Delay.Ms(500);
			currentWP.PressKeys(cmWPValue + downKey);
			Delay.Ms(3000);			
        }
    }
}
