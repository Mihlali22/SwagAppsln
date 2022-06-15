using SwagApp.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SwagApp
{
    public partial class MainPage : TabbedPage
    {
        private List<Tshirt> _tshirts = new List<Tshirt>();

        public List<Tshirt> Tshirts
        {
            get { return _tshirts; }
            set { _tshirts = value; }
        }
        public MainPage()
        {
            InitializeComponent();
        }
    }
}
