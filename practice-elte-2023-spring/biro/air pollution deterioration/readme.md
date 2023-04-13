
# Air pollution deterioration

Air pollution is measured at a busy part of the city each day in the morning and in the evening.

Write a program that gives us how many days were when the morning measurement was bigger than the morning measurement of the previous day, and the evening measurement was also bigger than the evening measurement of the previous day.

## Input

The first line of the standard input contains the count of ($1\le N\le 100$).

The next $N$ lines contain the two integers separated by a space:
- the first number is the morning measurement ($1\le M\le 300$),
- the other number is the evening measurement ($1\le E\le 300$).

## Output

The first line of the standard output should contain the count of days when the morning measurement was bigger than the morning measurement of the previous day, and the evening measurement was also bigger than the evening measurement of the previous day.

## Example

**Input**

```
6
100 120
200 122
170 190
100 222
150 155
75 60
```

**Output**

```
1
```

**Limits**

Time limit: 0.1 second

Memory limit: 32 MiB

Evaluation: In 40% of tests, the count of data is $\le 20$