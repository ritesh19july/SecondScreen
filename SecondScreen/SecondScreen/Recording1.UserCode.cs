﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// Your custom recording code should go in this file.
// The designer will only add methods to this file, so your custom code won't be overwritten.
// http://www.ranorex.com
// 
///////////////////////////////////////////////////////////////////////////////

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

namespace SecondScreen
{
    public partial class Recording1
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void Validate_DivTagCreatedNewTerm()
        {
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='\nCreated new term .') on item 'ShowsWWE.DivTagCreatedNewTerm'.", repo.ShowsWWE.DivTagCreatedNewTermInfo);
            Validate.Attribute(repo.ShowsWWE.DivTagCreatedNewTermInfo, "InnerText", "\nCreated new term .");
        }

        public void Mouse_Click_EditSubmit()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ShowsWWE.EditSubmit' at 53;6.", repo.ShowsWWE.EditSubmitInfo);
            repo.ShowsWWE.EditSubmit.Click("53;6");
        }

        public void Mouse_Click_EditParent()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ShowsWWE.EditParent' at 143;7.", repo.ShowsWWE.EditParentInfo);
            repo.ShowsWWE.EditParent.Click("143;7");
        }

        public void Mouse_DoubleClick_EditParent2()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'ShowsWWE.EditParent' at 391;60.", repo.ShowsWWE.EditParentInfo);
            repo.ShowsWWE.EditParent.DoubleClick("391;60");
        }

        public void Mouse_DoubleClick_EditParent1()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'ShowsWWE.EditParent' at 391;60.", repo.ShowsWWE.EditParentInfo);
            repo.ShowsWWE.EditParent.DoubleClick("391;60");
        }

        public void Mouse_DoubleClick_EditParent()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'ShowsWWE.EditParent' at 391;60.", repo.ShowsWWE.EditParentInfo);
            repo.ShowsWWE.EditParent.DoubleClick("391;60");
        }

        public void Mouse_Click_Relations()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ShowsWWE.Relations' at 44;10.", repo.ShowsWWE.RelationsInfo);
            repo.ShowsWWE.Relations.Click("44;10");
        }

        public void Key_Sequence_EditFieldDurationUnd0Value2()
        {
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '7{RShiftKey down}:{RShiftKey up}33' with focus on 'ShowsWWE.EditFieldDurationUnd0Value'.", repo.ShowsWWE.EditFieldDurationUnd0ValueInfo);
            repo.ShowsWWE.EditFieldDurationUnd0Value.PressKeys("7{RShiftKey down}:{RShiftKey up}33");
        }

        public void Key_Sequence_EditFieldDurationUnd0Value1()
        {
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{RShiftKey down}:{RShiftKey up}7{RShiftKey}{Back}0' with focus on 'ShowsWWE.EditFieldDurationUnd0Value'.", repo.ShowsWWE.EditFieldDurationUnd0ValueInfo);
            repo.ShowsWWE.EditFieldDurationUnd0Value.PressKeys("{RShiftKey down}:{RShiftKey up}7{RShiftKey}{Back}0");
        }

        public void Key_Sequence_EditFieldDurationUnd0Value()
        {
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '00' with focus on 'ShowsWWE.EditFieldDurationUnd0Value'.", repo.ShowsWWE.EditFieldDurationUnd0ValueInfo);
            repo.ShowsWWE.EditFieldDurationUnd0Value.PressKeys("00");
        }

        public void Mouse_Click_EditFieldDurationUnd0Value()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ShowsWWE.EditFieldDurationUnd0Value' at 390;19.", repo.ShowsWWE.EditFieldDurationUnd0ValueInfo);
            repo.ShowsWWE.EditFieldDurationUnd0Value.Click("390;19");
        }

        public void Mouse_Up_ShowsWWE()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'ShowsWWE' at 1365;471.", repo.ShowsWWE.SelfInfo);
            repo.ShowsWWE.Self.MoveTo("1365;471");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
        }

        public void Mouse_Down_ShowsWWE()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'ShowsWWE' at 1355;239.", repo.ShowsWWE.SelfInfo);
            repo.ShowsWWE.Self.MoveTo("1355;239");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
        }

        public void Key_Sequence_EditFieldExternalIdUnd0Value()
        {
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '4566' with focus on 'ShowsWWE.EditFieldExternalIdUnd0Value'.", repo.ShowsWWE.EditFieldExternalIdUnd0ValueInfo);
            repo.ShowsWWE.EditFieldExternalIdUnd0Value.PressKeys("4566");
        }

        public void Mouse_DoubleClick_EditFieldExternalIdUnd0Value()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'ShowsWWE.EditFieldExternalIdUnd0Value' at 74;8.", repo.ShowsWWE.EditFieldExternalIdUnd0ValueInfo);
            repo.ShowsWWE.EditFieldExternalIdUnd0Value.DoubleClick("74;8");
        }

        public void Key_Sequence_EditName()
        {
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LShiftKey down}F{LShiftKey up}resh{LShiftKey down}T{LShiftKey up}est' with focus on 'ShowsWWE.EditName'.", repo.ShowsWWE.EditNameInfo);
            repo.ShowsWWE.EditName.PressKeys("{LShiftKey down}F{LShiftKey up}resh{LShiftKey down}T{LShiftKey up}est");
        }

        public void Mouse_Click_EditName()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ShowsWWE.EditName' at 115;14.", repo.ShowsWWE.EditNameInfo);
            repo.ShowsWWE.EditName.Click("115;14");
        }

        public void Mouse_Click_AddTerm()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ShowsWWE.AddTerm' at 56;12.", repo.ShowsWWE.AddTermInfo);
            repo.ShowsWWE.AddTerm.Click("56;12");
        }

        public void Recording1_Open_Browser()
        {
            Report.Log(ReportLevel.Info, "Website", "Opening web site 'http://qa.wwe-app.cloud6.wwe.com/admin/structure/taxonomy/shows' with browser 'chrome' in normal mode.");
            Host.Local.OpenBrowser("http://qa.wwe-app.cloud6.wwe.com/admin/structure/taxonomy/shows", "chrome", "", false, false);
        }

        public void Validate_DivTagCreatedNewTerm1()
        {
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='\nCreated new term .') on item 'ShowsWWE.DivTagCreatedNewTerm'.", repo.ShowsWWE.DivTagCreatedNewTermInfo);
            Validate.Attribute(repo.ShowsWWE.DivTagCreatedNewTermInfo, "InnerText", "\nCreated new term .");
        }

        public void Mouse_Click_EditSubmit1()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ShowsWWE.EditSubmit' at 53;6.", repo.ShowsWWE.EditSubmitInfo);
            repo.ShowsWWE.EditSubmit.Click("53;6");
        }

        public void Mouse_Click_EditParent1()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ShowsWWE.EditParent' at 143;7.", repo.ShowsWWE.EditParentInfo);
           //repo.ShowsWWE.EditParent.Click("143;7");
           // repo.ShowsWWE.EditParent.Element.SetAttributeValue("InnerText","Second Screen Test Sessions");
           
           //get_Object("/dom[@caption='Shows | WWE']//select[@tagvalue='26001428']");
          
           //get_Object("/dom[@caption='Shows | WWE']//select[#'edit-parent']/option[@innertext='Second Screen Test Sessions']");
        }

        public void Mouse_DoubleClick_EditParent5()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'ShowsWWE.EditParent' at 391;60.", repo.ShowsWWE.EditParentInfo);
            repo.ShowsWWE.EditParent.DoubleClick("391;60");
        }

        public void Mouse_DoubleClick_EditParent4()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'ShowsWWE.EditParent' at 391;60.", repo.ShowsWWE.EditParentInfo);
            repo.ShowsWWE.EditParent.DoubleClick("391;60");
        }

        public void Mouse_DoubleClick_EditParent3()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'ShowsWWE.EditParent' at 391;60.", repo.ShowsWWE.EditParentInfo);
            //repo.ShowsWWE.EditParent.DoubleClick("391;60");
            repo.ShowsWWE.EditParent.DoubleClick("91;30");
        }

        public void Mouse_Click_Relations1()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ShowsWWE.Relations' at 44;10.", repo.ShowsWWE.RelationsInfo);
           // repo.ShowsWWE.Relations.Click("44;10");
           get_Object("/dom[@caption='Shows | WWE']//fieldset[#'edit-relations']//a[@innertext='Relations']");
        }

        public void Key_Sequence_EditFieldDurationUnd0Value5()
        {
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable $varDurationSec with focus on 'ShowsWWE.EditFieldDurationUnd0Value'.", repo.ShowsWWE.EditFieldDurationUnd0ValueInfo);
            repo.ShowsWWE.EditFieldDurationUnd0Value.PressKeys(varDurationSec);
        }

        public void Key_Sequence_EditFieldDurationUnd0Value4()
        {
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable $varDurationMin with focus on 'ShowsWWE.EditFieldDurationUnd0Value'.", repo.ShowsWWE.EditFieldDurationUnd0ValueInfo);
            repo.ShowsWWE.EditFieldDurationUnd0Value.PressKeys(varDurationMin);
        }

        public void Key_Sequence_EditFieldDurationUnd0Value3()
        {
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable $varDuration with focus on 'ShowsWWE.EditFieldDurationUnd0Value'.", repo.ShowsWWE.EditFieldDurationUnd0ValueInfo);
            repo.ShowsWWE.EditFieldDurationUnd0Value.PressKeys(varDuration);
        }

        public void Mouse_Click_EditFieldDurationUnd0Value1()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ShowsWWE.EditFieldDurationUnd0Value' at 390;19.", repo.ShowsWWE.EditFieldDurationUnd0ValueInfo);
            repo.ShowsWWE.EditFieldDurationUnd0Value.Click("390;19");
        }

        public void Mouse_Up_ShowsWWE1()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'ShowsWWE' at 1365;471.", repo.ShowsWWE.SelfInfo);
            repo.ShowsWWE.Self.MoveTo("1365;471");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
        }

        public void Mouse_Down_ShowsWWE1()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'ShowsWWE' at 1355;239.", repo.ShowsWWE.SelfInfo);
            repo.ShowsWWE.Self.MoveTo("1355;239");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
        }

        public void Key_Sequence_EditFieldExternalIdUnd0Value1()
        {
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable $varExternalId with focus on 'ShowsWWE.EditFieldExternalIdUnd0Value'.", repo.ShowsWWE.EditFieldExternalIdUnd0ValueInfo);
            repo.ShowsWWE.EditFieldExternalIdUnd0Value.PressKeys(varExternalId);
        }

        public void Mouse_DoubleClick_EditFieldExternalIdUnd0Value1()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'ShowsWWE.EditFieldExternalIdUnd0Value' at 74;8.", repo.ShowsWWE.EditFieldExternalIdUnd0ValueInfo);
            repo.ShowsWWE.EditFieldExternalIdUnd0Value.DoubleClick("74;8");
        }

        public void Key_Sequence_EditName1()
        {
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable $varShowsName with focus on 'ShowsWWE.EditName'.", repo.ShowsWWE.EditNameInfo);
            repo.ShowsWWE.EditName.PressKeys(varShowsName);
        }

        public void Mouse_Click_EditName1()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ShowsWWE.EditName' at 115;14.", repo.ShowsWWE.EditNameInfo);
           // repo.ShowsWWE.EditName.Click("115;14");
           get_Object("/dom[8]//input[#'edit-name']");
           
        }

        public void Mouse_Click_AddTerm1()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ShowsWWE.AddTerm' at 56;12.", repo.ShowsWWE.AddTermInfo);
            //repo.ShowsWWE.AddTerm.Click("56;12");
            get_Object("/dom[@caption='Shows | WWE' and @page='shows']//div[#'content']//a[@innertext='Add term']");
        }

        public void Recording1_Open_Browser1()
        {
            Report.Log(ReportLevel.Info, "Website", "Opening web site URL in variable $varURL with browser specified by variable $varBrowser in normal mode.");
            Host.Local.OpenBrowser(varURL, varBrowser, "", false, false);
        }
 		private void get_Object(string xpath)
        	{
				var elements = Ranorex.Host.Local.Find<Ranorex.Unknown>(xpath);
        		
				if(elements.Count>0)
		        	{
        			 elements[0].Click();
		        	}
			}

        public void Key_Sequence()
        {
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.");
            Keyboard.Press("{Tab}");
        }

    }
}