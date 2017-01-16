using System;

using Xamarin.Forms;

namespace 1_.NET_Test1
{
	public class MyPageForm : ContentPage
{
	public MyPageForm()
	{
		Content = new StackLayout
		{
			Children = {
					new Label { Text = "Hello ContentPage" }
				}
		};
	}
}
}

