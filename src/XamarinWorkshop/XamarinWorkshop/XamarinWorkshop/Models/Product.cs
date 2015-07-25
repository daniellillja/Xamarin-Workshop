using System.ComponentModel;
using System.Runtime.CompilerServices;
using XamarinWorkshop.Annotations;

namespace XamarinWorkshop.Models
{
    public class Product : INotifyPropertyChanged

    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string ImgUrl { get; set; }
        public string Description { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
