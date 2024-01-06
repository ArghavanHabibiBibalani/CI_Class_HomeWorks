using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace XO
{
    public partial class Form1 : Form
    {
        private readonly List<Data> _separatedData = new List<Data>();
        private readonly int[] _testingData = new int[25];
        private readonly Hebb _hebb;
        private int _click = 0;
        private bool _isTraining = false;
        private bool _ishebb = false;

        public Form1(List<Data> separatedData, int[] testingData)
        {
            InitializeComponent();
            _separatedData.AddRange(separatedData);
            Array.Copy(testingData, _testingData, testingData.Length);

            _hebb = new Hebb(_separatedData, _testingData);
        }



        private void checktraining_CheckedChanged(object sender, EventArgs e)
        {
            _isTraining = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            int index = int.Parse(button.Tag.ToString());

            if (_isTraining)
            {
                var propertyName = $"x{index - 1}";
                var property = typeof(Data).GetProperty(propertyName);
                
                if (property != null)
                {
                    property.SetValue(_separatedData[_click], 1);
                }
            }
            else
            {
                _testingData[index] = 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            int index = int.Parse(button.Tag.ToString());

            if (_isTraining)
            {
                var propertyName = $"x{index - 1}";
                var property = typeof(Data).GetProperty(propertyName);
                if (property != null)
                {
                    property.SetValue(_separatedData[_click], 1);
                }
            }
            else
            {
                _testingData[index] = 1;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            int index = int.Parse(button.Tag.ToString());

            if (_isTraining)
            {
                var propertyName = $"x{index - 1}";
                var property = typeof(Data).GetProperty(propertyName);
                if (property != null)
                {
                    property.SetValue(_separatedData[_click], 1);
                }
            }
            else
            {
                _testingData[index] = 1;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            int index = int.Parse(button.Tag.ToString());

            if (_isTraining)
            {
                var propertyName = $"x{index - 1}";
                var property = typeof(Data).GetProperty(propertyName);
                if (property != null)
                {
                    property.SetValue(_separatedData[_click], 1);
                }
            }
            else
            {
                _testingData[index] = 1;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            int index = int.Parse(button.Tag.ToString());

            if (_isTraining)
            {
                var propertyName = $"x{index - 1}";
                var property = typeof(Data).GetProperty(propertyName);
                if (property != null)
                {
                    property.SetValue(_separatedData[_click], 1);
                }
            }
            else
            {
                _testingData[index] = 1;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            int index = int.Parse(button.Tag.ToString());

            if (_isTraining)
            {
                var propertyName = $"x{index - 1}";
                var property = typeof(Data).GetProperty(propertyName);
                if (property != null)
                {
                    property.SetValue(_separatedData[_click], 1);
                }
            }
            else
            {
                _testingData[index] = 1;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            int index = int.Parse(button.Tag.ToString());

            if (_isTraining)
            {
                var propertyName = $"x{index - 1}";
                var property = typeof(Data).GetProperty(propertyName);
                if (property != null)
                {
                    property.SetValue(_separatedData[_click], 1);
                }
            }
            else
            {
                _testingData[index] = 1;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            int index = int.Parse(button.Tag.ToString());

            if (_isTraining)
            {
                var propertyName = $"x{index - 1}";
                var property = typeof(Data).GetProperty(propertyName);
                if (property != null)
                {
                    property.SetValue(_separatedData[_click], 1);
                }
            }
            else
            {
                _testingData[index] = 1;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            int index = int.Parse(button.Tag.ToString());

            if (_isTraining)
            {
                var propertyName = $"x{index - 1}";
                var property = typeof(Data).GetProperty(propertyName);
                if (property != null)
                {
                    property.SetValue(_separatedData[_click], 1);
                }
            }
            else
            {
                _testingData[index] = 1;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            int index = int.Parse(button.Tag.ToString());

            if (_isTraining)
            {
                var propertyName = $"x{index - 1}";
                var property = typeof(Data).GetProperty(propertyName);
                if (property != null)
                {
                    property.SetValue(_separatedData[_click], 1);
                }
            }
            else
            {
                _testingData[index] = 1;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            int index = int.Parse(button.Tag.ToString());

            if (_isTraining)
            {
                var propertyName = $"x{index - 1}";
                var property = typeof(Data).GetProperty(propertyName);
                if (property != null)
                {
                    property.SetValue(_separatedData[_click], 1);
                }
            }
            else
            {
                _testingData[index] = 1;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            int index = int.Parse(button.Tag.ToString());

            if (_isTraining)
            {
                var propertyName = $"x{index - 1}";
                var property = typeof(Data).GetProperty(propertyName);
                if (property != null)
                {
                    property.SetValue(_separatedData[_click], 1);
                }
            }
            else
            {
                _testingData[index] = 1;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            int index = int.Parse(button.Tag.ToString());

            if (_isTraining)
            {
                var propertyName = $"x{index - 1}";
                var property = typeof(Data).GetProperty(propertyName);
                if (property != null)
                {
                    property.SetValue(_separatedData[_click], 1);
                }
            }
            else
            {
                _testingData[index] = 1;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            int index = int.Parse(button.Tag.ToString());

            if (_isTraining)
            {
                var propertyName = $"x{index - 1}";
                var property = typeof(Data).GetProperty(propertyName);
                if (property != null)
                {
                    property.SetValue(_separatedData[_click], 1);
                }
            }
            else
            {
                _testingData[index] = 1;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            int index = int.Parse(button.Tag.ToString());

            if (_isTraining)
            {
                var propertyName = $"x{index - 1}";
                var property = typeof(Data).GetProperty(propertyName);
                if (property != null)
                {
                    property.SetValue(_separatedData[_click], 1);
                }
            }
            else
            {
                _testingData[index] = 1;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            int index = int.Parse(button.Tag.ToString());

            if (_isTraining)
            {
                var propertyName = $"x{index - 1}";
                var property = typeof(Data).GetProperty(propertyName);
                if (property != null)
                {
                    property.SetValue(_separatedData[_click], 1);
                }
            }
            else
            {
                _testingData[index] = 1;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            int index = int.Parse(button.Tag.ToString());

            if (_isTraining)
            {
                var propertyName = $"x{index - 1}";
                var property = typeof(Data).GetProperty(propertyName);
                if (property != null)
                {
                    property.SetValue(_separatedData[_click], 1);
                }
            }
            else
            {
                _testingData[index] = 1;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            int index = int.Parse(button.Tag.ToString());

            if (_isTraining)
            {
                var propertyName = $"x{index - 1}";
                var property = typeof(Data).GetProperty(propertyName);
                if (property != null)
                {
                    property.SetValue(_separatedData[_click], 1);
                }
            }
            else
            {
                _testingData[index] = 1;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            int index = int.Parse(button.Tag.ToString());

            if (_isTraining)
            {
                var propertyName = $"x{index - 1}";
                var property = typeof(Data).GetProperty(propertyName);
                if (property != null)
                {
                    property.SetValue(_separatedData[_click], 1);
                }
            }
            else
            {
                _testingData[index] = 1;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            int index = int.Parse(button.Tag.ToString());

            if (_isTraining)
            {
                var propertyName = $"x{index - 1}";
                var property = typeof(Data).GetProperty(propertyName);
                if (property != null)
                {
                    property.SetValue(_separatedData[_click], 1);
                }
            }
            else
            {
                _testingData[index] = 1;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            int index = int.Parse(button.Tag.ToString());

            if (_isTraining)
            {
                var propertyName = $"x{index - 1}";
                var property = typeof(Data).GetProperty(propertyName);
                if (property != null)
                {
                    property.SetValue(_separatedData[_click], 1);
                }
            }
            else
            {
                _testingData[index] = 1;
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            int index = int.Parse(button.Tag.ToString());

            if (_isTraining)
            {
                var propertyName = $"x{index - 1}";
                var property = typeof(Data).GetProperty(propertyName);
                if (property != null)
                {
                    property.SetValue(_separatedData[_click], 1);
                }
            }
            else
            {
                _testingData[index] = 1;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            int index = int.Parse(button.Tag.ToString());

            if (_isTraining)
            {
                var propertyName = $"x{index - 1}";
                var property = typeof(Data).GetProperty(propertyName);
                if (property != null)
                {
                    property.SetValue(_separatedData[_click], 1);
                }
            }
            else
            {
                _testingData[index] = 1;
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            int index = int.Parse(button.Tag.ToString());

            if (_isTraining)
            {
                var propertyName = $"x{index - 1}";
                var property = typeof(Data).GetProperty(propertyName);
                if (property != null)
                {
                    property.SetValue(_separatedData[_click], 1);
                }
            }
            else
            {
                _testingData[index] = 1;
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            int index = int.Parse(button.Tag.ToString());

            if (_isTraining)
            {
                var propertyName = $"x{index - 1}";
                var property = typeof(Data).GetProperty(propertyName);
                if (property != null)
                {
                    property.SetValue(_separatedData[_click], 1);
                }
            }
            else
            {
                _testingData[24] = 1;
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            int index = int.Parse(button.Tag.ToString());

            if (_isTraining)
            {
                var propertyName = $"x{index - 1}";
                var property = typeof(Data).GetProperty(propertyName);
                if (property != null)
                {
                    property.SetValue(_separatedData[_click], 1);
                }
            }
            
        }

        private void start_Click_1(object sender, EventArgs e)
        {
            _click++;

            if (checktraining.Checked)
            {
                _hebb.Training(_separatedData);
                MessageBox.Show("Training completed!");
            }
            else if (checktesting.Checked)
            {
                string result = _hebb.Testing(_testingData).ToString();
                MessageBox.Show(result);
            }
        }

        private void checktesting_CheckedChanged_1(object sender, EventArgs e)
        {
            _isTraining = false;
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox.Text.Equals("Hebb"))
            {
                _ishebb = true; 
            }
        }
    }
}
