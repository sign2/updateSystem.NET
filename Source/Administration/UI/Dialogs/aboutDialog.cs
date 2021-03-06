﻿/**
 * updateSystem.NET
 * Copyright (c) 2008-2012 Maximilian Krauss <http://coffeeInjection.com> eMail: max@coffeeInjection.com
 *
 * This library is licened under The Code Project Open License (CPOL) 1.02
 * which can be found online at <http://www.codeproject.com/info/cpol10.aspx>
 * 
 * THIS WORK IS PROVIDED "AS IS", "WHERE IS" AND "AS AVAILABLE", WITHOUT
 * ANY EXPRESS OR IMPLIED WARRANTIES OR CONDITIONS OR GUARANTEES. YOU,
 * THE USER, ASSUME ALL RISK IN ITS USE, INCLUDING COPYRIGHT INFRINGEMENT,
 * PATENT INFRINGEMENT, SUITABILITY, ETC. AUTHOR EXPRESSLY DISCLAIMS ALL
 * EXPRESS, IMPLIED OR STATUTORY WARRANTIES OR CONDITIONS, INCLUDING
 * WITHOUT LIMITATION, WARRANTIES OR CONDITIONS OF MERCHANTABILITY,
 * MERCHANTABLE QUALITY OR FITNESS FOR A PARTICULAR PURPOSE, OR ANY
 * WARRANTY OF TITLE OR NON-INFRINGEMENT, OR THAT THE WORK (OR ANY
 * PORTION THEREOF) IS CORRECT, USEFUL, BUG-FREE OR FREE OF VIRUSES.
 * YOU MUST PASS THIS DISCLAIMER ON WHENEVER YOU DISTRIBUTE THE WORK OR
 * DERIVATIVE WORKS.
 */
using System;
using System.Diagnostics;
using System.Reflection;
using updateSystemDotNet.Administration.Core;

namespace updateSystemDotNet.Administration.UI.Dialogs {
	internal partial class aboutDialog : dialogBase {
		public aboutDialog() {
			InitializeComponent();
			btnClose.Click += btnClose_Click;
			imgAppLogo.Image = resourceHelper.getImage("app_logo_big.png");
			imgDonate.Image = resourceHelper.getImage("paypalDonate.gif");
			lblAppName.Text = Strings.applicationInternalName;
		}

		public override void localizeDialog() {
			base.localizeDialog();
			lblVersion.Text = string.Format(Session.getLocalizedString(lblVersion),
			                                Assembly.GetExecutingAssembly().GetName().Version, Session.applicationCodeName);
			lblAppName.Text = Session.applicationName;
			lblCopyright.linkText = string.Format(Session.getLocalizedString(lblCopyright), DateTime.Now.Year);
		}

		private void btnClose_Click(object sender, EventArgs e) {
			Close();
		}

		private void imgDonate_Click(object sender, EventArgs e) {
			Process.Start(Strings.urlDonate);
		}
	}
}