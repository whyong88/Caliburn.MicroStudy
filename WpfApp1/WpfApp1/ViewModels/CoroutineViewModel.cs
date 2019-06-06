using System.Collections.Generic;
using Caliburn.Micro;
using WpfApp1.Results;

namespace WpfApp1.ViewModels
{
    public class CoroutineViewModel:Screen
    {
        public IEnumerable<IResult> Execute()
        {
            yield return new VisualStateResult("Loading");
        }
    }
}