# Mirror phone numbers

Hungarian phone numbers insist of 8 digit together with the district prefix.
The prefix of Budapest is always 1, and it is followed by 7 digits (eg. 11234567), while the prefix of non-Budapest settlements is 2 digits, and is followed by 6 digits (eg. 84123456).
We have N phone numbers, and we would like to know how many of those are mirror
phone number.

A mirror phones number is defned as the following:

- the phone number is the same read from backwards (eg. 11233211 or 84122148)

- in the case of non-Budapest phone numbers the prefix is the same backwards (eg. 66123456), or the part without the prefi is the same backwards (eg. 72123321)


Write a program that writes the mirror phone numbers on the output.

## Input

The frst line of the standard input contains the count of phone numbers (1 $\le$ N $\le$ 10,000).
The next N lines each contain a phone numberx Each phone number consists of 8 digits.

## Output

You should write M phone numbers on the standard output, where M is the count of mirror phone numbers.
Each line of the output should contain one mirror phone number.


## Example
**Input** 

```
8 
11811886
13977931
64719635
88922988
68874786
33842127
37895247
56362263
```

**Output**

```
13977931
88922988
56362263
```

**Limits**

Time limitg 0.1 second

Memory limitg 32 MiB

Evaluationg In 30% of tests, the count of data is N $\le$ 100