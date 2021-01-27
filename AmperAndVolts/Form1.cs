using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmperAndVolts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_count_Click(object sender, EventArgs e)
        {
            if (textBox_volts1.Text != "" && textBox_resistance1.Text != "")
            {
                VoltOmAmper first = new VoltOmAmper(textBox_volts1.Text, textBox_resistance1.Text);
                textBox_ampers1.Text = $"{first.getAmper()}";
                MessageBox.Show($"Напряжение: {first.getVolts()} Вольт\nСопротивление: {first.getOm()} Ом\nСила тока: {first.getAmper()} Ампер", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox_resistance_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void button_count2_Click(object sender, EventArgs e)
        {
            if (textBox_ampers2.Text != "" && textBox_resistance2.Text != "")
            {
                AmperOmWatt first = new AmperOmWatt(textBox_ampers2.Text, textBox_resistance2.Text);
                textBox_power.Text = $"{first.getWatts()}";
                MessageBox.Show($"Сила тока: {first.getAmpers()} Ампер\nСопротивление: {first.getOm()} Ом\nМощность: {first.getWatts()} Ватт", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_count3_Click(object sender, EventArgs e)
        {
            if (textBox_mass.Text != "" && textBox_speed.Text != "")
            {
                MassSpeedEnergy first = new MassSpeedEnergy(textBox_mass.Text, textBox_speed.Text);
                textBox_energy.Text = $"{first.getEnergy()}";
                MessageBox.Show($"Масса: {first.getMass()} грамм\nСкорость: {first.getSpeed()} м/с\nЭнергия: {first.getEnergy()} Дж", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
