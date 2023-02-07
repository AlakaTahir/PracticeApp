using PracticeApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeApp.Logic
{
    public class AdditionLogic
    {
        public double AddNumbers(AdditionModel model)
        {
            var result = model.NumA + model.NumB;
            return result;
        }
    }
}
