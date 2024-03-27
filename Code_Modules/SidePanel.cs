/*
 * Created by Ranorex
 * User: NSN
 * Date: 3/13/2024
 * Time: 7:53 AM
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

namespace LynxDrive_ControlSystems_001.Code_Modules
{
    /// <summary>
    /// Description of repoIntegration.
    /// </summary>
    [TestModule("C5FECBF7-DFA7-4218-A15C-BF0D33BC3A99", ModuleType.UserCode, 1)]
    public class SidePanel : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        /// 
        
        private static LynxDrive_ControlSystems_001Repository repo;
        private int cmIteration;
        
        public SidePanel()
        {
           // Instantiate the repository object
           repo = new LynxDrive_ControlSystems_001Repository();
        }
#region Code Module Variables to Input Values

string _cmSprinklerModel = "";
[TestVariable("c7cf6a29-7a98-498b-ac80-f51601f06a26")]
public string cmSprinklerModel
{
	get { return _cmSprinklerModel; }
	set { _cmSprinklerModel = value; }
}


string _cmNozzleModel = "";
[TestVariable("12d906ee-f764-4a38-ad10-04480ae4ae4a")]
public string cmNozzleModel
{
	get { return _cmNozzleModel; }
	set { _cmNozzleModel = value; }
}


string _cmArc = "";
[TestVariable("fd92dfd3-5db2-442c-a8a0-87f84ea3eb4a")]
public string cmArc
{
	get { return _cmArc; }
	set { _cmArc = value; }
}


string _cmPressure = "";
[TestVariable("99e819fe-2d32-4b40-8f10-eb27df25a0a4")]
public string cmPressure
{
	get { return _cmPressure; }
	set { _cmPressure = value; }
}

string _cmNumberSprinklers = "";
[TestVariable("a76516ac-49ba-474f-a481-4531b78ae9d4")]
public string cmNumSprinklers
{
	get { return _cmNumberSprinklers; }
	set { _cmNumberSprinklers = value; }
}


string _cmNozzleFlow = "";
[TestVariable("9f2b783a-e9cb-465e-bb76-70b31d7a2eb4")]
public string cmNozzleFlow
{
	get { return _cmNozzleFlow; }
	set { _cmNozzleFlow = value; }
}



string _cmBackFlow = "";
[TestVariable("dd68e781-0a9b-4eb3-83d7-dd9664d400c7")]
public string cmBackFlow
{
	get { return _cmBackFlow; }
	set { _cmBackFlow = value; }
}


string _cmStaFlow = "";
[TestVariable("60dad728-6231-4171-a99d-4312dab00eef")]
public string cmStaFlow
{
	get { return _cmStaFlow; }
	set { _cmStaFlow = value; }
}


string _cmPrecipRate = "";
[TestVariable("79a200f7-a796-4c8e-97e5-90a5517acae9")]
public string cmPrecipRate
{
	get { return _cmPrecipRate; }
	set { _cmPrecipRate = value; }
}


string _cmPattern = "";
[TestVariable("bfef245b-48a4-44d4-8be6-ad25e283c082")]
public string cmPattern
{
	get { return _cmPattern; }
	set { _cmPattern = value; }
}


string _cmSprinklerSpacing = "";
[TestVariable("616998cc-f7da-445a-9855-4a7dfb07e5a4")]
public string cmSprinklerSpacing
{
	get { return _cmSprinklerSpacing; }
	set { _cmSprinklerSpacing = value; }
}


string _cmRowSpacing = "";
[TestVariable("845efe94-50e4-4392-9ee1-6f041416012b")]
public string cmRowSpacing
{
	get { return _cmRowSpacing; }
	set { _cmRowSpacing = value; }
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
            
            //const string retKey = "{Return}";
       		//const string downKey = "{Down}";
       		const string tabKey = "{Tab}";
       		int tDelay = 100; //mS
       		//cmIterration++;

       		//click on scrol bar to acces all areas
       		if (cmIteration == 0)
       		{
       			repo.MainForm.CS_StaLevel.SidePanel.rSidePanelScrollBar.Click(new Location(465, 742));
       			Delay.Ms(tDelay);
       		}
			// Drop Fown List (DDL) one click and Input Box (IB) double click
			
       		//input Prinkler Moodel DDL
       		repo.MainForm.CS_StaLevel.SidePanel.rSprinklerModel.Click();
       		repo.MainForm.CS_StaLevel.SidePanel.rSprinklerModel.PressKeys(cmSprinklerModel + tabKey);
			Delay.Ms(tDelay);
			//input Nozzle Model DDL
			repo.MainForm.CS_StaLevel.SidePanel.rNozzleModel.Click();
			repo.MainForm.CS_StaLevel.SidePanel.rNozzleModel.PressKeys(cmNozzleModel + tabKey);
			Delay.Ms(tDelay);
			//input Arc angle (degrees) IB
			repo.MainForm.CS_StaLevel.SidePanel.rArc.DoubleClick();
			repo.MainForm.CS_StaLevel.SidePanel.rArc.PressKeys(cmArc + tabKey);
			Delay.Ms(tDelay);
			//input pressure IB
			repo.MainForm.CS_StaLevel.SidePanel.rPressure.DoubleClick();
			repo.MainForm.CS_StaLevel.SidePanel.rPressure.PressKeys(cmPressure + tabKey);
			Delay.Ms(tDelay);			
			//input number of sprinklers IB
			repo.MainForm.CS_StaLevel.SidePanel.rNumSprinklers.DoubleClick();
			repo.MainForm.CS_StaLevel.SidePanel.rNumSprinklers.PressKeys(cmNumSprinklers + tabKey);
			Delay.Ms(tDelay);			
			//input nozzle flow IB
			repo.MainForm.CS_StaLevel.SidePanel.rNozzleFlow.DoubleClick();
			repo.MainForm.CS_StaLevel.SidePanel.rNozzleFlow.PressKeys(cmNozzleFlow + tabKey);
			Delay.Ms(tDelay);
			//input back flow IB
			repo.MainForm.CS_StaLevel.SidePanel.rBackFlow.DoubleClick();
			repo.MainForm.CS_StaLevel.SidePanel.rBackFlow.PressKeys(cmBackFlow + tabKey);
			Delay.Ms(tDelay);			
			//input sta fllow IB
			repo.MainForm.CS_StaLevel.SidePanel.rStaFlow.DoubleClick();
			repo.MainForm.CS_StaLevel.SidePanel.rStaFlow.PressKeys(cmStaFlow + tabKey);
			Delay.Ms(tDelay);					
			//input precip rate IB
			repo.MainForm.CS_StaLevel.SidePanel.rPrecipRate.DoubleClick();
			repo.MainForm.CS_StaLevel.SidePanel.rPrecipRate.PressKeys(cmPrecipRate + tabKey);
			Delay.Ms(tDelay);			
			//input pattern DDL
			repo.MainForm.CS_StaLevel.SidePanel.rPattern.Click();
			repo.MainForm.CS_StaLevel.SidePanel.rPattern.PressKeys(cmPattern + tabKey);
			Delay.Ms(tDelay);			
			//input sprinkler specing IB
			repo.MainForm.CS_StaLevel.SidePanel.rSprinklerSpacing.DoubleClick();
			repo.MainForm.CS_StaLevel.SidePanel.rSprinklerSpacing.PressKeys(cmSprinklerSpacing + tabKey);
			Delay.Ms(tDelay);			
			//input row spacing IB
			repo.MainForm.CS_StaLevel.SidePanel.rRowSpacing.DoubleClick();
			repo.MainForm.CS_StaLevel.SidePanel.rRowSpacing.PressKeys(cmRowSpacing + tabKey);
			Delay.Ms(tDelay);	
			
			cmIteration++;
        }
    }
}
