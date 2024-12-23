using System;

namespace tekhnika
{
    class Tekhnika
    {
        private string Model;
        protected int Power;
        public string Sostayanie;

        public string setModel
        {
            get { return Model; }
            set { Model = value; }
        }

        public int setPower
        {
            get { return Power; }
            set { Power = value; }
        }

        public void TurnOn()
        {
            Sostayanie = "On";
            Console.WriteLine("Дастгох кор карда истодасст.");
        }

        public void TurnOff()
        {
            Sostayanie = "Off";
            Console.WriteLine("Дастгох хомуш аст.");
        }


        public void Run()
        {
            Console.WriteLine("Модель: "+setModel+" Тавонои "+setPower+" ВТ. Санчиш: "+Sostayanie);
        }
    }

    class Yakhdon:Tekhnika
    {
        public Yakhdon()
        {
            setModel = "Samsung";
            setPower = 2500;
        }
    }

    class Stm : Tekhnika
    {
        public Stm()
        {
            setModel= "LG";
            setPower = 5000;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Yakhdon yakhdon = new Yakhdon();
            yakhdon.TurnOn();
            yakhdon.Run();
            yakhdon.TurnOff();
            yakhdon.Run();
            
            Stm stm = new Stm();
            stm.TurnOn();
            stm.Run();
            stm.TurnOff();
            stm.Run();
        }
    }
}