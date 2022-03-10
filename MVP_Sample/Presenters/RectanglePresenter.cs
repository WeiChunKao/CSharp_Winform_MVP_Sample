using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVP_Sample.Views;
using MVP_Sample.Models;
namespace MVP_Sample.Presenters
{
    public class RectanglePresenter
    {
        IRectangle rectangleView;

        public RectanglePresenter(IRectangle view)
        {
            rectangleView = view;
        }

        public void CalculateArea()
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Length = double.Parse(rectangleView.LengthTest);
            rectangle.Breadth = double.Parse(rectangleView.BreadthText);
            rectangleView.AreaText = rectangle.CalculateArea().ToString();
        }
    }
}
