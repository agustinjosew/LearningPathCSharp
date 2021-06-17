
# Why?

 I am preparing for an interview on c # and these are the topics that I am going to consider :grin: :school_satchel::

 ## <u>Class:</u>
 * Properties with backing fields
 <a href="https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/properties#properties-with-backing-fields" target="_blank">+info</a>
 
 The **get** accessor returns the value of the private field, and the **set** accessor may perform some data validation before assigning a value to the private field. Both accessors may also perform some conversion or computation on the data before it is **stored** or **returned**.
 
 The interesting thing behind all the encapsulation is that we can put logic to verify that certain parameters are fulfilled, not put things that are invalid after being executed:
 ```csharp
string _twitterLink;
string Twitterlink
{
    // usuario @
    // manipular backing var
    get { return _twitterLink; }
    set
    {
        if (value.StartsWith("@"))
        {
            _twitterLink = value;
        }

        else
        {
            throw new Exception("El usuario debe contener @.");
        }
    }

}
```

---
* Access Modifiers <a href="https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers" target="_blank">+info</a>

The accessibility level controls whether they can be used from other code in your assembly or other assemblies.

<a href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/public" target="_blank">public</a>: The type or member can be accessed by any other code in the same assembly or another assembly that references it.

<a href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/private" target="_blank">private</a>: The type or member can be accessed only by code in the same class or struct.

<a href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/protected" target="_blank">protected</a>: The type or member can be accessed only by code in the same class, or in a class that is derived from that class.

<a href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/internal" target="_blank">internal</a>: The type or member can be accessed by any code in the same assembly, but not from another assembly.

<a href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/protected-internal" target="_blank">protected internal</a>: The type or member can be accessed by any code in the assembly in which it's declared, or from within a derived class in another assembly.

<a href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/private-protected" target="_blank">private protected</a>: The type or member can be accessed only within its declaring assembly, by code in the same class or in a type that is derived from that class.

 ---
 * Constructors <a href="https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/constructors" target="_blank">+info</a>
 
 A constructor is a method whose name is the same as the name of its type. Its method signature includes only the method name and its parameter list; it does not include a return type.
 
```csharp
//generate the constructor directly from the name of the class using the command
ctor + tab 
```
As a result we get a empty constructor with no arguments:
```csharp
public Colegio()
        {

        }
```
The point of using constructors is handle initialization , i have a set of properties but I haven't set any of them to a initial value yet...

```csharp
public string Nombre          { get; set; }
public string Direccion       { get; set; }
public string Ciudad          { get; set; }
public string Provincia       { get; set; }
public string CodPostal       { get; set; }
public string NumeroTelefono  { get; set; }
```
So...
```csharp
public Colegio()
{
    Nombre         = "Escuela NoName";
    NumeroTelefono = "000-000-000000";

}

//tambien puedo hacerlo mediante instancia
public Colegio(string NombreDelColegio, string ColegioNumeroTelefono)
{
    Nombre         = NombreDelColegio;
    NumeroTelefono = ColegioNumeroTelefono;
}
```





