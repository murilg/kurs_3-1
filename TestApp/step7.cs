using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace TestApp
{
    public partial class step7 : Form
    {
        public step7()
        {
            InitializeComponent();
        }

        private void step7_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MaxDate = DateTime.Today.AddYears(-18);
            dateTimePicker1.MinDate = DateTime.Today.AddYears(-150);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Autho();
            GetRta();
            insertRD(Form1.id, Form4.rta.VehicleId1, Form4.rta.damage1, Form4.rta.can1, Form4.rta.park1);
            insertRD(Form4.rta.DriverId2, Form4.rta.VehicleId2, Form4.rta.damage2, Form4.rta.can2, Form4.rta.park2);
            SetWitness();
            Hide();
            var form = new step8();
            form.ShowDialog();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            var form = new Form3();
            form.ShowDialog();
            Close();
        }

        private void Autho()
        {
            string cmdstr = """
                            insert into RTA (City, Street, Building, Date_and_time, Number_of_wounded, Number_of_dead, by_an_GIBDD_officer)
                            values (@city, @street, @b, @date, 0, 0, 0)
                            """;
            using (var con = new SqlConnection(Connection.Constr.ConnectionString))
            {
                using (var cmd = new SqlCommand(cmdstr, con))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@city", Form4.rta.City);
                        cmd.Parameters.AddWithValue("@street", Form4.rta.Street);
                        cmd.Parameters.AddWithValue("@b", Form4.rta.Building);
                        cmd.Parameters.AddWithValue("@date", Form4.rta.Date_and_time);
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка: {ex}");
                    }
                }
            }
        }

        private void GetRta()
        {
            string cmdstr = """
                            select rta_id
                            from RTA
                            where city = @city and street = @street and building = @b and date_and_time = @date
                            """;
            using (var con = new SqlConnection(Connection.Constr.ConnectionString))
            {
                using (var cmd = new SqlCommand(cmdstr, con))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@city", Form4.rta.City);
                        cmd.Parameters.AddWithValue("@street", Form4.rta.Street);
                        cmd.Parameters.AddWithValue("@b", Form4.rta.Building);
                        cmd.Parameters.AddWithValue("@date", Form4.rta.Date_and_time);
                        con.Open();
                        Form4.rta.RtaId = (int)cmd.ExecuteScalar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка: {ex}");
                    }
                }
            }
        }

        private void insertRD(int did, int vid, string damage, int move, string park)
        {
            string cmdstr = """
                            insert into RTA_Driver (RTA_id, Driver_id, Vehicle_id, the_driver_is_drunk, is_the_owner_a_driver, is_the_vehicle_insured, Vehicle_damage, damage_to_other_property, can_the_vehicle_move, Vehicle_parking_address)
                            values (@rtaid, @did, @vid, 0, 0, 0, @damage, 0, @move, @parking)
                            """;
            using (var con = new SqlConnection(Connection.Constr.ConnectionString))
            {
                using (var cmd = new SqlCommand(cmdstr, con))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@rtaid", Form4.rta.RtaId);
                        cmd.Parameters.AddWithValue("@did", did);
                        cmd.Parameters.AddWithValue("@vid", vid);
                        cmd.Parameters.AddWithValue("@damage", damage);
                        cmd.Parameters.AddWithValue("@move", move);
                        cmd.Parameters.AddWithValue("@parking", park);
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка: {ex}");
                    }
                }
            }
        }

        private void SetWitness()
        {
            string cmdstr = """
                            insert into Witness (RTA_id, Surname, Name, Patronymic, Date_of_birth, Address, Phone_number) 
                            values (@rtaid, @sur, @name, @pat, @dr, @adr, @pn)
                            """;
            using (var con = new SqlConnection(Connection.Constr.ConnectionString))
            {
                using (var cmd = new SqlCommand(cmdstr, con))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@rtaid", Form4.rta.RtaId);
                        cmd.Parameters.AddWithValue("@sur", textBox1.Text);
                        cmd.Parameters.AddWithValue("@name", textBox2.Text);
                        cmd.Parameters.AddWithValue("@pat", textBox3.Text);
                        cmd.Parameters.AddWithValue("@dr", dateTimePicker1.Value.Date);
                        cmd.Parameters.AddWithValue("@adr", textBox4.Text);
                        cmd.Parameters.AddWithValue("@pn", maskedTextBox1.Text);
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка: {ex}");
                    }
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
