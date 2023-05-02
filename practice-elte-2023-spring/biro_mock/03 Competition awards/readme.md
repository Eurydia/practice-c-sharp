
# Competition awards

At a competition, all participants get 1st place if they reach $90$% of the total points; 2nd place if they reach $80$% of the total points (but less than $90$%); and 3rd place if they reach $70$% of the total points (but less than $80$%). 
The results of the participants are listed in alphabetical order.

Write a program that creates the lists of awarded participants (grouped by category), and not awarded participants.

## Input

The first line of the standard input contains the count of participants ($1\le{N}\le{100}$) and the total points ($1\le{P}\le{100}$). 

The next $N$ lines each contain a name and the achieved points ($1\le{P}_{i}\le{100}$) which are separated by a semicolon.

## Output

Each line of the standard output should contain the count of participants of the given award, and the participants who were awarded.
The items should be separated by a semicolon.

The first item in each line should be the count.
The order of lines: I, II, III, not awarded

## Example

**Input**

```
6 100
Angyal Pofa;90
Bozontos Beata;73
Cukor Falat;85
Dohongo Diana;78
Eros Pista;83
Fickos Ferenc;64
```

**Output**

```
1;Angyal Pofa
2;Cukor Falat;Eros Pista
2;Bozontos Beata;Dohongo Diana
1;Fickos Fere
```