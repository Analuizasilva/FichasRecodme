using System;

namespace Ficha26
{
    #region Grupo I
    #region Exercicio 1 ao 4
    public interface IVehicle
    {
        public void Start();
        public void Stop();
        public void ChangeGear();
        public void Break();
        public void Accelerate();
        public void TurnWheel();
    }
    public class Mota : IVehicle
    {
        public void Accelerate()
        {
            throw new NotImplementedException();
        }

        public void Break()
        {
            throw new NotImplementedException();
        }

        public void ChangeGear()
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }

        public void TurnWheel()
        {
            throw new NotImplementedException();
        }
    }
    public class Barco : IVehicle
    {
        public void Accelerate()
        {
            throw new NotImplementedException();
        }

        public void Break()
        {
            throw new NotImplementedException();
        }

        public void ChangeGear()
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }

        public void TurnWheel()
        {
            throw new NotImplementedException();
        }
    }
    #endregion
    #region Exercicio 5 ao 8

    public interface IErasable
    {
        public void Erase();
    }
    public interface IWritingUtensil
    {
        public string Color { get; set; }
        public string TipType { get; set; }
        public string Write();
    }
    public class Pen : IWritingUtensil, ITrashable
    {
        public string Color { get; set; }
        public string TipType { get; set; }
        public string Text { get; set; }

        public string Write()
        {
            return Text;
        }
    }
    public class Pencil : IWritingUtensil, IErasable, ITrashable
    {
        public string Color { get; set; }
        public string TipType { get; set; }

        public void Erase()
        {
        
        }
        public string Text { get; set; }

        public string Write()
        {
            return Text;
        }
    }
    public class ColoredPencil : IWritingUtensil, IErasable, ITrashable
    {
        public string Color { get; set; }
        public string TipType { get; set; }

        public void Erase()
        {
            
        }
        public string Text { get; set; }

        public string Write()
        {
            return Text;
        }
    }
    public class Paper 
    {
        public string Color { get; set; }
        public string TipType { get; set; }

        public void Erase()
        {
           
        }

        public string Text { get; set; }

        public void Write(IWritingUtensil utensil)
        {
            Text = utensil.Write();

        }
    }
    public class PaperContent 
    {
       public string Text { get; private set; }

        public void Erase()
        {
           
        }

        public void Write(IWritingUtensil utensil)
        {
            Text = utensil.Write();

        }
    }
    #endregion
    #endregion
}
