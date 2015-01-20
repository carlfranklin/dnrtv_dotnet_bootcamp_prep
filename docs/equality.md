#Rules For Equality Checking .Net

1. Is it a class (reference type)
  * Does the type implement IEquatable<T> - use it
  * Does the type override Equals - use it 
  * Are the pointers the same 

2. Is it a struct (value type)
  * Does the type override Equals - use it 
  * Reflective field by field equality check

