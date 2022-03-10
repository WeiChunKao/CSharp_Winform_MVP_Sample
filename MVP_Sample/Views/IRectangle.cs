using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_Sample.Views
{
    public interface IRectangle
    {
        string LengthTest { get; set; }
        string BreadthText { get; set; }
        string AreaText { get; set; }
    }
}
