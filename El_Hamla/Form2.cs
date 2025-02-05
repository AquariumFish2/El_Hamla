using FastReport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace El_Hamla
{
    public partial class Form2 : Form
    {
        private DataTable myDataTable;
        public Form2()
        {
            InitializeComponent();
            // Sample DataTable initialization (replace with your actual data)
            myDataTable = new DataTable();
            myDataTable.Columns.Add("Column1", typeof(string));
            myDataTable.Columns.Add("Column2", typeof(int));

            // Add some sample data
            myDataTable.Rows.Add("Item1", 100);
            myDataTable.Rows.Add("Item2", 200);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create a new report instance
            Report report = new Report();

            try
            {
                // Load the report from file (.frx file)
                report.Load(@"repo2.frx");

                // Register the DataTable to the report
                DataSet dataSet = new DataSet();
                dataSet.Tables.Add(myDataTable);  // Add your DataTable to a DataSet

                // Register the dataset to the report
                report.RegisterData(dataSet, "DataSetName");

                // Prepare the report (compile and generate)
                report.Prepare();

                // Show the print preview before printing
                report.ShowPrepared();

                // Optionally, print the report directly without preview
                // report.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Dispose of the report to free resources
                report.Dispose();
            }
        }
    }
}
