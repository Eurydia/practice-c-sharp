
# Sailing competition – always awarded

At a sailing competition, there are $N$ rounds. 
In each round, the first $K$ sailors are awarded with points.
There are $M$ sailors at the competition.
The first gets $K$, the second $K-1$, the third $K-3$, ... points. 

When calculating the total points, only the first $L$ highest points are included.
The ranking is defined by these totals, the more points you have the better is the rank.
If the totals of two competitors are the same, then the ranking is decided by the
count of first places, if these are also the same, then the second places and so on. 

If all these are totally the same, then their ranking can be arbitrary.

Write a program that lists those sailors who ranked less than $K$ in each of the rounds.

## Input

The first line of the standard input contains the count of rounds ($0\lt{N}\le{100}$), the count of rewarded competitors ($3\le{K}\le{10}$), the limit of ranking that counts in the total ($2\le{L}\le{N}$), and the count of competitors ($1\le{M}\le{1000}$).
The next $N$ lines each contain the start numbers of competitors ($1\le{S}_{i},j\le{M}$) in decreasing order of their rankings, separated by spaces.

## Output

The first line of the standard output should contain the count of those competitors who ranked less than $K$ in each of the rounds (so they were rewarded points), then the list of numbers of these competitors, in increasing order, separated by spaces.

## Example

**Input**

```
5 5 3 15
1 2 3 4 5
2 4 6 8 3
3 6 9 12 4
5 4 3 2 1
1 4 5 2 3
```

**Output**

```
2 3 4   
```