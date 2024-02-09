# 4500CardGenerator

Page
1
of 9
HW1: The Art Dealer, Part 1 CS 4500, Spring 2024
This specification is many pages long and includes many details. I advise you to read it carefully at least once,
top to bottom, before doing anything else. No, this is not a trick specification where the last line says “you
don’t have to do any of that.” But reading the entire document at least once all the way through will help you
understand things better than reading a bit and then trying to do bits and pieces before reading the rest.
This is your first small group programming project for CS 4500. There will be five such projects. Please look in
the “People” tab on our Canvas website to see who is in your small group. Please email the other people in the
group to introduce yourself. (That is an assignment, not a suggestion.) You will have 3 weeks to complete this
first assignment, since there is a lot to get used to. Subsequent HW assignments will only allow you two and a
half weeks.

Be sure to log each minute you spend on this project. See the syllabus for details.

In this and subsequent documents, when you see “the Boss,” that’s me, your instructor. I also play the role of
the Customer, and when you have questions about these projects, you should ask me either as the Boss or as
the Customer. Our software engineering textbook emphasizes good communication with the customer, so you
should be sure to communicate with me about any questions that need consultation with the customer. Email
me at millerkei@umsl.edu, either to ask the question, or to set up an appointment to talk, or both.
In each of the five projects, you will be assigned a “role.” The roles will be assigned using a letter that is
established in this first project. The groups may change during the semester, but the letter you receive during
the first project will “stick,” no matter what group you are for subsequent projects.
Place the people in your HW1 group in alphabetical order by last name. The first person in that list is assigned
an A; the second person is assigned a B; the third person is C; the fourth person is D; and if there is a fifth
person, that person is E.

As we go through the semester, the roles will rotate among the letters on your team. Thus, you will fill each of
these roles sometime this semester. For HW1, there will be five roles, assigned as follows:

A – Team leader; B – Chief Programmer; C – Team Scribe; D – Lead Designer; and E – Lead Tester.

A: The Team Leader will oversee the project, including scheduling team meetings and organizing reports for
the Boss (Keith). There should be at least one all-hands meeting of the team each week. When the project is
submitted, the Team Leader will submit a report about the time the team (as a whole) has spent on the
project. This report will include a table that includes the names of all the team members (including the Team
Leader) and the total number of minutes each member spent during the HW1 development. The report will
also include a graph with each date during the development on the x axis, and the total number of minutes
spent by the team on that day on the y axis. No date is skipped on the x axis, even if no one on the team
logged any minutes on that day. The Team Leader will base this document on the logs of all the team
members. When the project is submitted, the Team Leader will collect all required documents from the other
team members, combine it with the Team Leader’s report, Zip the files into a single file, and submit that
zipped file, before the deadline, to the Canvas assignment for the project.

B: The Chief Programmer will be primarily responsible for the code written to fulfill the HW1 specification.
However, the Chief Programmer may ask other team members to contribute code to the project, which the
Chief Programmer will integrate into the program. Whoever authors a part of the code should include that
authorship as part of the internal comments of the code. The Programmer will cooperate with the Team
Scribe to make sure that the documentation inside the code is sufficient. The Programmer will cooperate with
the Lead Tester in making sure that the code passes all tests before it is submitted. In addition to any code
written, any files required for running the program must be included in the submission. For HW1, this will
include a .exe file executable in Windows.

C: The Team Scribe will take minutes at any meeting of the entire team (“all hands meetings”). There should
be at least one such meeting each week. Minutes must include the date and how the team met (could be, for
example, in person, via Zoom, or via phone). Minutes must include the names of all team members present.
The minutes should include the time the meeting started, and the time the meeting ended, precise to the
minute. The meeting (and those times) should appear in the logs of all members who attended the meeting.
The minutes should include a list of all topics discussed, and all decisions made. The collected minutes of any
team meetings during the project development should be submitted by the Team Scribe when the HW1
project is submitted. In addition to taking minutes at all hands meetings, the Team Scribe will cooperate with
the Chief Programmer to make sure that documentation in the program is sufficient and accurate. Finally, the
Team Scribe is in charge of a User Manual, which describes the project, and how a user (not a programmer)
can use the software. For HW1, the User Manual will probably be only a few pages. However, as the projects
progress, the User Manual will become more complex. Each version of the User Manual should start with a
title page as described below. The User Manual should include a revision history with a separate version each
time it is submitted. The User Manual should include page numbers, and a table of contents. User Manuals
should include screen shots as well as text, explaining how the program works, and how the user should
interact with the program. The User Manual can be a MS Word document, an Open Office document, a Google
Doc, an Open Office document, or a PowerPoint or Google Slides document. If a Scribe wants to use a format
different from these, the Scribe should contact the Boss for prior approval. The User Manual should be
submitted when the rest of the project is submitted.

D: The Lead Designer will be the primary author of any required Design Documents. However, the entire team
should be involved in deciding about the design, since they will all be affected when the design is followed. For
each project, there will be specific design documents required. The Lead Designer will coordinate with the
Chief Programmer to make sure that the code follows the design. The Lead Designer will coordinate with the
Lead Tester to make sure that the functions described by the designs are adequately tested. For HW1, the
Lead Designer should create a Design Document with a title page as described below. The Design Document
should contain two designs. The first should be a high-level design (not too many details) written in pseudo-
code. If the Lead Designer doesn’t know what pseudo-code is, please see
https://www.code4example.com/pseudocode/pseudocode-examples/. This initial pseudo-code should be at
most a page long. The second design should be a static “calling graph,” which shows the main program and
any subprograms as rectangles connected by arrows. An arrow from A to B means “A calls B.” See
https://en.wikipedia.org/wiki/Call_graph for details. Each subroutine in the program should appear in the
calling graph.

E: The Lead Tester will author a Test Plan for the project. The Test Plan should include tests that exercise the
functions described in any design documents or the specification. Each test in the Test Plan must include any
inputs required to run the test, and the expected outcome. Each test should be executed with the program,
and that event should be documented with the outcome (passed or failed), the date and time it was executed,
and who executed it. If the test fails (the outcome was not what was expected), then what happened instead
must be recorded. The Lead Tester is primarily responsible for running the tests, although other team
members can help. All the tests should be run at least once before the program is submitted, and hopefully
more than once. If a test fails to yield the expected results, that test execution should be recorded, and then
the test should be run again after the program is debugged. That cycle should continue until all the tests pass.
Depending on how many people are in the course, some groups may have only 4 members. If that is the case
in your group, then the D member of the group will take on both the Lead Designer and the Lead Tester roles.
Other team members should help the D member as much as possible as that member is doing two jobs.
Notice that each role includes a deliverable or deliverables that are turned in with the project. (The
deliverables are marked in red with yellow highlights in the descriptions above.) These documents will be
graded separately, and that grade will belong to the person in charge of that document. In addition, the
project as a whole will receive an overall grade, and that grade will belong to everyone on the team.
Just because there is a Chief Programmer, that does NOT mean that the Chief Programmer must be the only
person writing code. In fact, it would probably be a mistake to have only one person writing code. But the
Chief Programmer is the last word on any code written. Likewise, more than one person can write designs,
documentation, tests, and so on. However, there is always just one person who is primarily responsible for a
particular deliverable.

Each deliverable except for the source code should start with a title page that includes the title of the
document, the name of the project, the name of the team, the date of last revision, and a list of team
members. The title page should also indicate who was primarily responsible for that document, including the
name and role of that team member. The title page is required for all deliverables except the source code,
even if the title page is not mentioned in the descriptions above. The second page of each deliverable should
list the dates of revisions. The third page should be a table of contents. Except for source code, documents
should have page numbers, and those page numbers should be used in the table of contents.

HW1 Project Specification

Now that we’ve established the preliminaries, I’ll describe your HW1 assignment.

Your HW1 can be developed using whatever language your team decides upon. However, you must be capable
of delivering a .exe file that is executable on a Windows machine. The executable file will become part of the
Zip file your team submits. The User Manual will describe how the user should install and run the program.
Note that this should be straightforward since the user should download the executable and some other files
and run it in Windows. If you envision a long and complicated installation process to make your project work, I
suggest that you choose a different platform for your project.

Your HW1 project will require external files other than the .exe file. For example, you will be using images of
playing cards. Your User Manual should identify what those images are, and how they should be stored along
with the executable. You should require that a directory with those images, using the names that I have given
them, will be installed in the same directory as the Windows executable. You can name that directory full of
images with any name you’d like (you can use the name I gave the directory: PlayingCards, but you don’t have
to). Again, this should all be clear in your User Manual.

Here is a link to a Google Docs directory with the card images:
https://drive.google.com/drive/folders/1wEEnA8gwEFQumjGWIsWopqyS2XCuwl8i?usp=drive_link. Note that
the file names use 2, 3, ..., 10 for the number cards, and 11, 12, 13, and 14 for the jack, queen, king, and ace
respectively.

This is a poker deck with 52 cards plus two jokers. The images are public domain. There is a file in the directory
with a link to the source of the images. They are .png images. You must use these card images in HW1, not
some set of card images that you prefer. If there is a different collection of card images that you prefer, you
may introduce them in subsequent CS 4500 projects, but only with the approval of the Boss (Keith).
You should assume that your program is being run by an interactive user at the keyboard. You should begin
the program with a printed announcement of the program’s purpose (one screen’s worth or less).
The interactive user should then be prompted to initiate the next step in the execution, either by entering
something on the keyboard or by pushing a button displayed on the screen (using a mouse click). When the
program executes, four cards should appear on the screen. They should be a reasonable size for reading by
the user. These four cards should be chosen randomly from the pack of 52 cards. (For HW1, the jokers should
not be used.) The four cards should be selected randomly from the deck without replacement. (That means
you should never see the same card twice in a single collection of four cards.) However, after those four cards
are shown, those cards are replaced in the deck, so the next time you see four cards, you might see a card that
you have seen previously.

Pseudo-random numbers will be used in CS 4500. Many programming languages have built in functionality for
getting random numbers generated. If you are unfamiliar with random numbers in programming, or you want
direct control of your random numbers in your programs, check out this Wikipedia page:
https://en.wikipedia.org/wiki/Lehmer_random_number_generator.
Once the first four randomly selected cards are displayed on the screen, the user should be given a choice:
either get another 4 cards “dealt,” or quit the program. If the user quits, display a pleasant goodbye message,
pause a few seconds, and then stop the program.

The user doesn’t have to see the following, but your program must do it: whenever four cards are dealt, your
program must record those four cards. When the user chooses to deal out four cards multiple times, you will
have multiple collections of these cards. Either during the execution of the program, or when it finishes, your
program should open an external file, output the date that the program is running, save a record of all the
cards that were dealt, and close the file before ending the progam. The next time the program runs, it should
reopen that same file, and append new information to the end of that file, and repeat the process of saving
data in that file.

In the next section, I’ll be describing the contents of that file using an EBNF grammar. (EBNF stands for
“Extended Backus–Naur Form.”) If you are unfamiliar with EBNF grammars, please see
https://en.wikipedia.org/wiki/Extended_Backus%E2%80%93Naur_form.
This external file that keeps track of the cards dealt by the program should be a text file, with the name
“CardsDealt.txt.” Your User Manual must inform us about that file and its name. That file should have the
structure shown by this EBNF grammar. Note that the semi-colons, quote marks, brackets, and equal signs are
all part of the grammar, and are NOT to appear in your file. Also, anything in pointy brackets is a non-terminal,
used in the grammar, not in your file. After you read through the grammar, check the example file contents
that follows; that should clarify what’s going on here. The notation {X} means that X can repeat 0 or more
times; (X}+ means X can repeat 0 or more times.
<file> = {<session>};
<session> = <date> {<four_cards>}+;
<date> = <month> <slash> <day> <slash> <year> <ENTER>;
<month> = "01" | "02" | "03" | "04" | "05" | "06" | "07" | "08" | "09" | "10" | ”11” | “12”;
<slash> = “/”;
<day> = "01" | "02" | "03" | "04" | "05" | "06" | "07" | "08" | "09" | "10" | "11" | "12" | "13" | "14" | "15" |
"16" | "17" | "18" | "19" | "20" | ”21” | “22” | "23" | "24" | "25" | "26" | "27" | "28" | "29" | "30" | "31" ;
<year> = “2024” | “2025” | “2026”;
<four_cards> = <card> <comma> <card> <comma> <card> <comma> <card> <ENTER>;
<comma> = “,”;
<card> = <rank> <suit>;
<rank> = “A” | “K” | “Q” | “J” | "2" | "3" | "4" | "5" | "6" | "7" | "8" | "9" | "10" ;
<suit> = “S” | “H” | “D” | “C” ;
<ENTER> = “\r\n”;
The last rule may be a bit misleading. The idea is that the <ENTER> symbol stands for the “carriage return –
linefeed” ASCI symbols that Windows text files use to indicate the end of a line of text. As long as your
program writes the correct number of lines of text, you are conforming to that part of the grammar.
This simple grammar doesn’t enforce all the proper semantics that you should enforce. For example, you
could make a bogus date like February 31 while still following this grammar. Don’t do that, please. Likewise, I
only list three possible years, and you shouldn’t write your program in such a way that later years are made
illegal. I hope you get the idea.
The grammar does express that the file can be empty. If not empty, it should include one or more sessions, in
which a session starts with a line that gives the date when the session occurred, followed by all the cards dealt
in that session, four cards to a line, separated by commas. Each session includes at least one set of four cards,
and may include many more. Session dates are in the form MM/DD/YYYY. Here is an example of the text in a
non-empty file that records two sessions. Note that the older session recorded is first in the file, and the
newer session is at the end of the file. There can be multiple sessions on the same day. Note also that blanks
are not allowed by this grammar, and blanks should not be in the textfile that you produce. This text file
example records two short sessions:
01/10/2024
AS,10H,2D,4C
JH,7H,9C,QD
3S,3D,4H,AH
01/12/2024
8C,5H,KC,4S
5H,KD,9C,JH
The text file with data about the sessions belongs in the same directory where your executable and your folder
full of card images reside.
When writing code to fulfill this specification, here are some specification of code documentation.
Understand, please, that these are not suggestions; they are requirements.
No matter what programming language you eventually use, start the source code for your program with an
extensive opening comment. The first line of that opening comment must describe which programming
language you are using. You should also mention what development system (or IDE) you used.
The User Manual and the opening comment in your code must include a section that describes how to
compile, build, and execute your program. These instructions must be sufficiently detailed and clear so that
your instructor and the course grader will be able to compile, build, and execute your program. If your
instructions can’t be followed, or don’t work, then your grade will suffer, and the grading of your project will
be delayed.
The rest of the opening comment must include the names of all the team members working on the project,
the date, the name of our class, an explanation of what the program is designed to do, a description of the
central data structure or structures in your program, and an explanation of any external files used.
Every subprogram in your code (function, procedure, or the like) should include a short opening comment.
That comment should include what the subprogram accomplishes, any global variables it uses, and what, if
anything, it returns to the caller.
If you use any outside resources to develop your program, for example looking up programming language
details on the Web, then your opening comment should explicitly list those sources, and give at least a little
information about what you found at each resource. If you don’t use ANY outside resources during
development (and that would greatly surprise me), then indicate that no outside resources were used.
Remember, even looking up a syntax detail, or checking out a debug problem in StackOverflow, are examples
of using an outside resource. There is absolutely nothing wrong with doing that, but you must document it.
Give credit where credit is due. Also, if you adapt or adopt a function or code segment from the Web or
perhaps from a previous program you wrote, document it twice: once in your opening comment, and again in
an internal comment wherever the borrowed code appears in your program.
I hope you are getting the impression that documentation is a central concern when developing high quality
software. I am convinced that the best software engineering professionals document their work in
excruciating detail. That’s exactly what I want you to do for any assignments in CS 4500.
In addition to the extensive opening comment, internal comments should explain important data structures
where they are declared and/or used, delineate large sections of code (“paragraphing comments”), and clarify
anything clever or hard to understand in your code. We grade documentation critically, so I recommend that
you spend some time on your opening and internal comments. Both the Chief Programmer and the Team
Scribe should make sure there are sufficient comments in any code handed in.
We will test your program by recompiling it, by running it with different inputs and by examining what your
program does. For HW1, the “inputs” are pretty straightforward: run the program, say “go,” and then say
“keep going” 0 or more times, and then indicate “stop.” We will do that more than once with different
numbers of “keep going.” We will assess what you put on the screen, and what you put in the output file. We
will also make a judgement about how your documents and your program fit together, and the quality of the
entire project, including all documents.
Peer Evaluations
After the project has been submitted, each member of your team will send me a confidential assessment of
the other team members’ contributions to the project. These are peer evaluations. A team member does not
assess him or herself. The assessments are straightforward. Each team member will submit, via Canvas, a list
of the names of the other team members, giving each member a rank of either 1, 2, or -1.
 1 will indicate that the team member made a good faith effort to contribute to the project. We expect
that most of the time, most team members will get a 1 from the rest of the team.
 2 will indicate that, in your opinion, this particular team member made an extraordinary effort to
contribute to the project. You can only award one 2 in each of your peer assessments, and you are not
required to award any 2 ranking.
 -1 will indicate that, in your opinion, a team member did NOT make a good faith contribution to the
group project.
I hope that there will be very few -1 rankings. If someone receives multiple -1 rankings, there will probably be
changes made in the small group development teams, which will cause some confusion. I’d rather not do that,
but low ratings may necessitate some such changes.
If you or your team have questions about the HW1 project, or about anything else in CS 4500, please email me
at millerkei@umsl.edu. Don’t be shy... I get paid for this.
Take care, and best of luck on HW1.
Keith
PS. The following pages are a grading rubric for HW1. This tells you what’s important to me, and helps you
understand how we will grade your HW1 project. As you will see, the individual tasks for each role will be
graded, and then the project as a whole will be graded. DON’T TURN IN YOUR DELIVERABLE BEFORE YOU’VE
READ THE RUBRIC!
HW1 Rubric
Team Leader Report: 50 points total
1. Is there a title page, and does it follow the specification? Are there page numbers? [10]
2. Is there a revision history and a table of contents? [10]
3. Is there a table that lists each team member (including the Team Leader) and their total minutes? [10]
4. Is there a graph that shows the total team minutes for each day of development? [10]
5. Is the report free of spelling and grammatical errors? [10]
Code from the Chief Programmer: 50 points total
1. Did the first line of the opening comment tell which programming language was to be used? [5]
2. Does the opening comment identify all the programmers, the date, and the class, an explanation of
what the program does, a description of the central data structure(s), any external files used, and any
external sources used in preparing the program? [5]
3. Does the code include instructions that are sufficient to compile, build, and execute the code?
4. Do the instructions result in a functioning Windows executable? [5]
5. Does the code include appropriate internal comments ? [5]
6. When the program begins, does it print to the screen an explanation that is no more than 1 screen, and
tells concisely what the program does? [5]
7. When the interactive user somehow indicates “go,” does the program display four different cards,
seemingly randomly selected? [5]
8. If the interactive user somehow indicates “go again,” does the program do that? If the interactive user
somehow indicates “stop,” does the program do that? NOTE: the team can decide how to describe
these choices to the user, and how the user indicates his/her choice. [5]
9. After the program halts, is there a file that records the date and what cards were dealt? Is that file in
the required format? For example, there should be no blanks in the file. [5]
10. If the program is run multiple times, is the file that records the data in the proper order, and in the
proper format? [5]
Minutes and the User Manual from the Team Scribe: 50 points total
1. Is there a title page, and does it follow the specification? Are there page numbers? [5]
2. Is there a revision history and a table of contents? [5]
3. Do the minutes record each weekly meeting, including all the information required in the
specification? [5]
4. Do the logs of the team members include the meetings as recorded by the Team Scribe?
5. Is the User Manual in one of the required formats? [5]
6. Does the User Manual include a title page with the required information? [5]
7. Does the User Manual have page numbers and a Table of Contents? [5]
8. Does the User Manual include screen shots and good explanations? [5]
9. Does the User Manual include directions sufficient to install the project correctly? [5]
10. Does the User Manual use color to good advantage? [5]
Two Designs from the Lead Designer: 50 points total
1. Is there a title page, and does it follow the specification? Are there page numbers? [10]
2. Is there a revision history and a table of contents? [10]
3. Is the first design pseudo-code? Is the code at a high level (less than a page long)? [10]
4. Is the second design a call graph? Are the symbols consistent and machine (not hand) drawn? [10]
5. Are the designs consistent with the code? [10]
The Test Plan from the Lead Tester: 50 points total
1. Is there a title page, and does it follow the specification? Are there page numbers? [10]
2. Is there a revision history and a table of contents? [10]
3. Does each test include inputs (or actions) and the expected behavior? [10]
4. Have all the tests been executed at least once? Is each execution dated and attributed to a team
member? [10]
5. Will the specified tests exercise each subroutine at least once? [10]
Questions for the Project as a Whole: 100 points total
1. Was the project handed in on time? [10]
2. Were all the documents delivered in a single zipped file? Did it unzip without problems? [10]
3. Do the deliverables from this team fit together? Do the pieces agree on the details? [10]
4. Is the format of the deliverables consistent across the different documents? Is it coherent? [10]
5. Did the designs, tests, and code produce the correct behaviors? [20]
6. Is the user interface pleasing to look at, well organized, and is it polite to the interactive user? [10]
7. Does this software, including all deliverables, give the impression of competent professionalism? [20]
8. Is there something stylish, clever, or interesting that surprised me in a good way? [10]
