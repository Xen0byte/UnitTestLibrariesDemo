/*
 *  THESE ATTRIBUTES ARE COMMENTED FOR THE PURPOSE OF SHOWCASING THE DEFAULT BEHAVIOUR OF THE LIBRARY
 */

// Parallelisation In NUnit Is Disabled By Default
// Uncomment This Attribute To Enable Parallelisation
// [assembly: Parallelizable(ParallelScope.Fixtures)]

// The Maximum Number Of Logical Processors To Use When Running Tests In Parallel
// If It Is Not Specified, NUnit Uses The Logical Processor Count Or "2", Whichever Is Greater
// A Value Of "0" Represents The Default
// Uncomment This Attribute To Override The Default
// [assembly: LevelOfParallelism(0)]

// Whether To Instantiate A Test Fixture Once For All The Contained Tests Or Every Time For Every Test Case (Potentially, Multiple Times Per Test)
// This Is The Major Difference Between NUnit And xUnit/MSTest, And (Arguably) This Should Be Set To "LifeCycle.InstancePerTestCase"
// Uncomment This Attribute To Enable Per-Test-Case Instantiation
// [assembly: FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
