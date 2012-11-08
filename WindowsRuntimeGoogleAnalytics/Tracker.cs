using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nascent.GoogleAnalytics;

namespace WindowsRuntimeGoogleAnalytics
{
    public sealed class Tracker
    {
        public string webPropertyId { get; set; }

        public Tracker(string id)
        {
            webPropertyId = id;
        }

        public void SetCustomVariable(int index, string name, string value)
        {
            AnalyticsTracker tracker = AnalyticsTracker.GetInstance(webPropertyId);
            tracker.SetCustomVariable(index, name, value);
        }

        public void TrackPageView(string page)
        {
            AnalyticsTracker tracker = AnalyticsTracker.GetInstance(webPropertyId);
            tracker.TrackPageView(page);
        }

        public void TrackEvent(string category, string action)
        {
            AnalyticsTracker tracker = AnalyticsTracker.GetInstance(webPropertyId);
            tracker.TrackEvent(category, action, null, null);
        }

        public void TrackEvent(string category, string action, string label)
        {
            AnalyticsTracker tracker = AnalyticsTracker.GetInstance(webPropertyId);
            tracker.TrackEvent(category, action, label, null);
        }
    }
}
