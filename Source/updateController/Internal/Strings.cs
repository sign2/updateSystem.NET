﻿/*
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
namespace updateSystemDotNet.Internal {
	internal class Strings {
		/// <summary>
		/// Der Titel der in Nachrichtenfelder etc angezeigt werden soll
		/// </summary>
		public const string AppTitle = "updateSystem.NET";

		/// <summary>
		/// Der Registry-Path an welchem die Orte der PoolAssemblies gespeichert werden mit HKCU
		/// </summary>
		public const string CompleteAppRegHive = @"HKEY_CURRENT_USER\Software\updateSystem.NET\LastUpdateChecks\";

		/// <summary>
		/// Der Registry-Path an welchem die Orte der PoolAssemblies gespeichert werden ohne HKCU
		/// </summary>
		public const string AppRegHive = @"Software\updateSystem.NET\LastUpdateChecks\";
	}
}