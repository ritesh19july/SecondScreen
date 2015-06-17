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
    public partial class ActiveContent
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        static Bitmap secondImage;
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void Mouse_Click_Tweet567800697372024832()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ShowsWWE.Tweet567800697372024832' at 5;2.", repo.ShowsWWE.Tweet567800697372024832Info);
            repo.ShowsWWE.Tweet567800697372024832.Click("5;2");
        }

        public void Mouse_Click_Tweet567800857355415552()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ShowsWWE.Tweet567800857355415552' at 0;0.", repo.ShowsWWE.Tweet567800857355415552Info);
            repo.ShowsWWE.Tweet567800857355415552.Click("0;0");
        }

        public void Mouse_Click_HttpQaWweAppCloud6WweComFStyle()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ShowsWWE.HttpQaWweAppCloud6WweComFStyle' at 193;71.", repo.ShowsWWE.HttpQaWweAppCloud6WweComFStyleInfo);
            repo.ShowsWWE.HttpQaWweAppCloud6WweComFStyle.Click("193;71");
        }

        public void activeContent_Open_Browser()
        {
            Report.Log(ReportLevel.Info, "Website", "Opening web site URL in variable $varURL with browser specified by variable $varBrowser in normal mode.");
            Host.Local.OpenBrowser(varURL, varBrowser, "", false, false);
        }
        
        private void storeImage(){
        	
            String CurrentTimestamp = System.DateTime.Now.ToString("dd_MM_yyyy_HH_mm_ss");
			Console.WriteLine(CurrentTimestamp);
        	
			String name1="2a_"+CurrentTimestamp+".png";
        	Console.WriteLine(name1);
			//name1="D:/CaptureImage/"+name1;    	
		     name1="D:/CaptureImage/secondImage.png";  
            //Get the Object from Production URL
            Report.Log(ReportLevel.Info, "Snapshot", "Capturing Screenshot from Production URL");
        	secondImage = get_Snapshot("/dom[5]//div[#'content-item-44682-container']/img[@src='http://qa.wwe-app.cloud6.wwe.com/f/styles/active_1/public/wweactive/photo/2015/01/1-7/raw_extra_teaser.jpg']");
			secondImage.Save(name1, System.Drawing.Imaging.ImageFormat.Png);
        	//Compare Images:-
        		Ranorex.Report.Success("Image saved successfully");
	
        }
        private Bitmap get_Snapshot(string xpath)
        		{
				var elements = Ranorex.Host.Local.Find<Ranorex.Unknown>(xpath);
        			if(elements.Count>0)
		        	{
		        		return elements[0].CaptureCompressedImage();
		        	}
        			else
		        	{
		        		return null;
		        	}
			}
        private void validateImage(String img1,String img2){
              	if (Ranorex.Imaging.Compare(ManageContentNew.firstImage,secondImage,0.95))
        		Ranorex.Report.Success("Image is Same.");
        	else
        		Ranorex.Report.Failure("Image is not same.");
        }

        public void Validate_HttpQaWweAppCloud6WweComFStyle1()
        {
            Report.Log(ReportLevel.Info, "Validation", "Validating CompareImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=874,Height=378}) on item 'ShowsWWE.HttpQaWweAppCloud6WweComFStyle1'.", repo.ShowsWWE.HttpQaWweAppCloud6WweComFStyle1Info);
            Validate.CompareImage(repo.ShowsWWE.HttpQaWweAppCloud6WweComFStyle1Info, HttpQaWweAppCloud6WweComFStyle1_Screenshot1, HttpQaWweAppCloud6WweComFStyle1_Screenshot1_Options);
        }
    }
}