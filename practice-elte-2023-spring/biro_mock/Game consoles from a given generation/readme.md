# Game consoles from a given generation

Game consoles exists since the 1970s, and many companies fght for having a bigger share
on the market of game consoles even today.
Currently, we are in the 8th generation of game consoles.
We made a short note of the game console companies that we think important.

The note contains the name of the companies and the count of consoles released in each generation.
We know that a certain console was released in the 7th generation. 

Write a program that defines which companies could make this console.
How many such companies are there, and which are those companies?

## Input

The standard input consists of 3 parts.

The first line contains the count of companies ($1\le N\le 100$), then the next $N$ lines contain the names of the companies.

The first line of the second part contains the count of notes ($1\le M \le 50$); then come the notes themselves in $M$ lines.

A note consists of $3$ numbers (separated by spaces): 

- the $ID$ of the console company ($1\le ID\le N$) based on the first part of the input, 

- the generation ($1\le G\le 8$), and then 

- the count of consoles ($1\le C\le 100$).

The same company and generation pair is listed only once. 
The third part of the input is just one line: two company indexes ($1\le C1,C2\le N$).

## Output

The first line of the standard output should contain the count and names of those companies who released consoled in the 7th generation.
If there are no consoles from this generation, then write “NONE” 

If this does not seem to work, try the Hungarian word “NINCS”.

## Example

**Input** 

```
5
Nintendo
Sega
Sony
Microsoft
Nvidia
6
1 1 5
1 3 4
2 3 4
4 5 4
1 4 5
4 7 1
1 3
```

**Output**

```
1 Microsoft
```

