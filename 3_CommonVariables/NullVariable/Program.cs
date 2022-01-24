/*
 * Null is niet zozeer een variabele, maar de state die een variabele kan hebben.
 * Null: het gebrek aan een value.
 */

int? age = null;            // De default value voor een 'age' variabele wanneer we die nog niet hebben opgevraagd is niet 0,
                            // want technisch gezien is dat ook al een leeftijd.
                            // De default value is dan dus null, want daarmee zeggen we dat 'age' nog geen value heeft.
                            // Met het vraagteken maken we de int-variabele nullable,
                            // oftewel we geven aan dat deze int een null kan bewaren.

//int age = null;           // Maar je kunt dus eisen dat de value van 'age' niet null is, door die variabele niet nullable te maken.

bool? birthday = null;      // Je kunt elk type nullable maken, in dit geval bijv. een bool.
double? average = null;

string firstName = null;    // String hoeft als enige type niet nullable te worden gemaakt met een '?'. 
string? firstName2 = null;  // Maar toch is het netter om ook een string wel alsnog nullable te maken,
                            // omdat je zo duidelijk aangeeft dat je een null verwacht voor deze variabele. 

