using System.Reflection;
using System.Runtime.Serialization.Json;
using NewNCRHack.ViewModels;
using Xamarin.Forms.Internals;

namespace NewNCRHack.DataService
{
    /// <summary>
    /// Data service to load the data from json file.
    /// </summary>
    [Preserve(AllMembers = true)]
    public class DailyTimelineDataService
    {
        #region Fields

        private static DailyTimelineDataService dailyTimelineDataService;
        private InstantSolutionViewModel dailyTimelineViewModel;
        #endregion

        #region Constructor

        /// <summary>
        /// Creates an instance for the <see cref="DailyTimelineDataService"/> class.
        /// </summary>
        public DailyTimelineDataService()
        {
        }
        #endregion

        #region properties

        /// <summary>
        /// Gets an instance of the <see cref="DailyTimelineDataService"/>.
        /// </summary>
        public static DailyTimelineDataService Instance => dailyTimelineDataService ?? (dailyTimelineDataService = new DailyTimelineDataService());

        /// <summary>
        /// Gets or sets the value of pDaily Timeline page view model.
        /// </summary>
        public InstantSolutionViewModel InstantSolutionViewModel =>
            this.dailyTimelineViewModel = PopulateData<InstantSolutionViewModel>("timeline.json");
        #endregion

        #region Methods

        /// <summary>
        /// Populates the data for view model from json file.
        /// </summary>
        /// <typeparam name="T">Type of view model.</typeparam>
        /// <param name="fileName">Json file to fetch data.</param>
        /// <returns>Returns the view model object.</returns>
        private static T PopulateData<T>(string fileName)
        {
            var file = "NewNCRHack.Data." + fileName;

            var assembly = typeof(App).GetTypeInfo().Assembly;

            T data;

            using (var stream = assembly.GetManifestResourceStream(file))
            {
                var serializer = new DataContractJsonSerializer(typeof(T));
                data = (T)serializer.ReadObject(stream);
            }

            return data;
        }
        #endregion
    }
}
