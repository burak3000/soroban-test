Feature: NumberGenerator
Number generator.

    @twoDigit
    Scenario: Number generation with digit count.
        Given entered digit number and generated number count is like below
          | DigitCount | NumberCountToGenerate |
          | 1          | 1                     |
          | 1          | 2                     |
          | 2          | 1                     |
          | 2          | 2                     |
          | 3          | 1                     |
          | 3          | 2                     |
          | 3          | 3                     |
          | 9          | 45                    |
        When generate is called
        Then the generated numbers
          | EachLessThan | GeneratedNumberCount |
          | 10           | 1                    |
          | 10           | 2                    |
          | 100          | 1                    |
          | 100          | 2                    |
          | 1000         | 1                    |
          | 1000         | 2                    |
          | 1000         | 3                    |
          | 1000000000   | 45                   |
          