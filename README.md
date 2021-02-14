# **C# ValueTuple vs Entity Class**
## c# comparing speed between ValueTuple vs Entity class

*The reason for performing this test is to compare the speed between an Entity class object and a ValueTuple.
Following are the observations.*

* The Entity class objects is reference type hence it is stored in Heap and the ValueTuple is a struct so a value type hence stored in stack frame.
* In my tests using this code, The ValueTuple seems to be **8-9 times faster than Entity Class objects**.
* Also ValueTuple also allows us to name the fields which the Tuple type didn't allow.
