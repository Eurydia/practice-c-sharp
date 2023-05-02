# Game consoles from a given generation

We investigated the environment around us, and made notes of food chain pairs (what eats what?). 
There are a maximum of $30$ pairs. 
Plants do not eat animals, animals eat plants or other animals. 
In a pair, the first eats the second, for example “fox partridge” means that “fox eats partridge”, or “snail grass” means “snail eats grass”.

Write a program that lists the names of animals that eat other animals (they might eat plants, too). 

Attention: if something does not eat anything else, it is a plant.

## Input

The first line of the standard input contains the count of food chain pairs ($1\le N\le 30$).

The next $N$ lines contain the food chain pairs: two words separated by a space. 

The frst living being eats the second.
There are no accents in the names of living beings

## Output

The first line of the standard output should contain the count of animals that eat other animals (they might eat plants, as well).
The next lines should each contain the name of an animal that eats another animal.

If there are no such animals, the output should be 0.

## Example

**Input** 

```
7
fox partridge
fox blackbird
partridge earthworm
snail grass
blackbird snail
earthworm leaflitter
blackbird grain
```

**Output**

```
3
fox
partridge
blackbird
```

