```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8037/25H2/2025Update/HudsonValley2)
Intel Core i7-10510U CPU 1.80GHz (Max: 2.30GHz), 1 CPU, 8 logical and 4 physical cores
.NET SDK 10.0.302
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 [AttachedDebugger]
  DefaultJob : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3


```
| Method                     | Iterations | Mean         | Error      | StdDev     | Median       | Gen0      | Gen1   | Allocated   |
|--------------------------- |----------- |-------------:|-----------:|-----------:|-------------:|----------:|-------:|------------:|
| **StringConcatenation**        | **100**        | **1,246.955 μs** | **24.6463 μs** | **47.4850 μs** | **1,254.796 μs** | **3820.3125** |      **-** | **15664.01 KB** |
| StringBuilderConcatenation | 100        |     5.554 μs |  0.1105 μs |  0.3240 μs |     5.507 μs |   15.5411 | 1.2894 |    63.67 KB |
| **StringConcatenation**        | **1000**       | **1,102.347 μs** | **21.9525 μs** | **49.0999 μs** | **1,095.795 μs** | **3820.3125** |      **-** | **15664.01 KB** |
| StringBuilderConcatenation | 1000       |     5.196 μs |  0.0822 μs |  0.0769 μs |     5.193 μs |   15.5411 | 1.2894 |    63.67 KB |
| **StringConcatenation**        | **10000**      | **1,055.714 μs** | **21.0863 μs** | **57.7234 μs** | **1,041.973 μs** | **3820.3125** |      **-** | **15664.01 KB** |
| StringBuilderConcatenation | 10000      |     5.298 μs |  0.1044 μs |  0.1686 μs |     5.276 μs |   15.5411 | 1.2894 |    63.67 KB |
| **StringConcatenation**        | **100000**     | **1,011.711 μs** | **20.2138 μs** | **47.6462 μs** |   **995.724 μs** | **3820.3125** |      **-** | **15664.01 KB** |
| StringBuilderConcatenation | 100000     |     5.134 μs |  0.0946 μs |  0.0839 μs |     5.109 μs |   15.5411 | 1.2894 |    63.67 KB |
