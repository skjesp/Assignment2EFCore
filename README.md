# Assignment2EFCore
Dette projekt indeholder en hjemmeside der udviklet i ASP.NET CORE. Her benyttes EFCore til at skabe en database som er baseret på det vedhæftede ER-Diagram.

### Getting Started - Opsætning af database
#### Step 1
Først åbnes Azure Data Studio. Her der forbindes til localhost, hvorefter man fra "master" databasen kører den vedhæftede SQL-Query der er navngivet SQL-DatabaseCreation.

#### Step 2
Efter at repositoriet er downloadet til computeren, skal filstien til projektets solution tilgåes.
Efter dette indtastes "cmd" i exploren (det felt hvor filstien er angivet). Dette åbner op for kommando-prompten, hvor _working directory_ bør være den mappe hvor solution er.
I kommandoprompten indtastes følgende: _dotnet ef database update_. Dette opsætter arkitekturen for databasen.

#### Step 3
Der indsættes nu dummydata ved at køre SQL-Dummydata querien ind i Azure Data Studio.

#### Step 4
For at hoste hjemmesiden benyttes ctrl + f5 i visual studio.

