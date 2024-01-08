/*
 *  THESE ATTRIBUTES ARE COMMENTED FOR THE PURPOSE OF SHOWCASING THE DEFAULT BEHAVIOUR OF THE LIBRARY
 */

// Parallelisation In xUnit Is Disabled By Default
// Uncomment This Attribute To Enable Parallelisation
// [assembly: CollectionBehavior(DisableTestParallelization = false)]

// The Scope Of Parallelisation
// Uncomment This Attribute To Override The Default, Which Is "CollectionBehavior.CollectionPerClass"
// [assembly: CollectionBehavior(CollectionBehavior.CollectionPerClass)]

// The Maximum Number Of Threads To Use When Running Tests In Parallel
// The Default (Represented By "MaxParallelThreads = 0") Is The Number Of Virtual CPUs In The PC
// Uncomment This Attribute To Override The Default
// [assembly: CollectionBehavior(MaxParallelThreads = 0)]

// To Be Used Together, The Attributes Above Need To Be Combined
// [assembly: CollectionBehavior(CollectionBehavior.CollectionPerClass, DisableTestParallelization = false, MaxParallelThreads = 0)]
