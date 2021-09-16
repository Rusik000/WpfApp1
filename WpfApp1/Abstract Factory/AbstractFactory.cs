using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1.Abstract_Factory
{

    public interface IChair
    {
        bool sitOn();
        bool hasLegs();
    }

    public class ArtDecoChair : IChair
    {
        public bool hasLegs()
        {
            return false;
        }

        public bool sitOn()
        {
            return false;
        }



        public string ImagePath_ArtDecoChair { get; set; }
    }



    public class ModernChair : IChair
    {
        public bool hasLegs()
        {
            return true;
        }

        public bool sitOn()
        {
            return true;
        }

        public string ImagePath_ModernChair { get; set; }
    }



    public class VictorialChair : IChair
    {
        public bool hasLegs()
        {
            return true;
        }

        public bool sitOn()
        {
            return false;
        }
        public string ImagePath_VictorialChair { get; set; }
    }




    public interface ITable
    {
        bool sitOn();
        bool hasLegs();
    }


    public class ArtDecoTable : ITable
    {
        public bool hasLegs()
        {
            return true;

        }

        public bool sitOn()
        {
            return false;
        }
    }


    public class ModernTable : ITable
    {
        public bool hasLegs()
        {
            return false;
        }

        public bool sitOn()
        {
            return true;
        }
    }


    public class VictorialTable : ITable
    {
        public bool hasLegs()
        {
            return false;
        }

        public bool sitOn()
        {
            return true;
        }
    }

    public interface ISofa
    {
        bool CanEnlarge();

    }
    public class ArtDecoSofa : ISofa
    {
        public bool CanEnlarge()
        {
            return true;
        }
    }


    public class ModernSofa : ISofa
    {
        public bool CanEnlarge()
        {
            return false;
        }
    }


    public class VictorianSofa : ISofa
    {
        public bool CanEnlarge()
        {
            return true;
        }
    }



    public interface IFurnitureFactory
    {
        IChair createChair();
        ITable createTable();
        ISofa createSofa();
        void Show();
    }




    public class ModernFurnitureFactory : IFurnitureFactory
    {
        public IChair createChair()
        {
            return new ModernChair();
        }

        public ISofa createSofa()
        {
            return new ModernSofa();
        }

        public ITable createTable()
        {
            return new ModernTable();
        }

        public void Show()
        {
            MessageBox.Show("Art Deco Style");
            var chair = createChair();
            var table = createTable();
            var sofa = createSofa();
        }
    }


    public class VictorianFurnitureFactory : IFurnitureFactory
    {
        public IChair createChair()
        {
            return new VictorialChair();
        }

        public ISofa createSofa()
        {
            return new VictorianSofa();
        }

        public ITable createTable()
        {
            return new VictorialTable();
        }

        public void Show()
        {
            MessageBox.Show("Art Deco Style");
            // Console.WriteLine("Victorian Style");
            //var chair = createChair();
            //var table = createTable();
            //var sofa = createSofa();
        }
    }





    public class ArtDecoFurnitureFactory : IFurnitureFactory
    {
        public IChair createChair()
        {
            return new ArtDecoChair();
        }

        public ISofa createSofa()
        {
            return new ArtDecoSofa();
        }

        public ITable createTable()
        {
            return new ArtDecoTable();
        }

        public void Show()
        {
            MessageBox.Show("Art Deco Style");
            //Console.WriteLine("Art Deco Style");
            var chair = createChair();
            var table = createTable();
            var sofa = createSofa();
        }
    }
    public class AbstractFactory
    {

    }
}
