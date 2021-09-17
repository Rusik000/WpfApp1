using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Command;
using Prism.Commands;
using static WpfApp1.Abstract_Factory.VictorianSofa;
using System.Windows.Controls;

namespace WpfApp1.ViewModels
{
    public class AppViewModel : BaseViewModel
    {

        private IFurnitureFactory furnitureFactory { get; set; }

        private string _imageChair;

        public string ImageChair
        {
            get { return _imageChair; }
            set { _imageChair = value; OnPropertyChanged(); }
        }


        private string _imageTable;

        public string ImageTable
        {
            get { return _imageTable; }
            set { _imageTable = value; OnPropertyChanged(); }
        }


        private string _imageSofa;

        public string ImageSofa
        {
            get { return _imageSofa; }
            set { _imageSofa = value; OnPropertyChanged(); }
        }


        public RelayCommand SelectedChanged { get; set; }
        public AppViewModel()
        {
            SelectedChanged = new RelayCommand((sender) =>
            {
                var item = sender as ComboBoxItem;
                string data = item.Content.ToString();
                SelectedChange(data);
            });
        }


        private void SelectedChange(string value)
        {
            if (value == "Modern")
            {
                furnitureFactory = new ModernFurnitureFactory();
                //furnitureFactory.Show();
                ImageChair = furnitureFactory.createChair().getImageChair();
                ImageTable = furnitureFactory.createTable().getImageTable();
                ImageSofa = furnitureFactory.createSofa().GetImageSofa();


            }
            else if (value == "ArtDeco")
            {
                furnitureFactory = new ArtDecoFurnitureFactory();
                //furnitureFactory.Show();
                ImageChair = furnitureFactory.createChair().getImageChair();
                ImageTable = furnitureFactory.createTable().getImageTable();
                ImageSofa = furnitureFactory.createSofa().GetImageSofa();
            }
            else if (value == "Victorian")
            {
                furnitureFactory = new VictorianFurnitureFactory();
                //furnitureFactory.Show();
                ImageChair = furnitureFactory.createChair().getImageChair();
                ImageTable = furnitureFactory.createTable().getImageTable();
                ImageSofa = furnitureFactory.createSofa().GetImageSofa();
            }
        }
    }
}
