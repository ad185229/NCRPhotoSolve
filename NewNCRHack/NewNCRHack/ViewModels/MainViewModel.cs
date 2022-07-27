using System;
using System.Collections.Generic;
using System.Text;

namespace NewNCRHack.ViewModels
{
    public class MainViewModel
    {

        public  MainViewModel()
        {

            onboardings = GetOnboardings();
        }

        public List<Onboarding> onboardings { get; set; }

        private List<Onboarding> GetOnboardings()
        {
            return new List<Onboarding> { 
                new Onboarding{Heading="NCR Photo SOLVE", Caption="Solve Error Soon" },
                new Onboarding{Heading="test", Caption="test2"}
            };
        }

    }

    public class Onboarding
    {
        public string Heading { get; set; }
        public string Caption { get; set; }
    }
}
