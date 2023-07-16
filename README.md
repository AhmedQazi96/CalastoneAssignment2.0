# CalastoneAssignment2.0

-Improved separation of concerns:
Main entry point of the application is now cleaner and focuses on error handling
Application logic is now encapsulated in the TextFilterApp class
Exception handling removed from ReadText method, instead now caught higher up in the call stack for better context, also promotes readability and maintainability

-Reduced lines of code
Removal of unnecessary if blocks
Instead of storing boolean results in a variable (filter logic), they are directly returned to the caller
Instead of a foreach loop, use of LINQ in TextFilterProcessor for conciseness
StringBuilder no longer neccessary in TextFilterProcessor
