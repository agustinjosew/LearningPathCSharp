
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

 
 
 
