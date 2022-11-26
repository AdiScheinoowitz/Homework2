using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Homework2.Shared.Rectagle
{
    public class MyRectagle
    {
        public string Color { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Surface()
        {
            return Length * Width;
        }
        public double Scope()
        {
            return 2 * (Width + Length);
        }
    }
}