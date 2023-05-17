# Longest period with few guards

$N$ guards work at a museum for $M$ days.
For each guard, we know the two days between which they were on duty.

Write a program that gives the longestv period of days when the number of guards in the museum was always less than two.

## Input

The first line of standard input contains the count of days $1\le{M}\le{100}$, and the count of guards ($1\le{N}\le{1000}$).
The next $N$ lines contain the first day and the last day the given guard was on duty ($1\le{F}$, $L\le{M}$) separated by a space.

## Output

The first line of standard output should contain the beginning and end of the longest period of days when the number of guards in the museum was always less than $2$.
If there is no such period, the output should be $0$.
If there is more than one solution, the output should be the one with the smallest beginning index.

## Example

**Input**

```
6 5
1 3
6 6
1 2
2 3
3 4
```

**Output**

```
4 6
```