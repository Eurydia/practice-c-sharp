# Total dispensed money

The events of a bank branch are controlled by an automatic machine during a whole day (0:0..23:59).
It detects and logs the entries and exits (as customers can only entry with the use of their credit cards) in chronological.
It also logs the transaction type (dipense, deposit) and the amount.
The machine registered N events during the given day.
It logged the time of the event (hour + minute, strictly monotonous), the type of the events (entry, exit, dispense, deposit), and the numeric attributes of the event (card ID number at entry/exit, the amount at dispense/deposit). 
Interpretation of the time of the event: if there was an entry at 12:00, it means that the person was inside at 12:00.

Write a program that gives how much money was dispensed totally.

## Input

The frst line of the standard input contains the count of events (1 $\le$ N $\le$ 100) and a time (1 $\le$ X $\le$ 23).
The next N lines contain the data of events: in the form of 4 integers separated by a space.
The frst number is the hour part of the time of the event (0 $\le$ H $\le$ 23), the second is the minute part of the time (0 $\le$ M $\le$ 59).
The third number is 1, if the event is an entry, -1, if it is an exit, -2 if it is a dispense, and 2 if it is a deposit.
The fourth number is a positive integer (1 $\le$ S $\le$ 10,000,000), either the card ID, or the amount (depending on the previous parameter).

## Output

The frst line of the standard output should contain one number: the total amount of money that was dispensed.

## Example

**Input**

```
7
11 10 1 12345
11 50 -2 10000
12 10 -1 12345
23 10 1 24680
23 11 -2 5000
23 15 1 13579
23 20 1 98765
```
**Output**

```
15000
```
**Limits**

Time limit: 0.1 second

Memory limit: 32 MB
