/// <summary>
/// 
/// Composite pattern is used to separate an abstraction from its implementation so that both can be modified independently.
/// Composite pattern is used when we need to treat a group of objects and a single object in the same way.Composite pattern composes objects in term of a tree structure to represent part as well as whole hierarchies.
/// This pattern creates a class contains group of its own objects.This class provides ways to modify its group of same objects.
/// 
/// 1. Component - This is an abstract class containing members that will be implemented by all object in the hierarchy.It acts as the base class for all the objects within the hierarchy
/// 2. Composite - This is a class which includes Add, Remove, Find and Get methods to do operations on child components.
/// 3. Leaf - This is a class which is used to define leaf components within the tree structure means these cannot have children.
/// 
/// When to use it?
/// Hierarchical representations of objects are required.
/// A single object and a group of objects should be treated in the same way.
/// The Composite pattern is used when data is organized in a tree structure (for example directories in a computer).
/// 
/// </summary>
