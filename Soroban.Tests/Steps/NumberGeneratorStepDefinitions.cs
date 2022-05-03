using NUnit.Framework;
using Soroban.Core;
using TechTalk.SpecFlow.Assist;

namespace Soroban.Steps;

[Binding]
public class NumberGeneratorStepDefinitions
{
    private NumberGenerator m_Generator = new NumberGenerator();
    private List<GenerationParameters> m_GenerationParamters = new List<GenerationParameters>();
    private List<AssertionParameters> m_AssertionParameters = new List<AssertionParameters>();
    private List<List<int>> m_GeneratedNumbers = new List<List<int>>();

    [Given(@"entered digit number and generated number count is like below")]
    public void GivenEnteredDigitNumberAndGeneratedNumberCountIsLikeBelow(Table table)
    {
        m_GenerationParamters = table.CreateSet<GenerationParameters>().ToList();
    }

    [When(@"generate is called")]
    public void WhenGenerateIsCalled()
    {
        m_GenerationParamters.ForEach(p =>
            m_GeneratedNumbers.Add(m_Generator.GenerateNDigitRandomNumbers(p.DigitCount, p.NumberCountToGenerate)));
    }

    [Then(@"the generated numbers")]
    public void ThenTheGeneratedNumbers(Table table)
    {
        m_AssertionParameters = table.CreateSet<AssertionParameters>().ToList();
        for (int i = 0; i < m_GeneratedNumbers.Count; i++)
        {
            Assert.That(m_GeneratedNumbers[i].Count, Is.EqualTo(m_AssertionParameters[i].GeneratedNumberCount));
            m_GeneratedNumbers[i].ForEach(n => { Assert.That(n, Is.LessThan(m_AssertionParameters[i].EachLessThan)); });
        }
    }

    public class GenerationParameters
    {
        public int DigitCount { get; set; }
        public int NumberCountToGenerate { get; set; }
    }

    public class AssertionParameters
    {
        public int EachLessThan { get; set; }
        public int GeneratedNumberCount { get; set; }
    }
}