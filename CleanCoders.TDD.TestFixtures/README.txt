1) Arrange
2) Act
3) Assert
4) Annihilate


From xUnit Test Patterns (Gerrard Metzeros)

To drive the test into the required state we create a Test Fixture

3 kind of test fixtures:
	1) Transient fresh test fixtures (new clean plate): New fresh copy for every test.
		  Created and destroyed around every test
	2) Persistent fresh test fixtures (wash a plate before): State survives the test 
	3) Persistent shared test fixtures (dirty plate): Allows some state to accumulate from test
	to test.

		// nUnit: Does not create a fresh test instance in between test functions.
		// Persistent test fixtures, need teardown functions
		// E.g. sockets, files, semaphores, DB connections, graphic context, etc.
		// Everything that sits in a static variable, you have to find
		// them and clean them down in tear down methods.

		// jUnit: @BeforeClass, @AfterClass: Executed even before the constructor
		// This is to create shared state for a test suite



		// The fresher the better, use tearDown as few as possible
		// Try to avoid SuiteSetUp and SuiteTearDown