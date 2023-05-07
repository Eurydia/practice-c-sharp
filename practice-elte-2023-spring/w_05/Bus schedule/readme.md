# Bus schedule

We have bus schedules for routes between Budapest and Mohács, which includes the arrival and departure times at the intermediate stations, as well.
Data is sorted in ascending order of departure times.

Write a program that decides whether there exists a bus that starts its route in Szekszárd.

## Input

The frst line of the standard input contains the count of lines of the bus (1 $\le$ N $\le$ 100).
The next N lines contain the name of a town (without accents), the arrival and departure time, separated by spaces.
Time is given in minutes within the day, so 24*60 is the maximum value – all buses arrive before midnight.
There is “-1” if the arrival is not interpretable, and “9999” if the departure is not interpretable.

## Output

The frst line of the standard output should contain the answer.
It should contain the word “YES”, if there is a bus that starts its route in Szekszárd (arrival time is “-1”), and “NO”, if there is no such bus.
(Try the Hungarian words, “VAN” and “NINCS” if Biro does not seem to give you the points.)

## Example

**Input** 

```
7
Budapest -1 480
Dunaujvaros 549 550
Paks 580 582
Szekszard -1 600
Szekszard 604 605
Mohacs 650 9999
Mohacs 655 9999
```

**Output**

```
YES
```

**Limits**

Time limit: 0.1 second

Memory limit: 32 MB
