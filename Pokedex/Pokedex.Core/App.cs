using MvvmCross.ViewModels;
using Pokedex.Core.ViewModels;

namespace Pokedex.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            this.RegisterAppStart<MainViewModel>();
        }
    }
}
