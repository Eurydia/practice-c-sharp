# Special days

We have a list of special days (birthday, name day, holidays etc.) of our friends (they have unique names).

Write a program that solves the following subtasks:

- a) Count and list all the special days (dates) that belong to a given person.
- b) Count and list all of our friends (each person should appear in the list only once).
- c) Create a summary about all the special days of each month.
- d) In which month are there the most special days, and how many special days are there in that
month?

## Input

The first line of the standard input contains the name you should use for task a). 

The second line contains the number of special days ($1\le{N}\le{50}$). 

Then comes the description in the next $2*N$ lines, in ascending order of the dates. 

We have the following information about a special day: the friend’s name who celebrates that day (1st line, it is not empty, but can consist of more than one word) and the date of the day given by the number of the month ($1\le{month}\le{12}$) and the number of the day ($1\le{day}\le{31}$).


## Output

The first line of the standard output should contain the solution to task a).
It should start with the number of special days, then comes the list of dates (month and day) in ascending order, separated by spaces.

The second line should contain the solution to task b). It should also start with the number of friends, then comes the list of names that should be in the order of appearance in the input. 
Separate the names from each other with a comma.

The third line should contain the solution to task c), i.e. $12$ numbers that are the count of special days in each month, separated by spaces.

The fourth line should contain the solution to task d), i.e. the month and the count of special days.
If there is more than one solution, give the month that comes first in the year.