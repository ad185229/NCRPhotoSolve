using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using NewNCRHack.Models;
using Xamarin.Forms.Internals;

namespace NewNCRHack.ViewModels
{
    /// <summary>
    /// ViewModel for Daily Timeline page.
    /// </summary>
    [Preserve(AllMembers = true)]
    [DataContract]
    public class InstantSolutionViewModel : BaseViewModel
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance for the <see cref="InstantSolutionViewModel"/> class.
        /// </summary>
        public InstantSolutionViewModel()
        {
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets a collction of value to be displayed in Daily timeline page.
        /// </summary>
        [DataMember(Name = "dailyTimeline")]
        public ObservableCollection<Timeline> DailyTimeline { get; set; }

        #endregion
    }
}
