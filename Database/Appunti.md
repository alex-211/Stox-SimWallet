# Appunti sullo sviluppo della gestione DB
## Lo sviluppo di questa feature è in pausa

[Risorse ufficiali](firebirdsql.org)
Per usare Microsoft SQL Server Managament Studio con un DB Firebird è necessario usare un pacchetto NuGet o un driver ODBC

### Installare e configurare ODBC 
(Istruzioni qui)

### Istruzioni una volta aver installato e configurato ODBC
Start your Management Studio and choose your SQL Server instance.
1. In the Object Explorer pane, expand the Server Objects, right-click on Linked Servers and then click on New Linked Server.
2. Configure your linked server in the dialog box:
3. Give a name for your server in the Linked server field.
3. Under Server type, select Other data source .
4. Choose Microsoft OLE DB Provider for ODBC Drivers in the Provider drop-down list.
5. In the Data source field, enter the name of your DSN, e.g. Devart ODBC Driver for Firebird . Alternatively, you can input the ODBC Driver connection string in the Provider field.
