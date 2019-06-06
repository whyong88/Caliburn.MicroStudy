using System.Collections.Generic;
using Caliburn.Micro;
using WpfApp1.Common;
using WpfApp1.Results;

namespace WpfApp1.ViewModels
{
    public class CoroutineViewModel:Screen
    {
        public IEnumerable<IResult> Execute()
        {
            yield return new VisualStateResult("Loading");
            yield return TaskHelper.Delay(2000).AsResult();
            yield return new VisualStateResult("LoadingComplete");
            yield return new MessageDialogResult("This was executed from a custom IResult, MessageDialogResult.",
                "IResult Coroutines");
        }

         
    }
}