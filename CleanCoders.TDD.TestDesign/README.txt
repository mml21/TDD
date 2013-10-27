- Every class (not interfaces) has its own test class file
- Inner classes are special cases, they normally don't have their own test class files.
- The tests test the behaviours of the outer class, the way the behaviour is implemented
doesn't matter.
- Sometimes as part of a refactoring you break an outer class into multiple classes.
- E.g. VideoStore Martin Fowler's example from a previous episode.

 - Test Suites: For instance run only the tests in the package you are currently working.


 - SOLID Tests: Otherwise your tests become fragile.

 SRP: Every test funcion and class should have only one responsability where that responsability
 is the same as the class being tested.

 OCP: We want to be able to change the production code without changing the tests too much.
 Hide internal classes that the class you are testing uses from the tests.
 E.g. Video Store tests Statement class and we know about the Movie class!

 LSP: Governs the way we use polymorphism. The clients of a derived class should be able
 to use the base class without any change.

 ISP: Protects us from too much knowledges. Protects clients from interfaces that have 
 methods that we don't call. Tests are clients as well. 
 You can create interfaces that the tests can use even if no other client uses that interface.
 A test-specific interface in the production code is harmless and helps protects the test
 from too much knowledge.

 DIP: High Level Policy should be independent and low level detail should depend on high level
 policy. Our tests are low level details. Every test is lower level that the code it tests.
 The test code depends on the production code. The production code never depends on the test code.
 It's a one way source code dependency. The direction of runtime dependencies is up to you.
 The inversion of source code dependencies is accomplished through polymorphism.
  


Testing private methods: They are extracted from public methods during refactoring.
The test covers the public function and therefore also those private. 
Write the tests through the public interface. If you need to test a private function you have
to promote it to public or protected.

What test do you write first?:
- You write the test that forces you to write the code that you already know you want to write. 


