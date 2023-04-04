# No bite

A person went fshing for N days, and we know how much fish he caught each day.

Write a program that gives a day on which he did not catch anything.

## Input

The first line of the standard input contains the count of days (1 $\le$ N $\le$ 100).
The next N lines each contain the fish caught on the given day (0 $\le$ Fi $\le$ 30).

## Output

The first line of the standard output should contain the index of the day on which the person did not catch any fish.
If there is no such day, you should write -1.
If there is more than one solution, you should write out the one with the smallest index.

## Example

**Input**

```
6
20
1
0
3
10
6
```

**Output**

```
3
```

**Limits**

Time limit: 0.1 second

Memory limit: 32 MB

Evaluation: In 40% of tests, the count of data is $\le$ 20