# _Word Counter_

#### _A Word Counter Program, 02/15/19_

#### By _**Kenny Halim**_

## Description

_Epicodus Week 6 & 7 Individual Project_

_A program that counts how many times a word occurs in a sentence. The Program will also only allows the user to input alphabets, numbers and spaces (No punctuation is allowed)._

|| Behavior  | Input  | Output  |
|---|---|---|---|
|1.| User input English alphabetical word and sentence  | I eat cockcroach, eat   | 1 |
|2.| User input non-alphabetical word and alphabetical sentence  | Epicodus is great!, $!$   | Not Valid   |
|3.| User input sentence and a word not in the sentence  | Epicodus is great!, crazy   | 0  |
|4.| User input a sentence and word doesn't full match one of the words in the sentence | I had a great team week, tea | 0 |
|5.| User input non-alphabetical sentence and valid word | Epicodus is great!, great | 0 |
|6.| User input blank sentence, blank word, or both fields blank | | 0 |


## Setup/Installation Requirements

Requirements Software

Download .NET Core 1.1.4 SDK and .NET Core Runtime 1.1.2 and install them.
Download Mono and install it.

1.)Clone this repository: $ git clone https://github.com/kennyhalim/WordCounter.Solution
2.)Change into the work directory:: $ cd WordCounter.Solution
3.)To edit the project, open the project in your preferred text editor.

To run the tests, use these commands: $ cd WordCounter.Tests $ dotnet test

To run the program on chrome, use these commands: $ cd WordCounter $ dotnet build $ dotnet run


## Technologies Used

_Atom, C#, .NET_

### License

*MIT License*

Copyright (c) 2019 **_Kenny Halim_**
