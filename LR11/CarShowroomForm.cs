using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR11
{
    public partial class CarShowroomForm : Form
    {
        public CarShowroomForm()
        {
            InitializeComponent();
        }

        public class Car
        {
            private string engineNum; 
            private string brand; 
            private string model; 
            private Color color;
            private string bodyType; 
            private double engineDisplacement; 
            private int releaseYear; 
            private double price; 
            private int HP;
            private string engineType; 

            public Car() 
            {
                engineNum = "";
                brand = "";
                model = "";
                color = Color.Empty;
                bodyType = "";
                engineDisplacement = 0;
                releaseYear = 0;
                price = 0;
                HP = 0;
                engineType = "";
            }

            public Car(string engNum, string br, string mod, Color clr, string type, double engDisplacement, int release, double pr, int horses, string engType)
            {
                engineNum = engNum;
                brand = br;
                model = mod;
                color = clr;
                bodyType = type;
                engineDisplacement = engDisplacement;
                releaseYear = release;
                price = pr;
                HP = horses;
                engineType = engType;
            }

            public Color getSetClr
            {
                get { return color; } 
                set { color = value; }
            }

            public double getSetPrice
            {
                get { return price; }
                set { price = value; }
            }

            public int getSetHP
            {
                get { return HP; }
                set { HP = value; }
            }

            public string getEngNum
            {
                get { return engineNum; }
            }

            public string getBrand
            {
                get { return brand; }
            }

            public string getModel
            {
                get { return model; }
            }

            public string getBodyType
            {
                get { return bodyType; }
            }

            public double getEngDis
            {
                get { return engineDisplacement; }
            }

            public int getReleaseYear
            {
                get { return releaseYear; }
            }

            public string getEngType
            {
                get { return engineType; }
            }

            public override string ToString()
            {
                return "Производитель: " + getBrand + 
                       "\nМодель: " + getModel + 
                       "\nГод выпуска: " + getReleaseYear + 
                       "\nНомер двигателя: " + getEngNum + 
                       "\nТип двигателя: " + getEngType +
                       "\nОбъем двигателя: " + getEngDis +
                       "\nМощность двигателя: " + getSetHP +
                       "\nТип кузова: " + getBodyType +
                       "\nЦвет кузова: " + getSetClr + 
                       "\nЦена: " + getSetPrice;
            }

            public override bool Equals(object obj)
            {
                if (obj == null || GetType() != obj.GetType())
                    return false;

                Car other = (Car)obj;
                return engineNum == other.engineNum &&
                       brand == other.brand &&
                       model == other.model &&
                       color == other.color &&
                       bodyType == other.bodyType &&
                       engineDisplacement == other.engineDisplacement &&
                       releaseYear == other.releaseYear &&
                       price == other.price &&
                       HP == other.HP &&
                       engineType == other.engineType;
            }

            public override int GetHashCode()
            {
                return engineNum.GetHashCode() ^
                       brand.GetHashCode() ^
                       model.GetHashCode() ^
                       color.GetHashCode() ^
                       bodyType.GetHashCode() ^
                       engineDisplacement.GetHashCode() ^
                       releaseYear.GetHashCode() ^
                       price.GetHashCode() ^
                       HP.GetHashCode() ^
                       engineType.GetHashCode();
            } 
        }

        public Car[] GetFromFile()
        {
            StreamReader sr = new StreamReader("data.txt");
            Car[] carList = new Car[0]; 

            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
            }





            return carList;
        }
    }
}
