using static TestWeek4.Service.RabanutService;
namespace TestWeek4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CreateXmlIfNotExists();
        }

        private void AddDateButton_Click(object sender, EventArgs e)
        {
            string day = DayDomboBox.Text;
            string numDay = NumDayComboBox.Text;
            string month = MonthComboBox.Text;
            string year = YearComboBox.Text;
            string resultText = AddQueryToXml(day, numDay, month, year);

            MessageBox.Show($"Day: {day},\n" +
                $" DayMonth: {numDay},\n" +
                $" Month: {month},\n" +
                $" Year: {year},\n" +
                $"Result: {resultText}");
        }
    }
}
