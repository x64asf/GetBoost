using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetBoost
{
    public partial class Form1 : Form
    {
		enum RecycleFlags : uint
		{
			SHERB_NOCONFIRMATION = 0x00000001,
			SHERB_NOPROGRESSUI = 0x00000002,
			SHERB_NOSOUND = 0x00000004
		}

		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;

		[System.Runtime.InteropServices.DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[System.Runtime.InteropServices.DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		[DllImport("Shell32.dll", CharSet = CharSet.Unicode)]
		private static extern uint SHEmptyRecycleBin(IntPtr hwnd, string pszRootPath, Form1.RecycleFlags dwFlags);

		public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "GetBoost 1.5 || Overlay";
            label1.Text = "GetBoost 1.5 || Welcome " + Environment.UserName;

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(-1);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            try
            {
                Process process = new Process();
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.Arguments = "/C bcdedit /deletevalue useplatformclock";
                process.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
                process.Start();
                this.ptim.Text = "HPET Closing...";
                process.WaitForExit();
                this.ptim.Text = "HPET Close Succes.";
            }
            catch
            {
                this.ptim.Text = "HPET Close Failure 0xG.";
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            try
            {
                Process process = new Process();
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.Arguments = "/C powercfg -duplicatescheme E9A42B02-D5DF-448D-AA00-03F14749EB61";
                process.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
                process.Start();
                this.ptim.Text = "Changing Power Mode...";
                process.WaitForExit();
                this.ptim.Text = "Changing Power Mode Succes. You Need To Select It.";
            }
            catch
            {
                this.ptim.Text = "Changing Power Mode Failure 0xG.";
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
			this.ptim.Text = "Turning Off Unnecessary Services...";
			try
			{
				ServiceController serviceController = new ServiceController("MixedRealityOpenXRSvc");
				TimeSpan timeout = TimeSpan.FromMilliseconds(1000.0);
				serviceController.Stop();
				serviceController.WaitForStatus(ServiceControllerStatus.Stopped, timeout);
				try
				{
					ServiceController serviceController2 = new ServiceController("WerSvc");
					TimeSpan timeout2 = TimeSpan.FromMilliseconds(1000.0);
					serviceController2.Stop();
					serviceController2.WaitForStatus(ServiceControllerStatus.Stopped, timeout2);
				}
				catch
				{
				}
				try
				{
					ServiceController serviceController3 = new ServiceController("WSearch");
					TimeSpan timeout3 = TimeSpan.FromMilliseconds(1000.0);
					serviceController3.Stop();
					serviceController3.WaitForStatus(ServiceControllerStatus.Stopped, timeout3);
				}
				catch
				{
				}
				try
				{
					ServiceController serviceController4 = new ServiceController("wisvc");
					TimeSpan timeout4 = TimeSpan.FromMilliseconds(1000.0);
					serviceController4.Stop();
					serviceController4.WaitForStatus(ServiceControllerStatus.Stopped, timeout4);
				}
				catch
				{
				}
				try
				{
					ServiceController serviceController5 = new ServiceController("FontCache");
					TimeSpan timeout5 = TimeSpan.FromMilliseconds(1000.0);
					serviceController5.Stop();
					serviceController5.WaitForStatus(ServiceControllerStatus.Stopped, timeout5);
				}
				catch
				{
				}
				try
				{
					ServiceController serviceController6 = new ServiceController("WbioSrvc");
					TimeSpan timeout6 = TimeSpan.FromMilliseconds(1000.0);
					serviceController6.Stop();
					serviceController6.WaitForStatus(ServiceControllerStatus.Stopped, timeout6);
				}
				catch
				{
				}
				try
				{
					ServiceController serviceController7 = new ServiceController("WalletService");
					TimeSpan timeout7 = TimeSpan.FromMilliseconds(1000.0);
					serviceController7.Stop();
					serviceController7.WaitForStatus(ServiceControllerStatus.Stopped, timeout7);
				}
				catch
				{
				}
				try
				{
					ServiceController serviceController8 = new ServiceController("PlugPlay");
					TimeSpan timeout8 = TimeSpan.FromMilliseconds(1000.0);
					serviceController8.Stop();
					serviceController8.WaitForStatus(ServiceControllerStatus.Stopped, timeout8);
				}
				catch
				{
				}
				try
				{
					ServiceController serviceController9 = new ServiceController("SEMgrSvc");
					TimeSpan timeout9 = TimeSpan.FromMilliseconds(1000.0);
					serviceController9.Stop();
					serviceController9.WaitForStatus(ServiceControllerStatus.Stopped, timeout9);
				}
				catch
				{
				}
				try
				{
					ServiceController serviceController10 = new ServiceController("wuauserv");
					TimeSpan timeout10 = TimeSpan.FromMilliseconds(1000.0);
					serviceController10.Stop();
					serviceController10.WaitForStatus(ServiceControllerStatus.Stopped, timeout10);
				}
				catch
				{
				}
			}
			catch
			{
			}
			this.ptim.Text = "Turn Off Unnecessary Services Successful.";
		}

        private void guna2Button6_Click(object sender, EventArgs e)
        {
			try
			{
				Process process = new Process();
				process.StartInfo.FileName = Application.StartupPath + "\\comp\\toff10-10-21.reg";
				process.StartInfo.Arguments = "true";
				process.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
				process.Start();
				this.ptim.Text = "Telemetry Closing...";
				process.WaitForExit();
				this.ptim.Text = "Telemetry Close Succes.";
			}
			catch
			{
				this.ptim.Text = "Telemetry Close Failure 0xG.";
			}
		}

        private void guna2Button7_Click(object sender, EventArgs e)
        {
			try
			{
				Process process = new Process();
				process.StartInfo.FileName = "cmd.exe";
				process.StartInfo.Arguments = "/c reg.exe add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\BackgroundAccessApplications /v GlobalUserDisabled /t REG_DWORD /d 0 /f";
				process.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
				process.Start();
				this.ptim.Text = "Background Apps Closing...";
				process.WaitForExit();
				this.ptim.Text = "Background Apps Closing Succes.";
			}
			catch
			{
				this.ptim.Text = "Background Apps Closing Failure 0xG.";
			}
		}

        private void guna2Button12_Click(object sender, EventArgs e)
        {
			try
			{
				this.ptim.Text = "Registry Editing...";
				RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", RegistryKeyPermissionCheck.ReadWriteSubTree);
				registryKey.SetValue("TaskbarSi", "0", RegistryValueKind.DWord);
				this.ptim.Text = "Registry Editing Succes. (You Need Restart).";
			}
			catch
			{
				this.ptim.Text = "Registry Editing Failure 0xG.";
			}
		}

        private void guna2Button11_Click(object sender, EventArgs e)
        {
			try
			{
				this.ptim.Text = "Registry Editing...";
				RegistryKey registryKey = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Control", RegistryKeyPermissionCheck.ReadWriteSubTree);
				registryKey.SetValue("WaitToKillServiceTimeout", "100");
				this.ptim.Text = "Registry Editing Succes. (You Need Restart).";
			}
			catch
			{
				this.ptim.Text = "Registry Editing Failure 0xG.";
			}
		}

        private void guna2Button10_Click(object sender, EventArgs e)
        {
			try
			{
				this.ptim.Text = "Registry Editing...";
				RegistryKey registryKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", RegistryKeyPermissionCheck.ReadWriteSubTree);
				registryKey.SetValue("VerboseStatus", "1", RegistryValueKind.DWord);
				this.ptim.Text = "Registry Editing Succes. (You Need Restart).";
			}
			catch
			{
				this.ptim.Text = "Registry Editing Failure 0xG.";

			}
		}

        private void guna2Button9_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button17_Click(object sender, EventArgs e)
        {
			try
			{
				this.ptim.Text = "Registry Editing...";
				RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", RegistryKeyPermissionCheck.ReadWriteSubTree);
				registryKey.DeleteValue("TaskbarSi");
				this.ptim.Text = "Registry Editing Succes. (You Need Restart).";
			}
			catch
			{
				this.ptim.Text = "Registry Editing Failure 0xG.";
			}
		}

        private void guna2Button16_Click(object sender, EventArgs e)
        {
			try
			{
				this.ptim.Text = "Registry Editing...";
				RegistryKey registryKey = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Control", RegistryKeyPermissionCheck.ReadWriteSubTree);
				registryKey.SetValue("WaitToKillServiceTimeout", "5000");
				this.ptim.Text = "Registry Editing Succes. (You Need Restart).";
			}
			catch
			{
				this.ptim.Text = "Registry Editing Failure 0xG.";
			}
		}

        private void guna2Button15_Click(object sender, EventArgs e)
        {
			try
			{
				this.ptim.Text = "Registry Editing...";
				RegistryKey registryKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", RegistryKeyPermissionCheck.ReadWriteSubTree);
				registryKey.DeleteValue("VerboseStatus");
				this.ptim.Text = "Registry Editing Succes. (You Need Restart).";
			}
			catch
			{
				this.ptim.Text = "Registry Editing Failure 0xG.";

			}
		}

        private void guna2Button14_Click(object sender, EventArgs e)
        {
			try
			{
				this.ptim.Text = "Registry Editing...";
				RegistryKey registryKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", RegistryKeyPermissionCheck.ReadWriteSubTree);
				registryKey.SetValue("legalnoticecaption", "");
				this.ptim.Text = "Registry Editing Succes. (You Need Restart).";
			}
			catch
			{
				this.ptim.Text = "Registry Editing Failure 0xG.";

			}
		}

        private void guna2Button13_Click(object sender, EventArgs e)
        {
			try
			{
				this.ptim.Text = "Registry Editing...";
				RegistryKey registryKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", RegistryKeyPermissionCheck.ReadWriteSubTree);
				registryKey.SetValue("legalnoticetext", "");
				this.ptim.Text = "Registry Editing Succes. (You Need Restart).";
			}
			catch
			{
				this.ptim.Text = "Registry Editing Failure 0xG.";

			}
		}

        private void guna2Button22_Click(object sender, EventArgs e)
        {
			try
			{
				Process process = new Process();
				process.StartInfo.FileName = "cmd.exe";
				process.StartInfo.Arguments = "/c %SystemRoot%\\SysWOW64\\OneDriveSetup.exe /uninstall";
				process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				Stopwatch stopwatch = new Stopwatch();
				stopwatch.Start();
				process.Start();
				this.ptim.Text = "Uninstalling OneDrive";
				process.WaitForExit();
				this.ptim.Text = "The Passing Time: " + stopwatch.Elapsed.Seconds.ToString() + " seconds, Uninstall Succes...";
			}
			catch
			{
				this.ptim.Text = "Uninstall Failure 0xG.";

			}
		}

        private void guna2Button21_Click(object sender, EventArgs e)
        {
			try
			{
				Process process = new Process();
				process.StartInfo.FileName = "cmd.exe";
				process.StartInfo.Arguments = "/c %SystemRoot%\\System32\\OneDriveSetup.exe /uninstall";
				process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				Stopwatch stopwatch = new Stopwatch();
				stopwatch.Start();
				process.Start();
				this.ptim.Text = "Uninstalling OneDrive";
				process.WaitForExit();
				this.ptim.Text = "The Passing Time: " + stopwatch.Elapsed.Seconds.ToString() + " seconds, Uninstall Succes...";
			}
			catch
			{
				this.ptim.Text = "Uninstall Failure 0xG.";

			}
		}

        private void guna2Button20_Click(object sender, EventArgs e)
        {
			try
			{
				Process process = new Process();
				process.StartInfo.FileName = "powershell.exe";
				process.StartInfo.Arguments = "Get-AppxPackage -allusers Microsoft.549981C3F5F10 | Remove-AppxPackage";
				process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				Stopwatch stopwatch = new Stopwatch();
				stopwatch.Start();
				process.Start();
				this.ptim.Text = "Uninstalling Cortana";
				process.WaitForExit();
				this.ptim.Text = "The Passing Time: " + stopwatch.Elapsed.Seconds.ToString() + " seconds, Uninstall Succes...";
			}
			catch
			{
				this.ptim.Text = "Uninstall Failure 0xG.";

			}
		}

        private void guna2Button19_Click(object sender, EventArgs e)
        {
			try
			{
				Process process = new Process();
				process.StartInfo.FileName = "powershell.exe";
				process.StartInfo.Arguments = "Get-AppxPackage *Microsoft.YourPhone* -AllUsers | Remove-AppxPackage";
				process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				Stopwatch stopwatch = new Stopwatch();
				stopwatch.Start();
				process.Start();
				this.ptim.Text = "Uninstalling Your Phone";
				process.WaitForExit();
				this.ptim.Text = "The Passing Time: " + stopwatch.Elapsed.Seconds.ToString() + " seconds, Uninstall Succes...";
			}
			catch
			{
				this.ptim.Text = "Uninstall Failure 0xG.";

			}
		}

        private void guna2Button18_Click(object sender, EventArgs e)
        {
			try
			{
				Process process = new Process();
				process.StartInfo.FileName = "cmd.exe";
				process.StartInfo.Arguments = "/c sc stop wuauserv";
				process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				Stopwatch stopwatch = new Stopwatch();
				stopwatch.Start();
				process.Start();
				this.ptim.Text = "Stopping Update Service";
				process.WaitForExit();
				this.ptim.Text = "The Passing Time: " + stopwatch.Elapsed.Seconds.ToString() + " seconds, Stopping Update Service Succes...";
			}
			catch
			{
				this.ptim.Text = "Stop Failure 0xG.";

			}
		}

        private void guna2Button27_Click(object sender, EventArgs e)
        {
			try
			{
				Process process = new Process();
				process.StartInfo.FileName = "cmd.exe";
				process.StartInfo.Arguments = "/c %SystemRoot%\\SysWOW64\\OneDriveSetup.exe /install";
				process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				Stopwatch stopwatch = new Stopwatch();
				stopwatch.Start();
				process.Start();
				this.ptim.Text = "Installing OneDrive";
				process.WaitForExit();
				this.ptim.Text = "The Passing Time: " + stopwatch.Elapsed.Seconds.ToString() + " seconds, Install Succes...";
			}
			catch
			{
				this.ptim.Text = "Install Failure 0xG.";

			}
		}

        private void guna2Button26_Click(object sender, EventArgs e)
        {
			try
			{
				Process process = new Process();
				process.StartInfo.FileName = "cmd.exe";
				process.StartInfo.Arguments = "/c %SystemRoot%\\System32\\OneDriveSetup.exe /install";
				process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				Stopwatch stopwatch = new Stopwatch();
				stopwatch.Start();
				process.Start();
				this.ptim.Text = "Installing OneDrive";
				process.WaitForExit();
				this.ptim.Text = "The Passing Time: " + stopwatch.Elapsed.Seconds.ToString() + " seconds, Install Succes...";
			}
			catch
			{
				this.ptim.Text = "Install Failure 0xG.";

			}
		}

        private void guna2Button25_Click(object sender, EventArgs e)
        {
			try
			{
				Process process = new Process();
				process.StartInfo.FileName = "powershell.exe";
				process.StartInfo.Arguments = "Get-AppxPackage Microsoft.Windows.Cortana | Foreach {Add-AppxPackage -DisableDevelopmentMode -Register $($_.InstallLocation)\\AppXManifest.xml}";
				process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				Stopwatch stopwatch = new Stopwatch();
				stopwatch.Start();
				process.Start();
				this.ptim.Text = "Installing Cortana";
				process.WaitForExit();
				this.ptim.Text = "The Passing Time: " + stopwatch.Elapsed.Seconds.ToString() + " seconds, Install Succes...";
			}
			catch
			{
				this.ptim.Text = "Install Failure 0xG.";

			}
		}

        private void guna2Button23_Click(object sender, EventArgs e)
        {
			try
			{
				Process process = new Process();
				process.StartInfo.FileName = "cmd.exe";
				process.StartInfo.Arguments = "/c sc start wuauserv";
				process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				Stopwatch stopwatch = new Stopwatch();
				stopwatch.Start();
				process.Start();
				this.ptim.Text = "Starting Update Service";
				process.WaitForExit();
				this.ptim.Text = "The Passing Time: " + stopwatch.Elapsed.Seconds.ToString() + " seconds, Starting Update Service Succes...";
			}
			catch
			{
				this.ptim.Text = "Start Failure 0xG.";

			}
		}

		private void CleanTemporaryFolders()
		{
			string folderName = Environment.ExpandEnvironmentVariables("%TEMP%");
			string folderName2 = Environment.ExpandEnvironmentVariables("%SYSTEMROOT%") + "\\Prefetch";
			this.EmptyFolderContents(folderName);
			this.EmptyFolderContents(folderName2);
		}

		private void EmptyFolderContents(string folderName)
		{
			foreach (string text in Directory.GetDirectories(folderName))
			{
				try
				{
					Directory.Delete(text, true);
				}
				catch (Exception value)
				{
					Debug.WriteLine(value);
				}
			}
			foreach (string text2 in Directory.GetFiles(folderName))
			{
				try
				{
					File.Delete(text2);
				}
				catch (Exception value2)
				{
					Debug.WriteLine(value2);
				}
			}
		}

		private void guna2Button30_Click(object sender, EventArgs e)
        {
			try
			{
				this.ptim.Text = "Temp Cleaning ...";
				this.CleanTemporaryFolders();
				this.ptim.Text = "Temp Cleaning Succes.";
				
			}
			catch
			{
				this.ptim.Text = "Temp Cleaning Failure 0xG.";

			}
		}

        private void guna2Button29_Click(object sender, EventArgs e)
        {
			try
			{
				this.ptim.Text = "Recycle Bin Cleaning...";
				uint num = Form1.SHEmptyRecycleBin(IntPtr.Zero, null, (Form1.RecycleFlags)0U);
				this.ptim.Text = "Recycle Bin Clean Succes.";
			}
			catch
			{
				this.ptim.Text = "Clean Failure 0xG.";

			}
		}

        private void guna2Button28_Click(object sender, EventArgs e)
        {
			try
			{
				this.ptim.Text = "Prefetch Cleaning ...";
				this.CleanTemporaryFolders();
				this.ptim.Text = "Prefetch Cleaning Succes.";

			}
			catch
			{
				this.ptim.Text = "Prefetch Cleaning Failure 0xG.";

			}
		}

        private void guna2Button24_Click(object sender, EventArgs e)
        {
			try
			{
				Process process = new Process();
				process.StartInfo.FileName = "cmd.exe";
				process.StartInfo.Arguments = "/C c:\\windows\\SYSTEM32\\cleanmgr.exe /(C:)";
				process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process.Start();
				this.ptim.Text = "Cleaning Windows Waste...";
				process.WaitForExit();
				this.ptim.Text = "Cleaning Windows Waste Succes (Or Exit).";
			}
			catch
			{
				this.ptim.Text = "Cleaning Windows Waste Failure 0xG (Or Exit).";


			}
		}

        private void guna2Button34_Click(object sender, EventArgs e)
        {
			try
			{
				Process process = new Process();
				process.StartInfo.FileName = "cmd.exe";
				process.StartInfo.Arguments = "/C chkdsk /r /f /Y";
				process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process.Start();
				this.ptim.Text = "Chkdsk Service...(Do not panic if looks stuck)";
				Stopwatch stopwatch = new Stopwatch();
				stopwatch.Start();
				process.WaitForExit();
				this.ptim.Text = "The Passing Time: " + stopwatch.Elapsed.Seconds.ToString() + " seconds, Chkdsk Command Succes...";
			}
			catch
			{
				this.ptim.Text = "Chkdsk Service Broken 0xG.";

			}
		}

        private void guna2Button32_Click(object sender, EventArgs e)
        {
            try
            {
				Process process = new Process();
				process.StartInfo.FileName = "cmd.exe";
				process.StartInfo.Arguments = "/C cipher/w:c";
				process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process.Start();
				Stopwatch stopwatch = new Stopwatch();
				stopwatch.Start();
				this.ptim.Text = "Cipher Command Starting...(Do not panic if looks stuck)";
				process.WaitForExit();
				this.ptim.Text = "Cipher Command Succes...";
				this.ptim.Text = "The Passing Time: " + stopwatch.Elapsed.Seconds.ToString() + " seconds, Cipher Command Succes...";
			}
            catch 
            {

				this.ptim.Text = "Cipher Command Failure 0xG.";
			}
        }

        private void guna2Button31_Click(object sender, EventArgs e)
        {
            try
            {
				Process process = new Process();
				process.StartInfo.FileName = "cmd.exe";
				process.StartInfo.Arguments = "/c DISM.exe /Online /Cleanup-image /RestoreHealth";
				process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process.Start();
				Stopwatch stopwatch = new Stopwatch();
				stopwatch.Start();
				this.ptim.Text = "DISM Command Starting...(Do not panic if looks stuck)";
				process.WaitForExit();
				this.ptim.Text = "The Passing Time: " + stopwatch.Elapsed.Seconds.ToString() + " seconds, DISM Command Succes...";
			}
            catch 
            {
				this.ptim.Text = "DISM Command Failure 0xG.";

			}
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
			try
			{
				this.ptim.Text = "Registry Editing...";
				RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", RegistryKeyPermissionCheck.ReadWriteSubTree);
				registryKey.SetValue("DisableAntiSpyware", "1", RegistryValueKind.DWord);
				this.ptim.Text = "Defender Closed Succesfuly.";
			}
			catch
			{
				this.ptim.Text = "Registry Editing Failure 0xG.";
			}
		}

        private void guna2Button8_Click(object sender, EventArgs e)
        {
			try
			{
				this.ptim.Text = "Registry Editing...";
				RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", RegistryKeyPermissionCheck.ReadWriteSubTree);
				registryKey.DeleteValue("DisableAntiSpyware");
				this.ptim.Text = "Defender Opened Succesfuly.";
			}
			catch
			{
				this.ptim.Text = "Registry Editing Failure 0xG.";
			}
		}

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}
    }
}
