using System;
using Microsoft.Maui.Essentials;

namespace Main
{
    public partial class MainPage
    {
        private int _count;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            _count++;
            CounterLabel.Text = $"Current count: {_count}";

            SemanticScreenReader.Announce(CounterLabel.Text);
        }
    }
}
