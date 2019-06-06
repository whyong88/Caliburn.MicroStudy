using System.Collections.Generic;
using Caliburn.Micro;
using WpfApp1.Common;
using WpfApp1.Results;
using WpfApp1.ViewModels.Activity;

namespace WpfApp1.ViewModels
{
    public class BubblingViewModel:Screen
    {
        public BindableCollection<MessageActivityViewModel> Phrases { get; }=new
            BindableCollection<MessageActivityViewModel>
        {
            new MessageActivityViewModel(Lipsum.Get(32)),
            new MessageActivityViewModel(Lipsum.Get(32)),
            new MessageActivityViewModel(Lipsum.Get(32)),
            new MessageActivityViewModel(Lipsum.Get(32))
        };

        public IEnumerable<IResult> SelectPhrase(MessageActivityViewModel phrase)
        {
            yield return new MessageDialogResult($"The selected phrase was {phrase.Message}.", "Phrase Selected");
        }

    }
}