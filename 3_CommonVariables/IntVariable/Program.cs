/* 
 * - Officieel is een int een signed Int32.
 * 
 * Signed vs. Unsigned:
 * - Een Int32 is standaard signed, maar kan ook unsigned zijn:
 *   a. Signed betekent dat de int een plus- of minteken (een sign) ervoor heeft.
 *      Een signed Int32 kan een getal van maximaal 2 biljoen (afgerond) groot zijn, in de positieve of negatieve kant.
 *   b. Een unsigned int noemen we een 'UInt32' en bevat geen sign voor het getal. 
 *      Daardoor kan deze dus een getal vab 4 biljoen groot zijn (want negatief EN positief).
 *   c. Maar Tim raadt het gebruik van unsigned int's af. Je gaat het bijna nooit nodig hebben, en ze nemen dan onnodig meer geheugen in.
 *      Dus gebruik liever gewoon de standaard signed Int32, aka 'int'.
 *      
 * - 32 bit:
 *   a. Zowel de signed Int32 als unsigned UInt32 zijn 32 bit groot. 
 *   b. Een bit is een 0 of 1 (binary).
 *   c. Byte: 8 bits -> 01100101
 *            Int32 is dus 4 bytes. 
 *            Computers slaan informatie namelijk op in bytes.
 *   d. Door de manier van tellen in het binaire systeem verdubbelt het aantal mogelijke getallen met elke bit.
 *      9 bit is dus 2x zo groot als 8 bit, en 10 bit is weer 4x zo groot als 8 bit.
 *      Veel mensen maken de fout om te denken dat bijv. 16 bit het dubbele is van 8 bit, maar dat is dus eigenlijk veel groter!
 * 
 * - Int64:
 *   a. Stel je wil om wat voor reden toch een grotere int hebben dan de standaard 32 bit int, aka Int32,
 *      dan is de volgende stap de Int64.
 *   b. De Int64, van dus 64 bit is een gigantisch groot getal.
 *      Waar de Int32 dus een getal van 2 biljoen groot kan zijn,
 *      zou een hypothetische Int33 als 4 biljoen zijn, laat staan de Int64!
 *      De Int64 is dus extreme overkill die eigenlijk bijna nooit nodig is.
 */

int age = 0;
age = 43;

int ageInTenYears = age + 10;

int cutOffDecimal = age / 2;            // Opletten bij het delen van int's! Tim raad aan om uberhaupt niet int's te delen.
                                        // Aangezien 'cutOffDecimal' een int is, zal het getal achter de decimal simpelweg worden weggelaten.

Console.WriteLine(age);
Console.WriteLine(ageInTenYears);
Console.WriteLine(cutOffDecimal);

Console.ReadLine();