using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMADPartyStore
{
    public class Balloon
    {
        private string color;
        private int height;
        private int diameter;

        public string Color
        {
            get { return color; }
            set
            {
                //limit ro red white or blue colors
                if (value.ToUpper() == "RED" || value.ToUpper() == "BLUE" || value.ToUpper() == "WHITE")
                {
                    color = value;
                }
                else
                {
                    throw new DataException("Color must be red, white, or blue.");
                }
                
            }
        }

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public int Diameter
        {
            get
            {
                return diameter;
            }

            set
            {
                if (color == string.Empty)
                {
                    throw new DataException("Please set the coulor prior to the diameter.");
                }
                else
                {
                    //check the color
                    //enforse the business rules
                    //if violated, throw new constrain exception with informative mssg.
                    if (color.ToUpper() == "RED")
                    {
                        if (value >= 12)
                        {
                            diameter = value;
                        }
                        else
                        {
                            throw new ConstraintException("red baloon diameter must be at least 12");
                        }
                    }
                    else if (color.ToUpper() == "WHITE")
                    {
                        if (value >= 10)
                        {
                            diameter = value;
                        }
                        else
                        {
                            throw new ConstraintException("white baloon diameter must be at least 10");
                        }
                    }
                    else
                    {
                        if (value != 0)
                        {
                            diameter = value;
                        }
                        else
                        {
                            throw new ConstraintException("baloon diameter cannot be zero");
                        }
                    }
                }
            }
        }
    }
}
