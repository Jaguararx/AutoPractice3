
namespace AutoPractice3.Models
{
    class Car
    {
        public int Size;
        public int NumberWeels;

        readonly private int Length;

        private string model;
        public string Model { 
            get {
                if (string.IsNullOrEmpty(model)) {
                    model = "Unknown model";
                }
                return model;
            } 
            set {
                model = value;
            }
        }

        public Car(string model, int lenght, int numberWeels, int size) {
            Model = model;
            Length = lenght;
            NumberWeels = numberWeels;
            Size = size;
        }

        public void Calculate() {

        }
    }
}
