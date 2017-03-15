using FluentAssertions;
using Unicorn.ControlPanel.Headings;
using Xunit;

namespace Unicorn.Tests.ControlPanel.Headings
{
	public class HeadingServiceTests
	{
        [Fact(Skip = "UI tests not relevant as running via console")]
        public void ShouldReturnValidControlPanelHeading()
		{
			var service = new HeadingService();

			service.GetControlPanelHeadingHtml().Should().NotBeNullOrWhiteSpace();
		}

		[Fact(Skip = "UI tests not relevant as running via console")]
		public void ShouldReturnValidHeading()
		{
			var service = new HeadingService();

			service.GetHeadingHtml().Should().NotBeNullOrWhiteSpace();
		}
	}
}
