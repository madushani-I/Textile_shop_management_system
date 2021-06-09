using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPPM
{
	public partial class touchControl: UserControl
	{
		public delegate void ButtonClickedEventHandler(object sender,EventArgs e);
		public event ButtonClickedEventHandler OnUserControlButtonClicked;
		public touchControl()
		{
			InitializeComponent();
		}

		#region ButtonClick
		/// <summary>
		/// Touch pad button which will respond to the selected operation
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonClick(object sender,EventArgs e)
		{
			Button btnNumber = sender as Button;
			switch (btnNumber.Text)
			{
				case "0":
					OnUserControlButtonClicked(btnNumber,e);
					MyGlobal.bTouch = false;
					break;
				case "1":
					OnUserControlButtonClicked(btnNumber,e);
					MyGlobal.bTouch = false;
					break;
				case "2":
					OnUserControlButtonClicked(btnNumber,e);
					MyGlobal.bTouch = false;
					break;
				case "3":
					OnUserControlButtonClicked(btnNumber,e);
					MyGlobal.bTouch = false;
					break;
				case "4":
					OnUserControlButtonClicked(btnNumber,e);
					MyGlobal.bTouch = false;
					break;
				case "5":
					OnUserControlButtonClicked(btnNumber,e);
					MyGlobal.bTouch = false;
					break;
				case "6":
					OnUserControlButtonClicked(btnNumber,e);
					break;
				case "7":
					OnUserControlButtonClicked(btnNumber,e);
					MyGlobal.bTouch = false;
					break;
				case "8":
					OnUserControlButtonClicked(btnNumber,e);
					MyGlobal.bTouch = false;
					break;
				case "9":
					OnUserControlButtonClicked(btnNumber,e);
					MyGlobal.bTouch = false;
					break;
				case ".":
					OnUserControlButtonClicked(btnNumber,e);
					MyGlobal.bTouch = false;
					break;
				case "Back":
					OnUserControlButtonClicked(btnNumber,e);
					MyGlobal.bTouch = false;
					break;
			}
		}
        #endregion

        private void touchControl_Load(object sender, EventArgs e)
        {

        }
    }
}
