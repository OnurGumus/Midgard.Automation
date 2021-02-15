# Midgard.Automation

To build it you need [.NET 5 SDK](https://dotnet.microsoft.com/download/dotnet/5.0) installed. Make sure LPC1 Test page is running at https://localhost:3333 

You also need  the following change on TestPage.web.tsx if you want the test to pass but this is optional (the test will fail otherwise):  
```
behavior: {
-                locationToOpen: "ExpandedViewDistributionListMembersSection",
+                locationToOpen: undefined,
                 onCardOpen: undefined,

```

Clone the repo. And in the root folder run:

```bash
dotnet tool restore
dotnet paket restore
cd src/Midgard.Test.Automation
dotnet run
```
