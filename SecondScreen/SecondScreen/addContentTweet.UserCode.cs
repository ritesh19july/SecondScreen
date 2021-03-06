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
    public partial class AddContentTweet
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void Mouse_Up_DropMeWhereIShouldAppear()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'ShowsWWE.DropMeWhereIShouldAppear' at 10;10.", repo.ShowsWWE.DropMeWhereIShouldAppearInfo);
            //repo.ShowsWWE.DropMeWhereIShouldAppear.MoveTo("10;10");
            repo.ShowsWWE.InnerContent.MoveTo("50;50");
            Ranorex.Delay.Seconds(1);
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
        }

        public void Mouse_Down_HttpQaWweAppCloud6WweComFeedsW1()
        {
             Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'ShowsWWE.HttpQaWweAppCloud6WweComFeedsW1' at 10;10.", repo.ShowsWWE.HttpQaWweAppCloud6WweComFeedsW1Info);
             repo.ShowsWWE.HttpQaWweAppCloud6WweComFeedsW1.MoveTo("10;10");
             Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
              Ranorex.Delay.Seconds(1);
            
        }

        public void Mouse_Click_RTAtWadeBarrettHowAboutThatAtWayne1()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ShowsWWE.RTAtWadeBarrettHowAboutThatAtWayne1' at 156;5.", repo.ShowsWWE.RTAtWadeBarrettHowAboutThatAtWayne1Info);
            repo.ShowsWWE.RTAtWadeBarrettHowAboutThatAtWayne1.Click("156;5");
        }

        public void Mouse_Click_HttpQaWweAppCloud6WweComFeedsW()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ShowsWWE.HttpQaWweAppCloud6WweComFeedsW' at 11;8.", repo.ShowsWWE.HttpQaWweAppCloud6WweComFeedsWInfo);
           // repo.ShowsWWE.HttpQaWweAppCloud6WweComFeedsW.Click("11;8");
        }

        public void Mouse_Click_OnTweet()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ShowsWWE.UiAccordionAccordionHeader6' at 97;13.", repo.ShowsWWE.UiAccordionAccordionHeader6Info);
            //repo.ShowsWWE.UiAccordionAccordionHeader6.Click("97;13");
           clickOnObject("/dom[@caption='WWE']//h3[#'ui-accordion-accordion-header-6']/a[@innertext='Tweet']");
          
        }
         public void clickOnObject(string xpath)
        	{
				var elements = Ranorex.Host.Local.Find<Ranorex.Unknown>(xpath);
        		
				if(elements.Count>0)
		        	{
        			 elements[0].Click();
		        	}
			}
         public void dragNDrop(){
         	//Object.click();
			Ranorex.Delay.Milliseconds(400);
			Mouse.ButtonDown(WinForms.MouseButtons.Left);
			Ranorex.Delay.Milliseconds(400);
			//parentObject.MoveTo(position);
			Ranorex.Delay.Milliseconds(400);
			Mouse.ButtonUp(WinForms.MouseButtons.Left);
         }

        public void Mouse_Click_HttpWweDevWweAppCloud14WweComF()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ShowsWWE.HttpWweDevWweAppCloud14WweComF' at 9;12.", repo.ShowsWWE.HttpWweDevWweAppCloud14WweComFInfo);
            repo.ShowsWWE.HttpWweDevWweAppCloud14WweComF.Click("9;12");
        }

        public void Key_Sequence1()
        {
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.");
            Keyboard.Press("{Tab}");
        }

       

        public void Key_Sequence_EditTweetSiid()
        {
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable $varNID with focus on 'ShowsWWE.EditTweetSiid'.", repo.ShowsWWE.EditTweetSiidInfo);
            repo.ShowsWWE.EditTweetSiid.PressKeys(varNID);
        }

        public void Key_Sequence_EditTweetSiid1()
        {
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back 15}' with focus on 'ShowsWWE.EditTweetSiid'.", repo.ShowsWWE.EditTweetSiidInfo);
            repo.ShowsWWE.EditTweetSiid.PressKeys("{Back 1}");
        }

        public void Mouse_Click_EditTweetSiid()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ShowsWWE.EditTweetSiid' at 73;8.", repo.ShowsWWE.EditTweetSiidInfo);
            repo.ShowsWWE.EditTweetSiid.Click("73;8");
        }

    }
}