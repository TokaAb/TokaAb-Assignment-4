BenchmarkDotNet Results

| Method                     | Iterations | Mean         | Error       | StdDev      | Allocated |
|---------------------------|-----------:|------------:|------------:|------------:|-----------:|
| StringConcatenation       | 100        | 1,246.955 us | 24.6463 us | 47.4850 us | 15664.01 KB |
| StringBuilderConcatenation| 100        | 5.554 us     | 0.1105 us  | 0.3240 us  | 63.67 KB |
| StringConcatenation       | 1000       | 1,102.347 us | 21.9525 us | 49.0999 us | 15664.01 KB |
| StringBuilderConcatenation| 1000       | 5.196 us     | 0.0822 us  | 0.0769 us  | 63.67 KB |
| StringConcatenation       | 10000      | 1,055.714 us | 21.0863 us | 57.7234 us | 15664.01 KB |
| StringBuilderConcatenation| 10000      | 5.298 us     | 0.1044 us  | 0.1686 us  | 63.67 KB |
| StringConcatenation       | 100000     | 1,011.711 us | 20.2138 us | 47.6462 us | 15664.01 KB |
| StringBuilderConcatenation| 100000     | 5.134 us     | 0.0946 us  | 0.0839 us  | 63.67 KB |


Analysis

1. Which approach was faster with 100 iterations?

StringBuilderConcatenation was faster with 100 iterations.
Its mean execution time was 5.554 us, compared with 1,246.955 us for StringConcatenation.


2. Which approach was faster with 100,000 iterations?

StringBuilderConcatenation was faster with 100,000 iterations.
Its mean execution time was 5.134 us, compared with 1,011.711 us for StringConcatenation.


3. Which approach allocated more memory?

StringConcatenation allocated more memory.
It allocated 15664.01 KB, while StringBuilderConcatenation allocated only 63.67 KB.


4. What happened to string concatenation performance as the loop size increased?

In these benchmark results, the mean execution time of StringConcatenation decreased from 1,246.955 us at 100 iterations to 1,011.711 us at 100,000 iterations.
However, StringConcatenation remained much slower than StringBuilderConcatenation in all tested cases.


5. Why does repeated string concatenation create additional allocations?

Strings in C# are immutable. This means that when we use += to add text to a string, the original string is not modified.
A new string is created to contain the updated value, which can result in additional memory allocations.


6. Why does StringBuilder usually perform better when text is repeatedly appended?

StringBuilder is designed for modifying and building text repeatedly.
It uses an internal buffer and can append text without creating a new string for every append operation.
Therefore, it usually reduces allocations and improves performance when text is repeatedly appended.


7. Is StringBuilder always better than normal string operations? Explain.

No, StringBuilder is not always better.

For simple string operations or a small number of concatenations, normal string operations such as + or += can be simpler and appropriate.

StringBuilder is especially useful when text is repeatedly appended, particularly inside loops or when building larger strings.