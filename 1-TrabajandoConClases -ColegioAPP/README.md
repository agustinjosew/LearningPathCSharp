| Preparing objectives                         |
|---------------------------------------------|
| Declaring variables<br>Working with strings<br>Using mathematical operations<br>Creating classes and properties<br>Using expressions<br>Using static, abstract, and virtual methods<br>Building a user interface<br>Extending classes<br>Working with subclassed objects<br>Using the object-oriented features of C# |


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
---
* Methods or Functions <a href="https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/methods" target="_blank">+info</a>

A method is a code block that contains a series of statements. A program causes the statements to be executed by calling the method and specifying any required method arguments. In C#, every executed instruction is performed in the context of a method.

The Main method is the entry point for every C# application and it's called by the common language runtime (CLR) when the program is started. In an application that uses top-level statements, the Main method is generated by the compiler and contains all top-level statements.

```csharp
//metodos o funciones
public float PromedioDeNotas(float a, float b, float c)
{
    var promedio = (a + b + c) / 3;
    return promedio;
}
```

Overloading means that you have two methods with the same name but with a different method signature and the method signature refers to the return type, the name, and the name and type of the arguments.
```csharp
//metodos o funciones
public float PromedioDeNotas(float a, float b, float c)
{
    var promedio = (a + b + c) / 3;
    return promedio;
}

public int PromedioDeNotas(int a, int b, int c)
{
    var promedio = (a + b + c) / 3;
    return promedio;
}
```
And then we've got two methods in here, they're overloading each other. Overloading is a form of polymorphism which is another one of the cornerstones of object-oriented programming. 

A function bodied expression is just a different way of writing a method, not unlike the one that i wrote  before.  In a function bodied expression instead of doing a code block with a curly brace, we're just going to do a very simple expression. It kind of looks like something that we're seing in JavaScript, which is an arrow function.  Though, to be honest, I probably wouldn't try anything very long with this. It really only supports very simple expressions. This is kind of handy if we just want to expose some very simple logic, like what we have here. If we're doing something really complicated that involves a lot of steps, working with data bases, working with arrays, searching for things I probably wouldn't want to try something like that in a function bodied expression. ***These are really just limited to really simple returns.***

```csharp
//funciones dentro la expresion
public float PromedioDeNotas(float a, float b, float c) => (a + b + c) / 3;
```


---
* Static methods

Static methods are methods that we can call without instantiating the class, expose something that can be used without instantiation. 

---
* Overriding ToString <a href="https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/how-to-override-the-tostring-method" target="_blank">+info</a>

Something we'll often want to do in our class is to override the ToString method. The ToString method is a common method. It's on the base object in everything in C#, and so everything pretty much has a ToString method.

```csharp
//sobre escribiendo ToString
public override string ToString()
{
    var sb = new StringBuilder();
    sb.AppendLine(Nombre);
    sb.AppendLine(Direccion);
    sb.AppendLine(Ciudad);
    sb.Append(", ");
    sb.Append(Provincia);
    sb.Append(" ");
    sb.Append(CodPostal);

    return sb.ToString();
}
```



