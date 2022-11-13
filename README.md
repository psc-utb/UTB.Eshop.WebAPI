# UTB.Eshop.WebAPI (pro .NET 6)

## Ukázkový projekt Web API pro výuku Pokročilých webových technologií.

Nezapomeňte nastavit heslo k MySql databázi a nezapomeňte aplikovat migrace pomocí Update-Database! (popř. si vytvořte vlastní)

Po spuštění pod Development prostředím se spustí Swagger UI, který vám umožní simulovat HTTP requesty na Web API.

Pokud chcete vidět "čistou" odpověď od Web API, tak request pošlete přes prohlížeč zadáním: "https://localhost:5001/Product", resp. "https://localhost:5001/Product/2" (jedná se zde o HTTP Get).

Pro testování požadavků a odpovědí je možné využít také jiné nástroje, jako je např. Postman.

Další možností je napsat klientskou aplikaci, která bude na dané URL posílat requesty a odpovědi zobrazovat v grafickém uživatelském rozhraní (např. ASP.NET MVC aplikace, mobilní aplikace (MAUI), ale klidně i aplikace napsané mimo .NET, např. pomocí PHP, Kotlin, Java, Swift, atd.).
