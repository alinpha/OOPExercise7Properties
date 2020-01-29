using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMADPartyStore
{
    /// <summary>
    /// Class for a Ballon
    /// </summary>
    public class Balloon
    {

        //privaet fields

        #region Privaet Fields

        private string color;
        private int height;
        private int diameter;

        #endregion

        /// <summary>
        /// Color of the ballon
        /// </summary>
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

        /// <summary>
        /// Height of the ballon
        /// </summary>
        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        /// <summary>
        /// diameter of the balloon
        /// </summary>
        public int Diameter
        {
            get
            {
                return diameter;
            }

            set
            {
                //if (color == string.Empty)
                //{
                //    throw new DataException("Please set the color prior to the diameter.");
                //}
                //else
                //{
                //    //check the color
                //    //enforse the business rules
                //    //if violated, throw new constrain exception with informative mssg.
                //    if (color.ToUpper() == "RED")
                //    {
                //        if (value >= 12)
                //        {
                //            diameter = value;
                //        }
                //        else
                //        {
                //            throw new ConstraintException("red baloon diameter must be at least 12");
                //        }
                //    }
                //    else if (color.ToUpper() == "WHITE")
                //    {
                //        if (value >= 10)
                //        {
                //            diameter = value;
                //        }
                //        else
                //        {
                //            throw new ConstraintException("white baloon diameter must be at least 10");
                //        }
                //    }
                //    else
                //    {
                //        if (value > 0)
                //        {
                //            diameter = value;
                //        }
                //        else
                //        {
                //            throw new ConstraintException("baloon diameter must be greater than zero");
                //        }
                //    }
                //}

                if (color == string.Empty) throw new DataException("Please set the color prior to the diameter.");

                if (color.ToUpper() == "RED")
                    if (value < 12) throw new ConstraintException("red baloon diameter must be at least 12");
                
                if (color.ToUpper() == "WHITE")
                    if (value < 10) throw new ConstraintException("white baloon diameter must be at least 10");
                
                if (value <= 0) throw new ConstraintException("baloon diameter must be greater than zero");
                
                diameter = value;
            }
        }
    }
}
