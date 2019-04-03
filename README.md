# CamlQueryApi
This API generates a performable CAML Query String result through an instance of a POCO (Plain Old C# Object) class using native .NET [System.Xml.Serialization](https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization) namespace; this Api strictly follows the [Query Schema of CAML documented at Microsoft docs](https://docs.microsoft.com/en-us/sharepoint/dev/schema/query-schema).

To test and preview Caml Query Strings generation results by this Api, not needed download SharePoint Client Components SQK and the developer may reference this as a Assembly in your Visual Studio C# SharePoint projects like Farm Solution or SharePoint Add-ins Provider-Hosted.

But remeber: if you're work with Farm Solution on different SharePoint versions, switch/change .Net Framework version and using x64 build.

Follow the codes examples bellow to test and validate:

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

//... and catch the string result
string camlQueryStrSSOM = camlQueryObjSSOM.ToString();

//Use on Microsoft SharePoint Server Object Model (by 'Microsoft.SharePoint' directive):
SPQuery spQuery = new SPQuery()
{
   Query = camlQueryStrSSOM
};

//****//

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

//... and use on Microsoft SharePoint Client Object Model (by 'Microsoft.SharePoint.Client' directive):
CamlQuery spQuery = new CamlQuery()
{
   ViewXml = camlQueryStrCSOM
};
```
