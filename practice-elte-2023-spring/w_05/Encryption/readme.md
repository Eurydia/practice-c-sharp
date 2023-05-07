# Encryption

We use the following table to encrypt a text (the character in row c and column i is a space).

| - | a | b | c | d | e | f | g | h | i |
| - | - | - | - | - | - | - | - | - | - |
| a | i | o | q | h | b | f | y | l | w |
| b | n | r | a | g | s | k | t | e | z |
| c | d | u | p | x | c | j | v | m | " " (space) |


The method of encryption: we fnd each character inside the table, and then substitute them with the letter combination of the row and column heads.
We only use letters of the English alphabet.

Write a program that asks for a word as input, and then encrypts that word.

## Input

The frst line of the standard input contains a word.
It consists of letters of the English alphabet.

## Output

The frst line of the standard output should contain the encrypted word.

## Example

**Input**

```
balaton
```

**Output**

```
aebcahbcbgabba
```

**Limits**

Time limit: 0.1 second

Memory limit: 32 MB
