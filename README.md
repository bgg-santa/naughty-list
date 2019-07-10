# Naughty List

## Principle
To make the naughty list very fast to check (I know you have billions of people to check in a matter of nanoseconds), I've implemented this small tool using a very simple [Bloom filter]([https://en.wikipedia.org/wiki/Bloom_filter](https://en.wikipedia.org/wiki/Bloom_filter)).

But as this list is very sensitive, I've decided to make it a little bit enciphered. For this purpose, the entire hash list has been extracted has a base64 string and compressed using [run-length encoding]([https://en.wikipedia.org/wiki/Run-length_encoding](https://en.wikipedia.org/wiki/Run-length_encoding)).

You should always keep the list safe!

## Usage
```
$ naughtyChecker.exe
Secret list: 
<enter the secret list>
Child name (or enter to quit): 
Alexandr
Alexandr is definitely nice! :D
Child name (or enter to quit): 
Simon
Simon is definitely nice! :D
Child name (or enter to quit): 
Belzamin
Belzamin is probably naughty >:o
Child name (or enter to quit): 
Mysterios
Mysterios is probably naughty >:o
Child name (or enter to quit): 
Runyon Zay
Runyon Zay is probably naughty >:o
Child name (or enter to quit): 
Emilijus
Emilijus is definitely nice! :D
Child name (or enter to quit): 
Eglé
Eglé is definitely nice! :D
Child name (or enter to quit): 
```
