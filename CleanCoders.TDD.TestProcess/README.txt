Test techniques
---------------

- Trivial Implementation

- Fake it 'til you make it: Fake the result of the function you are test driving.
E.g. return 0, empty list, etc. 
Goal is incrementalism. Make the first take case pass by faking it, make the next one
pass by faking it less. And incrementally until you are not faking it anymore.
The rationale is taking small steps and building incrementally. Sometimes there is no way
to fake it and we get stuck writing tests, we've to write the whole algorithm.
Solution is to write a simple test, the most degenerate cases first.
Keep your tests simple and small. Tackle the simplest test cases first and then and only then
tackle the complicated test cases.
Test a function from the outside in, simple and perhiperal issues like arguments.

- Staircase step tests (throw away tests): Tests sometimes are like staircase steps, 
they are used to write the next test case in sequence. and then you can delete the previous one.
Feels like a waste of time but it isn't.

- Assert First: Write the test backwards, starting with the Assert first.

- Triangulation: One of the ways we create generalisation. 
Remember: As the tests get more specific, the production code gets more generic.
When you are testing a hierarchy you want to use a test hierarchy.
The way to triangle is to create a new test case.

- One to Many: The best way to deal with an array/list of objects is deal with one object first.
E.g. Stack with capacity for just one element at first. Then create an array with 2 elements.

- Importance of refactoring tests since they are a critical part of a system.

"Write the tests that You'd want to Read" - Nat Pryce and Steve Freeman in GOOS
"Write to an Audience (who want to read tests as a clear specification) - Kent Beck
"Test Behaviour NOT APIs!" - Nat Pryce and Steve Freeman in GOOS
Write tests to test the behaviour of the system you expect, not the API

Ron Jeffries' Rules of Simple Design for code:
 - Pass all tests
 - NO duplication in the code
 - Express the author's ideas
 - Minimize number of classes and methods

Kent Beck says:
  "First make it Work,   (by any means possible)
   Then make it Right,   (refactor it to clean the mess we made before, eliminate duplication, clear internal structure, apply SOLID & design principles & patterns, etc.)
   Then make it Fast and Small." (express our intent very well: fiddle with the name, partition code into nicely expressed ideas, etc.)

Kent Beck:
  "All design principles strive from Elimination of Duplication"

"Never Optimise Blindly" - First make the appropriate measures and optimise what it needs to be.

Test-first means that the tests come first when we write them, refactor and clean them.