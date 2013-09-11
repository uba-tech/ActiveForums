﻿//
// Active Forums - http://www.dnnsoftware.com
// Copyright (c) 2013
// by DNN Corp.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated 
// documentation files (the "Software"), to deal in the Software without restriction, including without limitation 
// the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and 
// to permit persons to whom the Software is furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all copies or substantial portions 
// of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED 
// TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL 
// THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF 
// CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER 
// DEALINGS IN THE SOFTWARE.
//
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

using System.ComponentModel;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DotNetNuke.Modules.ActiveForums.Controls
{
	[DefaultProperty("Text"), ToolboxData("<{0}:HtmlControlLoader runat=server></{0}:HtmlControlLoader>")]
	public class HtmlControlLoader : Control
	{
		public string ControlId {get; set;}
		public string Height {get; set;}
		public string Width {get; set;}
		public string Name {get; set;}
		public string FilePath {get; set;}
		protected override void Render(HtmlTextWriter writer)
		{
			this.EnableViewState = false;
			FilePath = HttpContext.Current.Server.MapPath(FilePath);
			string sControl = Utilities.GetFile(FilePath);
			sControl = sControl.Replace("{id}", ControlId);
			sControl = sControl.Replace("{height}", Height);
			sControl = sControl.Replace("{width}", Width);
			sControl = sControl.Replace("{name}", Name);
			writer.Write(sControl);
		}

	}
}

