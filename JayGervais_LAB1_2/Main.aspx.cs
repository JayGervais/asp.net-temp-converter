using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JayGervais_LAB1_2
{
    public partial class Main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                tempDropDown(ddlTempSystemsTo);
                tempDropDown(ddlTempSystemsFrom);
                ddlTempSystemsTo.SelectedValue = "Fahrenheit";
                ddlTempSystemsFrom.SelectedValue = "Celsius";
            }
        }

        private void tempDropDown(DropDownList inputList)
        {
            List<ListItem> tempList = new List<ListItem>();
            tempList.Add(new ListItem("Celsius", "Celsius"));
            tempList.Add(new ListItem("Fahrenheit", "Fahrenheit"));
            tempList.Add(new ListItem("Kelvin", "Kelvin"));
            inputList.Items.AddRange(tempList.ToArray());
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtCalcResult.Text = "";
            txtTempInput.Text = "";
            ddlTempSystemsFrom.SelectedValue = "Celsius";
            ddlTempSystemsTo.SelectedValue = "Fahrenheit";
        }

        protected void btnConvert_Click1(object sender, EventArgs e)
        {
            if(txtTempInput.Text != "")
            {
                double temp = Convert.ToDouble(txtTempInput.Text);

                if (ddlTempSystemsFrom.SelectedValue == "Celsius" && ddlTempSystemsTo.SelectedValue == "Celsius")
                {
                    txtCalcResult.Text = DoFormat(temp);
                }
                else if (ddlTempSystemsFrom.SelectedValue == "Celsius" && ddlTempSystemsTo.SelectedValue == "Fahrenheit")
                {
                    double CtoF = (temp * 9) / 5 + 32;
                    txtCalcResult.Text = DoFormat(CtoF);
                }
                else if (ddlTempSystemsFrom.SelectedValue == "Celsius" && ddlTempSystemsTo.SelectedValue == "Kelvin")
                {
                    double CtoK = temp + 273.15;
                    txtCalcResult.Text = DoFormat(CtoK);
                }
                else if (ddlTempSystemsFrom.SelectedValue == "Fahrenheit" && ddlTempSystemsTo.SelectedValue == "Celsius")
                {
                    double FtoC = (temp - 32) * 5.0 / 9.0;
                    txtCalcResult.Text = DoFormat(FtoC);
                }
                else if (ddlTempSystemsFrom.SelectedValue == "Fahrenheit" && ddlTempSystemsTo.SelectedValue == "Fahrenheit")
                {
                    txtCalcResult.Text = DoFormat(temp);
                }
                else if (ddlTempSystemsFrom.SelectedValue == "Fahrenheit" && ddlTempSystemsTo.SelectedValue == "Kelvin")
                {
                    double FtoK = (temp - 32) * 5.0 / 9.0 + 273.15;
                    txtCalcResult.Text = DoFormat(FtoK);
                }
                else if (ddlTempSystemsFrom.SelectedValue == "Kelvin" && ddlTempSystemsTo.SelectedValue == "Celsius")
                {
                    double KtoC = temp - 273.15;
                    txtCalcResult.Text = DoFormat(KtoC);
                }
                else if (ddlTempSystemsFrom.SelectedValue == "Kelvin" && ddlTempSystemsTo.SelectedValue == "Fahrenheit")
                {
                    double KtoF = (((temp - 273.15) * 9) / 5) + 32;
                    txtCalcResult.Text = DoFormat(KtoF);
                }
                else if (ddlTempSystemsFrom.SelectedValue == "Kelvin" && ddlTempSystemsTo.SelectedValue == "Kelvin")
                {
                    txtCalcResult.Text = DoFormat(temp);
                }
                else
                {
                    txtCalcResult.Text = "Did not work";
                }
            }
        }

        public static string DoFormat(double myNumber)
        {
            var s = string.Format("{0:0.00}", myNumber);

            if (s.EndsWith("00"))
            {
                return ((int)myNumber).ToString();
            }
            else
            {
                return s;
            }
        }

    }
}
