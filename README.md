# Caml Query Api
The focus with this API is not leak memory with string concat portions and generates with performance and givest simplest way to CAML Query String result only through an instance of a POCO (Plain Old CLR Object) class using native .NET [System.Xml.Serialization](https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization) namespace; this Api strictly follows the [Query Schema of CAML documented at Microsoft docs](https://docs.microsoft.com/en-us/sharepoint/dev/schema/query-schema).

To test and preview Caml Query Strings generation results by this Api, not needed download SharePoint Client Components SDK and the developer may reference this as a Assembly in your Visual Studio C# SharePoint projects like Farm Solution or SharePoint Add-ins Provider-Hosted.

But remeber: if you're work with Farm Solution on different SharePoint versions, switch/change .Net Framework version and using x64 build.


#### Follow the simple codes examples bellow to test and validate:

```cs
//This object means an record selection on
//SharePoint List by List Column Name and Value,
//with Farm Solution integration (SSOM)...
Query camlQueryObjSSOM = new Query()
{
    Where = new Where()
    {
        Eq = new Eq()
        {
            FieldRef = new FieldRef()
            {
                Name = "ColumnName"
            },
            Value = new Value()
            {
                Type = ValueType.Text,
                TextValue = "Column Text Value"
            }
        }
    }
};

//and catch the string result
string camlQueryStrSSOM = camlQueryObjSSOM.ToString();
```
```xml
<!--The result of camlQueryStrSSOM variable follow bellow.
Pear attention on XML result, the 'Query' node is removed by API.-->
<Where>
  <Eq>
    <FieldRef Name="ColumnName" Ascending="false" Explicit="false" LookupId="false" TextOnly="false" />
    <Value Type="Text" IncludeTimeValue="false">Column Text Value</Value>
  </Eq>
</Where>
```
```cs
//Use on Microsoft SharePoint Server Object Model (by 'Microsoft.SharePoint' directive):
SPQuery spQuery = new SPQuery()
{
   Query = camlQueryStrSSOM
};
```
```cs
//But at CSOM, the developer need to instantiate the View Object, like this:
View camlQueryObjCSOM = new View()
{
  Query = new Query()
  {
    Where = new Where()
    {
      Eq = new Eq()
      {
        FieldRef = new FieldRef()
        {
        	Name = "ColumnName"
        },
        Value = new Value()
        {
        	Type = ValueType.Text,
        	TextValue = "Column Text Value"
        }
      }
    }
  }
};

//Catch the string result...
string camlQueryStrCSOM = camlQueryObjCSOM.ToString();
```
```xml
<!--The result of camlQueryStrCSOM variable is:-->
<View>
  <Query>
    <Where>
      <Eq>
        <FieldRef Name="ColumnName" Ascending="false" Explicit="false" LookupId="false" TextOnly="false" />
        <Value Type="Text" IncludeTimeValue="false">Column Text Value</Value>
      </Eq>
    </Where>
  </Query>
</View>
```
```cs
//... and use on Microsoft SharePoint Client Object Model (by 'Microsoft.SharePoint.Client' directive):
CamlQuery spQuery = new CamlQuery()
{
   ViewXml = camlQueryStrCSOM
};
```



#### At these codes bellow, we have example of Comparison Operators:

```cs
Query comparisonOp = new Query()
{
    Where = new Where()
    {
        IsNull = new IsNull()
        {
            FieldRef = new FieldRef()
            {
                Name = "ComlumnName"
            }
        }
    }
};

Query comparisonOp = new Query()
{
    Where = new Where()
    {
        IsNotNull = new IsNotNull()
        {
            FieldRef = new FieldRef()
            {
                Name = "ComlumnName"
            }
        }
    }
};
```



#### Now, this more complex code will query a Calendar List, with Equality and Logical Operators (at this case, follow the CAML Query specifications about use until twice Equality Operators inner Logical Operators):

```cs
using SPUtility = Microsoft.SharePoint.Utilities.SPUtility;

int currentYear = DateTime.Now.Year;

DateTime startDateFxDT = new DateTime(currentYear, 1, 1),
         endDatFxDT = new DateTime(currentYear, 12, 31);

string startDateFx = SPUtility.CreateISO8601DateTimeFromSystemDateTime(startDateFxDT),
         endDateFx = SPUtility.CreateISO8601DateTimeFromSystemDateTime(endDatFxDT);

Query query = new Query()
{
    Where = new Where()
    {
        And = new And[1]
    }
};

query.Where.And[0] = new And()
{
    Geq = new Geq[1],
    Leq = new Leq[1]
};

query.Where.And[0].Geq[0] = new Geq()
{
    FieldRef = new FieldRef()
    {
        Name = "EventDate"
    },
    Value = new Value()
    {
        IncludeTimeValue = false,
        Type = CamlQueryApi.ValueType.DateTime,
        TextValue = startDateFx
    }
};

query.Where.And[0].Leq[0] = new Leq()
{
    FieldRef = new FieldRef()
    {
        Name = "EventDate"
    },
    Value = new Value()
    {
        IncludeTimeValue = false,
        Type = CamlQueryApi.ValueType.DateTime,
        TextValue = endDateFx
    }
}
```



#### Using OrderBy statement:

```cs
Query result = new Query
{
    Where = new Where()
    {
        IsNull = new IsNull()
        {
            FieldRef = new FieldRef()
            {
                Name = "ColumnName"
            }
        }
    },
    OrderBy = new OrderBy()
    {
        FieldRef = new FieldRef[1]
    }
};
result.OrderBy.FieldRef[0] = new FieldRef()
{
    Name = "AnotherColumnName",
    Ascending = true
};
```
----------------------
## License

[View MIT license](https://github.com/antonio-leonardo/CamlQueryApi/blob/master/LICENSE)
