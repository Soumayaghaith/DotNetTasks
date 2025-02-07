using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A5.Question1
{
    internal interface ICircle: IShape
    {
        //While it is not mentioned in the question that this interface have radius prop 
        //I cannot implemnent the question and display the shape's info
        //without adding some properties and this is also the case with rectangle interface

        public int Radius { get; set; }
       
    }
}
