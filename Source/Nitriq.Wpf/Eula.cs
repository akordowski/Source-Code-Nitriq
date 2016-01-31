using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace Nitriq.Wpf
{
	public class Eula : Window, IComponentConnector
	{
		private string string_0 = "END-USER LICENSE AGREEMENT FOR NITRIQ CODE ANALYSIS\r\nIMPORTANT PLEASE READ THE TERMS AND CONDITIONS OF THIS LICENSE AGREEMENT CAREFULLY BEFORE CONTINUING WITH THIS PROGRAM INSTALL: Nitriq Code Analysis End-User License Agreement (\"EULA\") is a legal agreement between you (\"CUSTOMER\") (either an individual or a single entity) and Jon von Gillern. For the software product identified above which may include associated software components, media, printed materials, and \"online\" or electronic documentation (\"SOFTWARE PRODUCT\"). By installing, copying, or otherwise using the SOFTWARE PRODUCT, you agree to be bound by the terms of this EULA. This license agreement represents the entire agreement concerning the program between you and Jon von Gillern, (referred to as \"licenser\"), and it supersedes any prior proposal, representation, or understanding between the parties. If you do not agree to the terms of this EULA, do not install or use the SOFTWARE PRODUCT.\r\n\r\nThe SOFTWARE PRODUCT is protected by copyright laws and international copyright treaties, as well as other intellectual property laws and treaties. The SOFTWARE PRODUCT is licensed, not sold.\r\n\r\n1. GRANT OF LICENSE.\r\nThe SOFTWARE PRODUCT is licensed as follows:\r\n(a) Installation and Use.\r\nJon von Gillern grants you the right to install and use copies of the SOFTWARE PRODUCT on your computer running a validly licensed copy of the operating system for which the SOFTWARE PRODUCT was designed (Any Version of Microsoft Windows that has the .Net Framework 3.5 SP1 installed)\r\n(b) Backup Copies.\r\nYou may also make copies of the SOFTWARE PRODUCT as may be necessary for backup and archival purposes.\r\n\r\n2. DESCRIPTION OF OTHER RIGHTS AND LIMITATIONS.\r\n(a) Maintenance of Copyright Notices.\r\nYou must not remove or alter any copyright notices on any and all copies of the SOFTWARE PRODUCT.\r\n(b) Distribution.\r\nYou may not distribute registered copies of the SOFTWARE PRODUCT to third parties. Evaluation versions available for download from Jon von Gillern's websites may be freely distributed.\r\n(c) Prohibition on Reverse Engineering, Decompilation, and Disassembly.\r\nYou may not reverse engineer, decompile, or disassemble the SOFTWARE PRODUCT, except and only to the extent that such activity is expressly permitted by applicable law notwithstanding this limitation.\r\n(d) Rental.\r\nYou may not rent, lease, or lend the SOFTWARE PRODUCT.\r\n(e) Support Services.\r\nJon von Gillern may provide you with support services related to the SOFTWARE PRODUCT (\"Support Services\"). Any supplemental software code provided to you as part of the Support Services shall be considered part of the SOFTWARE PRODUCT and subject to the terms and conditions of this EULA.\r\n(f) Compliance with Applicable Laws.\r\nYou must comply with all applicable laws regarding use of the SOFTWARE PRODUCT.\r\n\r\n3. TERMINATION\r\nWithout prejudice to any other rights, Jon von Gillern may terminate this EULA if you fail to comply with the terms and conditions of this EULA. In such event, you must destroy all copies of the SOFTWARE PRODUCT in your possession.\r\n\r\n4. COPYRIGHT\r\nAll title, including but not limited to copyrights, in and to the SOFTWARE PRODUCT and any copies thereof are owned by Jon von Gillern or its suppliers. All title and intellectual property rights in and to the content which may be accessed through use of the SOFTWARE PRODUCT is the property of the respective content owner and may be protected by applicable copyright or other intellectual property laws and treaties. This EULA grants you no rights to use such content. All rights not expressly granted are reserved by Jon von Gillern.\r\n\r\n5. NO WARRANTIES\r\nJon von Gillern expressly disclaims any warranty for the SOFTWARE PRODUCT. The SOFTWARE PRODUCT is provided 'As Is' without any express or implied warranty of any kind, including but not limited to any warranties of merchantability, noninfringement, or fitness of a particular purpose. Jon von Gillern does not warrant or assume responsibility for the accuracy or completeness of any information, text, graphics, links or other items contained within the SOFTWARE PRODUCT. Jon von Gillern makes no warranties respecting any harm that may be caused by the transmission of a computer virus, worm, time bomb, logic bomb, or other such computer program. Jon von Gillern further expressly disclaims any warranty or representation to Authorized Users or to any third party.\r\n\r\n6. LIMITATION OF LIABILITY\r\nIn no event shall Jon von Gillern be liable for any damages (including, without limitation, lost profits, business interruption, or lost information) rising out of 'Authorized Users' use of or inability to use the SOFTWARE PRODUCT, even if Jon von Gillern has been advised of the possibility of such damages. In no event will Jon von Gillern be liable for loss of data or for indirect, special, incidental, consequential (including lost profit), or other damages based in contract, tort or otherwise. Jon von Gillern shall have no liability with respect to the content of the SOFTWARE PRODUCT or any part thereof, including but not limited to errors or omissions contained therein, libel, infringements of rights of publicity, privacy, trademark rights, business interruption, personal injury, loss of privacy, moral rights or the disclosure of confidential information.\r\n\r\n7. LIMITATION OF USE\r\nUnder no circumstances may the CUSTOMER use the SOFTWARE PRODUCT to analyze any other assembly or executable where the malfunction thereof could result in the loss of life or limb. ";

		internal RadioButton radioButton_0;

		internal RadioButton radioButton_1;

		internal TextBox textBox_0;

		private bool bool_0;

		public Eula()
		{
			this.InitializeComponent();
			this.textBox_0.Text = this.string_0;
		}

		private void method_0(object sender, RoutedEventArgs e)
		{
			base.DialogResult = new bool?(false);
			base.Close();
		}

		private void method_1(object sender, RoutedEventArgs e)
		{
			base.DialogResult = new bool?(true);
			base.Close();
		}

		[DebuggerNonUserCode]
		public void InitializeComponent()
		{
			if (!this.bool_0)
			{
				this.bool_0 = true;
				Uri resourceLocator = new Uri("/Nitriq.Wpf;component/eula.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never), DebuggerNonUserCode]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				((Button)target).Click += new RoutedEventHandler(this.method_0);
				break;
			case 2:
				((Button)target).Click += new RoutedEventHandler(this.method_1);
				break;
			case 3:
				this.radioButton_0 = (RadioButton)target;
				break;
			case 4:
				this.radioButton_1 = (RadioButton)target;
				break;
			case 5:
				this.textBox_0 = (TextBox)target;
				break;
			default:
				this.bool_0 = true;
				break;
			}
		}
	}
}
