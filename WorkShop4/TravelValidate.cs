using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkShop4
{
    class TravelValidate
    {

    /// <summary>
    /// Use to validate if there is text in an input field, and if the text is under the maximum amount
    /// </summary>
    /// <param name="count">Enter the max number of char that this field allows as an int argument</param>
    public void validateText(int count, string txt)
        {
            if (txt == "")
                MessageBox.Show("This field cannot be left blank");
            else if (txt.Length > count)
                MessageBox.Show($"This field cannot be longer than {count} characters");
        }
    }
}
