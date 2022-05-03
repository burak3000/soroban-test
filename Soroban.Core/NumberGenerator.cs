namespace Soroban.Core;

public class NumberGenerator
{
    Random m_RandomGenerator = new Random();
    private int m_LowerLimit = 1;
    private int m_UpperLimit = 1;
    public List<int> GenerateNDigitRandomNumbers(int digitCount, int numberCountToGenerate)
    {
        List<int> randomNumbers = new List<int>();
        m_LowerLimit = 1;
        m_UpperLimit = 1;
        for (int i = 1; i < digitCount; i++)
        {
            m_LowerLimit *= 10;
        }

        for (int i = 0; i < digitCount; i++)
        {
            m_UpperLimit *= 10;
        }

        for (int i = 0; i < numberCountToGenerate; i++)
        {
            int randomNumber = m_RandomGenerator.Next(m_LowerLimit, m_UpperLimit);
            randomNumbers.Add(randomNumber);
        }

        return randomNumbers;
    }
}