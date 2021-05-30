using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RailwayPanel
{
    public partial class Form1 : Form
    {
        SqlConnection sqlCon;

        public Form1()
        {
            InitializeComponent();
            comboBox1.Validated += comboBox1_Validated;
            errorProvider1.SetIconAlignment(comboBox1, ErrorIconAlignment.MiddleRight);
            comboBox2.Validated += comboBox2_Validated;
            errorProvider1.SetIconAlignment(comboBox2, ErrorIconAlignment.MiddleRight);
            comboBox3.Validated += comboBox3_Validated;
            errorProvider1.SetIconAlignment(comboBox3, ErrorIconAlignment.MiddleRight);
            comboBox4.Validated += comboBox4_Validated;
            errorProvider1.SetIconAlignment(comboBox4, ErrorIconAlignment.MiddleRight);
            comboBox5.Validated += comboBox5_Validated;
            errorProvider1.SetIconAlignment(comboBox5, ErrorIconAlignment.MiddleRight);
            comboBox6.Validated += comboBox6_Validated;
            errorProvider1.SetIconAlignment(comboBox6, ErrorIconAlignment.MiddleRight);
            comboBox7.Validated += comboBox7_Validated;
            errorProvider1.SetIconAlignment(comboBox7, ErrorIconAlignment.MiddleRight);
            comboBox8.Validated += comboBox8_Validated;
            errorProvider1.SetIconAlignment(comboBox8, ErrorIconAlignment.MiddleRight);
            comboBox9.Validated += comboBox9_Validated;
            errorProvider1.SetIconAlignment(comboBox9, ErrorIconAlignment.MiddleRight);
            comboBox10.Validated += comboBox10_Validated;
            errorProvider1.SetIconAlignment(comboBox10, ErrorIconAlignment.MiddleRight);



        }
        private void comboBox1_Validated(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {

                errorProvider1.SetError(comboBox1, "Выберите значение");
                errorProvider1.SetIconAlignment(comboBox1, ErrorIconAlignment.MiddleRight);

            }
            else
            {
                errorProvider1.Clear();

            }

        }
        private void comboBox2_Validated(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == -1)
            {

                errorProvider1.SetError(comboBox2, "Выберите значение");
                errorProvider1.SetIconAlignment(comboBox2, ErrorIconAlignment.MiddleRight);
            }
            else
            {
                errorProvider1.Clear();

            }
        }
        private void comboBox3_Validated(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex == -1)
            {

                errorProvider1.SetError(comboBox3, "Выберите значение");
                errorProvider1.SetIconAlignment(comboBox3, ErrorIconAlignment.MiddleRight);
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void comboBox4_Validated(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex == -1)
            {

                errorProvider1.SetError(comboBox4, "Выберите значение");
                errorProvider1.SetIconAlignment(comboBox4, ErrorIconAlignment.MiddleRight);
            }
            else
            {
                errorProvider1.Clear();
            }
        }
        private void comboBox5_Validated(object sender, EventArgs e)
        {
            if (comboBox5.SelectedIndex == -1)
            {

                errorProvider1.SetError(comboBox5, "Выберите значение");
                errorProvider1.SetIconAlignment(comboBox5, ErrorIconAlignment.MiddleRight);
            }
            else
            {
                errorProvider1.Clear();
            }
        }




        private void comboBox6_Validated(object sender, EventArgs e)
        {
            if (comboBox6.SelectedIndex == -1)
            {

                errorProvider1.SetError(comboBox6, "Выберите значение");
                errorProvider1.SetIconAlignment(comboBox6, ErrorIconAlignment.MiddleRight);
            }
            else
            {
                errorProvider1.Clear();
            }
        }
        private void comboBox7_Validated(object sender, EventArgs e)
        {
            if (comboBox7.SelectedIndex == -1)
            {

                errorProvider1.SetError(comboBox7, "Выберите значение");
                errorProvider1.SetIconAlignment(comboBox7, ErrorIconAlignment.MiddleRight);
            }
            else
            {
                errorProvider1.Clear();
            }
        }
        private void comboBox8_Validated(object sender, EventArgs e)
        {
            if (comboBox8.SelectedIndex == -1)
            {

                errorProvider1.SetError(comboBox8, "Выберите значение");
                errorProvider1.SetIconAlignment(comboBox8, ErrorIconAlignment.MiddleRight);
            }
            else
            {
                errorProvider1.Clear();
            }
        }
        private void comboBox9_Validated(object sender, EventArgs e)
        {
            if (comboBox9.SelectedIndex == -1)
            {

                errorProvider1.SetError(comboBox9, "Выберите значение");
                errorProvider1.SetIconAlignment(comboBox9, ErrorIconAlignment.MiddleRight);
            }
            else
            {
                errorProvider1.Clear();
            }
        }
        private void comboBox10_Validated(object sender, EventArgs e)
        {
            if (comboBox10.SelectedIndex == -1)
            {

                errorProvider1.SetError(comboBox10, "Выберите значение");
                errorProvider1.SetIconAlignment(comboBox10, ErrorIconAlignment.MiddleRight);
            }
            else
            {
                errorProvider1.Clear();
            }

        }




        private async void Form1_Load(object sender, EventArgs e)
        {
            string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\RailwayPanel\RailwayPanel\RailwayPanel\Database1.mdf;Integrated Security=True";
            sqlCon = new SqlConnection(connection);
            await sqlCon.OpenAsync();
            SqlDataReader sqlReader = null;
            SqlCommand sqlCom = new SqlCommand("SELECT * FROM [TableRail]", sqlCon);

            try
            {
                sqlReader = await sqlCom.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    listBox1.Items.Add(Convert.ToString(sqlReader["id"] + "   |   " + sqlReader["train_number"] + "   |   " + sqlReader["type"]
                        + "   |   " + sqlReader["last_station"] + "   |   " + sqlReader["time_in"] + "   |   " + sqlReader["time_out"] + "   |   " + sqlReader["fact_time_in"] +
                        "   |   " + sqlReader["fact_time_out"] + "   |   " + sqlReader["way_number"] + "   |   " + sqlReader["tickets_koupe"] + "   |   " + sqlReader["tickets_plaz"] + "   |   "
                        + sqlReader["data"]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null) sqlReader.Close();
            }
        }

        private void ВыходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sqlCon != null && sqlCon.State != ConnectionState.Closed) sqlCon.Close();
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sqlCon != null && sqlCon.State != ConnectionState.Closed) sqlCon.Close();
        }


        private async void Button1_Click(object sender, EventArgs e)
        {

                if (textBox1.Text == "" || comboBox1.Text == null || comboBox2.Text == null || comboBox3.Text == null || comboBox4.Text == null || comboBox5.Text == null)
                {
                label32.Visible = true;
                label32.Text ="Ошибка! Заполните все поля";
                }
                else
                {



                    SqlCommand sqlCom = new SqlCommand("INSERT INTO [TableRail] (train_number,type,last_station,time_in, time_out, fact_time_in, fact_time_out,way_number,tickets_koupe,tickets_plaz, data)VALUES(@train_number,@type,@last_station,@time_in, @time_out, @fact_time_in, @fact_time_out,@way_number,@tickets_koupe,@tickets_plaz, @data)", sqlCon);
                    sqlCom.Parameters.AddWithValue("train_number", textBox1.Text);
                    sqlCom.Parameters.AddWithValue("type", comboBox1.Text);
                    sqlCom.Parameters.AddWithValue("last_station", comboBox5.Text);
                    sqlCom.Parameters.AddWithValue("time_in", dateTimePicker2.Value);
                    sqlCom.Parameters.AddWithValue("time_out", dateTimePicker3.Value);
                if (checkBox1.Checked != true)
                {
                    sqlCom.Parameters.AddWithValue("fact_time_in", dateTimePicker2.Value);
                    sqlCom.Parameters.AddWithValue("fact_time_out", dateTimePicker3.Value);
                }
                else
                {
                    sqlCom.Parameters.AddWithValue("fact_time_in", dateTimePicker4.Value);
                    sqlCom.Parameters.AddWithValue("fact_time_out", dateTimePicker5.Value);
                }
                //sqlCom.Parameters.AddWithValue("fact_time_in", dateTimePicker4.Value);
                //    sqlCom.Parameters.AddWithValue("fact_time_out", dateTimePicker5.Value);
                    sqlCom.Parameters.AddWithValue("way_number", Convert.ToInt32(comboBox2.Text));
                    sqlCom.Parameters.AddWithValue("tickets_koupe", Convert.ToInt32(comboBox3.Text));
                    sqlCom.Parameters.AddWithValue("tickets_plaz", Convert.ToInt32(comboBox4.Text));
                    sqlCom.Parameters.AddWithValue("data", (dateTimePicker1.Value));
                label32.Visible = false;
                await sqlCom.ExecuteNonQueryAsync();
                }




        }

        private async void ОбновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            SqlDataReader sqlReader = null;
            SqlCommand sqlCom = new SqlCommand("SELECT * FROM [TableRail]", sqlCon);

            try
            {
                sqlReader = await sqlCom.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    listBox1.Items.Add(Convert.ToString(sqlReader["id"] + "   |   " + sqlReader["train_number"] + "   |   " + sqlReader["type"]
                             + "   |   " + sqlReader["last_station"] + "   |   " + sqlReader["time_in"] + "   |   " + sqlReader["time_out"] + "   |   " + sqlReader["fact_time_in"] +
                             "   |   " + sqlReader["fact_time_out"] + "   |   " + sqlReader["way_number"] + "   |   " + sqlReader["tickets_koupe"] + "   |   " + sqlReader["tickets_plaz"] + "   |   "
                             + sqlReader["data"]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null) sqlReader.Close();
            }
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private async void Button2_Click(object sender, EventArgs e)
        {
            if (textBox18.Text == "" || textBox19.Text == "" || comboBox6.Text == null || comboBox7.Text == null || comboBox8.Text == null || comboBox9.Text == null || comboBox10.Text == null)
            {
                label33.Visible = true;
                label33.Text = "Ошибка! Заполните все поля";
            }
            else
            {
                try
                {
                    SqlCommand sqlCom = new SqlCommand("UPDATE [TableRail] SET [train_number] = @train_number,[type]=@type,[last_station]=@last_station, [time_in] = @time_in, [time_out]=@time_out,[fact_time_in]=@fact_time_in,[fact_time_out]=@fact_time_out,[way_number]=way_number,[tickets_koupe]=@tickets_koupe,[tickets_plaz]=tickets_plaz WHERE[Id]=@Id", sqlCon);
                    int id = Convert.ToInt32(textBox19.Text);
                    sqlCom.Parameters.AddWithValue("id", Convert.ToInt32(textBox19.Text));
                    sqlCom.Parameters.AddWithValue("train_number", textBox18.Text);
                    sqlCom.Parameters.AddWithValue("type", comboBox6.Text);
                    sqlCom.Parameters.AddWithValue("last_station", comboBox7.Text);
                    sqlCom.Parameters.AddWithValue("time_in", dateTimePicker6.Value);
                    sqlCom.Parameters.AddWithValue("time_out", dateTimePicker7.Value);
                    if (checkBox2.Checked != true)
                    {
                        sqlCom.Parameters.AddWithValue("fact_time_in", dateTimePicker6.Value);
                        sqlCom.Parameters.AddWithValue("fact_time_out", dateTimePicker7.Value);
                        
                    }
                    else
                    {
                        sqlCom.Parameters.AddWithValue("fact_time_in", dateTimePicker8.Value);
                        sqlCom.Parameters.AddWithValue("fact_time_out", dateTimePicker9.Value);
                    }
                    sqlCom.Parameters.AddWithValue("way_number", Convert.ToInt32(comboBox8.Text));
                    sqlCom.Parameters.AddWithValue("tickets_koupe", Convert.ToInt32(comboBox9.Text));
                    sqlCom.Parameters.AddWithValue("tickets_plaz", Convert.ToInt32(comboBox10.Text));
                    label33.Visible = false;

                    await sqlCom.ExecuteNonQueryAsync();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Введите корректные данные в поле ID", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
            }
        }

        private async void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBox20.Text);
                SqlCommand command = new SqlCommand("DELETE FROM [TableRail] WHERE [Id]=@Id", sqlCon);

                command.Parameters.AddWithValue("Id", textBox20.Text);

                await command.ExecuteNonQueryAsync();
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите корректные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
            
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label24_Click(object sender, EventArgs e)
        {

        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Label25_Click(object sender, EventArgs e)
        {

        }

        private void Label21_Click(object sender, EventArgs e)
        {

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label28_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
   
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                label6.Visible = true;
                label7.Visible = true;
                dateTimePicker4.Visible = true;
                dateTimePicker5.Visible = true;


            }
            else
            {
                label6.Visible = false;
                label7.Visible = false;
                dateTimePicker4.Visible = false;
                dateTimePicker5.Visible = false;
            }
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                label12.Visible = true;
                label13.Visible = true;
                dateTimePicker8.Visible = true;
                dateTimePicker9.Visible = true;


            }
            else
            {
                label12.Visible = false;
                label13.Visible = false;
                dateTimePicker8.Visible = false;
                dateTimePicker9.Visible = false;
            }
        }

        private void СправкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var d = new AboutBox1();
            d.Show();
        }

        private void TextBox19_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
