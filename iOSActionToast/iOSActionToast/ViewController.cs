using System;
using UIKit;
using ActionComponents;

namespace iOSActionToast
{
	public partial class ViewController : UIViewController
	{
		#region Constructors
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}
		#endregion

		#region Override Methods
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
		#endregion

		#region Custom Actions
		partial void ShowAndroidStyle(Foundation.NSObject sender) {
			ACToast.MakeText("Android Style Message", ACToastLength.Long).Show();
		}

		partial void ShowTop(Foundation.NSObject sender) {
			ACToast.ShowText("Message at Top.", ACToastGravity.Top);
		}

		partial void ShowCenter(Foundation.NSObject sender) {
			ACToast.ShowText("Message at Center.", ACToastGravity.Center);
		}

		partial void ShowBottom(Foundation.NSObject sender) {
			ACToast.ShowText("Message at Bottom.", ACToastGravity.Bottom);
		}
		#endregion
	}
}
