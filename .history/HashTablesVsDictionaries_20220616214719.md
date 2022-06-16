<p align= ### Hashtable Vs Dictionary

| Hashtable   | 	Dictionary |
|:------------:|:-------------:|
|A Hashtable is a non-generic collection.| A Dictionary is a generic collection.|
|Hashtable is defined under System.Collections namespace.| 	Dictionary is defined under System.Collections.Generic namespace.|
|In Hashtable, you can store key/value pairs of the same type or of the different type.	| In Dictionary, you can store key/value pairs of same type.|
|Hashtable is thread-safe.| 	It is also thread safe but only for public static members.|
|In Hashtable, there is no need to specify the type of the key and value.|     In Dictionary, you need to specify the type of the key and value.|
|The data retrieval is slower than Dictionary due to boxing/ unboxing.| The data retrieval is faster than Hashtable due to no boxing/ unboxing.|
|In Hashtable, if you try to access a key that doesn’t present in the given Hashtable, then it will give null values.| In Dictionary, if you try to access a key that doesn’t present in the given Dictionary, then it will give error. |
| It doesn’t maintain the order of stored values.| It always maintains the order of stored values.|
