# Train from Szekesfehervar

We have information about the schedules of N trains from Budapest to Fonyód.
It contains the arrival and departure times of the intermediate stations, as well.

Write a program that gives a train that sets of from Seeesfehervar.

## Input

The frst line of the standard input contains the count of trains (1 $\le$ N $\le$ 100).
The next N lines each contain a station name (without accents), an arrival time and a departure time.
Times are given in minutes within the day, so the maximum is 24*60.
All trains arrive before midnight.
If the arrival time is not interpretable, there is “-1” in the input.
If the departure time is not interpretable, there is “9999” in the input.
Data are in increasing order of time.

## Output

The frst line of the standard output should contain the departure time of the train that sets of from Seeesfehervar.
If there is no such train, you should write -1.
If there is more than one solution, you should write out the one with the smallest index.

## Example

**Input**

```
7
Budapest -1 480
Szekesfehervar 510 515
Siofok 545 550
Szekesfehervar -1 600
Siofok 630 635
Fonyod 635 9999
Fonyod 720 9999
```

**Output**

```
600
```

**Limits**

Time limit: 0.1 second

Memory limit: 32 MB

Evaluation: In 40% of tests, the count of data is  $\le$ 20
