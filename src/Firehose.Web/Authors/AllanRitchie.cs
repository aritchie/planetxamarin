using System;
using System.Collections.Generic;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;


namespace Firehose.Web.Authors
{
    public class AllanRitchie : IAmAXamarinMVP, IAmAMicrosoftMVP, IFilterMyBlogPosts
	{
        public string FirstName => "Allan";

        public string LastName => "Ritchie";

        public string StateOrRegion => "Toronto, Canada";

        public string EmailAddress => "allan.ritchie@gmail.com";

        public string ShortBioOrTagLine => "OSS Maintainer of Shiny.NET & Various Xamarin Plugins.  Microsoft MVP & Former Xamarin MVP";

        public Uri WebSite => new Uri("https://aritchie.github.io");

        public string TwitterHandle => "allanritchie911";

        public string GitHubHandle => "aritchie";

        public string GravatarHash => "5f22bd04ca38ed4d0a5225d0825e0726";

        public GeoPosition Position => new GeoPosition(43.6425701,-79.3892455);

		public string FeedLanguageCode => "en";

		public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://aritchie.github.io/Xamarin.rss"); } }
		
		public bool Filter(SyndicationItem item) => true;
	}
}
