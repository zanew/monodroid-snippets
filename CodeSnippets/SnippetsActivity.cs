using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
//using Android.Animation;

namespace CodeSnippets
{
	[Activity (Label = "CodeSnippets", MainLauncher = true)]
	public class SnippetsActivity : Activity
	{
		int count = 1;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);
			
			button.Click += delegate {
				button.Text = string.Format ("{0} clicks!", count++); };
			
			// Animations
//			Animator anim1 = new Animator();
//			Animator anim2 = new Animator();
//			Animator anim3 = new Animator();
//			Animator anim4 = new Animator();
//						
//			AnimatorSet s = new AnimatorSet();
//			s.Play(anim1).With(anim2);
//			s.Play(anim2).Before(anim3);
//			s.Play(anim3).Before(anim2).Before(anim3);
//			s.Play(anim4).After(anim3);
			
			
			
			
			
			
			
		}
	}
}


