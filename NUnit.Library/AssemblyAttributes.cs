/*
 *  THESE ATTRIBUTES ARE COMMENTED FOR THE PURPOSE OF SHOWCASING THE DEFAULT BEHAVIOUR OF THE LIBRARY
 */

// Parallelisation In NUnit Is Disabled By Default
// Uncomment This Attribute To Enable Parallelisation
// [assembly: Parallelizable(ParallelScope.Fixtures)]

// This Attribute Is Optional; If It Is Not Specified, NUnit Uses The Processor Count Or 2, Whichever Is Greater
// For Example, On A Four Processor Machine, The Default Value Is 4
// Uncomment This Attribute To Serialise Test Execution, But Keep The Execution Scope Defined By The "Parallelizable" Attribute
// [assembly: LevelOfParallelism(1)]

// Whether To Instantiate A Test Fixture Once For All The Contained Tests Or Every Time For Every Test Case (Potentially, Multiple Times Per Test)
// This Is The Major Difference Between NUnit And xUnit/MSTest, And (Arguably) This Should Be Set To "LifeCycle.InstancePerTestCase"
// Uncomment This Attribute To Enable Per-Test-Case Instantiation
// [assembly: FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
