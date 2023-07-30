using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WindowsFormsApp4
{
    public partial class CarPrice : Form
    {
        public CarPrice()
        {
            InitializeComponent();
        }

        private int lastRow = -1;
        List<Vehicle> v = new List<Vehicle>();
        private void Type1_combo1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Company_combo1_SelectedIndexChanged(object sender, EventArgs e)
        {
            symbol1.SizeMode = PictureBoxSizeMode.StretchImage;
            if (Company_combo1.Text.ToString() == "Toyota")
            {
                symbol1.Load(@"C:\Users\אני\source\repos\WindowsFormsApp4\WindowsFormsApp4\resource\toyota.png");

            }
            if (Company_combo1.Text.ToString() == "Kia")
            {
                symbol1.Load(@"C:\Users\אני\source\repos\WindowsFormsApp4\WindowsFormsApp4\resource\kia.png");
            }
            if (Company_combo1.Text.ToString() == "Suzuki")
            {
                symbol1.Load(@"C:\Users\אני\source\repos\WindowsFormsApp4\WindowsFormsApp4\resource\suzuki.png");
            }
            if (Company_combo1.Text.ToString() == "Honda")
            {
                symbol1.Load(@"C:\Users\אני\source\repos\WindowsFormsApp4\WindowsFormsApp4\resource\honda.png");

            }
        }
        private void Year_textBox_TextChanged(object sender, EventArgs e)
        {

            if (Year_textBox.Text.ToString() != "" && ((int.Parse(Year_textBox.Text.ToString()) / 1000 > 0) && (int.Parse(Year_textBox.Text.ToString()) / 1000 <= 9)))
            {
                if (int.Parse(Year_textBox.Text.ToString()) <= 1999 || int.Parse(Year_textBox.Text.ToString()) >= 2023)
                {

                    MessageBox.Show("Try Again");
                }
            }
        }
        private void Price_textBox_TextChanged(object sender, EventArgs e)
        {
            if (Price_textBox.Text.ToString() != "" )
            {
                if (double.Parse(Price_textBox.Text.ToString()) <= 0 || double.Parse(Price_textBox.Text.ToString()) >= 100001)
                {

                    MessageBox.Show("Try Again");
                }
            }

        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            if (Type1_combo1.Text.ToString() == "PrivateCar")

            {
                if (Company_combo1.Text.ToString() == "Toyota")
                {

                    v.Add(new Toyota(Type1_combo1.Text, Company_combo1.Text, int.Parse(Year_textBox.Text), double.Parse(Price_textBox.Text), Vehicle.size++));


                    dataGridView2.Rows.Add(Type1_combo1.Text, Company_combo1.Text, Year_textBox.Text, Price_textBox.Text);

                }
                if (Company_combo1.Text.ToString() == "Kia")
                {

                    v.Add(new Kia(Type1_combo1.Text, Company_combo1.Text, int.Parse(Year_textBox.Text), double.Parse(Price_textBox.Text), Vehicle.size++));

                    dataGridView2.Rows.Add(Type1_combo1.Text, Company_combo1.Text, Year_textBox.Text, Price_textBox.Text);

                }
            }
            if (Type1_combo1.Text.ToString() == "Motorcycle")
            {

                if (Company_combo1.Text.ToString() == "Suzuki")
                {
                    v.Add(new Suzuki(Type1_combo1.Text, Company_combo1.Text, int.Parse(Year_textBox.Text), double.Parse(Price_textBox.Text), Vehicle.size++));

                    dataGridView2.Rows.Add(Type1_combo1.Text, Company_combo1.Text, Year_textBox.Text, Price_textBox.Text);
                }

                if (Company_combo1.Text.ToString() == "Honda")
                {
                    v.Add(new Honda(Type1_combo1.Text, Company_combo1.Text, int.Parse(Year_textBox.Text), double.Parse(Price_textBox.Text), Vehicle.size++));

                    dataGridView2.Rows.Add(Type1_combo1.Text, Company_combo1.Text, Year_textBox.Text, Price_textBox.Text);
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lastRow = e.RowIndex;




        }

        private void Remove_button_Click(object sender, EventArgs e)
        {
            if (lastRow != -1)
            {
                if (lastRow <= Vehicle.size)
                {
                    foreach (Vehicle vi in v)
                    {
                        if (vi.INDEX == lastRow)
                        {
                            v[lastRow] = v[Vehicle.size - 1];
                            v[lastRow].INDEX = lastRow;
                            Vehicle.size--;
                            dataGridView2.Rows.RemoveAt(lastRow);
                            return;
                        }
                    }
                }
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lastRow = e.RowIndex;
        }

        private void Type1_combo1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox temp = (ComboBox)sender;
            if (temp.SelectedItem.ToString() == "PrivateCar")
            {
                this.Company_combo1.Items.Clear();
                this.Company_combo1.Items.Add("Toyota");
                this.Company_combo1.Items.Add("Kia");

            }
            if (temp.SelectedItem.ToString() == "Motorcycle")
            {
                this.Company_combo1.Items.Clear();
                this.Company_combo1.Items.Add("Suzuki");
                this.Company_combo1.Items.Add("Honda");

            }
        }

        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
            if (lastRow !=-1)
            { 
            if (e.ColumnIndex == 2)
            {
                v[e.RowIndex].YEAR = Int32.Parse(dataGridView2[e.ColumnIndex, e.RowIndex].Value.ToString()); 
            }
            if (e.ColumnIndex == 3)
            {
                v[e.RowIndex].PRICE = Int32.Parse(dataGridView2[e.ColumnIndex, e.RowIndex].Value.ToString());
                    
            }
            }
            
        }

        private void Year_textBox_MouseDown(object sender, MouseEventArgs e)
        {
            Year_textBox.Text = "";
        }

        private void Price_textBox_MouseDown(object sender, MouseEventArgs e)
        {
            Price_textBox.Text = "";
        }

        private void s(object sender, EventArgs e)
        {

        }

        private void save_button_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog1.Filter = "model files (*.mdl)|*.mdl|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                IFormatter formatter = new BinaryFormatter();
                using (Stream stream = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    
                    formatter.Serialize(stream,v);
                }
            }
        }

        private void load_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog1.Filter = "model files (*.mdl)|*.mdl|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream stream = File.Open(openFileDialog1.FileName, FileMode.Open);
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                
                v= (List<Vehicle>)binaryFormatter.Deserialize(stream);
                
            }
            foreach (Vehicle vi in v)
            {
                dataGridView2.Rows.Add(vi.TYPE, vi.COMPANY, vi.YEAR, vi.PRICE);
            }
        }
    }

}
