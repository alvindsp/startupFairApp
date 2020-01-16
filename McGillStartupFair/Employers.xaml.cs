using System;
using System.Collections.Generic;
using McGillStartupFair.Models;

using Xamarin.Forms;

namespace McGillStartupFair
{ 
    public partial class Employers : ContentPage
    {
        public IList<Company> companies { get; private set; }

        public Employers()
        {

            InitializeComponent();

            companies = new List<Company>();


            companies.Add(new Company
            {
                Name = "Google",
                Description = "Search Engine Startup",
                URL = "www.google.com"
            });

            companies.Add(new Company
            {
                Name = "Amazon",
                Description = "Online Marketplace and Ruthless Regime",
                URL = "www.amazon.com"
            });

            companies.Add(new Company
            {
                Name = "Netflix",
                Description = "Streaming Media",
                URL = "www.netflix.com"
            });

            companies.Add(new Company
            {
                Name = "Oracle",
                Description = "tech comp",
                URL = "www.oracle.com"
            });

            BindingContext = this;

        }
    }
}
