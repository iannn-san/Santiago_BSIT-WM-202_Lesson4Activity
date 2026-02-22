//Question A:  Exception handling when user inputs a character instead of a number under Basic Pay, Rate per Hour
//code:
try
{
    double ratePerHour = double.Parse(txtBasicRatePerHour.Text);
}
catch (FormatException)
{
    MessageBox.Show("Invalid input! Please enter a number for Basic Pay Rate per Hour.",
                    "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    txtBasicRatePerHour.Clear();
    txtBasicRatePerHour.Focus();
}

//Question B: Exception handling when user inputs a character instead of a number under Other Income, Rate per Hour
//code:
    try
{
    double otherRatePerHour = double.Parse(txtOtherRatePerHour.Text);
}
catch (FormatException)
{
    MessageBox.Show("Invalid input! Please enter a number for Other Income Rate per Hour.",
                    "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    txtOtherRatePerHour.Clear();
    txtOtherRatePerHour.Focus();
}

//Question C:Exception handling when user clicks Calculate but some required textboxes are empty
//code:
    try
{
    if (txtBasicRatePerHour.Text == "" || txtBasicHours.Text == "" || txtOtherRatePerHour.Text == "")
    {
        throw new Exception("Some required fields are empty. Please fill in all required fields.");
    }

    double basicRate = double.Parse(txtBasicRatePerHour.Text);
    double basicHours = double.Parse(txtBasicHours.Text);
    double otherRate = double.Parse(txtOtherRatePerHour.Text);

}
catch (Exception ex)
{
    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
}