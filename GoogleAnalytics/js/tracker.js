(function () {
    "use strict";

    var Tracker = WinJS.Class.define(
        function (webPropertyId) {
            this.webPropertyId = webPropertyId;
            this.tracker = new WindowsRuntimeGoogleAnalytics.Tracker(webPropertyId);
        },

        {
            setCustomVariable: function (index, name, value) {
                var that = this;
                that.tracker.setCustomVariable(index, name, value);
            },

            trackPageView: function (page) {
                var that = this;
                that.tracker.trackPageView(page);
            },

            trackCurrentPageView: function () {
                var that = this;
                var page = Application.navigator.pageControl.uri.replace("ms-appx://" + Windows.ApplicationModel.Package.current.id.name.toLowerCase(), "");
                that.trackPageView(page);
            },

            trackEvent: function (category, action, label) {
                var that = this;
                that.tracker.trackEvent(category, action, label);
            }
        });

    WinJS.Namespace.define("GoogleAnalytics", {
        Tracker: new Tracker("UA-4291014-7")
    });
})();
