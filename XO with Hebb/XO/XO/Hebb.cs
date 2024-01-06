using System;
using System.Collections.Generic;

namespace XO
{
    public class Hebb
    {
        private readonly int[] _weights = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private int[] _deltaWeights = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private readonly List<Data> _separatedData;
        private readonly int[] _testingData;
        private bool _processCompleted = false;

        public bool ProcessCompleted => _processCompleted;

        public Hebb(List<Data> separatedData, int[] testingData)
        {
            _separatedData = separatedData;
            _testingData = testingData;
        }

        public void Training(List<Data> separatedData)
        {
            foreach (Data data in separatedData)
            {
                Array.Clear(_deltaWeights, 0, _deltaWeights.Length); // Clear delta weights for each data point

                for (int i = 0; i < 25; i++)
                {
                    for (int j = 0; j < 25; j++)
                    {
                        var propertyValue = (int)data.GetType().GetProperty($"x{i + 1}").GetValue(data);
                        _deltaWeights[j] += propertyValue * data.GetX26();
                    }
                }

                for (int j = 0; j < 25; j++)
                {
                    _weights[j] += _deltaWeights[j];
                }
            }

            _processCompleted = true;
        }




        public string Testing(int[] testingData)
        {
            int result = 0;

            for (int i = 0; i < 25; i++)
            {
                result += testingData[i] * _weights[i];
            }

            result += testingData[24];

            return result > 0 ? "x" : "o";
        }

    }
}
