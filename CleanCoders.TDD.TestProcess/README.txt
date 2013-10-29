Test techniques
-----------------


- Fake it Until you make it: Fake the result of the function you are test driving.
E.g. return 0, empty list, etc. 
Goal is incrementalism. Make the first take case pass by faking it, make the next one
pass by faking it less. And incrementally until you are not faking it anymore.
The rationale is taking small steps and building incrementally. Sometimes there is no way
to fake it and we get stuck writing tests, we've to write the whole algorithm.
Solution is to write a simple test, the most degenerate cases first.
Keep your tests simple and small. Tackle the simplest test cases first and then and only then
tackle the complicated test cases.
Test a function from the outside in, simple and perhiperal issues like arguments.

- 

