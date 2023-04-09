# Manipolazione dei TimeStamp Unix
Un tipo di format che si basa sul contare i secondi dalla data 1/1/1970 h 00:00:00 cioè lo Unix Epoch Time - è per questo che nel codice quando si converte in Unix TimeStamp, si sottraggono i secondi totali tra la data da convertire e 1/1/1970. Per ottenere la data necessaria, che nel nostro caso sono oggi e domani, si usa DateTime, che è built-in su C#.

```csharp
    DateTime today = DateTime.Now;
    DateTime yesterday = DateTime.Now.AddDays(-1);
    int period1 = (int)today.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
    int period2 = (int)yesterday.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
```