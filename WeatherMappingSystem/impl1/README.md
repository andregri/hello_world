#Use cases

                   +-----------------+
                   |                 |
    +--------------> 1.Request Data  +---------->station
    |              |                 |
    |              +-----------------+
    |
    |             +--------------------+
    |             |                    |
    +------------->  2. Validate Data  |
    |             |                    |
    |             +--------------------+
wms+>
    |             +-------------------+
    |             |                   |
    +------------->  3. Generate Map  |
    |             |                   |
    |             +-------------------+
    |
    |              +----------------+
    |              |                |
    +-------------->  4. Print Map  |
                   |                |
                   +----------------+

---------
Questo progetto di visual studio implementa solo il primo use case:
```
Il wms fa una richiesta a una stazione per ricevere i dati:
..* se ci sono problemi nella connessione, lancia un eccezione;
..* se la connessione va a buon fine verifica la validità dei dati:
....* se i dati sono validi li archivia;
....* se non sono validi lancia un'eccezione.
```
