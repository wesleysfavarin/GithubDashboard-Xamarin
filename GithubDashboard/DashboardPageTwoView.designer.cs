// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace GithubDashboard
{
	partial class DashboardPageTwoView
	{
		[Outlet]
		GithubDashboard.IssuesDataGridView issuesDataGrid { get; set; }

		[Outlet]
		GithubDashboard.MilestoneProgressView milestoneProgess { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (milestoneProgess != null) {
				milestoneProgess.Dispose ();
				milestoneProgess = null;
			}

			if (issuesDataGrid != null) {
				issuesDataGrid.Dispose ();
				issuesDataGrid = null;
			}
		}
	}
}
