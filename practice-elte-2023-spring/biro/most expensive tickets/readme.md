
# More expensive tickets

A travel agency stores how much the plane tickets to cities being different distances away cost.

Write a program that lists the cities to which the price per kilometer is greater than HUF $100$.

## Input

The first line of the standard input contains the count of cities ($0 \ge N \ge 100$).
The next $N$ lines contain the distance of a city ($1 \ge D \ge 20,000$) and the price of the plane ticket ($1\ge P\ge 2,000,000$) each.

## Output

The first line of the standard output should contain the count of cities, then the index of cities to which the price per kilometer is greater than HUF $100$. 
The numbers should be in increasing order, each separated by a space.

## Example

**Input**

```
6 
50 30000
1900 200000
2000 150000
900 38000
600 150000
2100 30000
```

**Output**

```
3 1 2 5
```

**Limits**

Time limit: 0.1 second

Memory limit: 32 MB

Evaluation: In 40% of tests, the count of data is ≤20
